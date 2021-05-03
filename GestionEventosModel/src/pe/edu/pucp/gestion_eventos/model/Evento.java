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
    private int id_evento;
    private String nombre;
    private Date fecha;
    private Date duracion;
    private ArrayList <Persona> ponentes ;
    private ArrayList <Persona> organizadores ;

    public Evento() {
        ponentes=new ArrayList<>();
        organizadores=new ArrayList<>();
    }

    public Evento(int id_evento,String nombre, Date fecha) {
        ponentes=new ArrayList<>();
        organizadores=new ArrayList<>();
        this.id_evento=id_evento;
        this.nombre = nombre;
        this.fecha = fecha;
    }

    public String getNombre() {
        return nombre;
    }

    public int getId_evento() {
        return id_evento;
    }

    public void setId_evento(int id_evento) {
        this.id_evento = id_evento;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public Date getDuracion() {
        return duracion;
    }

    public void setDuracion(Date duracion) {
        this.duracion = duracion;
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
