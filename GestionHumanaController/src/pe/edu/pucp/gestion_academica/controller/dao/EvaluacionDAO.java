
package pe.edu.pucp.gestion_academica.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_academica.model.Evaluacion;

/**
 *
 * @author DAYANA
 */
public interface EvaluacionDAO {
    public ArrayList<Evaluacion> listar(int id_curso_llevado);
    public int insertar(Evaluacion evaluacion);
    public int modificar(Evaluacion evaluacion);

}
