package pe.edu.pucp.gestion_atencion.model;


/**
 *
 * @author DAYANA
 */
public class Motivo {
    private int id_motivo;
    private String codigoMotivo;
    private String descripcion;

    public Motivo(){}
    
    public Motivo(int id_motivo, String codigoMotivo, String descripcion) {
        this.id_motivo = id_motivo;
        this.codigoMotivo = codigoMotivo;
        this.descripcion = descripcion;
    }

    public int getId_motivo() {
        return id_motivo;
    }

    public void setId_motivo(int id_motivo) {
        this.id_motivo = id_motivo;
    }

    public String getCodigoMotivo() {
        return codigoMotivo;
    }

    public void setCodigoMotivo(String codigoMotivo) {
        this.codigoMotivo = codigoMotivo;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
    
    
}
