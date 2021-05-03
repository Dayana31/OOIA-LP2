package pe.edu.pucp.gestion_humana.model;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.gestion_academica.model.Curso;
import pe.edu.pucp.gestion_academica.model.Horario;

public class Profesor extends MiembroPUCP {
    private int id_alumno;
    private String especialidad;
    private String facultad;
    private String categoria;
    private ArrayList<Curso> cursosDicta;
    private ArrayList<Horario> horariosDisponibles;

    public Profesor(int id_alumno, String especialidad, String facultad, String categoria, String dni, String nombre, int edad, String direccion, String codigoPUCP, Date fecha_inclusion) {
        super(dni, nombre, edad, direccion, codigoPUCP, fecha_inclusion);
        this.id_alumno = id_alumno;
        this.especialidad = especialidad;
        this.facultad = facultad;
        this.categoria = categoria;
    }

    public int getId_alumno() {
        return id_alumno;
    }

    public void setId_alumno(int id_alumno) {
        this.id_alumno = id_alumno;
    }

    public String getEspecialidad() {
        return especialidad;
    }

    public void setEspecialidad(String especialidad) {
        this.especialidad = especialidad;
    }

    public String getFacultad() {
        return facultad;
    }

    public void setFacultad(String facultad) {
        this.facultad = facultad;
    }

    public String getCategoria() {
        return categoria;
    }

    public void setCategoria(String categoria) {
        this.categoria = categoria;
    }

    public ArrayList<Curso> getCursosDicta() {
        return cursosDicta;
    }

    public void setCursosDicta(ArrayList<Curso> cursosDicta) {
        this.cursosDicta = cursosDicta;
    }

    public ArrayList<Horario> getHorariosDisponibles() {
        return horariosDisponibles;
    }

    public void setHorariosDisponibles(ArrayList<Horario> horariosDisponibles) {
        this.horariosDisponibles = horariosDisponibles;
    }

    
    @Override
    public String consultarDatos() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}

