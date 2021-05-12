package pe.edu.pucp.gestion_atencion.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_atencion.controller.dao.MotivoDAO;
import pe.edu.pucp.gestion_atencion.model.Motivo;

/**
 *
 * @author DAYANA
 */
public class MotivoMySQL implements MotivoDAO {
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Motivo> listar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int insertar(Motivo motivo) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call INSERTAR_MOTIVO(?,?,?)}");
           cs.registerOutParameter("_id_motivo",java.sql.Types.INTEGER);
           cs.setString("_codigo_motivo",motivo.getCodigoMotivo());
           cs.setString("_nombre_motivo",motivo.getDescripcion());
           cs.executeUpdate();
           motivo.setId_motivo(cs.getInt("_id_motivo"));
           resultado=1;
           cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            //esto siempre se va a ejecutar
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }

    @Override
    public int modificar(Motivo motivo) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call MODIFICAR_MOTIVO(?,?,?)}");
           cs.setInt("_id_motivo",motivo.getId_motivo());
           cs.setString("_codigo_motivo",motivo.getCodigoMotivo());
           cs.setString("_nombre_motivo",motivo.getDescripcion());
           cs.executeUpdate();
           resultado=1;
           cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            //esto siempre se va a ejecutar
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }
    
}
