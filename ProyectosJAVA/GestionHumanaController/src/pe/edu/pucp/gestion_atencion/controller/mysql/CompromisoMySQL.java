package pe.edu.pucp.gestion_atencion.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_atencion.controller.dao.CompromisoDAO;
import pe.edu.pucp.gestion_atencion.model.Compromiso;

/**
 *
 * @author DAYANA
 */
public class CompromisoMySQL  implements CompromisoDAO{
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Compromiso> listar(int id_cita) {
        ArrayList<Compromiso> compromisos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_COMPROMISOS(?)}");
            cs.setInt("_id_cita",id_cita);
            rs = cs.executeQuery();
            while(rs.next()){
                Compromiso compromiso = new Compromiso();
                compromiso.setId_compromiso(rs.getInt("id_compromiso"));
                compromiso.setDescripcion(rs.getString("descripcion"));

                compromisos.add(compromiso);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return compromisos;
    }

    @Override
    public int insertar(Compromiso compromiso) {
       int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call INSERTAR_COMPROMISO(?,?,?)}");
           cs.registerOutParameter("_id_compromiso",java.sql.Types.INTEGER);
           cs.setInt("_fid_cita",compromiso.getCita().getId_cita());
           cs.setString("_descripcion",compromiso.getDescripcion());
           cs.executeUpdate();
           compromiso.setId_compromiso(cs.getInt("_id_compromiso"));
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
    public int modificar(Compromiso compromiso) {
       int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call INSERTAR_COMPROMISO(?,?,?)}");
           cs.setInt("_id_compromiso",compromiso.getId_compromiso());
           cs.setInt("_fid_cita",compromiso.getCita().getId_cita());
           cs.setString("_descripcion",compromiso.getDescripcion());
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
