/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.gestion_tramites_academicos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_tramites_academicos.dao.PreguntaFrecuenteDAO;
import pe.edu.pucp.gestion_tramites_academicos.model.PreguntaFrecuente;

/**
 *
 * @author LENOVO
 */
public class PreguntaFrecuenteMySql implements PreguntaFrecuenteDAO{
    Connection con;
    ResultSet rs;
    CallableStatement cs;
    @Override
    public ArrayList<PreguntaFrecuente> listar(int id_tramite) { //agregar opcion si no ingresa tramite se listen todas las preguntas frecuentes que existan.
        ArrayList<PreguntaFrecuente> preguntas=new ArrayList<>();
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs= con.prepareCall("{call LISTAR_PREGUNTA_FRECUENTE(?)}");
            cs.setInt("_fid_tramite", id_tramite);
            rs=cs.executeQuery();
            
            while(rs.next()){
                PreguntaFrecuente pregunta=new PreguntaFrecuente();
                pregunta.setId_PreguntaFrecuente(rs.getInt("id_pregunta_frecuente"));
                pregunta.setPregunta(rs.getString("pregunta"));
                pregunta.setRespuesta(rs.getString("respuesta"));
                pregunta.setEstado(true);
                preguntas.add(pregunta);
            }
            rs.close();
            cs.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            
        }
        return preguntas;
    }

    @Override
    public int insertar(PreguntaFrecuente pregunta,int id_tramite) {
        int resultado=0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs= con.prepareCall("{call INSERTAR_PREGUNTA_FRECUENTE(?,?,?,?)}");
            cs.registerOutParameter("_id_pregunta_frecuente", java.sql.Types.INTEGER);
            cs.setInt("_fid_tramite", id_tramite);
            cs.setString("_pregunta", pregunta.getPregunta());
            cs.setString("_respuesta", pregunta.getRespuesta());
            cs.executeUpdate();
            pregunta.setId_PreguntaFrecuente(cs.getInt("_id_pregunta_frecuente"));
            resultado=1;
            cs.close();
        } catch (ClassNotFoundException | SQLException ex) {
            System.out.println(ex.getMessage());
        }   
        finally{
                try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
           return resultado;
    }
     


    @Override
 public int modificar(PreguntaFrecuente pregunta,int  id_tramite) {
            int resultado=0;
            try {
                Class.forName("com.mysql.cj.jdbc.Driver");
                con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
                cs= con.prepareCall("{call MODIFICAR_PREGUNTA_FRECUENTE(?,?,?,?)}");
                cs.setInt("_id_pregunta_frecuente", pregunta.getId_PreguntaFrecuente());
                cs.setInt("_fid_tramite", id_tramite);
                cs.setString("_pregunta", pregunta.getPregunta());
                cs.setString("_respuesta", pregunta.getRespuesta());
                cs.executeUpdate();
                resultado=1;
                cs.close();
         } catch (ClassNotFoundException | SQLException ex) {
                System.out.println(ex.getMessage());
         }   
        finally{
                try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
         }
        
        return resultado ;
    }

    @Override
    public int eliminar(PreguntaFrecuente pregunta,int id_tramite) {
            int resultado=0;
         try {
                Class.forName("com.mysql.cj.jdbc.Driver");
                con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
                cs= con.prepareCall("{call ELIMINAR_PREGUNTA_FRECUENTE(?,?)}");
                cs.setInt("_id_pregunta_frecuente", pregunta.getId_PreguntaFrecuente());
                cs.setInt("_fid_tramite", id_tramite);
                cs.executeUpdate();
                resultado=1;
                cs.close();
        }
         catch (ClassNotFoundException | SQLException ex) {
                System.out.println(ex.getMessage());
         }   
        finally{
                try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
         }
         return resultado ;
    }
    
}
    

