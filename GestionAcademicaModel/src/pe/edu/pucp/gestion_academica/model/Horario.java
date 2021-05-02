
package pe.edu.pucp.gestion_academica.model;

import java.util.Date;

/**
 *
 * @author DAYANA
 */
public class Horario {
    private int id_horario;
    private Date fecha;
    private Date horaInicio;
    private Date horaFin;

    public Horario(int id_horario, Date fecha, Date horaInicio, Date horaFin) {
        this.id_horario = id_horario;
        this.fecha = fecha;
        this.horaInicio = horaInicio;
        this.horaFin = horaFin;
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
    
    
}
