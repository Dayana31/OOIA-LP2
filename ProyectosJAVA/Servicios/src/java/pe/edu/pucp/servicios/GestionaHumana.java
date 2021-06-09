/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.servicios;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.gestion_humana.controller.dao.AlumnoDAO;
import pe.edu.pucp.gestion_humana.controller.dao.EspecialidadDAO;
import pe.edu.pucp.gestion_humana.controller.dao.InvitadoDAO;
import pe.edu.pucp.gestion_humana.controller.dao.ProfesorDAO;
import pe.edu.pucp.gestion_humana.controller.dao.PsicologoDAO;
import pe.edu.pucp.gestion_humana.controller.mysql.AlumnoMySQL;
import pe.edu.pucp.gestion_humana.controller.mysql.EspecialidadMySQL;
import pe.edu.pucp.gestion_humana.controller.mysql.InvitadoMySQL;
import pe.edu.pucp.gestion_humana.controller.mysql.ProfesorMySQL;
import pe.edu.pucp.gestion_humana.controller.mysql.PsicologoMySQL;
import pe.edu.pucp.gestion_humana.model.Alumno;
import pe.edu.pucp.gestion_humana.model.Especialidad;
import pe.edu.pucp.gestion_humana.model.Invitado;
import pe.edu.pucp.gestion_humana.model.Profesor;
import pe.edu.pucp.gestion_humana.model.Psicologo;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "GestionaHumana")
public class GestionaHumana {

    /**
     * This is a sample web service operation
     */
    private ProfesorDAO daoProfesor;
    private AlumnoDAO alumno;
    private EspecialidadDAO especialidad;    
    private PsicologoDAO psicologo;
    private InvitadoDAO invitado;
        public GestionaHumana(){
            daoProfesor=new ProfesorMySQL();
            alumno=new AlumnoMySQL();
            especialidad=new EspecialidadMySQL();
            invitado=new InvitadoMySQL();
            psicologo=new PsicologoMySQL();
        }
        
    @WebMethod(operationName = "listarProfesores")
    public ArrayList <Profesor>listarProfesores(){
        ArrayList<Profesor> empleador=new ArrayList<>();
        try {
            empleador= daoProfesor.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return empleador;
    }
    @WebMethod(operationName = "insertarProfesores")
    public int insertarProfesores( @WebParam(name="profesor") Profesor profesor){
        int resultado=0;
        try {
            resultado=daoProfesor.insertar(profesor);
            
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return resultado;
    }
    @WebMethod(operationName = "modificarProfesores")
    public int modificarProfesores(@WebParam(name = "profesor")Profesor profesor){
        int resultado=0;
        try {
            resultado=daoProfesor.modificar(profesor);
            
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return resultado;
    }
    @WebMethod(operationName = "eliminarProfesor")
    public int eliminarProfesor(@WebParam(name = "profesor")Profesor profesor){
        int resultado=0;
        try {
            resultado=daoProfesor.eliminar(profesor);
            
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return resultado;
    }
    

    @WebMethod(operationName = "listarAlumno")
    public ArrayList<Alumno> listarAlumno(){
        ArrayList<Alumno> lista=new ArrayList<>();
        try {
            lista=alumno.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
        
    }
    @WebMethod(operationName = "insertarAlumno")
    public int insertarAlumno(@WebParam(name = "alumno")Alumno alumno){
        int resultado=0;
        try {
            resultado=this.alumno.insertar(alumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarAlumno")
    public int modificarAlumno(@WebParam(name = "alumno")Alumno alumno){
        int resultado=0;
        try {
            resultado=this.alumno.modificar(alumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarAlumno")
    public int eliminarAlumno(@WebParam(name = "alumno")Alumno alumno){
        int resultado=0;
        try {
            resultado=this.alumno.eliminar(alumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarEsppecialidad")
    public ArrayList<Especialidad> listarEspecialidad(){
        ArrayList<Especialidad>listaEspecialidad=new ArrayList<>();
        try {
            listaEspecialidad= this.especialidad.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return listaEspecialidad;
    }
    @WebMethod(operationName = "insertarEspecialidad")
    public int insertarEspecialidad(@WebParam(name = "especialidad")Especialidad especialidad){
        int resultado=0;
        try {
            resultado=this.especialidad.insertar(especialidad);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarEspecialidad")
    public int modificarEspecialidad(@WebParam(name = "especialidad")Especialidad especialidad){
        int resultado=0;
        try {
            resultado=this.especialidad.modificar(especialidad);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarEspecialidad")
    public int eliminarEspecialidad(@WebParam(name = "especialidad")Especialidad especialidad){
        int resultado=0;
        try {
            resultado=this.especialidad.eliminar(especialidad);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarInvitado")
    public ArrayList<Invitado> listarInvitado(){
        ArrayList<Invitado> lista=new ArrayList<>();
        try {
            lista=invitado.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarInvitado")
    public int insertarInvitado(@WebParam(name = "invitado")Invitado invitado){
        int resultado=0;
        try {
            resultado=this.invitado.insertar(invitado);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "modificarInvitado")
    public int modificarInvitado(@WebParam(name = "invitado")Invitado invitado){
        int resultado=0;
        try {
            resultado=this.invitado.modificar(invitado);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "eliminarInvitado")
    public int eliminarInvitado(@WebParam(name = "invitado")Invitado invitado){
        int resultado=0;
        try {
            resultado=this.invitado.eliminar(invitado);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }


    @WebMethod(operationName = "listarPsicologo")
    public ArrayList<Psicologo> listarPsicologo(){
        ArrayList<Psicologo> lista=new ArrayList<>();
        try {
            lista=psicologo.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarPsicologo")
    public int insertarPsicologo(@WebParam(name = "invitado")Psicologo psicologo){
        int resultado=0;
        try {
            resultado=this.psicologo.insertar(psicologo);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "modificarPsicologo")
    public int modificarPsicologo(@WebParam(name = "invitado")Psicologo psicologo){
        int resultado=0;
        try {
            resultado=this.psicologo.modificar(psicologo);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "eliminarPsicologo")
    public int eliminarPsicologo(@WebParam(name = "invitado")Psicologo psicologo){
        int resultado=0;
        try {
            resultado=this.psicologo.eliminar(psicologo);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
}
