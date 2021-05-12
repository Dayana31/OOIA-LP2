
package pe.edu.pucp.gestion_academica.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_academica.controller.dao.CursoDAO;
import pe.edu.pucp.gestion_academica.model.Curso;

/**
 *
 * @author DAYANA
 */
public class CursoMySQL implements CursoDAO {
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Curso> listar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int insertar(Curso curso) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call INSERTAR_CURSO(?,?,?)}");
           cs.registerOutParameter("_id_curso",java.sql.Types.INTEGER);
           cs.setString("_codigo_curso",curso.getCodigoCurso());
           cs.setString("_nombre_curso",curso.getNombreCurso());
           cs.executeUpdate();
           curso.setId_curso(cs.getInt("_id_curso"));
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
    public int modificar(Curso curso) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call MODIFICAR_CURSO(?,?,?)}");
           cs.setInt("_id_curso",curso.getId_curso());
           cs.setString("_codigo_curso",curso.getCodigoCurso());
           cs.setString("_nombre_curso",curso.getNombreCurso());
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
    public int eliminar(int idCurso) {
        int resultado=0;
        try{
            //registrar el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //creamos la conexion
            con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
            
            cs = con.prepareCall("{call ELIMINAR_CURSO(?)}");
            cs.setInt("_id_curso",idCurso);
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
    
}
