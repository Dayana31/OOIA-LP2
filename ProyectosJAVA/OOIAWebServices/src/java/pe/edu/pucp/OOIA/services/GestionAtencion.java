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
import pe.edu.pucp.gestion_atencion.controller.dao.CitaDAO;
import pe.edu.pucp.gestion_atencion.controller.dao.CodigoAtencionDAO;
import pe.edu.pucp.gestion_atencion.controller.dao.CompromisoDAO;
import pe.edu.pucp.gestion_atencion.controller.dao.HorarioDAO;
import pe.edu.pucp.gestion_atencion.controller.mysql.CitaMySQL;
import pe.edu.pucp.gestion_atencion.controller.mysql.CodigoAtencionMySQL;
import pe.edu.pucp.gestion_atencion.controller.mysql.CompromisoMySQL;
import pe.edu.pucp.gestion_atencion.controller.mysql.HorarioMySQL;
import pe.edu.pucp.gestion_atencion.model.Cita;
import pe.edu.pucp.gestion_atencion.model.CodigoAtencion;
import pe.edu.pucp.gestion_atencion.model.Compromiso;
import pe.edu.pucp.gestion_atencion.model.Horario;

/**
 *
 * @author LENOVO
 */
@WebService(serviceName = "GestionAtencion")
public class GestionAtencion {

    private CitaDAO cita;
    private CodigoAtencionDAO codigo;
    private CompromisoDAO compromiso;
    private HorarioDAO horario;

    public GestionAtencion() {
        cita=new CitaMySQL();
        codigo=new CodigoAtencionMySQL();
        compromiso=new CompromisoMySQL();
        horario=new HorarioMySQL();
    }
    
    @WebMethod(operationName ="listarCita" )
    public ArrayList<Cita>listarCita(@WebParam(name = "id_alumno" )int id_alumno){
        ArrayList<Cita>lista=null;
        try {
            lista=cita.listar(id_alumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarCita")
   public int insertarCita(@WebParam(name = "cita")Cita cita){
       int resultado=0;
        try {
            resultado=this.cita.insertar(cita);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
   }
    @WebMethod(operationName = "modificarCita")
   public int modificarCita(@WebParam(name = "cita")Cita cita){
       int resultado=0;
        try {
            resultado=this.cita.modificar(cita);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
   }
    @WebMethod(operationName = "eliminarCita")
   public int eliminarCita(@WebParam(name = "cita")Cita cita){
       int resultado=0;
        try {
            resultado=this.cita.eliminar(cita.getId_cita());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
   }
           
    @WebMethod(operationName = "listarCodigo")
    public ArrayList<CodigoAtencion> listarCodigo(){
        ArrayList<CodigoAtencion>lista=null;
        try {
            lista=this.codigo.listar();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarCodigo")
    public int insertarCodigo(@WebParam(name = "codigo") CodigoAtencion codigo){
        int resultado=0;
        try {
            resultado=this.codigo.insertar(codigo);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
                return resultado;
    }
    @WebMethod(operationName = "modificarCodigo")
    public int modificarCodigo(@WebParam(name = "codigo") CodigoAtencion codigo){
        int resultado=0;
        try {
            resultado=this.codigo.modificar(codigo);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
                return resultado;
    }
    
    @WebMethod(operationName = "listarCompromiso")
    public ArrayList<Compromiso>listarCompromiso(@WebParam(name = "id_cita") int id_cita){
        ArrayList<Compromiso>lista=null;
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
    
    @WebMethod(operationName = "listarHorario")
    public ArrayList<Horario>listarHorario(@WebParam(name = "id_asesor")int id_asesor){
        ArrayList<Horario >lista=null;
        try {
            lista=this.horario.listar(id_asesor);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return lista;
    }
    @WebMethod(operationName = "insertarHorario")
    public int insertarHorario(@WebParam(name = "horario")Horario horario){
        int resultado=0;
        
        try {
            resultado=this.horario.insertar(horario);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "modificarHorario")
    public int modificarHorario(@WebParam(name = "horario")Horario horario){
        int resultado=0;
        
        try {
            resultado=this.horario.modificar(horario);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    @WebMethod(operationName = "eliminarHorario")
    public int eliminarHorario(@WebParam(name = "horario")Horario horario){
        int resultado=0;
        
        try {
            resultado=this.horario.eliminar(horario.getId_horario());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
        
    }
    
    
}
