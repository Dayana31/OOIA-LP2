
package pe.edu.pucp.gestion_humana.model;

public abstract class MiembroExterno extends Persona{
    private int id_miembro_externo;
    private int telefono;
    private String ocupacion;


    public MiembroExterno(int id_persona, String dni, String nombre, int edad, String direccion,
                          int id_miembro_externo, int telefono, String ocupacion) {
        super(id_persona, dni, nombre, edad, direccion);
        this.id_miembro_externo = id_miembro_externo;
        this.telefono = telefono;
        this.ocupacion = ocupacion;
    }

    public int getId_miembro_externo() {
        return id_miembro_externo;
    }

    public void setId_miembro_externo(int id_miembro_externo) {
        this.id_miembro_externo = id_miembro_externo;
    }
    
    public int getTelefono() {
        return telefono;
    }

    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }

    public String getOcupacion() {
        return ocupacion;
    }

    public void setOcupacion(String ocupacion) {
        this.ocupacion = ocupacion;
    }
    
    //No es necesario declarar el metodo consultar datos en una clase abstracta
    
}