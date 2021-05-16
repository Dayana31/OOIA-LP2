package pe.edu.pucp.gestion_tramites_academicos.model;

import java.io.File;
import java.util.ArrayList;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author LENOVO
 */
public class Tramite {
    private int id_tramite;
    private TipoTramite tipoTramite;
    private String descripcion;
    private ArrayList<File>archivos;
    private ArrayList<Requisito> requisitos;
    private ArrayList<PreguntaFrecuente>preguntas;
    private boolean estado;
    

    public Tramite() {
        archivos=new ArrayList<>();
        requisitos=new ArrayList<>();
        preguntas=new ArrayList<>();
    }

    public Tramite(int id_tramite, TipoTramite tipoTramite, String descripcion) {
        archivos=new ArrayList<>();
        requisitos=new ArrayList<>();
        preguntas=new ArrayList<>();
        this.id_tramite = id_tramite;
        this.tipoTramite = tipoTramite;
        this.descripcion = descripcion;
        
    }

    public int getId_tramite() {
        return id_tramite;
    }

    public void setId_tramite(int id_tramite) {
        this.id_tramite = id_tramite;
    }

    public TipoTramite getTipoTramite() {
        return tipoTramite;
    }

    public void setTipoTramite(TipoTramite tipoTramite) {
        this.tipoTramite = tipoTramite;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public ArrayList<File> getArchivos() {
        return archivos;
    }

    public void setArchivos(ArrayList<File> archivos) {
        this.archivos = archivos;
    }

    public ArrayList<Requisito> getRequisitos() {
        return requisitos;
    }

    public void setRequisitos(ArrayList<Requisito> requisitos) {
        this.requisitos = requisitos;
    }

    public ArrayList<PreguntaFrecuente> getPreguntas() {
        return preguntas;
    }

    public void setPreguntas(ArrayList<PreguntaFrecuente> preguntas) {
        this.preguntas = preguntas;
    }

    public boolean isEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }

    public void agregarRequisito(Requisito a){
        requisitos.add(a);
    }
    
    public void agregaArchivo(File e){
        archivos.add(e);
    }
    
    public void agregarPreguntaFrecuente(PreguntaFrecuente e){
        preguntas.add(e);
    }
    
}
