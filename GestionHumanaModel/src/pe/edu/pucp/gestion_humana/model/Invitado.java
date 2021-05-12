package pe.edu.pucp.gestion_humana.model;
import pe.edu.pucp.interfaces.IConsultable;

public class Invitado extends Persona implements IConsultable{
    private int id_invitado;

    public Invitado(int id_persona, String dni, String nombre, int edad, String direccion,
                    int id_invitado) {
        super(id_persona, dni, nombre, edad, direccion);
        this.id_invitado = id_invitado;
    }

    public int getId_invitado() {
        return id_invitado;
    }

    public void setId_invitado(int id_invitado) {
        this.id_invitado = id_invitado;
    }
    
    @Override
    public String consultarDatos() {
        /*Se contultan los datos */
        int hi;
        return "Hola";
    }
    
    
    
    
}


        
