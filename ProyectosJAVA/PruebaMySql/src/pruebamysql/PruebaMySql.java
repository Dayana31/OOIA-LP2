/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebamysql;

import java.util.ArrayList;
import pe.edu.pucp.gestion_academica.controller.mysql.CategoriaMySQL;
import pe.edu.pucp.gestion_academica.controller.mysql.CursoMySQL;
import pe.edu.pucp.gestion_academica.model.Categoria;
import pe.edu.pucp.gestion_academica.model.Curso;

/**
 *
 * @author LENOVO
 */
public class PruebaMySql {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Prueba prueba=new Prueba();
        
        
    }
    
    private void pruebaCategoria(){
        CategoriaMySQL categoriaMySQL=new CategoriaMySQL();
        Categoria categoria=new Categoria();
        Prueba prueba=new Prueba();
//        categoria.setNombre_categoria("Depresion");
//        categoriaMySQL.insertar( categoria);
//        System.out.println(categoria);
//        prueba.impresion(categoriaMySQL.listar());
        //categoriaMySQL.modificar(new Categoria(1, "Demasiado alto rendimiento"));
    }
    private void pruebaCurso(){
        Prueba prueba=new Prueba();
        Curso curso=new Curso("INF281", "Lenguajes de Programación 1", 1);
        CursoMySQL cursoMySQL=new CursoMySQL();
        cursoMySQL.insertar(curso);
        //cambiar Lenguaje de programacion 2 a ingeco
        cursoMySQL.modificar(new Curso(1,"IND135","Ingenieria Economica",1));
        
        prueba.impresion(cursoMySQL.listar());
        cursoMySQL.eliminar(1);
}
    
    
    
    
    
    private static class Prueba<T>{
        public void impresion(ArrayList<T> imprime){
            for(T aux:imprime){
                System.out.println(aux);
            }
        }
        
    }
    
    
}
