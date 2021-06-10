/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebamysql;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.logging.Level;
import java.util.logging.Logger;
import pe.edu.pucp.gestion_academica.controller.mysql.CategoriaMySQL;
import pe.edu.pucp.gestion_academica.controller.mysql.CursoLlevadoMySQL;
import pe.edu.pucp.gestion_academica.controller.mysql.CursoMySQL;
import pe.edu.pucp.gestion_academica.model.Categoria;
import pe.edu.pucp.gestion_academica.model.Curso;
import pe.edu.pucp.gestion_academica.model.CursoLlevado;
import pe.edu.pucp.gestion_atencion.controller.mysql.CodigoAtencionMySQL;
import pe.edu.pucp.gestion_atencion.model.CodigoAtencion;
import pe.edu.pucp.gestion_eventos.model.Evento;
import pe.edu.pucp.gestion_eventos.model.MiembroOOIA;
import pe.edu.pucp.gestion_eventos.mysql.CoordinadorEventosMySQL;
import pe.edu.pucp.gestion_eventos.mysql.EventoMySQL;
import pe.edu.pucp.gestion_humana.controller.mysql.EspecialidadMySQL;
import pe.edu.pucp.gestion_humana.controller.mysql.ProfesorMySQL;
import pe.edu.pucp.gestion_humana.controller.mysql.PsicologoMySQL;
import pe.edu.pucp.gestion_humana.model.Alumno;
import pe.edu.pucp.gestion_humana.model.Especialidad;
import pe.edu.pucp.gestion_humana.model.Persona;
import pe.edu.pucp.gestion_humana.model.Profesor;
import pe.edu.pucp.gestion_humana.model.Psicologo;

/**
 *
 * @author LENOVO
 */
public class PruebaMySql {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
//pruebaCategoria();
         //pruebaCodigoAtencion();
         
