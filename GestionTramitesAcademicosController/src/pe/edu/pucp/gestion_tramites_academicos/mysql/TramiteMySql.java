/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.gestion_tramites_academicos.mysql;


import java.io.File;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_humana.model.Alumno;
import pe.edu.pucp.gestion_tramites_academicos.dao.TramiteDAO;
import pe.edu.pucp.gestion_tramites_academicos.model.PreguntaFrecuente;
import pe.edu.pucp.gestion_tramites_academicos.model.Requisito;
import pe.edu.pucp.gestion_tramites_academicos.model.TipoTramite.*;
import static pe.edu.pucp.gestion_tramites_academicos.model.TipoTramite.CONTANCIAYCARTAS;
import static pe.edu.pucp.gestion_tramites_academicos.model.TipoTramite.EPAGOS;
import static pe.edu.pucp.gestion_tramites_academicos.model.TipoTramite.GRADOSYTITULOS;
import static pe.edu.pucp.gestion_tramites_academicos.model.TipoTramite.MATRICULA;
import static pe.edu.pucp.gestion_tramites_academicos.model.TipoTramite.NOTAS;
import pe.edu.pucp.gestion_tramites_academicos.model.Tramite;

/**
 *
 * @author LENOVO
 */
public class TramiteMySql implements TramiteDAO {
    Connection con;
    CallableStatement st;
    ResultSet rs;
    @Override
    public ArrayList<Tramite> listar() {
        ArrayList<Tramite>lista=new ArrayList<>();               
        try{ 
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            st=con.prepareCall("{call LISTAR_TRAMITE()}");
            rs=st.executeQuery();
            while(rs.next()){
                Tramite aux=new Tramite();
                aux.setDescripcion(rs.getString("descripcion"));
                aux.setId_tramite(rs.getInt("id_tramite"));
                aux.setEstado(true);
                switch (rs.getInt("tipo_tramite")){
                case 1:
                    aux.setTipoTramite(CONTANCIAYCARTAS);
                    break;
                case 2:
                    aux.setTipoTramite(EPAGOS);
                    break;
                case 3:
                    aux.setTipoTramite(GRADOSYTITULOS);
                    break;
                case 4:
                    aux.setTipoTramite(MATRICULA);
                    break;
                case 5:
                    aux.setTipoTramite(NOTAS);
                    break;    
            }
             aux.setArchivos(conseguirArchivos(aux));
             aux.setRequisitos(conseguirRequisitos(aux));
             aux.setPreguntas(conseguirPreguntas(aux));
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
    public int insertar(Tramite tramite) {
        int resultado=0;
        try{ 
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            st=con.prepareCall("{call INSERTAR_TRAMITE(?,?,?)}");
            st.registerOutParameter("_id_tramite", java.sql.Types.INTEGER);
            st.setString("_descripcion", tramite.getDescripcion());
            switch (tramite.getTipoTramite()){
                case CONTANCIAYCARTAS:
                    st.setInt("_tipo_tramite", 1);
                    break;
                case EPAGOS:
                    st.setInt("_tipo_tramite", 2);
                    break;
                case GRADOSYTITULOS:
                    st.setInt("_tipo_tramite", 3);
                    break;
                case MATRICULA:
                    st.setInt("_tipo_tramite", 4);
                    break;
                case NOTAS:
                    st.setInt("_tipo_tramite", 5);
                    break;    
            }
            st.executeUpdate();
            tramite.setId_tramite(st.getInt("_id_tramite"));
             
             st.close();
             ArrayList<Requisito>lista=tramite.getRequisitos();
             for( Requisito aux :lista){
                 st=con.prepareCall("{call INSERTAR_TRAMITE_REQUISITO(?,?)}");
                 st.setInt("_fid_tramite",  tramite.getId_tramite());
                 st.setInt("_fid_requisito",aux.getId_requisito());
                 st.executeUpdate();
                 st.close();
             }
             ArrayList<PreguntaFrecuente> listaP=tramite.getPreguntas();
             for( PreguntaFrecuente aux :listaP){
                 new PreguntaFrecuenteMySql().insertar(aux, tramite.getId_tramite());
             }
             ArrayList<File>listaArch=tramite.getArchivos();
            
             for(File aux : listaArch){
                 st=con.prepareCall("{call INSERTAR_ARCHIVO(?,?,?)}");
                 st.registerOutParameter("_id_archivo", java.sql.Types.INTEGER);
                 st.setInt("_fid_tramite", tramite.getId_tramite());
                 st.setString("_nombre", aux.getName());
                 st.executeUpdate();
                 st.close();
             }
          resultado=1;       
           
        }catch (Exception e) {
            System.out.println(e.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Tramite tramite) {
        int resultado=0;
        try{ 
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            st=con.prepareCall("{call MODIFICAR_TRAMITE(?,?,?)}");
           st.setInt("_id_tramite", tramite.getId_tramite());
           st.setString("_descripcion", tramite.getDescripcion());
           st.executeUpdate();
           resultado=1;
           st.close();
        }catch (Exception e) {
            System.out.println(e.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }

    @Override
    public int eliminar(Tramite tramite) {
        int resultado=0;
        try{ 
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            st=con.prepareCall("{call ELIMINAR_TRAMITE(?,?,?)}");
           st.setInt("_id_tramite", tramite.getId_tramite());
           st.executeUpdate();
           resultado=1;
           st.close();
        }catch (Exception e) {
            System.out.println(e.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    private ArrayList<File> conseguirArchivos(Tramite tramite) throws SQLException {
            ArrayList<File> lista=new ArrayList<File>();
            st=con.prepareCall("call LISTAR_ARCHIVO()");
            rs=st.executeQuery();
            while(rs.next()){
                if(rs.getInt("fid_tramite")==tramite.getId_tramite()){
                    lista.add(new File(rs.getString("nombre")));
                }
            }
            rs.close();
            st.close();
            return lista;
            
    }

    private ArrayList<Requisito> conseguirRequisitos(Tramite aux) throws SQLException {
        // se listan todos los requisitos que existen    
        ArrayList<Requisito>lista=new RequisitoMySql().listar();
        //variable que se va a devolver    
        ArrayList<Requisito>devolver=new ArrayList<>();
        //se lista todos los requisitos asociados a un tramite    
        st=con.prepareCall("{call LISTAR_TRAMITE_REQUISITO(?)}");
            st.setInt("_id_tramite", aux.getId_tramite());
            rs=st.executeQuery();
            int i=-1;
            Requisito x;
            //se busca y añade el requisito a la variable devolver
            while(rs.next()){
                i=estaRequisito(rs.getInt("fid_requisito"),lista);
                if(i>=0){
                    x=lista.get(i);
                    devolver.add(lista.get(i));
                    }
            }
            return devolver;
        
    }

    private ArrayList<PreguntaFrecuente> conseguirPreguntas(Tramite aux) {
        return new PreguntaFrecuenteMySql().listar(aux.getId_tramite());
        
    }

    private int estaRequisito(int aInt, ArrayList<Requisito> lista) {
        int pos=-1;
        for(int i=0;i<lista.size();i++)
            if(aInt==lista.get(i).getId_requisito())
                return i;
        
        return pos;
        
        
    }

}


