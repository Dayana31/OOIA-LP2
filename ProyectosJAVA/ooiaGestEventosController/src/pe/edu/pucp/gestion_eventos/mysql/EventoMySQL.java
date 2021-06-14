package pe.edu.pucp.gestion_eventos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.Time;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;

import pe.edu.pucp.config.DBManager;

import pe.edu.pucp.gestion_eventos.dao.EventoDAO;
import pe.edu.pucp.gestion_eventos.model.CategoriaEvento;

import pe.edu.pucp.gestion_eventos.model.Evento;
import pe.edu.pucp.ooia.gest_humana.model.Coordinador;
import pe.edu.pucp.ooia.gest_humana.model.Ponente;
import pe.edu.pucp.ooia.gest_humana.mysql.CoordinadorMySQL;

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
            cs = con.prepareCall("{call LISTAR_EVENTO(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Evento evento = new Evento();
                evento.setId_evento(rs.getInt("id_evento"));
                evento.setNombre(rs.getString("nombre"));
                evento.setDescripcion(rs.getString("descripcion"));
                evento.setCategoria(new CategoriaEvento(rs.getInt("id_categoria_evento"), 
                        rs.getString("nombre_categoria")));
                evento.setCoordinador(new Coordinador());
                evento.setCoordinador(obtenerCoordinador(rs.getInt("fid_coordinador")));
                evento.setCapacidad(rs.getInt("capacidad"));
                evento.setCupo(rs.getInt("cupo"));
                evento.setFecha(rs.getDate("fecha"));
                evento.setHoraInicio(rs.getTime("hora_inicio"));
                evento.setHoraFin(rs.getTime("hora_fin"));
                evento.setLugar(rs.getString("lugar"));
                evento.setImagen(rs.getBytes("imagen"));
                evento.setActivo(true);
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
            cs = con.prepareCall("{call INSERTAR_EVENTO(?,?,?,?,?,?,?,?,?,?,?)}");
            //SETEAMOS los parametros
            cs.registerOutParameter("_id_evento", java.sql.Types.INTEGER);
            //Insertamos en evento
            cs.setString("_nombre", evento.getNombre());
            cs.setString("_descripcion", evento.getDescripcion());
            cs.setInt("_fid_coordinador", evento.getCoordinador().getId_coordinador());
            cs.setInt("_fid_categoria", evento.getCategoria().getId_categoria());
            cs.setInt("_capacidad", evento.getCapacidad());
            cs.setString("_lugar", evento.getLugar());
            cs.setDate("_fecha", new Date(evento.getFecha().getTime()));
            cs.setTime("hora_inicio", new Time(evento.getHoraInicio().getTime()));
            cs.setTime("hora_final", new Time(evento.getHoraFin().getTime()));
            cs.setBytes("_imagen", evento.getImagen());
            //Ejecutamos el procedimiento
            cs.executeUpdate();
            evento.setId_evento(cs.getInt("_id_evento")); 
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage() + "Clase");
            Logger.getLogger(EventoMySQL.class.getName()).log(Level.SEVERE, null, ex);
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
            cs = con.prepareCall("{call MODIFICAR_EVENTO(?,?,?,?,?,?,?,?)}");
            //Modificamos en evento
            cs.setString("_nombre", evento.getNombre());
            cs.setString("_descripcion", evento.getDescripcion());
            cs.setInt("_fid_coordinador", evento.getCoordinador().getId_coordinador());
            cs.setInt("_fid_categoria", evento.getCategoria().getId_categoria());
            cs.setInt("_capacidad", evento.getCapacidad());
            cs.setInt("_cupo", evento.getCupo());
            cs.setString("_lugar", evento.getLugar());
            cs.setDate("_fecha", new Date(evento.getFecha().getTime()));
            cs.setTime("hora_inicio", new Time(evento.getHoraInicio().getTime()));
            cs.setTime("hora_final", new Time(evento.getHoraFin().getTime()));
            cs.setBytes("_imagen", evento.getImagen());
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
    
    private Coordinador obtenerCoordinador(int id_coordinador) {
        ArrayList<Coordinador> arrayList=new CoordinadorMySQL().listar();
        for(Coordinador aux:arrayList)
            if(aux.getId_coordinador()==id_coordinador)
                return aux;
        return null;
    }
    
//    private ArrayList<Integer> listarPonente(int id_evento){
//           ArrayList<Integer> lista=new ArrayList<>();
//           
//         try {
//            Class.forName("com.mysql.cj.jdbc.Driver");
//            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
//            cs = con.prepareCall("call listar_ponente_evento(?)");
//            cs.setInt("_id_evento", id_evento);
//            rs=cs.executeQuery();
//            while(rs.next()){
//                lista.add(rs.getInt("id_persona"));
//            }
//        } catch (Exception e) {
//             System.out.println(e.getMessage());
//        }
            
           
           return lista;
           
    }
    
}