/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebamysql;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.gestion_atencion.controller.dao.CodigoAtencionDAO;
import pe.edu.pucp.gestion_atencion.controller.dao.HorarioDAO;
import pe.edu.pucp.gestion_atencion.controller.mysql.CodigoAtencionMySQL;
import pe.edu.pucp.gestion_atencion.controller.mysql.HorarioMySQL;
import pe.edu.pucp.gestion_atencion.model.CodigoAtencion;
import pe.edu.pucp.gestion_atencion.model.Horario;
import pe.edu.pucp.gestion_encuesta.controller.dao.EncuestaDAO;
import pe.edu.pucp.gestion_encuesta.controller.mysql.EncuestaMySQL;
import pe.edu.pucp.gestion_encuesta.model.Encuesta;
import pe.edu.pucp.gestion_humana.controller.dao.AlumnoDAO;
import pe.edu.pucp.gestion_humana.controller.dao.InvitadoDAO;
import pe.edu.pucp.gestion_humana.controller.dao.ProfesorDAO;
import pe.edu.pucp.gestion_humana.controller.mysql.AlumnoMySQL;
import pe.edu.pucp.gestion_humana.controller.mysql.InvitadoMySQL;
import pe.edu.pucp.gestion_humana.controller.mysql.ProfesorMySQL;
import pe.edu.pucp.gestion_humana.model.Alumno;
import pe.edu.pucp.gestion_humana.model.Invitado;
import pe.edu.pucp.gestion_humana.model.MiembroPUCP;
import pe.edu.pucp.gestion_humana.model.Profesor;

/**
 *
 * @author DAYANA
 */
public class PruebaEncuestaMySQL {
    public static void main(String[] args)throws Exception {
        EncuestaDAO daoEncuesta = new EncuestaMySQL();
        Encuesta encuesta = new Encuesta();
        
        //Insertar
//        AlumnoDAO daoAlumno = new AlumnoMySQL();
//        ArrayList<Alumno> alumnos = new ArrayList<>();
//        alumnos = daoAlumno.listar();
//        
//        ProfesorDAO daoProfesor = new ProfesorMySQL();
//        ArrayList<Profesor> profesores = new ArrayList<>();
//        profesores = daoProfesor.listar();
        
//        encuesta.setPuntaje(2);
//        encuesta.setDescripcion("La atención me ayudo con mis problemas de organización.");
//        
//        MiembroPUCP asesor = new Profesor();
//        encuesta.setAlumno(alumnos.get(0));
//        encuesta.setAsesor(profesores.get(1));
        
        //int resultado=daoEncuesta.insertar(encuesta);
//        int resultado = daoEncuesta.modificar(new Encuesta(1,alumnos.get(0),5,"La atencion fue muy buena.",profesores.get(1)));
//        if(resultado==1){
//            System.out.println("Se ha modificado con exito");
//        }
        
//        ArrayList<Encuesta> encuestas = new ArrayList<>();
//        encuestas = daoEncuesta.listar(3);
//        
//        for(Encuesta a: encuestas)
//            System.out.println(a);
        
        InvitadoDAO daoInvitado = new InvitadoMySQL();
        Invitado invitado = new Invitado();
        invitado.setNombre("Junior Pérez");
        invitado.setCorreo("junior.perez@hotmail.com");
        invitado.setDireccion("Lima");
        invitado.setDni("284791948");
        invitado.setOcupacion("Medico");
        //invitado.setId_invitado(2);
        //invitado.setId_persona(6);
        invitado.setEdad(40);
        invitado.setTelefono(928381838);
//        int resultado = daoInvitado.insertar(invitado);
//        int resultado = daoInvitado.eliminar(invitado);
//        if(resultado==1){
//            System.out.println("Se ha insertado con exito");
//        }

//          ArrayList<Invitado> invitados = new ArrayList<>();
//          invitados = daoInvitado.listar();
//          for(Invitado i : invitados)
//                System.out.println(i);
          
          //HORARIO
//        HorarioDAO daoHorario = new HorarioMySQL();
//        Horario horario = new Horario();
        
        
        //horario.setHoraFin(horaFin);
        //horario.setHoraInicio(horaInicio);
        CodigoAtencionDAO daoCodigo = new CodigoAtencionMySQL();
        CodigoAtencion codigoAtencion = new CodigoAtencion();
        codigoAtencion.setCodigo("EX123");
        codigoAtencion.setDescripcion("Carta de permanencia");
       
       // daoCodigo.insertar(codigoAtencion);
       ArrayList<CodigoAtencion> codigos = new ArrayList<>();
          codigos = daoCodigo.listar();
          for(CodigoAtencion i : codigos)
                System.out.println(i);
          
    }
}
