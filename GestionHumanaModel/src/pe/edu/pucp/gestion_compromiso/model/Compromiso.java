package pe.edu.pucp.gestion_compromiso.model;
import pe.edu.pucp.gestion_humana.model.Alumno;
/**
 *
 * @author DAYANA
 */
public class Compromiso {
    private int id_opinion;
    private Alumno alumno;
    private String descripcion;

    public Compromiso(int id_opinion, Alumno alumno, String descripcion) {
        this.id_opinion = id_opinion;
        this.alumno = alumno;
        this.descripcion = descripcion;
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

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
    
    
}
