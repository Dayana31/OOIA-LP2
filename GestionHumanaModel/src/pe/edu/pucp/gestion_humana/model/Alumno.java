package pe.edu.pucp.gestion_humana.model;
import pe.edu.pucp.gestion_academica.model.CursoLlevado;
import java.util.ArrayList;
import java.util.Date;

public class Alumno extends MiembroPUCP {
    private int id_alumno;
    private String especialidad;
    private int escala;
    private ArrayList<CursoLlevado> historicoCursos;

    public Alumno(int id_alumno, String especialidad, int escala, String dni, String nombre, int edad, String direccion, String codigoPUCP, Date fecha_inclusion) {
        super(dni, nombre, edad, direccion, codigoPUCP, fecha_inclusion);
        this.id_alumno = id_alumno;
        this.especialidad = especialidad;
        this.escala = escala;
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

    public int getEscala() {
        return escala;
    }

    public void setEscala(int escala) {
        this.escala = escala;
    }

    public ArrayList<CursoLlevado> getHistoricoCursos() {
        return historicoCursos;
    }

    public void setHistoricoCursos(ArrayList<CursoLlevado> historicoCursos) {
        this.historicoCursos = historicoCursos;
    }

    @Override
    public String consultarDatos() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
