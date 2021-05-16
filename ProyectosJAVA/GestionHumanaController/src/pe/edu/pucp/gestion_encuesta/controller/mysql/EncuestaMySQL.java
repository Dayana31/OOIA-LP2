package pe.edu.pucp.gestion_encuesta.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_encuesta.controller.dao.EncuestaDAO;
import pe.edu.pucp.gestion_encuesta.model.Encuesta;
import pe.edu.pucp.gestion_humana.model.Alumno;

/**
 *
 * @author DAYANA
 */
public class EncuestaMySQL implements EncuestaDAO{
    Connection con; //java.sql.Connection
    Statement st; //java.sql.Statement
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Encuesta> listar(int id_asesor) {
        ArrayList<Encuesta> encuestas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_ENCUESTAS_ASESORES(?)}");
            cs.setInt("_id_asesor",id_asesor);
            rs = cs.executeQuery();
            while(rs.next()){
                Encuesta encuesta = new Encuesta();
                encuesta.setId_encuesta(rs.getInt("id_encuesta"));
                encuesta.setPuntaje(rs.getDouble("puntaje"));
                encuesta.setDescripcion(rs.getString("descripcion"));
                encuesta.setAlumno(new Alumno());
                encuesta.getAlumno().setId_alumno(rs.getInt("fid_alumno"));
      
                encuestas.add(encuesta);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return encuestas;
    }

    @Override
    public int insertar(Encuesta encuesta) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_ENCUESTA_ASESOR(?,?,?,?,?)}");
            cs.registerOutParameter("_id_encuesta", java.sql.Types.INTEGER);
            cs.setDouble("_puntaje", encuesta.getPuntaje());
            cs.setString("_descripcion", encuesta.getDescripcion());
            cs.setInt("_fid_alumno", encuesta.getAlumno().getId_alumno());
            cs.setInt("_fid_asesor", encuesta.getAsesor().getId_miembro_pucp());
            cs.executeUpdate();
            encuesta.setId_encuesta(cs.getInt("_id_encuesta"));
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Encuesta encuesta) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_ENCUESTA_ASESOR(?,?,?,?,?)}");
            cs.setInt("_id_encuesta", encuesta.getId_encuesta());
            cs.setDouble("_puntaje", encuesta.getPuntaje());
            cs.setString("_descripcion", encuesta.getDescripcion());
            cs.setInt("_fid_alumno", encuesta.getAlumno().getId_alumno());
            cs.setInt("_fid_asesor", encuesta.getAsesor().getId_miembro_pucp());
            cs.executeUpdate();
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
}
