package io.delta;

import io.delta.thrift.generated.City;
import io.delta.thrift.generated.CityCollection;
import io.delta.thrift.generated.CityService;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

import org.apache.thrift.TException;

public class ServiceHandler implements CityService.Iface {

	private static Map<Long, City> cities;

	static {
		cities = new HashMap<Long, City>();
		cities.put(1L, makeCity(1L, "Paris", "FRA", true));
		cities.put(2L, makeCity(2L, "Lyon", "FRA", true, 1));
		cities.put(3L, makeCity(3L, "Marseille", "FRA", true));
	}

	@Override
	public CityCollection GetAllCities() throws TException {
		return new CityCollection(new ArrayList<City>(cities.values()));
	}

	@Override
	public City GetCity(long id) throws TException {
		return cities.get(id);
	}

	private static City makeCity(long id, String name, String countryCode,
			boolean enabled) {
		City city = new City();
		city.setId(id);
		city.setName(name);
		city.setCountryCode(countryCode);
		city.setEnabled(enabled);
		return city;
	}

	private static City makeCity(long id, String name, String countryCode,
			boolean enabled, int displayOrder) {
		City city = makeCity(id, name, countryCode, enabled);
		city.setDisplayOrder(displayOrder);
		return city;
	}
}