       // pruebaPsicologo();
       //pruebaCursoLlevado();
//       new EspecialidadMySQL().insertar(new Especialidad(0, "Ingenieria Informatica"));
//       new EspecialidadMySQL().insertar(new Especialidad(0, "Ingenieria Mecatronica"));
//       new EspecialidadMySQL().insertar(new Especialidad(0, "Ingenieria Industrial"));
//       new EspecialidadMySQL().insertar(new Especialidad(0, "Ingenieria Electrica"));
//        new CursoMySQL().insertar(new Curso("INF282", "Lenguajes de programacion 2", 1));
//        new CursoMySQL().insertar(new Curso("INF281", "Lenguajes de programacion 1", 1));
//        new CursoMySQL().insertar(new Curso("INF282", "Sistemas de información 2", 1));
//pruebaProfesor();
    Evento evento= new Evento();
    evento.setCapacidad(10);
    evento.setFecha(new Date());
    evento.setHoraFina(new Date());
    evento.setHoraInicio(new Date());
    evento.setId_coordinador(11);
    evento.setLugar("Generales");
    evento.setNombre("Amistad ");
//        MiembroOOIA psicologo=new MiembroOOIA();
//                  psicologo.setNombre("Psicologo 1");
//                psicologo.setDni("98765432");
//                psicologo.setEdad(40);
//                psicologo.setDireccion("En algun lugar de Lima");
//                psicologo.setUsuario_pucp("25896314");
//                psicologo.setFecha_inclusion(new Date());
//               psicologo.setCorreo("Rony@pucp.edu.pe");
//               psicologo.setNombre("Psicologo 3");
//               evento.setId_evento(1);
//               new CoordinadorEventosMySQL().insertar(psicologo);
//                 evento.setId_evento(8); 
                 ArrayList<Persona>persona=new ArrayList<>();
                 Alumno al=new Alumno();
                 al.setId_persona(1);
                 persona.add(al);
                 al.setId_persona(2);
                 persona.add(al);
                 evento.setPonentes(persona);
       //new EventoMySQL().insertar(evento);
               Evento ev = new EventoMySQL().listar("").get(0);
                System.out.println(ev.getNombre()+" "+ev.getId_evento());
        
    }
    
    private static void pruebaCursoLlevado(){
        CursoLlevado curso=new CursoLlevado();
        CursoLlevadoMySQL cursoMySQL=new CursoLlevadoMySQL();
        Alumno alumno=new Alumno();
        alumno.setId_alumno(1);
        curso.setAlumno(alumno);
        //solo se necesita el id hacereferencia a lp2
        curso.setCurso(new Curso(2, "", "", 1));
        curso.setCiclo("2020-0");
        curso.setFormulaDeCalificacion("4EX1 +  3 LAB + 3EX2 ");
        curso.setNotaFinal(15);
        curso.setRetirado(false);
        curso.setVez(1);
        //cursoMySQL.insertar(curso);
        Prueba prueba=new Prueba();
        prueba.impresion(cursoMySQL.listar(alumno.getId_alumno()));
    }
    
    private static void pruebaPsicologo(){
        Psicologo psicologo=new Psicologo();
        PsicologoMySQL psicologoMySQL=new PsicologoMySQL();
        Prueba prueba=new Prueba();
        psicologo.setNombre("Psicologo 1");
                psicologo.setDni("98765432");
                psicologo.setEdad(40);
                psicologo.setDireccion("En algun lugar de Lima");
                psicologo.setUsuario_pucp("25896314");
                psicologo.setFecha_inclusion(new Date());
               psicologo.setCorreo("Rony@pucp.edu.pe");
               psicologo.setId_psicologo(3);
               psicologo.setNombre("Psicologo 3");
                //psicologoMySQL.insertar(psicologo);
              // psicologoMySQL.modificar(psicologo);
                prueba.impresion(psicologoMySQL.listar());
                
               
    }
    
    private static void pruebaCategoria(){
        CategoriaMySQL categoriaMySQL=new CategoriaMySQL();
        Categoria categoria=new Categoria();
        Prueba prueba=new Prueba();
        categoria.setNombre_categoria("Bica");
        categoriaMySQL.insertar( categoria);
        System.out.println(categoria);
        prueba.impresion(categoriaMySQL.listar());
        //categoriaMySQL.modificar(new Categoria(1, "Demasiado alto rendimiento"));
    }
    private static void pruebaCurso(){
        Prueba prueba=new Prueba();
        Curso curso= new Curso("INF281", "Lenguajes de Programación 1", 1);
        CursoMySQL cursoMySQL=new CursoMySQL();
        cursoMySQL.insertar(curso);
        //cambiar Lenguaje de programacion 2 a ingeco
        cursoMySQL.modificar(new Curso(1,"IND135","Ingenieria Economica",1));
        
        prueba.impresion(cursoMySQL.listar());
        cursoMySQL.eliminar(1);
}
    private static void pruebaCodigoAtencion(){
        Prueba prueba = new Prueba();
        CodigoAtencion codigoAtencion=new CodigoAtencion();
        codigoAtencion.setCodigo("EX123");
        codigoAtencion.setDescripcion("Carta de permanencia");
        CodigoAtencionMySQL codigoAtencionMySQL=new CodigoAtencionMySQL();
        codigoAtencionMySQL.insertar(codigoAtencion);
        System.out.println(codigoAtencion);
        //codigoAtencionMySQL.modificar(new CodigoAtencion(1, "MMM999", "Codigo cambiado"));
        prueba.impresion(codigoAtencionMySQL.listar());
    }
    private static void pruebaProfesor() {
                Prueba prueba = new Prueba();
                Profesor profesor= new Profesor();
                ProfesorMySQL profesorMySQL=new ProfesorMySQL();
                profesor.setId_profesor(1);
                profesor.setNombre("Miguel Guanira");
                profesor.setDni("98765432");
                profesor.setEdad(40);
                profesor.setDireccion("En algun lugar de Lima");
                profesor.setUsuario_pucp("25896314");
                profesor.setFecha_inclusion(new Date());
               profesor.setCorreo("Rony@pucp.edu.pe");
                profesor.setEspecialidad(new Especialidad(3, ""));
                profesor.setFacultad("Ciencias e Ingenieria");
                profesor.setCategoria("Contratado");
                profesorMySQL.insertar(profesor);
         
                
                
                //profesorMySQL.modificar(profesor);
                //profesorMySQL.eliminar(profesor);
                prueba.impresion(profesorMySQL.listar());
    } 
    
    
    
    private static class Prueba<T>{
        public void impresion(ArrayList<T> imprime){
            for(T aux:imprime){
                System.out.println(aux);
            }
        }
        
    }
    
    
}
