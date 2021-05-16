package pe.edu.pucp.gestion_atencion.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_atencion.model.Compromiso;


/**
 *
 * @author DAYANA
 */
public interface CompromisoDAO {
    public ArrayList<Compromiso> listar(int id_cita);
    public int insertar(Compromiso compromiso);
    public int modificar(Compromiso compromiso);
}
