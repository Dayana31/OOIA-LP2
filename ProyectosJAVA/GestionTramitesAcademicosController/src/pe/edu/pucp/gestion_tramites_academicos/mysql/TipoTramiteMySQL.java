package pe.edu.pucp.gestion_tramites_academicos.mysql;

import java.sql.*;
import java.sql.DriverManager;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_tramites_academicos.dao.TipoTramiteDAO;
import pe.edu.pucp.gestion_tramites_academicos.model.TipoTramite;

/**
 *
 * @author Gerardo
 */
public class TipoTramiteMySQL implements TipoTramiteDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    @Override
    public ArrayList<TipoTramite> listar() {
        //LISTAR_TIPO_TRAMITE
        ArrayList<TipoTramite> listaReq=new ArrayList<>();
       
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs= con.prepareCall("{call LISTAR_TIPO_TRAMITE()}");
            rs=cs.executeQuery();
            while(rs.next()){
                    TipoTramite aux=new TipoTramite();
                    aux.setId(rs.getInt("id_tipo_tramite"));
                    aux.setNombre(rs.getString("nombre_tipo_tramite"));
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
    public int insertar(TipoTramite tipo) {
        int resultado=0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs= con.prepareCall("{call INSERTAR_REQUISITO(?,?)}");
            cs.registerOutParameter("_id_tipo_tramite",  java.sql.Types.INTEGER);
            cs.setString("_nombre_tipo_tramite", tipo.getNombre());
            cs.executeUpdate();
            tipo.setId(cs.getInt("_id_tipo_tramite"));
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
    public int modificr(TipoTramite tipo) {
        int resultado=0;
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs= con.prepareCall("{call INSERTAR_REQUISITO(?,?)}");
            cs.setInt("_id_tipo_tramite",  java.sql.Types.INTEGER);
            cs.setString("_nombre_tipo_tramite", tipo.getNombre());
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
    
}
