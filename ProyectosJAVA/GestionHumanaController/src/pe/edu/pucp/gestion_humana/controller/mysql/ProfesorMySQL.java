package pe.edu.pucp.gestion_humana.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_humana.controller.dao.ProfesorDAO;
import pe.edu.pucp.gestion_humana.model.Especialidad;
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
                profesor.setId_profesor(rs.getInt("id_profesor") );
                profesor.setId_miembro_pucp(rs.getInt("id_miembro_pucp"));
                profesor.setNombre(rs.getString("nombre"));
                profesor.setDni(rs.getString("dni"));
                profesor.setEdad(rs.getInt("edad"));
                profesor.setDireccion(rs.getString("direccion"));
                
                profesor.setUsuario_pucp(rs.getString("usuario_pucp"));
                profesor.setFecha_inclusion(rs.getDate("fecha_de_inclusion"));
               
                profesor.setEspecialidad(new Especialidad(rs.getInt("fid_especialidad"),rs.getString("nombre_especialidad")));
                profesor.setFacultad(rs.getString("facultad"));
                profesor.setCategoria(rs.getString("categoria"));
                profesor.setEstado(1);
                
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
            cs.setDate("_fecha_de_inclusion", new java.sql.Date(profesor.getFecha_inclusion().getTime()));
            /*Profesor*/
            cs.setInt("_especialidad", profesor.getEspecialidad().getId_especialidad());
            cs.setString("_facultad", profesor.getFacultad());
            cs.setString("_categoria", profesor.getCategoria());
            cs.executeUpdate();
            profesor.setId_persona(cs.getInt("_id_profesor"));
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
            cs.registerOutParameter("_id_profesorm", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre", profesor.getNombre());
            cs.setString("_dni", profesor.getDni());
            cs.setInt("_edad", profesor.getEdad());
            cs.setString("_direccion", profesor.getDireccion());
            /*Miembro PUCP*/
            cs.setString("_usuario_pucp", profesor.getUsuario_pucp());
            cs.setDate("_fecha_de_inclusion", new java.sql.Date(profesor.getFecha_inclusion().getTime()));
            /*Profesor*/
            cs.setInt("_especialidad", profesor.getEspecialidad().getId_especialidad());
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
