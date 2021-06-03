package pe.edu.pucp.gestion_eventos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_eventos.dao.CoordinadorEventosDAO;
import pe.edu.pucp.gestion_eventos.model.MiembroOOIA;

public class CoordinadorEventosMySQL implements CoordinadorEventosDAO{

    Connection con;
    Statement st;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<MiembroOOIA> listar() {
        
        ArrayList<MiembroOOIA> coordinadores = new ArrayList<>();//lista para poner los coordinadores
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call LISTAR_COORDINADOR()");
            
            rs = cs.executeQuery();
            
            while(rs.next()){
                MiembroOOIA coordinador = new MiembroOOIA();
                
                coordinador.setId_persona(rs.getInt("id_persona"));
                coordinador.setNombre(rs.getString("nombre"));
                coordinador.setDni(rs.getString("dni"));
                coordinador.setEdad(rs.getInt("edad"));
                coordinador.setDireccion(rs.getString("direccion"));
                coordinador.setUsuario_pucp(rs.getString("usuario_pucp"));
                coordinador.setFecha_inclusion(rs.getDate("fecha_inclusion"));
                coordinador.setCorreo(rs.getString("correo"));
                
                coordinadores.add(coordinador);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            
        }
        return coordinadores;
    }

    @Override
    public int insertar(MiembroOOIA coordinador) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call INSERTAR_COORDINADOR(?,?,?,?,?,?,?,?)");
            //SETEAMOS los parametros
            
            //Insertamos en persona
            cs.registerOutParameter("_id_persona", java.sql.Types.INTEGER);
            cs.registerOutParameter("_id_coordinador", java.sql.Types.INTEGER);
            cs.setString("_nombre", coordinador.getNombre());
            cs.setString("_dni", coordinador.getDni());
            cs.setInt("_edad", coordinador.getEdad());
            cs.setString("_direccion", coordinador.getDireccion());
            //Insertamos en miembro_pucp
            cs.setString("_usuario_pucp", coordinador.getUsuario_pucp());
            cs.setDate("_fecha_de_inclusion", new java.sql.Date(coordinador.getFecha_inclusion().getTime()));
            
            //Ejecutamos el procedimiento
            cs.executeUpdate();
            
            //Rescatamos los id's que se generaron automaticamente
            coordinador.setId_persona(cs.getInt("_id_persona"));
            coordinador.setId_miembro_pucp(cs.getInt("_id_coordinador"));
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }

    @Override
    public int modificar(MiembroOOIA coordinador) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call MODIFICAR_COORDINADOR(?,?,?,?,?,?,?,?)");
            //SETEAMOS los parametros
            
            //Modificamos en persona
            cs.setInt("_id_persona", coordinador.getId_persona());
            cs.setInt("_id_coordinador", coordinador.getId_miembro_pucp());
            cs.setString("_nombre", coordinador.getNombre());
            cs.setString("_dni", coordinador.getDni());
            cs.setInt("_edad", coordinador.getEdad());
            cs.setString("_direccion", coordinador.getDireccion());
            //Modificamos en miembro_pucp
            cs.setString("_usuario_pucp", coordinador.getUsuario_pucp());
            cs.setDate("_fecha_de_inclusion", new java.sql.Date(coordinador.getFecha_inclusion().getTime()));
            
            //Ejecutamos el procedimiento
            cs.executeUpdate();
            
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }

    @Override
    public int eliminar(int id_coordinador) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call ELIMINAR_COORDINADOR(?)");
            //SETEAMOS los parametros
            cs.setInt("_id_coordinador", id_coordinador);
            
            //Hacemos la eliminacion logica
            cs.executeUpdate();
            
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }
    
}