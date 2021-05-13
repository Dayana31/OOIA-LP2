package pe.edu.pucp.gestion_humana.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_humana.controller.dao.ProfesorDAO;
import pe.edu.pucp.gestion_humana.model.Profesor;

/**
 *
 * @author Gerardo
 */
public class ProfesorMySQL implements ProfesorDAO {
    
    Connection con;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Profesor> listar() {
        ArrayList<Profesor> profesores = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call listar_profesor()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Profesor profesor = new Profesor();
                profesor.setId_persona(rs.getInt("id_persona"));
                profesor.setNombre(rs.getString("nombre"));
                profesor.setDni(rs.getString("dni"));
                profesor.setEdad(rs.getInt("edad"));
                profesor.setDireccion(rs.getString("direccion"));
                
                profesor.setUsuario_pucp(rs.getString("usuario_pucp"));
                profesor.setFecha_inclusion(rs.getDate("fecha_inclusion"));
               
                profesor.setEspecialidad(rs.getString("especialidad"));
                profesor.setFacultad(rs.getString("facultad"));
                profesor.setCategoria(rs.getString("categoria"));
                profesor.setEstado(rs.getInt("estado"));
                
                profesores.add(profesor);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return profesores;
    }

    @Override
    public int insertar(Profesor profesor) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call insertar_profesor(?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_profesor", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre", profesor.getNombre());
            cs.setString("_dni", profesor.getDni());
            cs.setInt("_edad", profesor.getEdad());
            cs.setString("_direccion", profesor.getDireccion());
            /*Miembro PUCP*/
            cs.setString("_usuario_pucp", profesor.getUsuario_pucp());
            cs.setDate("_fecha_inclusion", new java.sql.Date(profesor.getFecha_inclusion().getTime()));
            /*Alumno*/
            cs.setString("_especialidad", profesor.getEspecialidad());
            cs.setString("_facultad", profesor.getFacultad());
            cs.setString("_categoria", profesor.getCategoria());
            cs.executeUpdate();
            profesor.setId_persona(cs.getInt("_id_empleado"));
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
    public int modificar(Profesor profesor) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call modificar_profesor(?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_alumno", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre", profesor.getNombre());
            cs.setString("_dni", profesor.getDni());
            cs.setInt("_edad", profesor.getEdad());
            cs.setString("_direccion", profesor.getDireccion());
            /*Miembro PUCP*/
            cs.setString("_usuario_pucp", profesor.getUsuario_pucp());
            cs.setDate("_fecha_inclusion", new java.sql.Date(profesor.getFecha_inclusion().getTime()));
            /*Profesor*/
            cs.setString("_especialidad", profesor.getEspecialidad());
            cs.setString("_facultad", profesor.getFacultad());
            cs.setString("_categoria", profesor.getCategoria());
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
    public int eliminar(Profesor profesor) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call eliminar_profesor(?)}");
            cs.setInt("_id_profesor", profesor.getId_profesor());
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
