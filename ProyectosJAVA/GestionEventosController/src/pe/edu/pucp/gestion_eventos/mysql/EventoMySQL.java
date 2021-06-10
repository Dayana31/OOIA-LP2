package pe.edu.pucp.gestion_eventos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.Time;
import java.util.ArrayList;

import pe.edu.pucp.config.DBManager;

import pe.edu.pucp.gestion_eventos.dao.EventoDAO;

import pe.edu.pucp.gestion_eventos.model.Evento;
import pe.edu.pucp.gestion_humana.model.Invitado;
import pe.edu.pucp.gestion_humana.model.Persona;

public class EventoMySQL implements EventoDAO{

    Connection con;
    Statement st;
    ResultSet rs;
    CallableStatement cs;

    @Override
    public ArrayList<Evento> listar(String nombre) {
        ArrayList<Evento> eventos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("call LISTAR_EVENTO(?)");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Evento evento = new Evento();
                evento.setId_evento(rs.getInt("id_evento"));
                evento.setNombre(rs.getString("nombre"));
                evento.setLugar(rs.getString("lugar"));
                evento.setCapacidad(rs.getInt("capacidad"));
                evento.setFecha(rs.getDate("fecha"));
                int hora=rs.getTime("hora_inicio").toLocalTime().getHour(),
                        minuto=rs.getTime("hora_inicio").toLocalTime().getMinute();
                evento.setHoraInicio(new java.util.Date(0, 0, 0, hora, minuto));
                 hora=rs.getTime("hora_fin").toLocalTime().getHour();
                        minuto=rs.getTime("hora_fin").toLocalTime().getMinute();
                   evento.setHoraFina(new java.util.Date(0, 0, 0, hora, minuto));
                   evento.setPonentes(obtenerPonentes(evento.getId_evento()));
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
            
            cs = con.prepareCall("call INSERTAR_EVENTO(?,?,?,?,?,?,?,?)");
            //SETEAMOS los parametros
            
            //Insertamos en evento
            cs.setInt("_fid_coordinador", evento.getId_coordinador());
            cs.setInt("_id_evento", evento.getId_evento());
            cs.setInt("_capacidad", evento.getCapacidad());
            cs.setString("_nombre", evento.getNombre());
            cs.setDate("_fecha", new Date(evento.getFecha().getTime()));
            cs.setString("_lugar", evento.getLugar());
            cs.setTime("inicio", new Time(evento.getHoraInicio().getTime()));
            cs.setTime("final", new Time(evento.getHoraFina().getTime()));
            //Ejecutamos el procedimiento
            cs.executeUpdate();
            cs=con.prepareCall("call insertar_evento_ponente(?,?)");
            for(Persona persona:evento.getPonentes()){
                cs.setInt("persona", persona.getId_persona());
                cs.setInt("evento", evento.getId_evento());
                cs.executeUpdate();
            }
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
            
            cs = con.prepareCall("call MODIFICAR_EVENTO(?,?,?,?,?,?,?,?)");
            //SETEAMOS los parametros
            
            //Modificamos en evento
            cs.setInt("_fid_coordinador", evento.getId_coordinador());
            cs.setInt("_id_evento", evento.getId_evento());
            cs.setInt("_capacidad", evento.getCapacidad());
            cs.setString("_nombre", evento.getNombre());
            cs.setDate("_fecha", new Date(evento.getFecha().getTime()));
            cs.setString("_lugar", evento.getLugar());
            cs.setTime("inicio", new Time(evento.getHoraInicio().getTime()));
            cs.setTime("final", new Time(evento.getHoraFina().getTime()));
            
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

    private ArrayList<Persona> obtenerPonentes(int evento) throws Exception{
        Class.forName("com.mysql.cj.jdbc.Driver");
        Connection con1 = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);;
         CallableStatement cs1= con1.prepareCall("call listar_ponente_evento(?)");;
        cs1.setInt("evento",evento);
         ResultSet rs1=cs1.executeQuery();
         ArrayList<Persona>lista=new ArrayList<>();
         while(rs1.next()){
             Invitado invitado=new Invitado();
             invitado.setId_persona(rs1.getInt("id_persona"));
             invitado.setNombre(rs1.getString("nombre"));
             lista.add(invitado);
         }
        return lista;
    }
    
    
    
}