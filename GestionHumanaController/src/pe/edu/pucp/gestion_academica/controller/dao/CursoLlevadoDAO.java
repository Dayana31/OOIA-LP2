package pe.edu.pucp.gestion_academica.controller.dao;
import java.util.ArrayList;
import pe.edu.pucp.gestion_academica.model.CursoLlevado;

/**
 *
 * @author DAYANA
 */
public interface CursoLlevadoDAO {
    public ArrayList<CursoLlevado> listar();
    public int insertar(CursoLlevado cursoLlevado);
    public int modificar(CursoLlevado cursoLlevado);
    
}
