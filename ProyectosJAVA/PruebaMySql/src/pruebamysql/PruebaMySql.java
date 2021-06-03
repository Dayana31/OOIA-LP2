/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebamysql;

import java.util.ArrayList;
import pe.edu.pucp.gestion_academica.controller.mysql.CategoriaMySQL;
import pe.edu.pucp.gestion_academica.model.Categoria;

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
//        categoria.setNombre_categoria("Depresion");
//        categoriaMySQL.insertar( categoria);
//        System.out.println(categoria);
//        prueba.impresion(categoriaMySQL.listar());
        //categoriaMySQL.modificar(new Categoria(1, "Demasiado alto rendimiento"));
    }
    
    private static class Prueba<T>{
        public void impresion(ArrayList<T> imprime){
            for(T aux:imprime){
                System.out.println(aux);
            }
        }
        
    }
    
    
}
