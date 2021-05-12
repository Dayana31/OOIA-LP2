
package pe.edu.pucp.gestion_academica.model;

/**
 *
 * @author DAYANA
 */
public class Evaluacion {
    private int id_evaluacion;
    private String categoria;
    private String nombre;
    private int nota;

    public Evaluacion(int id_evaluacion, String categoria, String nombre, int nota) {
        this.id_evaluacion = id_evaluacion;
        this.categoria = categoria;
        this.nombre = nombre;
        this.nota = nota;
    }

    public int getId_evaluacion() {
        return id_evaluacion;
    }

    public void setId_evaluacion(int id_evaluacion) {
        this.id_evaluacion = id_evaluacion;
    }

    public String getCategoria() {
        return categoria;
    }

    public void setCategoria(String categoria) {
        this.categoria = categoria;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getNota() {
        return nota;
    }

    public void setNota(int nota) {
        this.nota = nota;
    }
    
    
}
