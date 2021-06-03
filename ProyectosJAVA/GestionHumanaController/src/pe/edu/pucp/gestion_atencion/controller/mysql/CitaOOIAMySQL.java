package pe.edu.pucp.gestion_atencion.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Time;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_atencion.controller.dao.CitaOOIADAO;
import pe.edu.pucp.gestion_atencion.model.CitaOOIA;
import pe.edu.pucp.gestion_atencion.model.Horario;
import pe.edu.pucp.gestion_atencion.model.CodigoAtencion;

/**
 *
 * @author DAYANA
 */
public class CitaOOIAMySQL implements CitaOOIADAO{
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<CitaOOIA> listar(int id_alumno) {
      ArrayList<CitaOOIA> citas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITASOOIA(?)}");
            cs.setInt("_id_alumno",id_alumno);
            rs = cs.executeQuery();
            while(rs.next()){
                CitaOOIA cita = new CitaOOIA();
                ///falta settear el asesor y el alumno
                cita.setId_cita(rs.getInt("id_cita"));
                cita.setFechaRegistro(rs.getDate("fecha_registro"));
                cita.setHorario(new Horario());
                cita.getHorario().setFecha(rs.getDate("fecha_cita"));
                cita.getHorario().setHoraInicio(rs.getDate("hora_inicio"));
                cita.setCodigo_atencion(new CodigoAtencion());
                cita.getCodigo_atencion().setDescripcion(rs.getString("descripcion"));
                cita.getAsesor().setId_miembro_pucp(rs.getInt("fid_asesor"));
                cita.setMotivo(rs.getString("motivo"));
                cita.setAsistio(rs.getBoolean("asistio"));
                cita.setEstado(1);
                citas.add(cita);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return citas;
    }

    @Override
    public int insertar(CitaOOIA citaOOIA) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call INSERTAR_CITAOOIA(?,?,?,?,?,?,?)}");
           cs.registerOutParameter("_id_cita",java.sql.Types.INTEGER);
           cs.setDate("_fecha_registro",(Date) citaOOIA.getFechaRegistro());
           cs.setInt("_fid_alumno",citaOOIA.getAlumno().getId_alumno());
           cs.setInt("_fid_horario",citaOOIA.getHorario().getId_horario());
           cs.setInt("_fid_atencion",citaOOIA.getCodigo_atencion().getId_codigo_atencion());
           cs.setInt("_fid_asesor",citaOOIA.getAsesor().getId_miembro_pucp());
           cs.setString("_motivo", citaOOIA.getMotivo());
           cs.setBoolean("_asistio",citaOOIA.isAsistio());
           cs.executeUpdate();
           citaOOIA.setId_cita(cs.getInt("_id_cita"));
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
    public int modificar(CitaOOIA citaOOIA) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call MODIFICAR_CITAOOIA(?,?,?,?,?,?,?)}");
           cs.setInt("_id_cita",citaOOIA.getId_cita());
           cs.setDate("_fecha_registro",(Date) citaOOIA.getFechaRegistro());
           cs.setInt("_fid_alumno",citaOOIA.getAlumno().getId_alumno());
           cs.setInt("_fid_horario",citaOOIA.getHorario().getId_horario());
           cs.setInt("_fid_atencion",citaOOIA.getCodigo_atencion().getId_codigo_atencion());
           cs.setInt("_fid_asesor",citaOOIA.getAsesor().getId_miembro_pucp());
           cs.setString("_motivo",citaOOIA.getMotivo());
           cs.setBoolean("_asistio",citaOOIA.isAsistio());
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
    public int eliminar(int idCitaOOIA) {
        int resultado=0;
        try{
            //registrar el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //creamos la conexion
            con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
            
            cs = con.prepareCall("{call ELIMINAR_CITAOOIA(?)}");
            cs.setInt("_id_cita",idCitaOOIA);
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
