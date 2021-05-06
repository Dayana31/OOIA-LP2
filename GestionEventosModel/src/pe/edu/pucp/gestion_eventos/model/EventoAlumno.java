package pe.edu.pucp.gestion_eventos.model;

import pe.edu.pucp.gestion_humana.model.Alumno;

public class EventoAlumno{
    private Evento evento;
    private Alumno alumno;
    private int id_encuesta;
    private int valoracionPonente;
    private int valoracionEvento;
    private int valoracionUtilidad;
    private boolean asistio;

    public EventoAlumno(Evento evento, Alumno alumno, int id_encuesta, int valoracionPonente, int valoracionEvento, int valoracionUtilidad, boolean asistio) {
        this.evento = evento;
        this.alumno = alumno;
        this.id_encuesta = id_encuesta;
        this.valoracionPonente = valoracionPonente;
        this.valoracionEvento = valoracionEvento;
        this.valoracionUtilidad = valoracionUtilidad;
        this.asistio = asistio;
    }

    public Evento getEvento() {
        return evento;
    }

    public void setEvento(Evento evento) {
        this.evento = evento;
    }

    public Alumno getAlumno() {
        return alumno;
    }

    public void setAlumno(Alumno alumno) {
        this.alumno = alumno;
    }

    public int getId_encuesta() {
        return id_encuesta;
    }

    public void setId_encuesta(int id_encuesta) {
        this.id_encuesta = id_encuesta;
    }

    public int getValoracionPonente() {
        return valoracionPonente;
    }

    public void setValoracionPonente(int valoracionPonente) {
        this.valoracionPonente = valoracionPonente;
    }

    public int getValoracionEvento() {
        return valoracionEvento;
    }

    public void setValoracionEvento(int valoracionEvento) {
        this.valoracionEvento = valoracionEvento;
    }

    public int getValoracionUtilidad() {
        return valoracionUtilidad;
    }

    public void setValoracionUtilidad(int valoracionUtilidad) {
        this.valoracionUtilidad = valoracionUtilidad;
    }

    public boolean isAsistio() {
        return asistio;
    }

    public void setAsistio(boolean asistio) {
        this.asistio = asistio;
    }
    
    
    
    
    
    
}