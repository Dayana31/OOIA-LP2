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
import pe.edu.pucp.ooia.gest_humana.mysql.PonenteMySQL;
import pe.edu.pucp.ooia.gest_humana.model.Ponente;
import pe.edu.pucp.ooia.gest_humana.dao.PonenteDao;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "InvitadoWS")
public class PonenteWS {

    /**
     * This is a sample web service operation
     */
    private PonenteDao ponente;

    public PonenteWS() {
        ponente=new PonenteMySQL();
    }
    
    @WebMethod(operationName = "listarInvitado")
    public ArrayList<Ponente> listarInvitado(){
        ArrayList<Ponente> lista=new ArrayList<>();
        try {
            lista=ponente.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarInvitado")
    public int insertarInvitado(@WebParam(name = "invitado")Ponente invitado){
        int resultado=0;
        try {
            resultado=this.ponente.insertar(invitado);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "modificarInvitado")
    public int modificarInvitado(@WebParam(name = "invitado")Ponente invitado){
        int resultado=0;
        try {
            resultado=this.ponente.modificar(invitado);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "eliminarInvitado")
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
