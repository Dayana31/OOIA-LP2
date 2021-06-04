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
import pe.edu.pucp.gestion_humana.controller.mysql.AlumnoMySQL;
import pe.edu.pucp.gestion_humana.controller.mysql.EspecialidadMySQL;
import pe.edu.pucp.gestion_humana.model.Alumno;
import pe.edu.pucp.gestion_humana.model.Especialidad;

/**
 *
 * @author PC
 */
public class PruebaAlumnoMySQL {
    private static AlumnoDAO daoAlumno;
    public static void main(String[] args) {
        daoAlumno = new AlumnoMySQL();
        listarAlumno();
//        insertarAlumno();
    }
    
    public static void listarAlumno(){
        ArrayList<Alumno> alumnos = new ArrayList<>();
        alumnos = daoAlumno.listar();
        for(Alumno a : alumnos){
            System.out.println("Entro");
            System.out.println(a.getNombre() + " " + a.getCodigo_pucp() + " " + 
                    a.getCraest());
        }
    }
    public static void insertarAlumno(){
        
        
        Alumno alum = new Alumno();
        
        //Insertar
        //Atributos persona
        alum.setId_persona(32323);
        alum.setDni("433123123");
        alum.setNombre("Juanito Castillo");
        alum.setEdad(45);
        alum.setDireccion("jr.Machu pichu, urb Los Robles");
        ArrayList<String> correos = new ArrayList<>();
        correos.add("asdasdas@pucp.edu.pe");
        correos.add("asdasd@gmail.com");
        alum.setCorreos(correos);
        
        //Atributos miembro pucp
        alum.setId_miembro_pucp(232323);
        alum.setUsuario_pucp("asdasdasd@pucp.edu.pe");
        alum.setFecha_inclusion(new Date());
        
        //Atributos Alumno
        alum.setId_alumno(23);
        alum.setCodigo_pucp("20193212");
        Especialidad esp = new Especialidad();
        esp.setId_especialidad(5);
        
//        EspecialidadDAO daoEsp = new EspecialidadMySQL();
//        
//        int flag = daoEsp.insertar(esp);
//        if(flag != 1){
//            System.out.println("Error al momento de insertar la especialidad");
//            return;
//        }
            
        alum.setEspecialidad(esp);
        alum.setCraest(70.3);
        alum.setCursos_por_primera(3);
        alum.setCursos_por_segunda(3);
        alum.setCursos_por_tercera(0);
        alum.setCreditos_aprobados(123.4);
        
        
        
        int resultado = daoAlumno.insertar(alum);//no lo pobre, falta modificar el mySQL
        if(resultado == 1){
            System.out.println("Se registro al alumno exitosamente");
        }else{
            System.out.println("Ocurrio un error al momento de insertar");
        }
    }
}
