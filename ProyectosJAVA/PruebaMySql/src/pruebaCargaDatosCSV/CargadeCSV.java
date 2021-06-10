/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebaCargaDatosCSV;

import java.io.File;
import java.util.Scanner;

/**
 *
 * @author PC
 */

public class CargadeCSV {
    public static void main(String[] args) throws Exception{
        /*Alumnos, ya funciona*/
        String ruta = "C:\\7mo ciclo\\LP2\\Proyecto Lp2\\Lab 7\\Archivos de carga\\Alumnos.csv";
        AlumnosCSV alumnosCsv = new AlumnosCSV();
        alumnosCsv.setRutaCSV(ruta);
        int filasNoInsertadas = alumnosCsv.cargarDatos();
        if(filasNoInsertadas == 0){
            System.out.println("Toda la carga fue exitosa");
        }else{
            System.out.println("Hubieron " + filasNoInsertadas + " filas que no se pudieron insertar");
        }
        /*Profesores, ya funciona*/
//        String ruta = "C:\\7mo ciclo\\LP2\\Proyecto Lp2\\Lab 7\\Archivos de carga\\Profesores.csv";
//        ProfesoresCSV profesoresCsv = new ProfesoresCSV();
//        profesoresCsv.setRutaCSV(ruta);
//        int filasNoInsertadas = profesoresCsv.cargarDatos();
//        if(filasNoInsertadas == 0){
//            System.out.println("Toda la carga fue exitosa");
//        }else{
//            System.out.println("Hubieron " + filasNoInsertadas + " filas que no se pudieron insertar");
//        }
        /*Psicologos, ya funciona*/
//        String ruta = "C:\\7mo ciclo\\LP2\\Proyecto Lp2\\Lab 7\\Archivos de carga\\Psicologos.csv";
//        PsicologosCSV psicologosCsv = new PsicologosCSV();
//        psicologosCsv.setRutaCSV(ruta);
//        int filasNoInsertadas = psicologosCsv.cargarDatos();
//        if(filasNoInsertadas == 0){
//            System.out.println("Toda la carga fue exitosa");
//        }else{
//            System.out.println("Hubieron " + filasNoInsertadas + " filas que no se pudieron insertar");
//        }
    }
    
    
}
