package io.delta;

import io.delta.thrift.generated.CityService;

import org.apache.thrift.server.TServer;
import org.apache.thrift.server.TServer.Args;
import org.apache.thrift.server.TSimpleServer;
import org.apache.thrift.transport.TServerSocket;
import org.apache.thrift.transport.TServerTransport;

public class Server {

	private static final int PORT = 9090;
	public static ServiceHandler service;
	public static CityService.Processor<ServiceHandler> processor;

	public static void main(String[] args) {
		try {
			service = new ServiceHandler();
			processor = new CityService.Processor<ServiceHandler>(service);

			Runnable server = new Runnable() {
				public void run() {
					startServer(processor);
				}
			};

			new Thread(server).start();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public static void startServer(CityService.Processor<ServiceHandler> processor) {
		try {
			TServerTransport serverTransport = new TServerSocket(PORT);
			TServer server = new TSimpleServer(new Args(serverTransport).processor(processor));

			// Use this for a multithreaded server
			// TServer server = new TThreadPoolServer(new
			// TThreadPoolServer.Args(serverTransport).processor(processor));

			System.out.println("Starting the server...");
			server.serve();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}