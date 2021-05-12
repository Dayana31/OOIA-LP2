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
public class Requisito {
    private int id_requisito;
    private String descripcion;
    private double craestMin;
    private double creditosMin;
    private int estadoAlumno;
    private int escalaAlumno;

    public Requisito() {
    }

    public Requisito(int id_requisito, String descripcion, double craestMin, double creditosMin, int estadoAlumno, int escalaAlumno) {
        this.id_requisito = id_requisito;
        this.descripcion = descripcion;
        this.craestMin = craestMin;
        this.creditosMin = creditosMin;
        this.estadoAlumno = estadoAlumno;
        this.escalaAlumno = escalaAlumno;
    }

    public Requisito(String descripcion, double craestMin, double creditosMin, int estadoAlumno, int escalaAlumno) {
        this.descripcion = descripcion;
        this.craestMin = craestMin;
        this.creditosMin = creditosMin;
        this.estadoAlumno = estadoAlumno;
        this.escalaAlumno = escalaAlumno;
    }

    public int getId_requisito() {
        return id_requisito;
    }

    public void setId_requisito(int id_requisito) {
        this.id_requisito = id_requisito;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public double getCraestMin() {
        return craestMin;
    }

    public void setCraestMin(double craestMin) {
        this.craestMin = craestMin;
    }

    public double getCreditosMin() {
        return creditosMin;
    }

    public void setCreditosMin(double creditosMin) {
        this.creditosMin = creditosMin;
    }

    public int getEstadoAlumno() {
        return estadoAlumno;
    }

    public void setEstadoAlumno(int estadoAlumno) {
        this.estadoAlumno = estadoAlumno;
    }

    public int getEscalaAlumno() {
        return escalaAlumno;
    }

    public void setEscalaAlumno(int escalaAlumno) {
        this.escalaAlumno = escalaAlumno;
    }
    
}
