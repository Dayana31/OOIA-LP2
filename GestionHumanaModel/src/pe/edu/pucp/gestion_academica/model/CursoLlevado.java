
package pe.edu.pucp.gestion_academica.model;

/**
 *
 * @author DAYANA
 */
public class CursoLlevado {
    private int id_curso_llevado;
    //private Alumno alumno;
    private Curso curso;
    private String ciclo;
    private int vez;
    private double notaFinal;
    private boolean retirado;
    private String formulaDeCalificacion;
    
    public CursoLlevado() {
    }
    

    public CursoLlevado(int id_curso_llevado, Curso curso, String ciclo, int vez, double notaFinal, boolean retirado, String formulaDeCalificacion) {
        this.id_curso_llevado = id_curso_llevado;
        this.curso = curso;
        this.ciclo = ciclo;
        this.vez = vez;
        this.notaFinal = notaFinal;
        this.retirado = retirado;
        this.formulaDeCalificacion = formulaDeCalificacion;
    }

    public int getId_curso_llevado() {
        return id_curso_llevado;
    }

    public void setId_curso_llevado(int id_curso_llevado) {
        this.id_curso_llevado = id_curso_llevado;
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

    public int getVez() {
        return vez;
    }

    public void setVez(int vez) {
        this.vez = vez;
    }

    public double getNotaFinal() {
        return notaFinal;
    }

    public void setNotaFinal(double notaFinal) {
        this.notaFinal = notaFinal;
    }

    public boolean isRetirado() {
        return retirado;
    }

    public void setRetirado(boolean retirado) {
        this.retirado = retirado;
    }

    public String getFormulaDeCalificacion() {
        return formulaDeCalificacion;
    }

    public void setFormulaDeCalificacion(String formulaDeCalificacion) {
        this.formulaDeCalificacion = formulaDeCalificacion;
    }
    



    
}
