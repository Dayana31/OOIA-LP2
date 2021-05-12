package pe.edu.pucp.gestion_atencion.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_atencion.controller.dao.CitaOOIADAO;
import pe.edu.pucp.gestion_atencion.model.CitaOOIA;

/**
 *
 * @author DAYANA
 */
public class CitaOOIAMySQL implements CitaOOIADAO{
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<CitaOOIA> listar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
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
           cs.setInt("_fid_motivo",citaOOIA.getMotivo().getId_motivo());
           cs.setInt("_fid_asesor",citaOOIA.getAsesor().getId_miembro_pucp());
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
           cs.setInt("_fid_motivo",citaOOIA.getMotivo().getId_motivo());
           cs.setInt("_fid_asesor",citaOOIA.getAsesor().getId_miembro_pucp());
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
