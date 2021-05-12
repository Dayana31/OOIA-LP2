package pe.edu.pucp.gestion_atencion.model;

/**
 *
 * @author DAYANA
 */
public class Compromiso {
    private int id_compromiso;
    private CitaOOIA cita;
    private String descripcion;

    public Compromiso(){}
    
    public Compromiso(CitaOOIA cita, String descripcion) {
        this.cita = cita;
        this.descripcion = descripcion;
    }
    

    public Compromiso(int id_compromiso, CitaOOIA cita, String descripcion) {
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


    public CitaOOIA getCita() {
        return cita;
    }

    public void setCita(CitaOOIA cita) {
        this.cita = cita;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
    
    
}
