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
import pe.edu.pucp.gestion_humana.controller.dao.AlumnoDAO;
import pe.edu.pucp.gestion_humana.controller.mysql.AlumnoMySQL;
import pe.edu.pucp.gestion_humana.model.Alumno;
import pe.edu.pucp.gestion_humana.model.Especialidad;

/**
 *
 * @author PC
 */
public class AlumnosCSV {
    
    private Scanner sc;
    private AlumnoDAO daoAlumno;
    
    public void setRutaCSV(String ruta) throws FileNotFoundException{
        sc = new Scanner(new File
        (ruta));
        daoAlumno = new AlumnoMySQL();
    }
    public void cargarDatos() throws ParseException{
        sc.useDelimiter("\n");
        while(sc.hasNext()){
            Alumno alumno = new Alumno();
            String[] datos = sc.next().split(",");
            String []datosCorrectos = new String[16];
            for(int i = 1; i < 15 ; i++){
                datosCorrectos[i] = datos[i].replaceAll(" ", "");
            }
            alumno.setNombre(datosCorrectos[0]);
            alumno.setDni(datosCorrectos[1]);
            alumno.setEdad(Integer.parseInt(datosCorrectos[2]));
            alumno.setCorreo(datosCorrectos[3]);
            alumno.setDireccion(datosCorrectos[4]);
            alumno.setUsuario_pucp(datosCorrectos[5]);
            alumno.setContraseña(datosCorrectos[6]);
            Date date1=new SimpleDateFormat("yyyy-MM-dd").parse(datosCorrectos[7]); 
            alumno.setFecha_inclusion(date1);
            alumno.setCodigo_pucp(datosCorrectos[8]);
            Especialidad especialidad = new Especialidad();
            especialidad.setId_especialidad(Integer.parseInt(datosCorrectos[9]));
            alumno.setEspecialidad(especialidad);
            alumno.setCraest(Double.parseDouble(datosCorrectos[10]));
            alumno.setCursos_por_primera(Integer.parseInt(datosCorrectos[11]));
            alumno.setCursos_por_segunda(Integer.parseInt(datosCorrectos[12]));
            alumno.setCursos_por_tercera(Integer.parseInt(datosCorrectos[13]));
            
            alumno.setCreditos_aprobados(Double.parseDouble(datosCorrectos[14]));
            
            int resultado = daoAlumno.insertar(alumno);
            if(resultado == 1){
                System.out.println("Se registro al alumno correctamente");
            }else{
                System.out.println("Ocurrio un error al registrar al alumno");
            }
        }
    }
}
