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
import pe.edu.pucp.gestion_atencion.controller.dao.CompromisoDAO;
import pe.edu.pucp.gestion_atencion.controller.mysql.CompromisoMySQL;
import pe.edu.pucp.gestion_atencion.model.Compromiso;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "ComprimisoWS")
public class ComprimisoWS {

    /**
     * This is a sample web service operation
     */
    
    private CompromisoDAO compromiso;
    
    public ComprimisoWS(){
        compromiso=new CompromisoMySQL();
    }

    @WebMethod(operationName = "listarCompromiso")
    public ArrayList<Compromiso> listarCompromiso(@WebParam(name = "id_cita") int id_cita) {
        ArrayList<Compromiso>lista=new ArrayList<>();
        try {
            lista=this.compromiso.listar(id_cita);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarCompromiso")
    public int insertarCompromiso(@WebParam(name = "compromiso")Compromiso compromiso){
        int resultado=0;
        try {
            resultado=this.compromiso.insertar(compromiso);
        } catch (Exception e) {
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarCompromiso")
    public int modificarCompromiso(@WebParam(name = "compromiso")Compromiso compromiso){
        int resultado=0;
        try {
            resultado=this.compromiso.modificar(compromiso);
        } catch (Exception e) {
        }
        return resultado;
    }
    
}
