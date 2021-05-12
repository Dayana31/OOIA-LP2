package pe.edu.pucp.gestion_atencion.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_atencion.model.Motivo;

/**
 *
 * @author DAYANA
 */
public interface MotivoDAO {
    public ArrayList<Motivo> listar();
    public int insertar(Motivo motivo);
    public int modificar(Motivo motivo);
}
