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
import pe.edu.pucp.gestion_eventos.dao.CoordinadorEventosDAO;
import pe.edu.pucp.gestion_eventos.model.MiembroOOIA;
import pe.edu.pucp.gestion_eventos.mysql.CoordinadorEventosMySQL;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "CoordinadorEventoWS")
public class CoordinadorEventoWS {

    /**
     * This is a sample web service operation
     */
    private CoordinadorEventosDAO coordinador;
    public CoordinadorEventoWS(){
        coordinador=new CoordinadorEventosMySQL();
    }

    @WebMethod(operationName = "listarCoordinadorEvento")
    public ArrayList<MiembroOOIA> listarCoordinadorEvento() {
        ArrayList<MiembroOOIA> lista= new ArrayList<>();
        try {
            lista=coordinador.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarCoordinadorEvento")
    public int insertarCoordinadorEvento(@WebParam(name = "coordinador")MiembroOOIA coordinador){
        int resultado=0;
        try {
            resultado=this.coordinador.insertar(coordinador);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarCoordinadorEvento")
    public int modificarCoordinadorEvento(@WebParam(name = "coordinador")MiembroOOIA coordinador){
        int resultado=0;
        try {
            resultado=this.coordinador.modificar(coordinador);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarCoordinadorEvento")
    public int eliminarCoordinadorEvento(@WebParam(name = "coordinador")MiembroOOIA coordinador){
        int resultado=0;
        try {
            resultado=this.coordinador.eliminar(coordinador.getId_coordinadorEventosOOIA());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
}
