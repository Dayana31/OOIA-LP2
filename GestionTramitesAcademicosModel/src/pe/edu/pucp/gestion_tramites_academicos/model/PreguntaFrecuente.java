/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.gestion_tramites_academicos.model;

/**
 *
 * @author LENOVO
 */
public class PreguntaFrecuente {
    private int id_PreguntaFrecuente;
    private String pregunta;
    private String respuesta;

    public PreguntaFrecuente(int id_PreguntaFrecuente, String pregunta, String respuesta) {
        this.id_PreguntaFrecuente = id_PreguntaFrecuente;
        this.pregunta = pregunta;
        this.respuesta = respuesta;
    }

    public PreguntaFrecuente() {
    }

    public int getId_PreguntaFrecuente() {
        return id_PreguntaFrecuente;
    }

    public void setId_PreguntaFrecuente(int id_PreguntaFrecuente) {
        this.id_PreguntaFrecuente = id_PreguntaFrecuente;
    }

    public String getPregunta() {
        return pregunta;
    }

    public void setPregunta(String pregunta) {
        this.pregunta = pregunta;
    }

    public String getRespuesta() {
        return respuesta;
    }

    public void setRespuesta(String respuesta) {
        this.respuesta = respuesta;
    }
    
            
    
}
