package pe.edu.pucp.gestion_humana.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_humana.model.Invitado;

/**
 *
 * @author Gerardo
 */
public interface InvitadoDAO {
    public ArrayList<Invitado> listar();
    public int insertar(Invitado alumno);
    public int modificar(Invitado alumno);
    public int eliminar(Invitado alumno);
}
