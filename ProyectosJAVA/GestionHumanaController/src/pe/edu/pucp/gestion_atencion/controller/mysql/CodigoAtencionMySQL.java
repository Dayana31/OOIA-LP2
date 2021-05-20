package pe.edu.pucp.gestion_atencion.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_atencion.model.CodigoAtencion;
import pe.edu.pucp.gestion_atencion.controller.dao.CodigoAtencionDAO;

/**
 *
 * @author DAYANA
 */
public class CodigoAtencionMySQL implements CodigoAtencionDAO {
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<CodigoAtencion> listar() {
        ArrayList<CodigoAtencion> codigos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_CODIGOS_ATENCION()}");
            rs = cs.executeQuery();
            while(rs.next()){
                CodigoAtencion codigo = new CodigoAtencion();
                codigo.setId_codigo_atencion(rs.getInt("id_codigo_atencion"));
                codigo.setCodigo(rs.getString("codigo"));
                codigo.setDescripcion(rs.getString("descripcion"));

                codigos.add(codigo);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return codigos;
    }

    @Override
    public int insertar(CodigoAtencion motivo) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call INSERTAR_CODIGO_ATENCION(?,?,?)}");
           cs.registerOutParameter("_id_codigo_atencion",java.sql.Types.INTEGER);
           cs.setString("_codigo",motivo.getCodigo());
           cs.setString("_descripcion",motivo.getDescripcion());
           cs.executeUpdate();
           motivo.setId_codigo_atencion(cs.getInt("_id_codigo_atencion"));
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
    public int modificar(CodigoAtencion motivo) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call MODIFICAR_CODIGO_ATENCION(?,?,?)}");
           cs.setInt("_id_codigo_atencion",motivo.getId_codigo_atencion());
           cs.setString("_codigo",motivo.getCodigo());
           cs.setString("_descripcion",motivo.getDescripcion());
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
