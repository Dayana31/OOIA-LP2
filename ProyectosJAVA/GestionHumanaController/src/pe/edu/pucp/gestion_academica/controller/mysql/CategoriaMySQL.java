package pe.edu.pucp.gestion_academica.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.config.DBManager;
import pe.edu.pucp.gestion_academica.controller.dao.CategoriaDAO;
import pe.edu.pucp.gestion_academica.model.Categoria;

/**
 *
 * @author Gerardo
 */
public class CategoriaMySQL implements CategoriaDAO {
    
    Connection con;
    ResultSet rs;
    CallableStatement cs;
    
    @Override
    public ArrayList<Categoria> listar() {
        ArrayList<Categoria> categorias = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_CATEGORIA()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Categoria categoria = new Categoria();
                categoria.setId_categoria(rs.getInt("id_categoria"));
                categoria.setNombre_categoria(rs.getString("nombre_categoría"));
                
                categorias.add(categoria);
            }
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return categorias;
    }

    @Override
    public int insertar(Categoria categoria) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_CATEGORIA(?,?)}");
            cs.registerOutParameter("_id_categoria", java.sql.Types.INTEGER);
            /*Persona*/
            cs.setString("_nombre_categoría", categoria.getNombre_categoria());
            cs.executeUpdate();
            categoria.setId_categoria(cs.getInt("_id_categoria"));
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
    public int modificar(Categoria categoria) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_CATEGORIA(?,?)}");
            cs.setInt("_id_categoria",categoria.getId_categoria());
            /*Persona*/
            cs.setString("_nombre_categoría", categoria.getNombre_categoria());
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

//    @Override
//    public int eliminar(Categoria categoria) {
//        int resultado = 0;
//        try{
//            Class.forName("com.mysql.cj.jdbc.Driver");
//            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
//            cs = con.prepareCall("{call eliminar_categoria(?)}");
//            cs.setInt("_id_categoria", categoria.getId_categoria());
//            cs.executeUpdate();
//            resultado = 1;
//            cs.close();
//        }catch(Exception ex){
//            System.out.println(ex.getMessage());
//        }finally{
//            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
//        }
//        return resultado;
//    }
    
}
