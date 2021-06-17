/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package services;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.text.ParseException;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ooia.carga_csv.CursosLlevadosCSV;

/**
 *
 * @author PC
 */
@WebService(serviceName = "CursosLlevadosCSVcargaWS")
public class CursosLlevadosCSVcargaWS {

    private CursosLlevadosCSV csvCursosLlevados;
    
    @WebMethod(operationName = "CargarCSVcursosLlevados")
    public int cargarCSVcursosLlevados(@WebParam(name = "RutaArchivo") byte[] ruta) throws FileNotFoundException, ParseException, IOException {
        int resultado = 0;
        csvCursosLlevados = new CursosLlevadosCSV();
        FileOutputStream outputStream = new FileOutputStream("Auxiliar");
        outputStream.write(ruta);
        outputStream.close();
        FileInputStream inputStream = new FileInputStream("Auxiliar");
        csvCursosLlevados.setRutaCSV(inputStream);
        resultado = csvCursosLlevados.cargarDatos();
        inputStream.close();
        return resultado;
    }
}
