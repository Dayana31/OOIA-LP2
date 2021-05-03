package pe.edu.pucp.gestion_tramites_academicos.model;

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
    private String requisitos;

    public Tramite() {
    }

    public Tramite(int id_tramite, TipoTramite tipoTramite, String descripcion, String requisitos) {
        this.id_tramite = id_tramite;
        this.tipoTramite = tipoTramite;
        this.descripcion = descripcion;
        this.requisitos = requisitos;
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

    public String getRequisitos() {
        return requisitos;
    }

    public void setRequisitos(String requisitos) {
        this.requisitos = requisitos;
    }
    
    
}
