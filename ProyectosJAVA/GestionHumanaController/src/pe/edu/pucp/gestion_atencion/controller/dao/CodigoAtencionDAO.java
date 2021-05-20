package pe.edu.pucp.gestion_atencion.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_atencion.model.CodigoAtencion;

/**
 *
 * @author DAYANA
 */
public interface CodigoAtencionDAO {
    public ArrayList<CodigoAtencion> listar();
    public int insertar(CodigoAtencion motivo);
    public int modificar(CodigoAtencion motivo);
}
