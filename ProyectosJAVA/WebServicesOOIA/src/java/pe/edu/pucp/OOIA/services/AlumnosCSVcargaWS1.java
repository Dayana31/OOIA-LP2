/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.OOIA.services;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.text.ParseException;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ooia.carga_csv.AlumnosCSV;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "AlumnosCSVcargaWS1")
public class AlumnosCSVcargaWS1 {

    /**
     * This is a sample web service operation
     */
    private AlumnosCSV csvAlumnos;
    
    
    @WebMethod(operationName = "CargarCSValumnos")
    public int cargarCSVAlumnos(@WebParam(name = "Rutaarchivo")byte[] ruta) throws FileNotFoundException, ParseException, IOException{
        int resultado = 0;
        csvAlumnos = new AlumnosCSV();

        FileOutputStream outputStream = new FileOutputStream("Auxiliar");
        outputStream.write(ruta);
        outputStream.close();
        FileInputStream inputStream = new FileInputStream("Auxiliar");
        
        csvAlumnos.setRutaCSV(inputStream);
        resultado = csvAlumnos.cargarDatos();
        inputStream.close();
        return resultado;
    }
}
