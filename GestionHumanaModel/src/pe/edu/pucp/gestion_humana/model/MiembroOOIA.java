package pe.edu.pucp.gestion_humana.model;

public abstract class MiembroOOIA extends Persona{
    private String telefonoContacto;

    public MiembroOOIA(String dni, String nombre, int edad, String direccion,String telefonoContacto) {
        super(dni, nombre, edad, direccion);
        this.telefonoContacto = telefonoContacto;
    }

    public String getTelefonoContacto() {
        return telefonoContacto;
    }

    public void setTelefonoContacto(String telefonoContacto) {
        this.telefonoContacto = telefonoContacto;
    }
    
    
}