package pe.edu.pucp.gestion_humana.model;

import java.util.Date;

public abstract class MiembroPUCP extends Persona{

   private String codigoPUCP;
   private Date fecha_inclusion;

    public MiembroPUCP(String dni, String nombre, int edad, String direccion, String codigoPUCP, Date fecha_inclusion) {
        super(dni, nombre, edad, direccion);
        this.codigoPUCP = codigoPUCP;
        this.fecha_inclusion = fecha_inclusion;
    }

    public String getCodigoPUCP() {
        return codigoPUCP;
    }

    public void setCodigoPUCP(String codigoPUCP) {
        this.codigoPUCP = codigoPUCP;
    }

    public Date getFecha_inclusion() {
        return fecha_inclusion;
    }

    public void setFecha_inclusion(Date fecha_inclusion) {
        this.fecha_inclusion = fecha_inclusion;
    }
}
