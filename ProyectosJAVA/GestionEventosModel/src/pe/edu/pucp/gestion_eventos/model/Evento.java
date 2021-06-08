package pe.edu.pucp.gestion_eventos.model;

import java.time.LocalTime;
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
public class Evento{
    private int id_coordinador;
    private int id_evento;
    private int capacidad;
    private String nombre;
    private Date fecha;
    private LocalTime horaInicio;
    private LocalTime horaFin;
    private String lugar;
    private boolean estado;
    private ArrayList <Persona> ponentes ;


    public Evento() {
        ponentes=new ArrayList<>();
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

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public LocalTime getHoraInicio() {
        return horaInicio;
    }

    public void setHoraInicio(LocalTime horaInicio) {
        this.horaInicio = horaInicio;
    }

    public LocalTime getHoraFin() {
        return horaFin;
    }

    public void setHoraFin(LocalTime horaFin) {
        this.horaFin = horaFin;
    }

    
 
    public void agregarPonente(Persona ponente){
        ponentes.add(ponente);
    }
    public void agregarOrganizador(Persona organizador){
        ponentes.add(organizador);
    }
    
}
