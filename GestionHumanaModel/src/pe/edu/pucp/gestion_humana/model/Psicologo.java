package pe.edu.pucp.gestion_humana.model;
import pe.edu.pucp.gestion_atencion.model.Horario;
import java.util.ArrayList;
import java.util.Date;

public class Psicologo extends MiembroPUCP{
    private int id_psicologo;
    private ArrayList<Horario> horariosDisponibls;

    public Psicologo(int id_psicologo, ArrayList<Horario> horariosDisponibls, String dni, String nombre, int edad, String direccion, String codigoPUCP, Date fecha_inclusion) {
        super(dni, nombre, edad, direccion, codigoPUCP, fecha_inclusion);
        this.id_psicologo = id_psicologo;
        this.horariosDisponibls = horariosDisponibls;
    }

    public int getId_psicologo() {
        return id_psicologo;
    }

    public void setId_psicologo(int id_psicologo) {
        this.id_psicologo = id_psicologo;
    }

    public ArrayList<Horario> getHorariosDisponibls() {
        return horariosDisponibls;
    }

    public void setHorariosDisponibls(ArrayList<Horario> horariosDisponibls) {
        this.horariosDisponibls = horariosDisponibls;
    }
    
    @Override
    public String consultarDatos() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}
