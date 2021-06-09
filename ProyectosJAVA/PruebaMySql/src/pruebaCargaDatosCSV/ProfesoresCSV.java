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
import pe.edu.pucp.gestion_humana.controller.dao.ProfesorDAO;
import pe.edu.pucp.gestion_humana.controller.mysql.AlumnoMySQL;
import pe.edu.pucp.gestion_humana.controller.mysql.ProfesorMySQL;
import pe.edu.pucp.gestion_humana.model.Especialidad;
import pe.edu.pucp.gestion_humana.model.Profesor;

/**
 *
 * @author PC
 */
public class ProfesoresCSV {
    private Scanner sc;
    private ProfesorDAO daoProfesor;
    
    public void setRutaCSV(String ruta) throws FileNotFoundException{
        sc = new Scanner(new File
        (ruta));
        daoProfesor = new ProfesorMySQL();
    }
    
    public void cargarDatos() throws ParseException{
        sc.useDelimiter("\n");
        while(sc.hasNext()){
            Profesor profesor = new Profesor();
            String[] datos = sc.next().split(",");
            String []datosCorrectos = new String[11];
            for(int i = 1; i < 9; i++){
                datosCorrectos[i] = datos[i].replaceAll(" ", "");
            }
            profesor.setNombre(datosCorrectos[0]);
            profesor.setDni(datosCorrectos[1]);
            profesor.setEdad(Integer.parseInt(datosCorrectos[2]));
            profesor.setDireccion(datosCorrectos[3]);
            profesor.setCorreo(datosCorrectos[4]);
            profesor.setUsuario_pucp(datosCorrectos[5]);
            profesor.setContraseña(datosCorrectos[6]);
            Date date1=new SimpleDateFormat("yyyy-MM-dd").parse(datosCorrectos[7]); 
            profesor.setFecha_inclusion(date1);
            Especialidad especialidad = new Especialidad();
            especialidad.setId_especialidad(Integer.parseInt(datosCorrectos[8]));
            profesor.setEspecialidad(especialidad);
            profesor.setFacultad(datosCorrectos[9]);
            profesor.setCategoria(datosCorrectos[10]);
           
            
            int resultado = daoProfesor.insertar(profesor);
            if(resultado == 1){
                System.out.println("Se registro al profesor correctamente");
            }else{
                System.out.println("Ocurrio un error al registrar al profesor");
            }
        }
    }
}
