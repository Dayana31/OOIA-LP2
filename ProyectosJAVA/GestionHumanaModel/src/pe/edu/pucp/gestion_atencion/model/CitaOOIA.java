
package pe.edu.pucp.gestion_atencion.model;
import java.util.Date;
import pe.edu.pucp.gestion_humana.model.Alumno;
import pe.edu.pucp.gestion_humana.model.MiembroPUCP;
/**
 *
 * @author DAYANA
 */
public class CitaOOIA {
    private int id_cita;
    private Date fechaRegistro;
    private Alumno alumno;
    private Horario horario;
    private Motivo motivo;
    private MiembroPUCP asesor;
    private boolean asistio;
    private int estado;

    public CitaOOIA(){};

    public CitaOOIA(int id_cita, Date fechaRegistro, Alumno alumno, Horario horario, Motivo motivo, MiembroPUCP asesor, boolean asistio, int estado) {
        this.id_cita = id_cita;
        this.fechaRegistro = fechaRegistro;
        this.alumno = alumno;
        this.horario = horario;
        this.motivo = motivo;
        this.asesor = asesor;
        this.asistio = asistio;
        this.estado = estado;
    }

    
    
    public int getId_cita() {
        return id_cita;
    }

    public void setId_cita(int id_cita) {
        this.id_cita = id_cita;
    }

    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }
    

    public Horario getHorario() {
        return horario;
    }

    public void setHorario(Horario horario) {
        this.horario = horario;
    }

    public Motivo getMotivo() {
        return motivo;
    }

    public void setMotivo(Motivo motivo) {
        this.motivo = motivo;
    }

    public Alumno getAlumno() {
        return alumno;
    }

    public void setAlumno(Alumno alumno) {
        this.alumno = alumno;
    }

    public MiembroPUCP getAsesor() {
        return asesor;
    }

    public void setAsesor(MiembroPUCP asesor) {
        this.asesor = asesor;
    }

  

    public boolean isAsistio() {
        return asistio;
    }

    public void setAsistio(boolean asistio) {
        this.asistio = asistio;
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }
    
    
}
