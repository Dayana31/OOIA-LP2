package pe.edu.pucp.gestion_humana.model;
import pe.edu.pucp.interfaces.IConsultable;
import java.util.ArrayList;

public abstract class Persona implements IConsultable {
    private int id_persona;
    private String dni;
    private String nombre;
    private int edad;
    private String direccion;
    private String correo;
    

    public Persona() {
    }

  
    
    public Persona(int id_persona, String dni, String nombre, int edad, String direccion, String correo) {
        this.id_persona = id_persona;
        this.dni = dni;
        this.nombre = nombre;
        this.edad = edad;
        this.direccion = direccion;
        this.correo = correo;
    }



    public int getId_persona() {
        return id_persona;
    }

    public void setId_persona(int id_persona) {
        this.id_persona = id_persona;
    }
    
    public String getDni() {
        return dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getCorreo() {
        return correo;
    }

    public void setCorreo(String correo) {
        this.correo = correo;
    }

   

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }
    
    
}
