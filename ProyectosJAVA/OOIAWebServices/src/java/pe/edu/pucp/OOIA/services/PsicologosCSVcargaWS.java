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
import pruebaCargaDatosCSV.PsicologosCSV;

/**
 *
 * @author PC
 */
@WebService(serviceName = "PsicologosCSVcargaWS")
public class PsicologosCSVcargaWS {

    /**
     * This is a sample web service operation
     */
    private PsicologosCSV csvPsicologos;
    @WebMethod(operationName = "CargarCSVpsicologos")
    public int cargarCSVProfesores(@WebParam(name = "Ruta Archivo") String ruta) throws FileNotFoundException, ParseException {
        int resultado = 0;
        csvPsicologos.setRutaCSV(ruta);
        resultado = csvPsicologos.cargarDatos();
        return resultado;
    }
}
