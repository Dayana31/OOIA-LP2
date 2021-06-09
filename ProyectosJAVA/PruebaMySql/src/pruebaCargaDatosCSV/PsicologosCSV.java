/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebaCargaDatosCSV;

import java.io.File;
import java.io.FileNotFoundException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Scanner;
import pe.edu.pucp.gestion_humana.controller.dao.PsicologoDAO;
import pe.edu.pucp.gestion_humana.controller.mysql.PsicologoMySQL;
import pe.edu.pucp.gestion_humana.model.Especialidad;
import pe.edu.pucp.gestion_humana.model.Profesor;
import pe.edu.pucp.gestion_humana.model.Psicologo;

/**
 *
 * @author PC
 */
public class PsicologosCSV {
    private Scanner sc;
    private PsicologoDAO daoPsicologo;
    
    public void setRutaCSV(String ruta) throws FileNotFoundException{
        sc = new Scanner(new File
        (ruta));
        daoPsicologo = new PsicologoMySQL();
    }
    
    public void cargarDatos() throws ParseException{
        sc.useDelimiter("\n");
        while(sc.hasNext()){
            Psicologo psicologo = new Psicologo();
            String[] datos = sc.next().split(",");
            String []datosCorrectos = new String[11];
            datosCorrectos[0] = datos[0];
            for(int i = 1; i < 8; i++){
                datosCorrectos[i] = datos[i].replaceAll(" ", "");
            }
            psicologo.setNombre(datosCorrectos[0]);
            psicologo.setDni(datosCorrectos[1]);
            psicologo.setEdad(Integer.parseInt(datosCorrectos[2]));
            psicologo.setDireccion(datosCorrectos[3]);
            psicologo.setUsuario_pucp(datosCorrectos[4]);
            psicologo.setContraseña(datosCorrectos[5]);
            psicologo.setCorreo(datosCorrectos[6]);
            Date date1=new SimpleDateFormat("yyyy-MM-dd").parse(datosCorrectos[7]); 
            psicologo.setFecha_inclusion(date1);

            int resultado = daoPsicologo.insertar(psicologo);
            if(resultado == 1){
                System.out.println("Se registro al psicologo correctamente");
            }else{
                System.out.println("Ocurrio un error al registrar al psicologo");
            }
        }
    }
}
