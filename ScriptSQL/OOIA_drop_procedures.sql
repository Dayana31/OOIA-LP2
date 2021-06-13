/*OOIA_drop_procedures.sql*/

/*Gestión Académica*/
--CURSO
drop procedure if exists INSERTAR_CURSO;
drop procedure if exists MODIFICAR_CURSO;
drop procedure if exists ELIMINAR_CURSO;
drop procedure if exists LISTAR_CURSOS;
--CURSO_LLEVADO
drop procedure if exists INSERTAR_CURSOLLEVADO;
drop procedure if exists MODIFICAR_CURSOLLEVADO;
drop procedure if exists LISTAR_CURSOSLLEVADOS;
--CATEGORIA
drop procedure if exists INSERTAR_CATEGORIA;
drop procedure if exists MODIFICAR_CATEGORIA;
drop procedure if exists LISTAR_CATEGORIA;
--EVALUACION
drop procedure if exists INSERTAR_EVALUACION;
drop procedure if exists MODIFICAR_EVALUACION;
drop procedure if exists LISTAR_EVALUCIONES;

/*Gestión Atención*/
--CODIGO_ATENCION
drop procedure if exists INSERTAR_CODIGO_ATENCION;
drop procedure if exists MODIFICAR_CODIGO_ATENCION;
drop procedure if exists LISTAR_CODIGOS_ATENCION;
--HORARIO
drop procedure if exists INSERTAR_HORARIO;
drop procedure if exists MODIFICAR_HORARIO;
drop procedure if exists ELIMINAR_HORARIO;
drop procedure if exists LISTAR_HORARIOS;
--COMPROMISO
drop procedure if exists INSERTAR_COMPROMISO;
drop procedure if exists MODIFICAR_COMPROMISO;
drop procedure if exists LISTAR_COMPROMISOS;
--CITA
drop procedure if exists INSERTAR_CITA;
drop procedure if exists MODIFICAR_CITA;
drop procedure if exists ELIMINAR_CITA;
drop procedure if exists LISTAR_CITAS_HISTORICO;
drop procedure if exists LISTAR_CITAS_PENDIENTES;
--ENCUESTA
drop procedure if exists INSERTAR_ENCUESTA_ASESOR;
drop procedure if exists MODIFICAR_ENCUESTA_ASESOR;
drop procedure if exists LISTAR_ENCUESTAS_ASESORES;

/*Gestión Eventos*/
--EVENTO
drop procedure if exists INSERTAR_EVENTO;
drop procedure if exists MODIFICAR_EVENTO;
drop procedure if exists ELIMINAR_EVENTO;
drop procedure if exists LISTAR_EVENTO;
--ENCUESTA_EVENTO
drop procedure if exists INSERTAR_ENCUESTA_EVENTO;
drop procedure if exists MODIFICAR_ENCUESTA_EVENTO;
drop procedure if exists ELIMINAR_ENCUESTA_EVENTO;
drop procedure if exists LISTAR_ENCUESTA_EVENTO;

/*Gestión Humana*/
--ESPECIALIDAD
drop procedure if exists LISTAR_ESPECIALIDAD;
drop procedure if exists INSERTAR_ESPECIALIDAD;
drop procedure if exists MODIFICAR_ESPECIALIDAD;
--COORDINADOR
drop procedure if exists INSERTAR_COORDINADOR;
drop procedure if exists MODIFICAR_COORDINADOR;
drop procedure if exists ELIMINAR_COORDINADOR;
drop procedure if exists LISTAR_COORDINADOR;
--ALUMNO
drop procedure if exists LISTAR_ALUMNO;
drop procedure if exists INSERTAR_ALUMNO;
drop procedure if exists MODIFICAR_ALUMNO;
drop procedure if exists ELIMINAR_ALUMNO;
--PROFESOR
drop procedure if exists LISTAR_PROFESOR;
drop procedure if exists INSERTAR_PROFESOR;
drop procedure if exists MODIFICAR_PROFESOR;
drop procedure if exists ELIMINAR_PROFESOR;
--PSICOLOGO
drop procedure if exists LISTAR_PSICOLOGO;
drop procedure if exists INSERTAR_PSICOLOGO;
drop procedure if exists MODIFICAR_PSICOLOGO;
drop procedure if exists ELIMINAR_PSICOLOGO;
--INVITADO
drop procedure if exists LISTAR_INVITADO;
drop procedure if exists INSERTAR_INVITADO;
drop procedure if exists MODIFICAR_INVITADO;
drop procedure if exists ELIMINAR_INVITADO;