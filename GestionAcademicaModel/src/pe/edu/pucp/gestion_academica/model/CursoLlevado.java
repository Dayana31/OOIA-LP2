
package pe.edu.pucp.gestion_academica.model;
import pe.edu.pucp.gestion_humana.model.Profesor;
/**
 *
 * @author DAYANA
 */
public class CursoLlevado {
    private Curso curso;
    private String ciclo;
    private double notaFinal;
    private Profesor profesor;

    public CursoLlevado(Curso curso, String ciclo, double notaFinal, Profesor profesor) {
        this.curso = curso;
        this.ciclo = ciclo;
        this.notaFinal = notaFinal;
        this.profesor = profesor;
    }

    public Curso getCurso() {
        return curso;
    }

    public void setCurso(Curso curso) {
        this.curso = curso;
    }

    public String getCiclo() {
        return ciclo;
    }

    public void setCiclo(String ciclo) {
        this.ciclo = ciclo;
    }

    public double getNotaFinal() {
        return notaFinal;
    }

    public void setNotaFinal(double notaFinal) {
        this.notaFinal = notaFinal;
    }

    public Profesor getProfesor() {
        return profesor;
    }

    public void setProfesor(Profesor profesor) {
        this.profesor = profesor;
    }
    
    
    
}
