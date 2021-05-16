package pe.edu.pucp.gestion_eventos.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_eventos.model.CoordinadorEventosOOIA;

public interface CoordinadorEventosDAO{
    public ArrayList<CoordinadorEventosOOIA> listar();//devuelve un arreglo de empleados
    public int insertar(CoordinadorEventosOOIA coordinador);
    public int modificar(CoordinadorEventosOOIA coordinador);
    public int eliminar(int id_coordinador);
}