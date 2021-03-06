package io.delta.api;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.jws.soap.SOAPBinding;
import javax.xml.bind.annotation.XmlSeeAlso;

/**
 * This class was generated by Apache CXF 3.0.4 2015-03-03T00:38:17.608+01:00
 * Generated source version: 3.0.4
 * 
 */
@WebService(targetNamespace = "http://www.delta.io/Api/", name = "Api")
@XmlSeeAlso({ ObjectFactory.class })
@SOAPBinding(parameterStyle = SOAPBinding.ParameterStyle.BARE)
public interface Api {

	@WebMethod(action = "http://www.delta.io/Api/searchCities")
	@WebResult(name = "searchCitiesResponse", targetNamespace = "http://www.delta.io/Api/", partName = "parameters")
	public SearchCitiesResponse searchCities(@WebParam(partName = "parameters", name = "searchCitiesRequest", targetNamespace = "http://www.delta.io/Api/") SearchCitiesRequest parameters);
}
