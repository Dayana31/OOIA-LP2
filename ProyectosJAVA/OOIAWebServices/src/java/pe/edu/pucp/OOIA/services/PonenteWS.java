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
import pe.edu.pucp.gestion_humana.controller.dao.InvitadoDAO;
import pe.edu.pucp.gestion_humana.controller.mysql.InvitadoMySQL;
import pe.edu.pucp.gestion_humana.model.Invitado;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "InvitadoWS")
public class InvitadoWS {

    /**
     * This is a sample web service operation
     */
    private InvitadoDAO invitado;

    public InvitadoWS() {
        invitado=new InvitadoMySQL();
    }
    
    @WebMethod(operationName = "listarInvitado")
    public ArrayList<Invitado> listarInvitado(){
        ArrayList<Invitado> lista=null;
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

    
}
