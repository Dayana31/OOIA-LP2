package pe.edu.pucp.gestion_atencion.model;

/**
 *
 * @author DAYANA
 */
public class Compromiso {
    private int id_compromiso;
    private Cita cita;
    private String descripcion;

    public Compromiso(){}
    
    public Compromiso(Cita cita, String descripcion) {
        this.cita = cita;
        this.descripcion = descripcion;
    }
    

    public Compromiso(int id_compromiso, Cita cita, String descripcion) {
        this.id_compromiso = id_compromiso;
        this.cita = cita;
        this.descripcion = descripcion;
    }

    public int getId_compromiso() {
        return id_compromiso;
    }

    public void setId_compromiso(int id_compromiso) {
        this.id_compromiso = id_compromiso;
    }


    public Cita getCita() {
        return cita;
    }

    public void setCita(Cita cita) {
        this.cita = cita;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
    
    
}
