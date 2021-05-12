package pe.edu.pucp.gestion_atencion.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_atencion.model.CitaOOIA;

/**
 *
 * @author DAYANA
 */
public interface CitaOOIADAO {
    public ArrayList<CitaOOIA> listar();
    public int insertar(CitaOOIA citaOOIA);
    public int modificar(CitaOOIA citaOOIA);
    public int eliminar(int idCitaOOIA);
}
