package pe.edu.pucp.gestion_humana.model;

/**
 *
 * @author Gerardo
 */
public class Especialidad {
    private int id_especialidad;
    private String nombre_especialiidad;

    public Especialidad() {
    }
    
    
    public Especialidad(int id_especialidad, String nombre_especialiidad) {
        this.id_especialidad = id_especialidad;
        this.nombre_especialiidad = nombre_especialiidad;
    }

    public int getId_especialidad() {
        return id_especialidad;
    }

    public void setId_especialidad(int id_especialidad) {
        this.id_especialidad = id_especialidad;
    }

    public String getNombre_especialiidad() {
        return nombre_especialiidad;
    }

    public void setNombre_especialiidad(String nombre_especialiidad) {
        this.nombre_especialiidad = nombre_especialiidad;
    }
    
}
