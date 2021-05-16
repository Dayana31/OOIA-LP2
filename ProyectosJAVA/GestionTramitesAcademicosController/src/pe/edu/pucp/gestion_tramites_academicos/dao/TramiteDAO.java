/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.gestion_tramites_academicos.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_tramites_academicos.model.Tramite;

/**
 *
 * @author LENOVO
 */
public interface TramiteDAO {
    public ArrayList<Tramite> listar();
    public int insertar(Tramite tramite);
    public int modificar(Tramite tramite);
    public int eliminar(Tramite tramite);
}
