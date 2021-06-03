/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebamysql;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.gestion_academica.model.Curso;
import pe.edu.pucp.gestion_academica.model.CursoLlevado;
import pe.edu.pucp.gestion_humana.controller.dao.AlumnoDAO;
import pe.edu.pucp.gestion_humana.controller.mysql.AlumnoMySQL;
import pe.edu.pucp.gestion_humana.model.Alumno;

/**
 *
 * @author PC
 */
public class PruebaAlumnoMySQL {
    public static void main(String[] args) {
        ArrayList<Alumno> alumnos = new ArrayList<>();
        AlumnoDAO daoAlumno = new AlumnoMySQL();
        Alumno alum = new Alumno();
        
        //Insertar
        //Atributos persona
        alum.setId_persona(32323);
        alum.setDni("433123123");
        alum.setNombre("Juanito Castillo");
        alum.setEdad(45);
        alum.setDireccion("jr.Machu pichu, urb Los Robles");
        ArrayList<String> correos = new ArrayList<>();
        correos.add("asdasdas@pucp.edu.pe");
        correos.add("asdasd@gmail.com");
        alum.setCorreos(correos);
        
        //Atributos miembro pucp
        alum.setId_miembro_pucp(232323);
        alum.setUsuario_pucp("asdasdasd@pucp.edu.pe");
        alum.setFecha_inclusion(new Date());
        
        //Atributos Alumno
        alum.setId_alumno(23);
        alum.setCodigo_pucp("20193212");
        alum.setEspecialidad("Informatica");
        alum.setCraest(70.3);
        alum.setCursos_por_primera(3);
        alum.setCursos_por_segunda(3);
        alum.setCursos_por_tercera(0);
        alum.setCreditos_aprobados(123.4);
        
        //Cursos llevados, hisotrico de cursos
        ArrayList<CursoLlevado> cursoLle = new ArrayList<>();
        Curso curso = new Curso();
        curso.setId_curso(0);
        curso.setCodigoCurso("INF06");
        curso.setNombreCurso("EDPM");
        curso.setEstado(1);
        
        
        CursoLlevado curL = new CursoLlevado();
        curL.setId_curso_llevado(0);
        curL.setAlumno(alum);
        curL.setCurso(curso);
        curL.setCiclo("2020-1");
        curL.setVez(4);
        curL.setNotaFinal(17.0);
        curL.setRetirado(false);
        curL.setFormulaDeCalificacion("EX*2 + EX1*2 + PA*9");
        
        cursoLle.add(curL);
        alum.setHistoricoCursos(cursoLle);
        
        //El historico de citas aun no se inplementa
        alum.setHistoricoCitas(null);
        
//        daoAlumno.insertar(alum);//no lo pobre, falta modificar el mySQL
    }
}
