package pe.edu.pucp.gestion_eventos.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_eventos.model.MiembroOOIA;

public interface CoordinadorEventosDAO{
    public ArrayList<MiembroOOIA> listar();//devuelve un arreglo de empleados
    public int insertar(MiembroOOIA coordinador);
    public int modificar(MiembroOOIA coordinador);
    public int eliminar(int id_coordinador);
}