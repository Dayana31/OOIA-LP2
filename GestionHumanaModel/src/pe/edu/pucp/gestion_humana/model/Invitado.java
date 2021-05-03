package pe.edu.pucp.gestion_humana.model;
import pe.edu.pucp.interfaces.IConsultable;

public class Invitado extends Persona implements IConsultable{
    private int id_invitado;

    public Invitado(String dni, String nombre, int edad, String direccion, int id_invitado) {
        super(dni, nombre, edad, direccion);
        this.id_invitado = id_invitado;
    }
    
    @Override
    public String consultarDatos() {
        /*Se contultan los datos */
        int hi;
        return "Hola";
    }
    
    
    
    
}


        
