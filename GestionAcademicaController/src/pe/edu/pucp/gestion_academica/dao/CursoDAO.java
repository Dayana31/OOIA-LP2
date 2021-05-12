package pe.edu.pucp.gestion_academica.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_academica.model.Curso;

/**
 *
 * @author DAYANA
 */
public interface CursoDAO {
    public ArrayList<Curso> listar();
    public int insertar(Curso curso);
    public int modificar(Curso curso);
    public int eliminar(int idCurso);
}
