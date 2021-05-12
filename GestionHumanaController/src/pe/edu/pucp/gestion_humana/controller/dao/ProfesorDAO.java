package pe.edu.pucp.gestion_humana.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_humana.model.Profesor;

/**
 *
 * @author Gerardo
 */
public interface ProfesorDAO {
    public ArrayList<Profesor> listar();
    public int insertar(Profesor alumno);
    public int modificar(Profesor alumno);
    public int eliminar(Profesor alumno);
}
