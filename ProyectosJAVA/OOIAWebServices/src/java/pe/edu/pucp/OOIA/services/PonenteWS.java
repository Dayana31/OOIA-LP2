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
import pe.edu.pucp.ooia.gest_humana.dao.PonenteDAO;
import pe.edu.pucp.ooia.gest_humana.model.Ponente;
import pe.edu.pucp.ooia.gest_humana.mysql.PonenteMySQL;


/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "PonenteWS")
public class PonenteWS {

    /**
     * This is a sample web service operation
     */
    private PonenteDAO ponente;

    public PonenteWS() {
        ponente=new PonenteMySQL();
    }
    
    @WebMethod(operationName = "listarPonente")
    public ArrayList<Ponente> listarInvitado(){
        ArrayList<Ponente> lista=null;
        try {
            lista=ponente.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarPonente")
    public int insertarInvitado(@WebParam(name = "invitado")Ponente ponente){
        int resultado=0;
        try {
            resultado=this.ponente.insertar(ponente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "modificarPonente")
    public int modificarInvitado(@WebParam(name = "ponente")Ponente ponente){
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

    
}
