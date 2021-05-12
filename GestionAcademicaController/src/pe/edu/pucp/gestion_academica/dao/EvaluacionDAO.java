
package pe.edu.pucp.gestion_academica.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_academica.model.Evaluacion;

/**
 *
 * @author DAYANA
 */
public interface EvaluacionDAO {
    public ArrayList<Evaluacion> listar();
    public int insertar(Evaluacion evaluacion);
    public int modificar(Evaluacion evaluacion);
    public int eliminar(int idEvaluacion);    
}
