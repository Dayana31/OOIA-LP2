/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.OOIA.services;

import java.io.FileNotFoundException;
import java.text.ParseException;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pruebaCargaDatosCSV.AlumnosCSV;

/**
 *
 * @author PC
 */
@WebService(serviceName = "AlumnosCSVcargaWS")
public class AlumnosCSVcargaWS {

    private AlumnosCSV csvAlumnos;
    
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
    
    @WebMethod(operationName = "Cargar CSV")
    public int cargarCSVAlumnos(@WebParam(name = "Ruta archivo") String ruta) throws FileNotFoundException, ParseException{
        int resultado = 0;
        csvAlumnos.setRutaCSV(ruta);
        resultado = csvAlumnos.cargarDatos();
        return resultado;
    }
}
