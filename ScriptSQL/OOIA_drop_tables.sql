/*OOIA_drop_tables.sql*/
/*Gestion Academica*/
drop table if exists evaluacion;
drop table if exists categoria;
drop table if exists curso_llevado;
drop table if exists curso;

/*Gestión Atencion*/
drop table if exists encuesta;
drop table if exists compromiso;
drop table if exists cita;
drop table if exists horario_asesor;
drop table if exists horario;
drop table if exists codigo_atencion;

/*Gestion Tramites*/
drop table if exists archivo;
drop table if exists pregunta_frecuente;
drop table if exists tramite_requisito;
drop table if exists tramite_alumno;
drop table if exists requisito;
drop table if exists tramite;
drop table if exists tipo_tramite;

/*Gestion Eventos*/
drop table if exists evento,
drop table if exists evento_alumno,
drop table if exists evento_ponente,
drop table if existe evento_organizador;

/*Gestion Humana*/
drop table if exists invitado;
drop table if exists miembro_externo;
drop table if exists coordinador;
drop table if exists profesor;
drop table if exists psicologo;
drop table if exists alumno;
drop table if exists especialidad;
drop table if exists miembro_pucp;
drop table if exists persona;