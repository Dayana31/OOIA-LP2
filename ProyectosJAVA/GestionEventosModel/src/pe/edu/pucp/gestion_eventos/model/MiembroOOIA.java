package pe.edu.pucp.gestion_eventos.model;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.gestion_humana.model.MiembroPUCP;

public class MiembroOOIA extends MiembroPUCP{
    private int id_coordinadorEventosOOIA;
    private ArrayList<Evento> eventos;
    private boolean estado;



    public MiembroOOIA(int id_coordinadorEventosOOIA, ArrayList<Evento> eventos, boolean estado) {
        this.id_coordinadorEventosOOIA = id_coordinadorEventosOOIA;
        this.eventos = eventos;
        this.estado = estado;
    }

  
   

    
    

    public MiembroOOIA() {
        eventos = new ArrayList<>();
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

    public boolean isEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }
    
    
    
    @Override
    public String consultarDatos() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

}
        