package pe.edu.pucp.ooia.gest_humana.dao;

import java.util.ArrayList;
import pe.edu.pucp.ooia.gest_humana.model.Coordinador;

public interface CoordinadorDAO{
    public ArrayList<Coordinador> listar();
    public int insertar(Coordinador coordinador);
    public int modificar(Coordinador coordinador);
    public int eliminar(int id_coordinador);
    public int inicioSesion(String usuario,String password);
}