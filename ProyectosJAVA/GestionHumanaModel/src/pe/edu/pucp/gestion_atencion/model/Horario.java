
package pe.edu.pucp.gestion_atencion.model;

import java.sql.Time;
import java.time.LocalTime;
import java.util.Date;
import pe.edu.pucp.gestion_humana.model.MiembroPUCP;

/**
 *
 * @author DAYANA
 */
public class Horario {
    private int id_horario;
    private int dia;
    private Time horaInicio;
    private Time horaFin;
    private int estado;

    public Horario() {
    } 

    public Horario(int id_horario, int dia, Time horaInicio, Time horaFin,int estado) {
        this.id_horario = id_horario;
        this.dia=dia;
        this.horaInicio = horaInicio;
        this.horaFin = horaFin;
        this.estado = estado;
    }
    


    public int getId_horario() {
        return id_horario;
    }

    public void setId_horario(int id_horario) {
        this.id_horario = id_horario;
    }

    public int getDia() {
        return dia;
    }

    public void setDia(int dia) {
        this.dia = dia;
    }


    public Time getHoraInicio() {
        return horaInicio;
    }

    public void setHoraInicio(Time horaInicio) {
        this.horaInicio = horaInicio;
    }

    public Time getHoraFin() {
        return horaFin;
    }

    public void setHoraFin(Time horaFin) {
        this.horaFin = horaFin;
    }

  

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }
    
    
}
