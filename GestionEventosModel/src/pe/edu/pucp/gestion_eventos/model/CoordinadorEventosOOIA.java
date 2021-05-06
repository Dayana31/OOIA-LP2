package pe.edu.pucp.gestion_eventos.model;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.gestion_humana.model.MiembroPUCP;

public class CoordinadorEventosOOIA extends MiembroPUCP{
    private int id_coordinadorEventosOOIA;
    private ArrayList<Evento> eventos;

    public CoordinadorEventosOOIA(int id_coordinadorEventosOOIA, ArrayList<Evento> eventos, String dni, String nombre, int edad, String direccion, String codigoPUCP, Date fecha_inclusion) {
        super(dni, nombre, edad, direccion, codigoPUCP, fecha_inclusion);
        this.id_coordinadorEventosOOIA = id_coordinadorEventosOOIA;
        this.eventos = eventos;
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
        