package pe.edu.pucp.gestion_humana.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_humana.model.Especialidad;

/**
 *
 * @author Gerardo
 */
public interface EspecialidadDAO {
    public ArrayList<Especialidad> listar();
    public int insertar(Especialidad especialidad);
    public int modificar(Especialidad especialidad);
    public int eliminar(Especialidad especialidad);
}
