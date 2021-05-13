package pe.edu.pucp.gestion_eventos.model;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.gestion_humana.model.Persona;
import pe.edu.pucp.interfaces.IConsultable;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author LENOVO
 */
public class Evento implements IConsultable{
    private int id_coordinador;
    private int id_evento;
    private int capacidad;
    private String nombre;
    private Date fechaInicio;
    private Date fechaFin;
    private String lugar;
    private boolean estado;
    private ArrayList <Persona> ponentes ;
    private ArrayList <Persona> organizadores ;

    public Evento() {
        ponentes=new ArrayList<>();
        organizadores=new ArrayList<>();
//        coordinador = new CoordinadorEventosOOIA();
    }

    public Evento(int id_coordinador, int id_evento, int capacidad, String nombre, Date fechaInicio, Date fechaFin, String lugar, boolean estado, ArrayList<Persona> ponentes, ArrayList<Persona> organizadores) {
        this.id_coordinador = id_coordinador;
        this.id_evento = id_evento;
        this.capacidad = capacidad;
        this.nombre = nombre;
        this.fechaInicio = fechaInicio;
        this.fechaFin = fechaFin;
        this.lugar = lugar;
        this.estado = estado;
        this.ponentes = ponentes;
        this.organizadores = organizadores;
    }

    public int getId_coordinador() {
        return id_coordinador;
    }

    public void setId_coordinador(int id_coordinador) {
        this.id_coordinador = id_coordinador;
    }

   


    public int getId_evento() {
        return id_evento;
    }

    public void setId_evento(int id_evento) {
        this.id_evento = id_evento;
    }

    public int getCapacidad() {
        return capacidad;
    }

    public void setCapacidad(int capacidad) {
        this.capacidad = capacidad;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public Date getFechaInicio() {
        return fechaInicio;
    }

    public void setFechaInicio(Date fechaInicio) {
        this.fechaInicio = fechaInicio;
    }

    public Date getFechaFin() {
        return fechaFin;
    }

    public void setFechaFin(Date fechaFin) {
        this.fechaFin = fechaFin;
    }

    public String getLugar() {
        return lugar;
    }

    public void setLugar(String lugar) {
        this.lugar = lugar;
    }

    public boolean isEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }

    public ArrayList<Persona> getPonentes() {
        return ponentes;
    }

    public void setPonentes(ArrayList<Persona> ponentes) {
        this.ponentes = ponentes;
    }

    public ArrayList<Persona> getOrganizadores() {
        return organizadores;
    }

    public void setOrganizadores(ArrayList<Persona> organizadores) {
        this.organizadores = organizadores;
    }
    
    

    
    @Override
    public String consultarDatos() {
        return null;
    }
 
    public void agregarPonente(Persona ponente){
        ponentes.add(ponente);
    }
    public void agregarOrganizador(Persona organizador){
        ponentes.add(organizador);
    }
    
}
