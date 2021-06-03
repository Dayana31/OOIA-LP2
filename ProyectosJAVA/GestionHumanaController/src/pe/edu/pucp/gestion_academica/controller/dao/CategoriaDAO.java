package pe.edu.pucp.gestion_academica.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_academica.model.Categoria;

/**
 *
 * @author Gerardo
 */
public interface CategoriaDAO {
    public ArrayList<Categoria> listar();
    public int insertar(Categoria categoria);
    public int modificar(Categoria categoria);
    //public int eliminar(Categoria categoria);
}
