/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.gestion_tramites_academicos.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_tramites_academicos.model.TramiteAlumno;
/**
 *
 * @author LENOVO
 */
public interface TramiteAlumnoDao {
     public ArrayList<TramiteAlumno> listar();
    public int insertar(TramiteAlumno tramiteAlumno);
    public int modificar(TramiteAlumno tramiteAlumno);
    public int eliminar(TramiteAlumno tramiteAlumno);
}
