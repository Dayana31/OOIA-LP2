/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebamysql;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.gestion_academica.model.Curso;
import pe.edu.pucp.gestion_academica.model.CursoLlevado;
import pe.edu.pucp.gestion_humana.controller.dao.AlumnoDAO;
import pe.edu.pucp.gestion_humana.controller.dao.EspecialidadDAO;
import pe.edu.pucp.gestion_humana.controller.dao.ProfesorDAO;
import pe.edu.pucp.gestion_humana.controller.dao.PsicologoDAO;
import pe.edu.pucp.gestion_humana.controller.mysql.AlumnoMySQL;
import pe.edu.pucp.gestion_humana.controller.mysql.EspecialidadMySQL;
import pe.edu.pucp.gestion_humana.controller.mysql.ProfesorMySQL;
import pe.edu.pucp.gestion_humana.controller.mysql.PsicologoMySQL;
import pe.edu.pucp.gestion_humana.model.Alumno;
import pe.edu.pucp.gestion_humana.model.Especialidad;
import pe.edu.pucp.gestion_humana.model.Profesor;
import pe.edu.pucp.gestion_humana.model.Psicologo;

/**
 *
 * @author PC
 */
public class PruebaHumanaMySQL {
    private static AlumnoDAO daoAlumno;
    private static ProfesorDAO daoProfesor;
    private static PsicologoDAO daoPsicologo;
    public static void main(String[] args) {
        daoAlumno = new AlumnoMySQL();
//        listarAlumno();
        daoProfesor = new ProfesorMySQL();
        System.out.println("Lista de profesores");
        listarProfesor();
        daoPsicologo = new PsicologoMySQL();
        System.out.println("\nLista de Psicologos");
        listarPsicologo();
        //insertarAlumno();
    }
    
    public static void listarPsicologo(){
        ArrayList<Psicologo> psicologos = new ArrayList<>();
        psicologos = daoPsicologo.listar();
        for(Psicologo a : psicologos){
//            System.out.println("Entro");
            System.out.println(a.getNombre() + " " + a.getCorreo()  +  " " + a.getUsuario_pucp());
        }
    }
    public static void listarProfesor(){
        ArrayList<Profesor> profesores = new ArrayList<>();
        profesores = daoProfesor.listar();
        for(Profesor a : profesores){
//            System.out.println("Entro");
            System.out.println(a.getNombre() + " " + a.getCorreo()  + " " + 
                    a.getFacultad() + " " + a.getUsuario_pucp() + " " + a.getCategoria());
        }
    }
    public static void listarAlumno(){
        ArrayList<Alumno> alumnos = new ArrayList<>();
        alumnos = daoAlumno.listar();
        for(Alumno a : alumnos){
            System.out.println("Entro");
            System.out.println(a.getNombre() + " " + a.getCorreo() + " " + a.getCodigo_pucp() + " " + 
                    a.getCraest());
        }
    }
    public static void insertarAlumno(){
        
        
        Alumno alum = new Alumno();
        
        //Insertar
        //Atributos persona
        alum.setId_persona(32323);
        alum.setDni("433123123");
        alum.setNombre("Alberto Bustamante");
        alum.setEdad(21);
        alum.setDireccion("jr. banhio de los incas, urb manco capac");
        alum.setCorreo("dasjdjasdjasjdas@pucp.edu.pe");
        
        //Atributos miembro pucp
        alum.setId_miembro_pucp(232323);
        alum.setUsuario_pucp("2083123@pucp.edu.pe");
        alum.setFecha_inclusion(new Date());
        
       
        //Atributos Alumno
        alum.setCodigo_pucp("20203212");
        Especialidad esp = new Especialidad();
        esp.setId_especialidad(3);
      
        alum.setEspecialidad(esp);
        alum.setCraest(54.3);
        alum.setCursos_por_primera(0);
        alum.setCursos_por_segunda(2);
        alum.setCursos_por_tercera(0);
        alum.setCreditos_aprobados(70.4);//hay un problema aqui, el decimal debe ser mas grande 
        //para que pueda recoger una mayor cantidad de creditos. Solo se admiten alumnos 
        //con cantidad de creditos 
        
        
        
        int resultado = daoAlumno.insertar(alum);//no lo pobre, falta modificar el mySQL
        if(resultado == 1){
            System.out.println("Se registro al alumno exitosamente");
        }else{
            System.out.println("Ocurrio un error al momento de insertar");
        }
    }
}
