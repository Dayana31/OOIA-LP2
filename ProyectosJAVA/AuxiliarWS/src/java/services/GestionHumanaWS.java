/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ooia.gest_humana.dao.AlumnoDAO;
import pe.edu.pucp.ooia.gest_humana.dao.EspecialidadDAO;
import pe.edu.pucp.ooia.gest_humana.dao.PonenteDao;
import pe.edu.pucp.ooia.gest_humana.dao.ProfesorDAO;
import pe.edu.pucp.ooia.gest_humana.dao.PsicologoDAO;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;
import pe.edu.pucp.ooia.gest_humana.model.Especialidad;
import pe.edu.pucp.ooia.gest_humana.model.Ponente;
import pe.edu.pucp.ooia.gest_humana.model.Profesor;
import pe.edu.pucp.ooia.gest_humana.model.Psicologo;
import pe.edu.pucp.ooia.gest_humana.mysql.AlumnoMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.EspecialidadMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.PonenteMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.ProfesorMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.PsicologoMySQL;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "GestionHumanaWS")
public class GestionHumanaWS {
    private AlumnoDAO alumno;
    private EspecialidadDAO especialidad;    
    private ProfesorDAO daoProfesor;
    private PonenteDao ponente;   
    private PsicologoDAO psicologo;
    
    public GestionHumanaWS() {
        alumno=new AlumnoMySQL();
        especialidad=new EspecialidadMySQL();
        daoProfesor=new ProfesorMySQL();
        ponente =new PonenteMySQL();
        psicologo=new PsicologoMySQL();
        
    }
@WebMethod(operationName = "listarAlumno")
    public ArrayList<Alumno> listarAlumno(){
        ArrayList<Alumno> lista= new ArrayList<>();
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
    public int eliminarAlumno(@WebParam(name = "id_alumno")int id_alumno){
        int resultado=0;
        try {
            resultado=this.alumno.eliminar(id_alumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
  
    @WebMethod(operationName = "listarEspecialidad")
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
    public int eliminarEspecialidad(@WebParam(name = "id_especialidad")int id_especialidad){
        int resultado=0;
        try {
            resultado=this.especialidad.eliminar(id_especialidad);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
 
    @WebMethod(operationName = "listarProfesor")
    public ArrayList <Profesor>listarProfesores(){
        ArrayList<Profesor> empleador=new ArrayList<>();
        try {
            empleador= daoProfesor.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return empleador;
    }
    @WebMethod(operationName = "insertarProfesor")
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
    public int eliminarProfesor(@WebParam(name = "id_profesor")int id_profesor){
        int resultado=0;
        try {
            resultado=daoProfesor.eliminar(id_profesor);
            
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return resultado;
    }
    
    @WebMethod(operationName = "listarPonente")
    public ArrayList<Ponente> listarPonente(){
        ArrayList<Ponente> lista=new ArrayList<>();
        try {
            lista=ponente.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarPonente")
    public int insertarInvitado(@WebParam(name = "Ponente")Ponente ponente){
        int resultado=0;
        try {
            resultado=this.ponente.insertar(ponente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "modificarPonente")
    public int modificarInvitado(@WebParam(name = "invitado")Ponente ponente){
        int resultado=0;
        try {
            resultado=this.ponente.modificar(ponente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "eliminarPonente")
    public int eliminarInvitado(@WebParam(name = "id_ponente")int id_ponente){
        int resultado=0;
        try {
            resultado=this.ponente.eliminar(id_ponente);
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
    public int eliminarPsicologo(@WebParam(name = "id_psicologo")int id_psicologo){
        int resultado=0;
        try {
            resultado=this.psicologo.eliminar(id_psicologo);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
}
