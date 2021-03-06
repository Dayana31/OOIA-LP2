package pe.edu.pucp.ooia.gest_atencion.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.ooia.gest_atencion.model.Cita;
import pe.edu.pucp.ooia.gest_atencion.model.Horario;
import pe.edu.pucp.ooia.gest_atencion.model.CodigoAtencion;
import pe.edu.pucp.ooia.gest_atencion.dao.CitaDAO;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;
import pe.edu.pucp.ooia.gest_humana.model.Profesor;
import pe.edu.pucp.ooia.gest_humana.model.Psicologo;
import pe.edu.pucp.ooia.gest_humana.mysql.AlumnoMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.ProfesorMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.PsicologoMySQL;

/**
 *
 * @author DAYANA
 */
public class CitaMySQL implements CitaDAO{
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Cita> listarPendiente(int id_alumno) {
      ArrayList<Cita> citas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITA_PENDIENTE(?)}");
            cs.setInt("_id_alumno",id_alumno);
            rs = cs.executeQuery();
            while(rs.next()){
                Cita cita = new Cita();
                /*Cita*/
                cita.setId_cita(rs.getInt("id_cita"));
                cita.setAlumno(new Alumno());
                cita.setAlumno(obtenerAlumno(rs.getInt("fid_alumno")));
                cita.setTipo_asesor(rs.getInt("id_tipo_asesor"));
                if(cita.getTipo_asesor() == 0){
                    cita.setAsesor(new Profesor());
                    cita.setAsesor(obtenerProfesor(rs.getInt("fid_asesor")));
                }
                else if(cita.getTipo_asesor() == 1){
                    cita.setAsesor(new Psicologo());
                    cita.setAsesor(obtenerPsicologo(rs.getInt("fid_asesor")));
                }
                cita.setFecha(rs.getDate("fecha"));
                cita.setHorario(new Horario(rs.getInt("id_horario"), rs.getInt("dia"), rs.getTime("hora_inicio"),
                        rs.getTime("hora_fin")));
                cita.setCodigo_atencion(new CodigoAtencion(rs.getInt("id_codigo_atencion"),
                        rs.getString("codigo"), rs.getString("descripcion")));
                cita.setMotivo(rs.getString("motivo"));
                cita.setCompromiso(rs.getString("compromiso"));
                cita.setAsistio(rs.getBoolean("asistio"));
                cita.setEstado(true);
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
    public ArrayList<Cita> listarHistorico(int id_alumno) {
      ArrayList<Cita> citas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITA_HISTORICO(?)}");
            cs.setInt("_id_alumno",id_alumno);
            rs = cs.executeQuery();
            while(rs.next()){
                Cita cita = new Cita();
                /*Cita*/
                cita.setId_cita(rs.getInt("id_cita"));
                cita.setAlumno(new Alumno());
                cita.setAlumno(obtenerAlumno(rs.getInt("fid_alumno")));
                cita.setTipo_asesor(rs.getInt("id_tipo_asesor"));
                if(cita.getTipo_asesor() == 0){
                    cita.setAsesor(new Profesor());
                    cita.setAsesor(obtenerProfesor(rs.getInt("fid_asesor")));
                }
                else if(cita.getTipo_asesor() == 1){
                    cita.setAsesor(new Psicologo());
                    cita.setAsesor(obtenerPsicologo(rs.getInt("fid_asesor")));
                }
                cita.setFecha(rs.getDate("fecha"));
                cita.setHorario(new Horario(rs.getInt("id_horario"), rs.getInt("dia"), rs.getTime("hora_inicio"),
                        rs.getTime("hora_fin")));
                cita.setCodigo_atencion(new CodigoAtencion(rs.getInt("id_codigo_atencion"),
                        rs.getString("codigo"), rs.getString("descripcion")));
                cita.setMotivo(rs.getString("motivo"));
                cita.setCompromiso(rs.getString("compromiso"));
                cita.setAsistio(rs.getBoolean("asistio"));
                cita.setEstado(true);
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
          
           cs = con.prepareCall("{call INSERTAR_CITA(?,?,?,?,?,?,?,?,?,?)}");
           cs.registerOutParameter("_id_cita",java.sql.Types.INTEGER);
           /*Cita*/
           cs.setInt("_fid_alumno",cita.getAlumno().getId_alumno());
           cs.setInt("_tipo_asesor",cita.getTipo_asesor());
           cs.setInt("_fid_asesor",cita.getAsesor().getId_miembro_pucp());
           cs.setInt("_fid_atencion",cita.getCodigo_atencion().getId_codigo_atencion());   
           cs.setInt("_fid_horario",cita.getHorario().getId_horario());
           cs.setDate("_fecha",(Date) cita.getFecha());  
           cs.setString("_motivo", cita.getMotivo());
           cs.setString("_compromiso", cita.getCompromiso());
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
          
           cs = con.prepareCall("{call MODIFICAR_CITA(?,?,?,?,?,?,?,?,?,?)}");
           cs.setInt("_id_cita",cita.getId_cita());
           cs.setInt("_fid_alumno",cita.getAlumno().getId_alumno());
           cs.setInt("_tipo_asesor",cita.getTipo_asesor());
           cs.setInt("_fid_asesor",cita.getAsesor().getId_miembro_pucp());
           cs.setInt("_fid_atencion",cita.getCodigo_atencion().getId_codigo_atencion());   
           cs.setInt("_fid_horario",cita.getHorario().getId_horario());
           cs.setDate("_fecha",(Date) cita.getFecha());  
           cs.setString("_motivo", cita.getMotivo());
           cs.setString("_compromiso", cita.getCompromiso());
           cs.setBoolean("_asistio",cita.isAsistio());
           cs.executeUpdate();
          
           resultado=1;
           cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }

    @Override
    public int eliminar(int id_cita) {
        int resultado=0;
        try{
            //registrar el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //creamos la conexion
            con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
            
            cs = con.prepareCall("{call ELIMINAR_CITA(?)}");
            cs.setInt("_id_cita", id_cita);
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
    
    private Alumno obtenerAlumno(int id_alumno) {
        ArrayList<Alumno> arrayList=new AlumnoMySQL().listar();
        for(Alumno aux:arrayList)
            if(aux.getId_alumno()==id_alumno)
                return aux;
        return null;
    } 
    
    private Profesor obtenerProfesor(int id_profesor) {
        ArrayList<Profesor> arrayList=new ProfesorMySQL().listar();
        for(Profesor aux:arrayList)
            if(aux.getId_profesor()==id_profesor)
                return aux;
        return null;
    } 
    
    private Psicologo obtenerPsicologo(int id_psicologo) {
        ArrayList<Psicologo> arrayList=new PsicologoMySQL().listar();
        for(Psicologo aux:arrayList)
            if(aux.getId_psicologo()==id_psicologo)
                return aux;
        return null;
    } 
    
}
