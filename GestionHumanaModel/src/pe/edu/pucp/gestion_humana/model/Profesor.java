package pe.edu.pucp.gestion_humana.model;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.gestion_academica.model.Curso;
import pe.edu.pucp.gestion_atencion.model.Horario;

public class Profesor extends MiembroPUCP {
    private int id_profesor;
    private String especialidad;
    private String facultad;
    private String categoria;
    private ArrayList<Curso> cursosDicta;
    private ArrayList<Horario> horariosDisponibles;

    public Profesor(int id_persona, String dni, String nombre, int edad, String direccion, 
                    int id_miembro_pucp, String usuario_pucp, Date fecha_inclusion, 
                    int id_profesor, String especialidad, String facultad, String categoria) {
        super(id_persona, dni, nombre, edad, direccion, id_miembro_pucp, usuario_pucp, fecha_inclusion);
        this.id_profesor = id_profesor;
        this.especialidad = especialidad;
        this.facultad = facultad;
        this.categoria = categoria;
    }    

    public int getId_profesor() {
        return id_profesor;
    }

    public void setId_profesor(int id_alumno) {
        this.id_profesor = id_alumno;
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

