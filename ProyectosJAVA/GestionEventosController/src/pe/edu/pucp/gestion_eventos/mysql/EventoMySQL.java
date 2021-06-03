package pe.edu.pucp.gestion_eventos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_eventos.dao.CoordinadorEventosDAO;
import pe.edu.pucp.gestion_eventos.dao.EventoDAO;
import pe.edu.pucp.gestion_eventos.model.MiembroOOIA;
import pe.edu.pucp.gestion_eventos.model.Evento;

public class EventoMySQL implements EventoDAO{

    Connection con;
    Statement st;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public ArrayList<Evento> listar() {
        ArrayList<Evento> eventos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call LISTAR_EVENTO()");
            
            rs = cs.executeQuery();
            
            while(rs.next()){
                Evento evento = new Evento();
                evento.setId_evento(rs.getInt("id_evento"));
                evento.setNombre(rs.getString("nombre"));
                evento.setLugar(rs.getString("lugar"));
                evento.setCapacidad(rs.getInt("capacidad"));
                evento.setFechaInicio(rs.getDate("fecha_inicio"));
                evento.setFechaFin(rs.getDate("fecha_fin"));
                eventos.add(evento);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            
        }
        return eventos;
    }

    @Override
    public int insertar(Evento evento) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call INSERTAR_EVENTO(?,?,?,?,?,?,?)");
            //SETEAMOS los parametros
            
            //Insertamos en evento
            cs.setInt("_fid_coordinador", evento.getId_coordinador());
            cs.setInt("_id_evento", evento.getId_evento());
            cs.setInt("_capacidad", evento.getCapacidad());
            cs.setString("_nombre", evento.getNombre());
            cs.setDate("_fecha_inicio", (Date) evento.getFechaInicio());
            cs.setDate("_fecha_fin", (Date) evento.getFechaFin());
            cs.setString("_lugar", evento.getLugar());
     
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
    public int modificar(Evento evento) {
        int resultado = 0;
        
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call MODIFICAR_EVENTO(?,?,?,?,?,?,?)");
            //SETEAMOS los parametros
            
            //Modificamos en evento
            cs.setInt("_fid_coordinador", evento.getId_coordinador());
            cs.setInt("_id_evento", evento.getId_evento());
            cs.setInt("_capacidad", evento.getCapacidad());
            cs.setString("_nombre", evento.getNombre());
            cs.setDate("_fecha_inicio", (Date) evento.getFechaInicio());
            cs.setDate("_fecha_fin", (Date) evento.getFechaFin());
            cs.setString("_lugar", evento.getLugar());
     
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
    public int eliminar(int id_evento) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call ELIMINAR_EVENTO(?)");
            //SETEAMOS los parametros
            cs.setInt("_id_evento", id_evento);
            
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