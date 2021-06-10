/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package services;

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
public class AlumnosCSVcargaWS1 {

    private AlumnosCSV csvAlumnos;
    
    @WebMethod(operationName = "CargarCSValumnos")
    public int cargarCSVAlumnos(@WebParam(name = "Rutaarchivo") String ruta) throws FileNotFoundException, ParseException{
        int resultado = 0;
        csvAlumnos = new AlumnosCSV();
        csvAlumnos.setRutaCSV(ruta);
        resultado = csvAlumnos.cargarDatos();
        return resultado;
    }
}
