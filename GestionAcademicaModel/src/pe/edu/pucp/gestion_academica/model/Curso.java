
package pe.edu.pucp.gestion_academica.model;

/**
 *
 * @author DAYANA
 */
public class Curso {
    private int id_curso;
    private String codigoCurso;
    private String nombreCurso;

    public Curso() {
    }

    public Curso(int id_curso, String codigoCurso, String nombreCurso) {
        this.id_curso = id_curso;
        this.codigoCurso = codigoCurso;
        this.nombreCurso = nombreCurso;
    }

    public int getId_curso() {
        return id_curso;
    }

    public void setId_curso(int id_curso) {
        this.id_curso = id_curso;
    }

    public String getCodigoCurso() {
        return codigoCurso;
    }

    public void setCodigoCurso(String codigoCurso) {
        this.codigoCurso = codigoCurso;
    }

    public String getNombreCurso() {
        return nombreCurso;
    }

    public void setNombreCurso(String nombreCurso) {
        this.nombreCurso = nombreCurso;
    }
    
    
}
