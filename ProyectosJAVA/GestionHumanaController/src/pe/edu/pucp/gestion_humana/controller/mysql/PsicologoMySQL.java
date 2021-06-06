package pe.edu.pucp.gestion_humana.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_humana.controller.dao.PsicologoDAO;
import pe.edu.pucp.gestion_humana.model.Psicologo;

/**
 *
 * @author Gerardo
 */
public class PsicologoMySQL implements PsicologoDAO {
    
    Connection con;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Psicologo> listar() {
        ArrayList<Psicologo> psicologos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call listar_psicologo()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Psicologo psicologo = new Psicologo();
                psicologo.setId_persona(rs.getInt("id_persona"));
                psicologo.setId_psicologo(rs.getInt("id_psicologo"));
                psicologo.setNombre(rs.getString("nombre"));
                psicologo.setDni(rs.getString("dni"));
                psicologo.setEdad(rs.getInt("edad"));
                psicologo.setDireccion(rs.getString("direccion"));
                psicologo.setCorreo(rs.getString("correo"));
                psicologo.setUsuario_pucp(rs.getString("usuario_pucp"));
                psicologo.setFecha_inclusion(rs.getDate("fecha_de_inclusion"));
               
                psicologos.add(psicologo);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return psicologos;
    }

    @Override
    public int insertar(Psicologo psicologo) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call insertar_psicologo(?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_psicologo", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre", psicologo.getNombre());
            cs.setString("_dni", psicologo.getDni());
            cs.setInt("_edad", psicologo.getEdad());
            cs.setString("_direccion", psicologo.getDireccion());
            /*Miembro PUCP*/
            cs.setString("_usuario_pucp", psicologo.getUsuario_pucp());
            cs.setString("_correo", psicologo.getCorreo());
            cs.setDate("_fecha_de_inclusion", new java.sql.Date(psicologo.getFecha_inclusion().getTime()));
            /*Psicologo*/
            cs.executeUpdate();
            psicologo.setId_persona(cs.getInt("_id_psicologo"));
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
    public int modificar(Psicologo psicologo) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call modificar_psicologo(?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_psicologo", psicologo.getId_psicologo());
            /*Persona*/
            cs.setString("_nombre", psicologo.getNombre());
            cs.setString("_dni", psicologo.getDni());
            cs.setInt("_edad", psicologo.getEdad());
            cs.setString("_correo", psicologo.getCorreo());
            cs.setString("_direccion", psicologo.getDireccion());
            /*Miembro PUCP*/
            cs.setString("_usuario_pucp", psicologo.getUsuario_pucp());
            cs.setDate("_fecha_de_inclusion", new java.sql.Date(psicologo.getFecha_inclusion().getTime()));
            /*Profesor*/
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
    public int eliminar(Psicologo psicologo) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call eliminar_psicologo(?)}");
            cs.setInt("_id_psicologo", psicologo.getId_psicologo());
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
