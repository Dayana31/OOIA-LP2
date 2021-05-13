
package pe.edu.pucp.gestion_academica.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_academica.controller.dao.CursoLlevadoDAO;
import pe.edu.pucp.gestion_academica.model.Curso;
import pe.edu.pucp.gestion_academica.model.CursoLlevado;

/**
 *
 * @author DAYANA
 */
public class CursoLlevadoMySQL implements CursoLlevadoDAO{
    Connection con; //java.sql.Connection
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<CursoLlevado> listar(int id_alumno) {
       ArrayList<CursoLlevado> cursos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_CURSOSLLEVADOS(?)}");
            cs.setInt("_id_alumno",id_alumno);
            rs = cs.executeQuery();
            while(rs.next()){
                CursoLlevado curso = new CursoLlevado();
                curso.setId_curso_llevado(rs.getInt("id_curso_llevado"));
                curso.setCurso(new Curso());
                curso.getCurso().setCodigoCurso(rs.getString("codigo_curso"));
                curso.getCurso().setNombreCurso(rs.getString("nombre_curso"));
                curso.setCiclo(rs.getString("ciclo"));
                curso.setVez(rs.getInt("vez"));
                curso.setNotaFinal(rs.getDouble("nota_final"));
                curso.setRetirado(rs.getBoolean("retirado"));
                curso.setFormulaDeCalificacion(rs.getString("formula_de_calificacion"));
   
                cursos.add(curso);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return cursos;
    }

    @Override
    public int insertar(CursoLlevado cursoLlevado) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call INSERTAR_CURSOLLEVADO(?,?,?,?,?,?,?,?)}");
           cs.registerOutParameter("_id_curso_llevado",java.sql.Types.INTEGER);
           cs.setInt("_fid_alumno",cursoLlevado.getAlumno().getId_alumno());
           cs.setInt("_fid_curso",cursoLlevado.getCurso().getId_curso());
           cs.setString("_ciclo",cursoLlevado.getCiclo());
           cs.setInt("_vez",cursoLlevado.getVez());
           cs.setDouble("_nota_final",cursoLlevado.getNotaFinal());
           cs.setBoolean("_retirado",cursoLlevado.isRetirado());
           cs.setString("_formula_de_calificacion",cursoLlevado.getFormulaDeCalificacion());
           cs.executeUpdate();
           cursoLlevado.setId_curso_llevado(cs.getInt("_id_curso_llevado"));
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
    public int modificar(CursoLlevado cursoLlevado) {
        int resultado=0;
        try{
            //registrar el driver
           Class.forName("com.mysql.cj.jdbc.Driver");
           //creamos la conexion
           con = DriverManager.getConnection(DBManager.url,
                   DBManager.user,DBManager.password);
          
           cs = con.prepareCall("{call MODIFICAR_CURSOLLEVADO(?,?,?,?,?,?,?,?)}");
           cs.setInt("_id_curso_llevado",cursoLlevado.getId_curso_llevado());
           cs.setInt("_fid_alumno",cursoLlevado.getAlumno().getId_alumno());
           cs.setInt("_fid_curso",cursoLlevado.getCurso().getId_curso());
           cs.setString("_ciclo",cursoLlevado.getCiclo());
           cs.setInt("_vez",cursoLlevado.getVez());
           cs.setDouble("_nota_final",cursoLlevado.getNotaFinal());
           cs.setBoolean("_retirado",cursoLlevado.isRetirado());
           cs.setString("_formula_de_calificacion",cursoLlevado.getFormulaDeCalificacion());
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
