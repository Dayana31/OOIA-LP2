package pe.edu.pucp.gestion_humana.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_humana.controller.dao.EspecialidadDAO;
import pe.edu.pucp.gestion_humana.model.Especialidad;

/**
 *
 * @author Gerardo
 */
public class EspecialidadMySQL implements EspecialidadDAO {

    Connection con;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Especialidad> listar() {
        ArrayList<Especialidad> especialidades = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_ESPECIALIDAD()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Especialidad especialidad = new Especialidad();
                especialidad.setId_especialidad(rs.getInt("id_especialidad"));
                especialidad.setNombre_especialidad(rs.getString("nombre"));
                
                especialidades.add(especialidad);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return especialidades;
    }

    @Override
    public int insertar(Especialidad especialidad) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_ESPECIALIDAD(?,?)}");
            cs.registerOutParameter("_id_especialidad", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre", especialidad.getNombre_especialidad());
            cs.executeUpdate();
            especialidad.setId_especialidad(cs.getInt("_id_especialidad"));
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Especialidad especialidad) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_ESPECIALIDAD(?,?)}");
            cs.registerOutParameter("_id_especialidad", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre", especialidad.getNombre_especialidad());
            cs.executeUpdate();
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(Especialidad especialidad) {
         int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_ESPECIALIDAD(?)}");
            cs.setInt("_id_especialidad", especialidad.getId_especialidad());
            cs.executeUpdate();
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
}
