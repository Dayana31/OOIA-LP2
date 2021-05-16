/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.gestion_tramites_academicos.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_tramites_academicos.model.Requisito;

/**
 *
 * @author LENOVO
 */
public interface RequisitoDAO {
    public ArrayList<Requisito> listar();
    public int insertar(Requisito requisito);
    public int modificar(Requisito requisito);
    public int eliminar(Requisito requisito);
}
