package pe.edu.pucp.gestion_humana.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_humana.controller.dao.InvitadoDAO;
import pe.edu.pucp.gestion_humana.model.Invitado;

/**
 *
 * @author Gerardo
 */
public class InvitadoMySQL implements InvitadoDAO{

    Connection con;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Invitado> listar() {
        ArrayList<Invitado> invitados = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call listar_invitado()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Invitado invitado = new Invitado();
                invitado.setId_persona(rs.getInt("id_persona"));
                invitado.setNombre(rs.getString("nombre"));
                invitado.setDni(rs.getString("dni"));
                invitado.setEdad(rs.getInt("edad"));
                invitado.setDireccion(rs.getString("direccion"));
                invitado.setCorreo(rs.getString("correo"));
                invitado.setTelefono(rs.getInt("telefono"));
                invitado.setOcupacion(rs.getString("ocupacion"));
               
                invitados.add(invitado);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return invitados;
    }

    @Override
    public int insertar(Invitado invitado) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call insertar_invitado(?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_invitado", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre", invitado.getNombre());
            cs.setString("_dni", invitado.getDni());
            cs.setInt("_edad", invitado.getEdad());
            cs.setString("_correo", invitado.getCorreo());
            cs.setString("_direccion", invitado.getDireccion());
            /*Miembro Externo*/
            cs.setInt("_telefono", invitado.getTelefono());
            cs.setString("_ocupacion", invitado.getOcupacion());
            /*Invitado*/
            cs.executeUpdate();
            invitado.setId_persona(cs.getInt("_id_invitado"));
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
    public int modificar(Invitado invitado) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call modificar_invitado(?,?,?,?,?,?,?,?)}");
            
            cs.setInt("_id_invitado", invitado.getId_invitado());
            /*Persona*/
            cs.setString("_nombre", invitado.getNombre());
            cs.setString("_dni", invitado.getDni());
            cs.setInt("_edad", invitado.getEdad());
            cs.setString("_correo", invitado.getCorreo());
            cs.setString("_direccion", invitado.getDireccion());
            /*Miembro Externo*/
            cs.setInt("_telefono", invitado.getTelefono());
            cs.setString("_ocupacion", invitado.getOcupacion());
            /*Invitado*/
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
    public int eliminar(Invitado invitado) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call eliminar_invitado(?)}");
            cs.setInt("_id_invitado", invitado.getId_invitado());
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