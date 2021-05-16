/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.gestion_tramites_academicos.mysql;

import java.sql.*;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_humana.controller.mysql.AlumnoMySQL;
import pe.edu.pucp.gestion_humana.model.Alumno;
import pe.edu.pucp.gestion_tramites_academicos.dao.TramiteAlumnoDao;
import pe.edu.pucp.gestion_tramites_academicos.model.Tramite;

import pe.edu.pucp.gestion_tramites_academicos.model.TramiteAlumno;

/**
 *
 * @author LENOVO
 */
public class TramiteAlumnoMySql implements TramiteAlumnoDao{
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    public ArrayList<TramiteAlumno> listar() {
        ArrayList<TramiteAlumno>lista=new ArrayList<>();
        try{ 
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs= con.prepareCall("{call LISTAR_TRAMITE_ALUMNO()}");
            rs=cs.executeQuery();
            while(rs.next()){
                    TramiteAlumno aux=new TramiteAlumno();
                    aux.setAlumno(asignarAlumno(aux,rs.getInt("fid_alumno")));
                    aux.setTramite(asignarTramite(aux,rs.getInt("fid_tramite")));
                    aux.setEstado(rs.getBoolean("estado"));
                    lista.add(aux);
            }
         
        }catch (Exception e) {
            System.out.println(e.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return lista;   
    }
    

    @Override
    public int insertar(TramiteAlumno tramiteAlumno) {
        int resultado=0;
        
        try{ 
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs= con.prepareCall("{call INSERTAR_TRAMITE_ALUMNO(?,?,?)}");
            cs.registerOutParameter("_id_tramite_alumno", java.sql.Types.INTEGER);
            cs.setInt("_fid_alumno",  tramiteAlumno.getAlumno().getId_alumno());
            cs.setInt("_fid_tramite",  tramiteAlumno.getTramite().getId_tramite());
            cs.executeUpdate();
            resultado=1;
            cs.close();
        }catch (Exception e) {
            System.out.println(e.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(TramiteAlumno tramiteAlumno) {
        int resultado=0;
        try{ 
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs= con.prepareCall("{call MODIFICAR_TRAMITE_ALUMNO(?,?,?)}");
            cs.setInt("_id_tramite_alumno ", tramiteAlumno.getId_tramite());
            cs.setInt("_fid_alumno ", tramiteAlumno.getAlumno().getId_alumno());
            cs.setInt("_fid_tramite ", tramiteAlumno.getTramite().getId_tramite());
            cs.executeUpdate();
            resultado=1;
            cs.close();
        }catch (Exception e) {
            System.out.println(e.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(TramiteAlumno tramiteAlumno) {
        int resultado=0;
        try{ 
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs= con.prepareCall("{call ELIMINAR_TRAMITE_ALUMNO(?)}");
            cs.setInt("_id_tramite_alumno", tramiteAlumno.getId_tramite());
            cs.executeUpdate();
            resultado=1;
            cs.close();
        }catch (Exception e) {
            System.out.println(e.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    private Alumno asignarAlumno(TramiteAlumno aux, int id_alumno) {
        try{ 
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            
           ArrayList<Alumno> lista=new AlumnoMySQL().listar();
           
            
           
            //busqueda a ser cambiada
            for(Alumno auxT : lista){
                if(auxT.getId_alumno()==id_alumno){
                  return auxT;
                }
            }
           
        }catch (Exception e) {
            System.out.println(e.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return null;
    }

    private Tramite asignarTramite(TramiteAlumno aux, int id_tramite) {
        try{ 
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            ArrayList <Tramite> lista=new TramiteMySql().listar();
           
            //busqueda a ser cambiada
            for(Tramite auxT : lista){
                if(auxT.getId_tramite()==id_tramite){
                    return auxT;
                    
                }
            }
           
           
        }catch (Exception e) {
            System.out.println(e.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return null;
    }

    
    
}
