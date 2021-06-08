/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.OOIA.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.gestion_humana.controller.dao.AlumnoDAO;
import pe.edu.pucp.gestion_humana.controller.mysql.AlumnoMySQL;
import pe.edu.pucp.gestion_humana.model.Alumno;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "AlumnoWS")
public class AlumnoWS {

    private AlumnoDAO alumno;
    public  AlumnoWS(){
        alumno=new AlumnoMySQL();
    }
    @WebMethod(operationName = "listarAlumno")
    public ArrayList<Alumno> listarAlumno(){
        ArrayList lista=null;
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
    
}
