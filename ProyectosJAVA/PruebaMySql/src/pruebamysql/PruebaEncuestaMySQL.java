/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebamysql;

import java.util.ArrayList;
import pe.edu.pucp.gestion_encuesta.controller.dao.EncuestaDAO;
import pe.edu.pucp.gestion_encuesta.controller.mysql.EncuestaMySQL;
import pe.edu.pucp.gestion_encuesta.model.Encuesta;
import pe.edu.pucp.gestion_humana.model.Alumno;
import pe.edu.pucp.gestion_humana.model.MiembroPUCP;
import pe.edu.pucp.gestion_humana.model.Profesor;

/**
 *
 * @author DAYANA
 */
public class PruebaEncuestaMySQL {
    public static void main(String[] args) {
        EncuestaDAO daoEncuesta = new EncuestaMySQL();
        //Encuesta encuesta = new Encuesta();
        
        //Insertar
        
//        encuesta.setPuntaje(2);
//        encuesta.setDescripcion("La atención me ayudo con mis problemas de organización.");
//        Alumno alumno = new Alumno();
//        alumno.setId_alumno(6);
//        
//        MiembroPUCP asesor = new Profesor();
//        asesor.setId_miembro_pucp(8);
//        encuesta.setAlumno(alumno);
//        encuesta.setAsesor(asesor);
        
        //int resultado=daoEncuesta.insertar(encuesta);
        //int resultado = daoEncuesta.modificar(new Encuesta(2,alumno,5,"La atencion fue muy buena.",asesor));
        //if(resultado==1){
        //    System.out.println("Se ha modificado con exito");
        //}
        
        ArrayList<Encuesta> encuestas = new ArrayList<>();
        encuestas = daoEncuesta.listar(8);
        
        for(Encuesta a: encuestas)
            System.out.println(a);
    }
}
