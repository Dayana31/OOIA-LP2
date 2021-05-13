
package pe.edu.pucp.gestion_academica.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_academica.controller.dao.EvaluacionDAO;
import pe.edu.pucp.gestion_academica.model.Evaluacion;

/**
 *
 * @author DAYANA
 */
public class EvaluacionMySQL implements EvaluacionDAO{
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Evaluacion> listar(int id_curso_llevado) {
        ArrayList<Evaluacion> evaluaciones = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_EVALUACIONES(?)}");
            cs.setInt("_id_evaluacion",id_curso_llevado);
            rs = cs.executeQuery();
            while(rs.next()){
                Evaluacion evaluacion = new Evaluacion();
                evaluacion.setId_evaluacion(rs.getInt("id_evaluacion"));
                evaluacion.setCategoria(rs.getString("categoria"));
                evaluacion.setNombre(rs.getString("nombre"));
                evaluacion.setNota(rs.getInt("nota"));
      
                evaluaciones.add(evaluacion);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return evaluaciones;
    }

    @Override
    public int insertar(Evaluacion evaluacion) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call INSERTAR_EVALUACION(?,?,?,?,?)}");
           cs.registerOutParameter("_id_evaluacion",java.sql.Types.INTEGER);
           cs.setInt("_fid_curso_llevado",evaluacion.getCursoLlevado().getId_curso_llevado());
           cs.setString("_categoria",evaluacion.getCategoria());
           cs.setString("_nombre",evaluacion.getNombre());
           cs.setInt("_nota",evaluacion.getNota());
           cs.executeUpdate();
           evaluacion.setId_evaluacion(cs.getInt("_id_evaluacion"));
           resultado=1;
           cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            //esto siempre se va a ejecutar
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }

    @Override
    public int modificar(Evaluacion evaluacion) {
         int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call MODIFICAR_EVALUACION(?,?,?,?,?)}");
           cs.registerOutParameter("_id_evaluacion",java.sql.Types.INTEGER);
           cs.setInt("_fid_curso_llevado",evaluacion.getCursoLlevado().getId_curso_llevado());
           cs.setString("_categoria",evaluacion.getCategoria());
           cs.setString("_nombre",evaluacion.getNombre());
           cs.setInt("_nota",evaluacion.getNota());
           cs.executeUpdate();
           resultado=1;
           cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            //esto siempre se va a ejecutar
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }

    @Override
    public int eliminar(int idEvaluacion) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
