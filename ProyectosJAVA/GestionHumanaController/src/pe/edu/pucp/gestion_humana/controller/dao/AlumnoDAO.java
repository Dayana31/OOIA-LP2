package pe.edu.pucp.gestion_humana.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_humana.model.Alumno;

/**
 *
 * @author Gerardo
 */
public interface AlumnoDAO {
    public ArrayList<Alumno> listar();
    public int insertar(Alumno alumno);
    public int modificar(Alumno alumno);
    public int eliminar(Alumno alumno);
}
