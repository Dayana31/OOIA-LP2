package pe.edu.pucp.gestion_encuesta.model;
import pe.edu.pucp.gestion_humana.model.Alumno;
import pe.edu.pucp.gestion_humana.model.MiembroPUCP;
/**
 *
 * @author DAYANA
 */
public class Encuesta {
    private int id_encuesta;
    private Alumno alumno;
    private double puntaje;
    private String descripcion;
    private MiembroPUCP asesor;
    
    

    public Encuesta(int id_encuesta, Alumno alumno, double puntaje, String descripcion, MiembroPUCP asesor) {
        this.id_encuesta = id_encuesta;
        this.alumno = alumno;
        this.puntaje = puntaje;
        this.descripcion = descripcion;
        this.asesor = asesor;
    }

    public Encuesta() {
    }

    public int getId_encuesta() {
        return id_encuesta;
    }

    public void setId_encuesta(int id_encuesta) {
        this.id_encuesta = id_encuesta;
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

    @Override
    public String toString() {
        return "Encuesta{" + "id_encuesta=" + id_encuesta + ", id_alumno=" + getAlumno().getId_alumno() + ", puntaje=" + puntaje + ", descripcion=" + descripcion;
    }
    
    
}
