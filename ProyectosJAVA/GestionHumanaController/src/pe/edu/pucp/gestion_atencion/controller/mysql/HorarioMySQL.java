package pe.edu.pucp.gestion_atencion.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_atencion.controller.dao.HorarioDAO;
import pe.edu.pucp.gestion_atencion.model.Horario;


/**
 *
 * @author DAYANA
 */
public class HorarioMySQL implements HorarioDAO{
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    

    @Override
    public ArrayList<Horario> listar(int id_asesor) {
        ArrayList<Horario> horarios = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_HORARIOS(?)}");
            cs.setInt("_id_asesor",id_asesor);
            rs = cs.executeQuery();
            while(rs.next()){
                Horario horario = new Horario();
                horario.setId_horario(rs.getInt("id_horario"));
                horario.setFecha(rs.getDate("fecha"));
                horario.setHoraInicio(rs.getDate("hora_inicio"));
                horario.setHoraFin(rs.getDate("hora_fin"));
                horario.setEstado(1);
                horarios.add(horario);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return horarios;
    }

    @Override
    public int insertar(Horario horario) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call INSERTAR_HORARIO(?,?,?,?,?)}");
           cs.registerOutParameter("_id_horario",java.sql.Types.INTEGER);
           cs.setDate("_fecha", (Date) horario.getFecha());
           cs.setDate("_hora_inicio",(Date) horario.getHoraInicio());
           cs.setDate("_hora_fin", (Date) horario.getHoraFin());
           cs.setInt("_fid_asesor", horario.getAsesor().getId_miembro_pucp());
           cs.executeUpdate();
           horario.setId_horario(cs.getInt("_id_horario"));
           resultado=1;
           cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            //esto siempre se va a ejecutar
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }

    @Override
    public int modificar(Horario horario) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call MODIFICAR_HORARIO(?,?,?,?,?)}");
           cs.setInt("_id_horario",horario.getId_horario());
           cs.setDate("_fecha", (Date) horario.getFecha());
           cs.setDate("_hora_inicio", (Date) horario.getHoraInicio());
           cs.setDate("_hora_fin", (Date) horario.getHoraFin());
           cs.setInt("_fid_asesor", horario.getAsesor().getId_miembro_pucp());
           cs.executeUpdate();
           resultado=1;
           cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            //esto siempre se va a ejecutar
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }

    @Override
    public int eliminar(int idHorario) {
        int resultado=0;
        try{
            //registrar el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //creamos la conexion
            con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
            
            cs = con.prepareCall("{call ELIMINAR_HORARIO(?)}");
            cs.setInt("_id_horario",idHorario);
            cs.executeUpdate();
            resultado=1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            //esto siempre se va a ejecutar
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
}
