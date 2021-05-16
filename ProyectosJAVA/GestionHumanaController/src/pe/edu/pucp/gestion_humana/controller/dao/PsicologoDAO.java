package pe.edu.pucp.gestion_humana.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_humana.model.Psicologo;

/**
 *
 * @author Gerardo
 */
public interface PsicologoDAO {
    public ArrayList<Psicologo> listar();
    public int insertar(Psicologo alumno);
    public int modificar(Psicologo alumno);
    public int eliminar(Psicologo alumno);
}
