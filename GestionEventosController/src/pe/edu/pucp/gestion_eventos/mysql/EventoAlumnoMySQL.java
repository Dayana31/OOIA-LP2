package pe.edu.pucp.gestion_eventos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_eventos.dao.CoordinadorEventosDAO;
import pe.edu.pucp.gestion_eventos.dao.EventoAlumnoDAO;
import pe.edu.pucp.gestion_eventos.model.CoordinadorEventosOOIA;
import pe.edu.pucp.gestion_eventos.model.EventoAlumno;

public class EventoAlumnoMySQL implements EventoAlumnoDAO{

    Connection con;
    Statement st;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public ArrayList<EventoAlumno> listar() {
        ArrayList<EventoAlumno> encuestas  = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call LISTAR_ENCUESTA_EVENTO()");
            
            rs = cs.executeQuery();
            
            while(rs.next()){
                EventoAlumno encuesta = new EventoAlumno();
                encuesta.setId_encuesta(rs.getInt("id_encuesta"));
                encuesta.setId_alumno(rs.getInt("fid_alumno"));
                encuesta.setId_evento(rs.getInt("fid_evento"));
                encuesta.setValoracionPonentes(rs.getInt("valoracion_ponentes"));
                encuesta.setValoracionEvento(rs.getInt("valoracion_evento"));
                encuesta.setValoracionUtilidad(rs.getInt("valoracion_utilidad"));
                encuesta.setAsistio(rs.getBoolean("asistencia"));
                encuesta.setComentario(rs.getString("comentario"));
                encuestas.add(encuesta);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            
        }
        return encuestas;
    }

    @Override
    public int insertar(EventoAlumno encuesta) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call INSERTAR_ENCUESTA_EVENTO(?,?,?,?,?,?,?,?)");
            //SETEAMOS los parametros
            
            //Insertamos en encuesta_evento
            cs.setInt("_id_encuesta", encuesta.getId_encuesta());
            cs.setInt("_fid_alumno", encuesta.getId_alumno());
            cs.setInt("_fid_evento", encuesta.getId_evento());
            cs.setInt("_valoracion_ponentes", encuesta.getValoracionPonentes());
            cs.setInt("_valoracion_evento", encuesta.getValoracionEvento());
            cs.setInt("_valoracion_utilidad", encuesta.getValoracionUtilidad());
            cs.setBoolean("_asistencia", encuesta.isAsistio());
            cs.setString("_comentario", encuesta.getComentario());
    
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
    public int modificar(EventoAlumno encuesta) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call MODIFICAR_ENCUESTA_EVENTO(?,?,?,?,?,?,?,?)");
            //SETEAMOS los parametros
            
            //Insertamos en encuesta_evento
            cs.setInt("_id_encuesta", encuesta.getId_encuesta());
            cs.setInt("_fid_alumno", encuesta.getId_alumno());
            cs.setInt("_fid_evento", encuesta.getId_evento());
            cs.setInt("_valoracion_ponentes", encuesta.getValoracionPonentes());
            cs.setInt("_valoracion_evento", encuesta.getValoracionEvento());
            cs.setInt("_valoracion_utilidad", encuesta.getValoracionUtilidad());
            cs.setBoolean("_asistencia", encuesta.isAsistio());
            cs.setString("_comentario", encuesta.getComentario());
    
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
    public int eliminar(int id_encuesta) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call ELIMINAR_ENCUESTA_EVENTO(?)");
            //SETEAMOS los parametros
            cs.setInt("_id_encuesta", id_encuesta);

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
    
    
}