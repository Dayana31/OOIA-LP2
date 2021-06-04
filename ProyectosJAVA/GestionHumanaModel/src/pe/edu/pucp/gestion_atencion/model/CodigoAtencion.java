package pe.edu.pucp.gestion_atencion.model;


/**
 *
 * @author DAYANA
 */
public class CodigoAtencion {
    private int id_codigo_atencion;
    private String codigo;
    private String descripcion;

    public CodigoAtencion(){}

    public CodigoAtencion(int id_codigo_atencion, String codigo, String descripcion) {
        this.id_codigo_atencion = id_codigo_atencion;
        this.codigo = codigo;
        this.descripcion = descripcion;
    }

    public int getId_codigo_atencion() {
        return id_codigo_atencion;
    }

    public void setId_codigo_atencion(int id_codigo_atencion) {
        this.id_codigo_atencion = id_codigo_atencion;
    }

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }
    
    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    @Override
    public String toString() {
        return "CodigoAtencion{" + "id_codigo_atencion=" + id_codigo_atencion + ", codigo=" + codigo + ", descripcion=" + descripcion + '}';
    }
    
    
}
