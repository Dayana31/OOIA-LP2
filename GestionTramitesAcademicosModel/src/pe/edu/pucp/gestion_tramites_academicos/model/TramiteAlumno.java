package pe.edu.pucp.gestion_tramites_academicos.model;

import java.io.File;
import java.util.ArrayList;
import pe.edu.pucp.gestion_humana.model.Alumno;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author LENOVO
 */
public class TramiteAlumno {
    private int id_tramite;
    private Alumno alumno;
    private Tramite tramite;
    private boolean estado;

    

    public TramiteAlumno(Alumno alumno, Tramite tramite) {
        this.alumno = alumno;
        this.tramite = tramite;
    }

    public TramiteAlumno(int id_tramite, Alumno alumno, Tramite tramite, ArrayList<File> archivos, ArrayList<String> requisitos) {
        this.id_tramite = id_tramite;
        this.alumno = alumno;
        this.tramite = tramite;
    
    }

    public int getId_tramite() {
        return id_tramite;
    }

    public void setId_tramite(int id_tramite) {
        this.id_tramite = id_tramite;
    }

    public Alumno getAlumno() {
        return alumno;
    }

    public void setAlumno(Alumno alumno) {
        this.alumno = alumno;
    }

    public Tramite getTramite() {
        return tramite;
    }

    public void setTramite(Tramite tramite) {
        this.tramite = tramite;
    }

    public boolean isEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }
    
    public int resultadoTramite(){
        return 0;
    }
    
}
