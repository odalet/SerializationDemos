package io.delta;

import io.delta.thrift.generated.City;
import io.delta.thrift.generated.CityCollection;
import io.delta.thrift.generated.CityService;

import org.apache.thrift.TException;
import org.apache.thrift.protocol.TBinaryProtocol;
import org.apache.thrift.server.TServer;
import org.apache.thrift.server.TServer.Args;
import org.apache.thrift.server.TSimpleServer;
import org.apache.thrift.transport.TServerSocket;
import org.apache.thrift.transport.TServerTransport;
import org.apache.thrift.transport.TSocket;
import org.apache.thrift.transport.TTransport;
import org.apache.thrift.transport.TTransportException;
import org.junit.Assert;
import org.junit.Test;

public class ServiceHandlerTest {
	private static final int PORT = 9090;
	private static final String HOST = "localhost";
	private TServer server;

	@Test
	public void shouldGetAllCities() throws TException, InterruptedException {
		System.out.println("Creating server");
		Thread thread = new Thread(serverTask());
		thread.start();

		Thread.sleep(500);
		System.out.println("Creating client");
		TTransport transport = new TSocket(HOST, PORT);
		transport.open();
		CityService.Client client = new CityService.Client(new TBinaryProtocol(transport));

		System.out.println("PING");
		CityCollection result = client.GetAllCities();

		// int one = 1;
		int expected = 3;
		int actual = 0;
		if (result != null && result.getItems() != null) {
			actual = result.getItems().size();
		}

		System.out.println("Closing client");
		transport.close();

		System.out.println("Stopping server");
		server.stop();
		thread.interrupt();

		Assert.assertEquals(expected, actual);
	}

	@Test
	public void shouldGetParis() throws TException, InterruptedException {
		System.out.println("Creating server");
		Thread thread = new Thread(serverTask());
		thread.start();

		Thread.sleep(500);
		System.out.println("Creating client");
		TTransport transport = new TSocket(HOST, PORT);
		transport.open();
		CityService.Client client = new CityService.Client(new TBinaryProtocol(transport));

		System.out.println("PING");
		City result = client.GetCity(1L);

		System.out.println("Closing client");
		transport.close();

		System.out.println("Stopping server");
		server.stop();
		thread.interrupt();

		Assert.assertEquals("Paris", result.getName());
		Assert.assertEquals(false, result.isSetDisplayOrder());
	}

	@SuppressWarnings({ "rawtypes", "unchecked" })
	private Runnable serverTask() {
		return new Runnable() {
			@Override
			public void run() {
				TServerTransport serverTransport;
				try {
					serverTransport = new TServerSocket(PORT);
					server = new TSimpleServer(new Args(serverTransport).processor(new CityService.Processor(new ServiceHandler())));
					System.out.println(String.format("Starting the server on port %d...", PORT));
					server.serve();
				} catch (TTransportException e) {
					e.printStackTrace();
				}
			}
		};
	}
}
