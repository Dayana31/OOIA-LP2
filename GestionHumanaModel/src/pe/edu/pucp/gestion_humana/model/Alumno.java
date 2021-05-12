package pe.edu.pucp.gestion_humana.model;
import pe.edu.pucp.gestion_academica.model.CursoLlevado;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.gestion_atencion.model.CitaOOIA;

public class Alumno extends MiembroPUCP {
    private int id_alumno;
    private String codigo_pucp;
    private String especialidad;
    private double craest;
    private int estado;
    private int cursos_por_primera;
    private int cursos_por_segunda;
    private int cursos_por_tercera;
    private double creditos_aprobados;
    private ArrayList<CursoLlevado> historicoCursos;
    private ArrayList<CitaOOIA> historicoCitas;   

    public Alumno(int id_persona, String dni, String nombre, int edad, String direccion,
                  int id_miembro_pucp, String usuario_pucp, Date fecha_inclusion,
                  int id_alumno, String codigo_pucp, String especialidad, int craest, int estado) {
        super(id_persona, dni, nombre, edad, direccion, id_miembro_pucp, usuario_pucp, fecha_inclusion);
        this.id_alumno = id_alumno;
        this.codigo_pucp = codigo_pucp;
        this.especialidad = especialidad;
        this.craest = craest;
        this.estado = estado;
    }

    public int getId_alumno() {
        return id_alumno;
    }

    public void setId_alumno(int id_alumno) {
        this.id_alumno = id_alumno;
    }

    public String getCodigo_pucp() {
        return codigo_pucp;
    }

    public void setCodigo_pucp(String codigo_pucp) {
        this.codigo_pucp = codigo_pucp;
    }
    
    public String getEspecialidad() {
        return especialidad;
    }

    public void setEspecialidad(String especialidad) {
        this.especialidad = especialidad;
    }
    
    public double getCraest() {
        return craest;
    }

    public void setCraest(double craest) {
        this.craest = craest;
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }

    public int getCursos_por_primera() {
        return cursos_por_primera;
    }

    public void setCursos_por_primera(int cursos_por_primera) {
        this.cursos_por_primera = cursos_por_primera;
    }

    public int getCursos_por_segunda() {
        return cursos_por_segunda;
    }

    public void setCursos_por_segunda(int cursos_por_segunda) {
        this.cursos_por_segunda = cursos_por_segunda;
    }

    public int getCursos_por_tercera() {
        return cursos_por_tercera;
    }

    public void setCursos_por_tercera(int cursos_por_tercera) {
        this.cursos_por_tercera = cursos_por_tercera;
    }

    public double getCreditos_aprobados() {
        return creditos_aprobados;
    }

    public void setCreditos_aprobados(double creditos_aprobados) {
        this.creditos_aprobados = creditos_aprobados;
    }

    public ArrayList<CursoLlevado> getHistoricoCursos() {
        return historicoCursos;
    }

    public void setHistoricoCursos(ArrayList<CursoLlevado> historicoCursos) {
        this.historicoCursos = historicoCursos;
    }

    public ArrayList<CitaOOIA> getHistoricoCitas() {
        return historicoCitas;
    }

    public void setHistoricoCitas(ArrayList<CitaOOIA> historicoCitas) {
        this.historicoCitas = historicoCitas;
    }

    @Override
    public String consultarDatos() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
    public double calcularPonderadoCiclo(){
        double ponderado = 0;
        
        return ponderado;
    }
    
    public int calcularFaltasCitas(){
        int faltas = 0;
        
        return faltas;
    }
    
    public void calcularCursosAprobados(){
        int por_primera = 0;
        int por_segunda = 0;
        int por_tercera = 0;
                
        this.cursos_por_primera = por_primera;
        this.cursos_por_segunda = por_segunda;
        this.cursos_por_tercera = por_tercera;
    }
    
    public double calcularCreditosAprobados(){
        double creditos=0;
        
        this.creditos_aprobados = creditos;
        return creditos;
    }
    
}
