package pe.edu.pucp.gestion_humana.model;
import pe.edu.pucp.interfaces.IConsultable;

public class Invitado extends MiembroExterno implements IConsultable{
    private int id_invitado;

    public Invitado() {
    }

    public Invitado(int id_invitado, int id_miembro_externo, int telefono,
            String ocupacion, int id_persona, String dni, String nombre, int edad, String direccion, String correo) {
        super(id_miembro_externo, telefono, ocupacion, id_persona, dni, nombre, edad, direccion, correo);
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

    @Override
    public String toString() {
        return this.getId_persona() + "-"+ this.getNombre()+ "-" + 
                this.getCorreo() + "-" +this.getDireccion() + "-"+ this.getDni() +
                "-" + this.getOcupacion() + "-"+ this.getEdad() + "-" + this.getTelefono();
    }

    
    
    
    
}


        
