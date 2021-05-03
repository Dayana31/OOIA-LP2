
package pe.edu.pucp.gestion_academica.model;

/**
 *
 * @author DAYANA
 */
public class CursoLlevado {
    private Curso curso;
    private String ciclo;
    private double notaFinal;

    public CursoLlevado(Curso curso, String ciclo, double notaFinal) {
        this.curso = curso;
        this.ciclo = ciclo;
        this.notaFinal = notaFinal;
        
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

    
    
}
