
package pe.edu.pucp.gestion_atencion.model;

import java.util.Date;
import pe.edu.pucp.gestion_humana.model.MiembroPUCP;

/**
 *
 * @author DAYANA
 */
public class Horario {
    private int id_horario;
    private Date fecha;
    private Date horaInicio;
    private Date horaFin;
    private MiembroPUCP asesor;
    private int estado;

    public Horario() {
    } 

    public Horario(int id_horario, Date fecha, Date horaInicio, Date horaFin, MiembroPUCP asesor, int estado) {
        this.id_horario = id_horario;
        this.fecha = fecha;
        this.horaInicio = horaInicio;
        this.horaFin = horaFin;
        this.asesor = asesor;
        this.estado = estado;
    }
    


    public int getId_horario() {
        return id_horario;
    }

    public void setId_horario(int id_horario) {
        this.id_horario = id_horario;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public Date getHoraInicio() {
        return horaInicio;
    }

    public void setHoraInicio(Date horaInicio) {
        this.horaInicio = horaInicio;
    }

    public Date getHoraFin() {
        return horaFin;
    }

    public void setHoraFin(Date horaFin) {
        this.horaFin = horaFin;
    }

    public MiembroPUCP getAsesor() {
        return asesor;
    }

    public void setAsesor(MiembroPUCP asesor) {
        this.asesor = asesor;
    }



    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }
    
    
}
