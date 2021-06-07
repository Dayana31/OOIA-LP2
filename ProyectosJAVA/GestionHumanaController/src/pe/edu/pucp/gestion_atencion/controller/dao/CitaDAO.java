package pe.edu.pucp.gestion_atencion.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_atencion.model.Cita;

/**
 *
 * @author DAYANA
 */
public interface CitaDAO {
    public ArrayList<Cita> listar(int id_alumno);
    public int insertar(Cita cita);
    public int modificar(Cita cita);
    public int eliminar(int idCita);
}
