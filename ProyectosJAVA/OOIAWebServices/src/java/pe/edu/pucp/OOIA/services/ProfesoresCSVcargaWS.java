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
import pruebaCargaDatosCSV.ProfesoresCSV;

/**
 *
 * @author PC
 */
@WebService(serviceName = "ProfesoresCSVcargaWS")
public class ProfesoresCSVcargaWS {

    /**
     * This is a sample web service operation
     */
    private ProfesoresCSV csvProfesores;
    @WebMethod(operationName = "CargarCSVprofesores")
    public int cargarCSVProfesores(@WebParam(name = "Ruta Archivo") String ruta) throws FileNotFoundException, ParseException {
        int resultado = 0;
        csvProfesores.setRutaCSV(ruta);
        resultado = csvProfesores.cargarDatos();
        return resultado;
    }
}
