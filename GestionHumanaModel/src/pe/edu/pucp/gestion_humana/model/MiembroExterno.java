
package pe.edu.pucp.gestion_humana.model;

public abstract class MiembroExterno extends Persona{
    
    private int telefono;
    private String ocupacion;
    
    public MiembroExterno(String dni, String nombre, int edad, String direccion, int telefono, String ocupacion) {
        super(dni, nombre, edad, direccion);
        this.telefono = telefono;
        this.ocupacion = ocupacion;
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