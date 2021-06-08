package pe.edu.pucp.gestion_atencion.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Time;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_atencion.model.Cita;
import pe.edu.pucp.gestion_atencion.model.Horario;
import pe.edu.pucp.gestion_atencion.model.CodigoAtencion;
import pe.edu.pucp.gestion_atencion.controller.dao.CitaDAO;

/**
 *
 * @author DAYANA
 */
public class CitaMySQL implements CitaDAO{
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Cita> listar(int id_alumno) {
      ArrayList<Cita> citas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITASOOIA(?)}");
            cs.setInt("_id_alumno",id_alumno);
            rs = cs.executeQuery();
            while(rs.next()){
                Cita cita = new Cita();
                ///falta settear el asesor y el alumno
                cita.setId_cita(rs.getInt("id_cita"));
                cita.setFechaRegistro(rs.getDate("fecha_registro"));
                cita.setHorario(new Horario());
                cita.getHorario().setFecha(rs.getDate("fecha_cita"));
                cita.getHorario().setHoraInicio(rs.getTime("hora_inicio"));
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
    public int insertar(Cita cita) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call INSERTAR_CITAOOIA(?,?,?,?,?,?,?)}");
           cs.registerOutParameter("_id_cita",java.sql.Types.INTEGER);
           cs.setDate("_fecha_registro",(Date) cita.getFechaRegistro());
           cs.setInt("_fid_alumno",cita.getAlumno().getId_alumno());
           cs.setInt("_fid_horario",cita.getHorario().getId_horario());
           cs.setInt("_fid_atencion",cita.getCodigo_atencion().getId_codigo_atencion());
           cs.setInt("_fid_asesor",cita.getAsesor().getId_miembro_pucp());
           cs.setString("_motivo", cita.getMotivo());
           cs.setBoolean("_asistio",cita.isAsistio());
           cs.executeUpdate();
           cita.setId_cita(cs.getInt("_id_cita"));
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
    public int modificar(Cita cita) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call MODIFICAR_CITAOOIA(?,?,?,?,?,?,?)}");
           cs.setInt("_id_cita",cita.getId_cita());
           cs.setDate("_fecha_registro",(Date) cita.getFechaRegistro());
           cs.setInt("_fid_alumno",cita.getAlumno().getId_alumno());
           cs.setInt("_fid_horario",cita.getHorario().getId_horario());
           cs.setInt("_fid_atencion",cita.getCodigo_atencion().getId_codigo_atencion());
           cs.setInt("_fid_asesor",cita.getAsesor().getId_miembro_pucp());
           cs.setString("_motivo",cita.getMotivo());
           cs.setBoolean("_asistio",cita.isAsistio());
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
    public int eliminar(int idCita) {
        int resultado=0;
        try{
            //registrar el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //creamos la conexion
            con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
            
            cs = con.prepareCall("{call ELIMINAR_CITAOOIA(?)}");
            cs.setInt("_id_cita",idCita);
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
