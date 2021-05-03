package pe.edu.pucp.gestion_humana.model;

public class SecretariaOOIA extends MiembroOOIA{
    private String id_secretaria;

    public SecretariaOOIA(String dni, String nombre, int edad, String direccion, String telefonoContacto
                ,String id_secretaria) {
        super(dni, nombre, edad, direccion, telefonoContacto);
        this.id_secretaria = id_secretaria;
    }
    
    public String getId_secretaria() {
        return id_secretaria;
    }

    public void setId_secretaria(String id_secretaria) {
        this.id_secretaria = id_secretaria;
    }

    @Override
    public String consultarDatos() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
    
    
}