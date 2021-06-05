package pe.edu.pucp.gestion_humana.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_humana.controller.dao.AlumnoDAO;
import pe.edu.pucp.gestion_humana.model.Alumno;
import pe.edu.pucp.gestion_humana.model.Especialidad;

/**
 *
 * @author Gerardo
 */
public class AlumnoMySQL implements AlumnoDAO{

    Connection con;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public ArrayList<Alumno> listar() {
        ArrayList<Alumno> alumnos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call listar_alumno()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Alumno alumno = new Alumno();
                alumno.setId_persona(rs.getInt("id_persona"));
                alumno.setNombre(rs.getString("nombre"));
                alumno.setDni(rs.getString("dni"));
                alumno.setEdad(rs.getInt("edad"));
                alumno.setCorreo(rs.getString("correo"));
                alumno.setDireccion(rs.getString("direccion"));
                
                alumno.setUsuario_pucp(rs.getString("usuario_pucp"));
                alumno.setFecha_inclusion(rs.getDate("fecha_de_inclusion"));
                
                alumno.setCodigo_pucp(rs.getString("codigo_pucp"));
                
                
                alumno.getEspecialidad().setId_especialidad(rs.getInt("fid_especialidad"));
                
                alumno.setCraest(rs.getDouble("craest"));
                
                //Especialidad, Invitado, Profesor Psicologo.
                
                alumnos.add(alumno);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return alumnos;
    }

    @Override
    public int insertar(Alumno alumno) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call insertar_alumno(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_alumno", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre", alumno.getNombre());
            cs.setString("_dni", alumno.getDni());
            cs.setInt("_edad", alumno.getEdad());
            cs.setString("_direccion", alumno.getDireccion());
            /*Miembro PUCP*/
            cs.setString("_usuario_pucp", alumno.getUsuario_pucp());
            cs.setString("_correo", alumno.getCorreo());
            cs.setDate("_fecha_de_inclusion", new java.sql.Date(alumno.getFecha_inclusion().getTime()));
            /*Alumno*/
            cs.setString("_codigo_pucp", alumno.getCodigo_pucp());
            cs.setInt("_fid_especialidad", alumno.getEspecialidad().getId_especialidad());
            cs.setDouble("_craest", alumno.getCraest());
            
            cs.setInt("_cursos_por_primera", alumno.getCursos_por_primera());
            cs.setInt("_cursos_por_segunda", alumno.getCursos_por_segunda());
            cs.setInt("_cursos_por_tercera", alumno.getCursos_por_tercera());
                    
            cs.setDouble("_creditos_aprobados", alumno.getCreditos_aprobados());
            cs.executeUpdate();
            alumno.setId_persona(cs.getInt("_id_alumno"));
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
    public int modificar(Alumno alumno) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call modificar_alumno(?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_alumno", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre", alumno.getNombre());
            cs.setString("_dni", alumno.getDni());
            cs.setInt("_edad", alumno.getEdad());
            cs.setString("_direccion", alumno.getDireccion());
            /*Miembro PUCP*/
            cs.setString("_usuario_pucp", alumno.getUsuario_pucp());
            cs.setDate("_fecha_de_inclusion", new java.sql.Date(alumno.getFecha_inclusion().getTime()));
            /*Alumno*/
            cs.setString("_codigo_pucp", alumno.getCodigo_pucp());
            cs.setString("_especialidad", alumno.getEspecialidad().getNombre_especialidad());
            cs.setDouble("_craest", alumno.getCraest());
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
    public int eliminar(Alumno alumno) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call eliminar_alumno(?)}");
            cs.setInt("_id_alumno", alumno.getId_alumno());
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

