
package pe.edu.pucp.gestion_atencion.model;
import pe.edu.pucp.gestion_humana.model.Persona;
/**
 *
 * @author DAYANA
 */
public class CitaOOIA {
    private int id_cita;
    private Horario horario;
    private Motivo motivo;
    private Persona asesor;

    public CitaOOIA(){};
    
    public CitaOOIA(int id_cita, Horario horario, Motivo motivo, Persona asesor) {
        this.id_cita = id_cita;
        this.horario = horario;
        this.motivo = motivo;
        this.asesor = asesor;
    }

    public int getId_cita() {
        return id_cita;
    }

    public void setId_cita(int id_cita) {
        this.id_cita = id_cita;
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

    public Persona getAsesor() {
        return asesor;
    }

    public void setAsesor(Persona asesor) {
        this.asesor = asesor;
    }
    
    
}
