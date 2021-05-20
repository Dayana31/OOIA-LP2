/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.gestion_tramites_academicos.model;

/**
 *
 * @author LENOVO
 */
public class TipoTramite {
        private int id;
        private String nombre;

    public TipoTramite(int id, String descripcion) {
        this.id = id;
        this.nombre = descripcion;
    }

    public TipoTramite() {
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

   
        
}
