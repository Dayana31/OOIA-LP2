/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebamysql;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.gestion_academica.controller.mysql.CategoriaMySQL;
import pe.edu.pucp.gestion_academica.controller.mysql.CursoMySQL;
import pe.edu.pucp.gestion_academica.model.Categoria;
import pe.edu.pucp.gestion_academica.model.Curso;
import pe.edu.pucp.gestion_atencion.controller.mysql.CodigoAtencionMySQL;
import pe.edu.pucp.gestion_atencion.model.CodigoAtencion;
import pe.edu.pucp.gestion_humana.controller.mysql.ProfesorMySQL;
import pe.edu.pucp.gestion_humana.model.Especialidad;
import pe.edu.pucp.gestion_humana.model.Profesor;

/**
 *
 * @author LENOVO
 */
public class PruebaMySql {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //  pruebaCategoria();
       // pruebaCodigoAtencion();
       pruebaProfesor();

    }
    
    private static void pruebaCategoria(){
        CategoriaMySQL categoriaMySQL=new CategoriaMySQL();
        Categoria categoria=new Categoria();
        Prueba prueba=new Prueba();
//        categoria.setNombre_categoria("Depresion");
//        categoriaMySQL.insertar( categoria);
//        System.out.println(categoria);
//        prueba.impresion(categoriaMySQL.listar());
        //categoriaMySQL.modificar(new Categoria(1, "Demasiado alto rendimiento"));
    }
    private static void pruebaCurso(){
        Prueba prueba=new Prueba();
        Curso curso=new Curso("INF281", "Lenguajes de Programación 1", 1);
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
        codigoAtencion.setCodigo("DEF123");
        codigoAtencion.setDescripcion("El alumno cometio algo muy muy malo");
        CodigoAtencionMySQL codigoAtencionMySQL=new CodigoAtencionMySQL();
        codigoAtencionMySQL.insertar(codigoAtencion);
        System.out.println(codigoAtencion);
        codigoAtencionMySQL.modificar(new CodigoAtencion(1, "MMM999", "Codigo cambiado"));
        prueba.impresion(codigoAtencionMySQL.listar());
    }
    private static void pruebaProfesor(){
                Prueba prueba = new Prueba();
                Profesor profesor= new Profesor();
                ProfesorMySQL profesorMySQL=new ProfesorMySQL();
//                profesor.setNombre("Rony Cave Moscoso");
//                profesor.setDni("98765432");
//                profesor.setEdad(40);
//                profesor.setDireccion("En algun lugar de Arequipa");
//                profesor.setUsuario_pucp("25896314");
//                profesor.setFecha_inclusion(new Date(1993  ,5   , 2));              
//                profesor.setEspecialidad(new Especialidad(7, "lo que sea"));
//                profesor.setFacultad("Ingenieria Informatica");
//                profesor.setCategoria("No se que sea esto");
//                profesorMySQL.insertar(profesor);
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
