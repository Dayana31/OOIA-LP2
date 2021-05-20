package pe.edu.pucp.gestion_tramites_academicos.dao;

import java.util.ArrayList;
import pe.edu.pucp.gestion_tramites_academicos.model.*;

/**
 *
 * @author Gerardo
 */
public interface TipoTramiteDAO {
        public ArrayList<TipoTramite> listar();
        public int insertar(TipoTramite tipo);
        public int modificr(TipoTramite tipo);
        
}

