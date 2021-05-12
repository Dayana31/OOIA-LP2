/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.gestion_tramites_academicos.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_tramites_academicos.model.PreguntaFrecuente;

/**
 *
 * @author LENOVO
 */
public interface PreguntaFrecuenteDAO {
    public ArrayList<PreguntaFrecuente> listar(int id_tramite);
    public int insertar(PreguntaFrecuente pregunta,int id_tramite);
    public int modificar(PreguntaFrecuente pregunta,int id_tramite);
    public int eliminar(PreguntaFrecuente pregunta,int id_tramite);
}
