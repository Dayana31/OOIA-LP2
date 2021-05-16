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
import java.sql.SQLType;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_tramites_academicos.dao.RequisitoDAO;
import pe.edu.pucp.gestion_tramites_academicos.model.Requisito;

/**
 *
 * @author LENOVO
 */
public class RequisitoMySql implements RequisitoDAO{
    Connection con;
    ResultSet rs;
    CallableStatement cs;
    @Override
    public ArrayList<Requisito> listar() {
        ArrayList<Requisito> listaReq=new ArrayList<>();
       
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs= con.prepareCall("{call LISTAR_REQUISITOS()}");
            rs=cs.executeQuery();
            while(rs.next()){
                    Requisito aux=new Requisito();
                    aux.setEstado(true);
                    aux.setId_requisito(rs.getInt("id_requisito"));
                    aux.setDescripcion(rs.getString("descripcion"));
                    aux.setCraestMin(rs.getDouble("craestMin"));
                    aux.setCreditosMin(rs.getDouble("creditosMin"));
                    aux.setEstadoAlumno(rs.getInt("estadoAlumno"));
                    aux.setEscalaAlumno(rs.getInt("escalaAlumno"));
                    listaReq.add(aux);
            }
            rs.close();
            cs.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
    }
        return listaReq;
    }

    @Override
    public int insertar(Requisito requisito) {
         int resultado=0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs= con.prepareCall("{call INSERTAR_REQUISITO(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_requisito",  java.sql.Types.INTEGER);
            cs.setString("_descripcion", requisito.getDescripcion());
            cs.setDouble("_craestMin", requisito.getCraestMin());
            cs.setDouble("_creditosMin", requisito.getCreditosMin());
            cs.setInt("_estadoAlumno", requisito.getEstadoAlumno());
            cs.setInt("_escala_alumno", requisito.getEscalaAlumno());
            cs.executeUpdate();
            requisito.setId_requisito(cs.getInt("_id_requisito"));
            resultado=1;
            cs.close();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
    }
        return resultado;
    }

    @Override
    public int modificar(Requisito requisito) {
        int resultado=0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs= con.prepareCall("{call MODIFICAR_REQUISITOS(?,?,?,?,?,?)}");
            cs.setInt("_id_registro",requisito.getId_requisito());
            cs.setString("_descripcion", requisito.getDescripcion());
            cs.setDouble("_craestMin", requisito.getCraestMin());
            cs.setDouble("_creditosMin", requisito.getCreditosMin());
            cs.setInt("_estadoAlumno", requisito.getEstadoAlumno());
            cs.setInt("_escalaAlumno", requisito.getEscalaAlumno());
            cs.executeUpdate();
            resultado=1;
            cs.close();
        
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
    }
        return resultado;
    }

    @Override
    public int eliminar(Requisito requisito) {
        int resultado=0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs= con.prepareCall("{call ELIMINAR_REQUISITOS(?)}");
            cs.setInt("_id_requisito",requisito.getId_requisito() );
            cs.executeUpdate();
            resultado=1;
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
    }
    return resultado;
    }
    
}
