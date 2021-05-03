package pe.edu.pucp.gestion_humana.model;

public class CoordinadorEventos extends MiembroOOIA{
    private String id_Coordinador;

    public CoordinadorEventos(String dni, String nombre, int edad, String direccion, String telefonoContacto
                            ,String id_Coordinador) {
        super(dni, nombre, edad, direccion, telefonoContacto);
        this.id_Coordinador = id_Coordinador;
    }

    @Override
    public String consultarDatos() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    public String getId_Coordinador() {
        return id_Coordinador;
    }

    public void setId_Coordinador(String id_Coordinador) {
        this.id_Coordinador = id_Coordinador;
    }

    
    
    
    
}


