package pe.edu.pucp.gestion_opinion.model;
import pe.edu.pucp.gestion_humana.model.Alumno;
import pe.edu.pucp.gestion_humana.model.MiembroPUCP;
/**
 *
 * @author DAYANA
 */
public class Opinion {
    private int id_opinion;
    private Alumno alumno;
    private double puntaje;
    private String descripcion;
    private MiembroPUCP asesor;

    public Opinion(int id_opinion, Alumno alumno, double puntaje, String descripcion, MiembroPUCP asesor) {
        this.id_opinion = id_opinion;
        this.alumno = alumno;
        this.puntaje = puntaje;
        this.descripcion = descripcion;
        this.asesor = asesor;
    }

    public int getId_opinion() {
        return id_opinion;
    }

    public void setId_opinion(int id_opinion) {
        this.id_opinion = id_opinion;
    }

    public Alumno getAlumno() {
        return alumno;
    }

    public void setAlumno(Alumno alumno) {
        this.alumno = alumno;
    }

    public double getPuntaje() {
        return puntaje;
    }

    public void setPuntaje(double puntaje) {
        this.puntaje = puntaje;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public MiembroPUCP getAsesor() {
        return asesor;
    }

    public void setAsesor(MiembroPUCP asesor) {
        this.asesor = asesor;
    }
    
    
}
