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
import pe.edu.pucp.ooia.gest_humana.dao.ProfesorDAO;
import pe.edu.pucp.ooia.gest_humana.model.Profesor;
import pe.edu.pucp.ooia.gest_humana.mysql.ProfesorMySQL;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "ProfesorWS")
public class ProfesorWS {

    /**
     * This is a sample web service operation
     */
    
    private ProfesorDAO daoProfesor;

    public ProfesorWS() {
        daoProfesor=new ProfesorMySQL();
    }
    

            
    @WebMethod(operationName = "listarProfesores")
    public ArrayList <Profesor>listarProfesores(){
        ArrayList<Profesor> empleador=null;
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
    public int eliminarProfesor(@WebParam(name = "id_profesor")int id_profesor){
        int resultado=0;
        try {
            resultado=daoProfesor.eliminar(id_profesor);
            
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        
        return resultado;
    }
    
}
