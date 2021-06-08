package pe.edu.pucp.gestion_humana.model;

import java.util.Date;

public abstract class MiembroPUCP extends Persona{
   private int id_miembro_pucp;
   private String usuario_pucp;
   private Date fecha_inclusion;
   private byte[] imagenDePerfil;
   
   
    public MiembroPUCP() {
    }

    public byte[] getImagenDePerfil() {
        return imagenDePerfil;
    }

    public void setImagenDePerfil(byte[] imagenDePerfil) {
        this.imagenDePerfil = imagenDePerfil;
    }

    public int getId_miembro_pucp() {
        return id_miembro_pucp;
    }

    public void setId_miembro_pucp(int id_miembro_pucp) {
        this.id_miembro_pucp = id_miembro_pucp;
    }

    public String getUsuario_pucp() {
        return usuario_pucp;
    }

    public void setUsuario_pucp(String usuario_pucp) {
        this.usuario_pucp = usuario_pucp;
    }

    public Date getFecha_inclusion() {
        return fecha_inclusion;
    }

    public void setFecha_inclusion(Date fecha_inclusion) {
        this.fecha_inclusion = fecha_inclusion;
    }
}

