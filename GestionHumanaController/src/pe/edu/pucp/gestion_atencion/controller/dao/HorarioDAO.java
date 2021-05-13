package pe.edu.pucp.gestion_atencion.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_atencion.model.Horario;

/**
 *
 * @author DAYANA
 */
public interface HorarioDAO {
    public ArrayList<Horario> listar(int id_asesor);
    public int insertar(Horario horario);
    public int modificar(Horario horario);
    public int eliminar(int idHorario);
}
