package pe.edu.pucp.gestion_encuesta.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_encuesta.model.Encuesta;


/**
 *
 * @author DAYANA
 */
public interface EncuestaDAO {
    public ArrayList<Encuesta> listar(int id_asesor);
    public int insertar(Encuesta encuesta);
    public int modificar(Encuesta encuesta);    
}
