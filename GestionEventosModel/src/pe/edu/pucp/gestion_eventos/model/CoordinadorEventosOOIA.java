package pe.edu.pucp.gestion_eventos.model;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.gestion_humana.model.MiembroPUCP;

public class CoordinadorEventosOOIA extends MiembroPUCP{
    private int id_coordinadorEventosOOIA;
    private ArrayList<Evento> eventos;

    public CoordinadorEventosOOIA(int id_persona, String dni, String nombre, int edad, String direccion, 
                                  int id_miembro_pucp, String usuario_pucp, Date fecha_inclusion, 
                                  int id_coordinadorEventosOOIA) {
        super(id_persona, dni, nombre, edad, direccion, id_miembro_pucp, usuario_pucp, fecha_inclusion);
        this.id_coordinadorEventosOOIA = id_coordinadorEventosOOIA;
    }

    @Override
    public String consultarDatos() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    public int getId_coordinadorEventosOOIA() {
        return id_coordinadorEventosOOIA;
    }

    public void setId_coordinadorEventosOOIA(int id_coordinadorEventosOOIA) {
        this.id_coordinadorEventosOOIA = id_coordinadorEventosOOIA;
    }

    public ArrayList<Evento> getEventos() {
        return eventos;
    }

    public void setEventos(ArrayList<Evento> eventos) {
        this.eventos = eventos;
    }
    
    
}
        