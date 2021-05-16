/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.gestion_eventos.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_eventos.model.EventoAlumno;

/**
 *
 * @author PC
 */
public interface EventoAlumnoDAO {
    public ArrayList<EventoAlumno> listar();//devuelve un arreglo de empleados
    public int insertar(EventoAlumno encuesta);
    public int modificar(EventoAlumno encuesta);
    public int eliminar(int id_encuesta);
}
