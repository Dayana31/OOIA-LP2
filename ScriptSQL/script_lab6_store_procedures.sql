-- Dayana
-- Eliminar los Procedimientos Almacenados
DROP PROCEDURE IF EXISTS INSERTAR_CODIGO_ATENCION;
DROP PROCEDURE IF EXISTS MODIFICAR_CODIGO_ATENCION;
DROP PROCEDURE IF EXISTS LISTAR_CODIGOS_ATENCION;
DROP PROCEDURE IF EXISTS INSERTAR_CURSO;
DROP PROCEDURE IF EXISTS MODIFICAR_CURSO;
DROP PROCEDURE IF EXISTS ELIMINAR_CURSO;
DROP PROCEDURE IF EXISTS LISTAR_CURSOS;
DROP PROCEDURE IF EXISTS INSERTAR_CURSOLLEVADO;
DROP PROCEDURE IF EXISTS MODIFICAR_CURSOLLEVADO;
DROP PROCEDURE IF EXISTS LISTAR_CURSOSLLEVADOS;
DROP PROCEDURE IF EXISTS INSERTAR_CATEGORIA;
DROP PROCEDURE IF EXISTS MODIFICAR_CATEGORIA;
DROP PROCEDURE IF EXISTS LISTAR_CATEGORIA;
DROP PROCEDURE IF EXISTS INSERTAR_EVALUACION;
DROP PROCEDURE IF EXISTS MODIFICAR_EVALUACION;
DROP PROCEDURE IF EXISTS LISTAR_EVALUCIONES;
DROP PROCEDURE IF EXISTS INSERTAR_HORARIO;
DROP PROCEDURE IF EXISTS MODIFICAR_HORARIO;
DROP PROCEDURE IF EXISTS ELIMINAR_HORARIO;
DROP PROCEDURE IF EXISTS LISTAR_HORARIOS;
DROP PROCEDURE IF EXISTS INSERTAR_COMPROMISO;
DROP PROCEDURE IF EXISTS MODIFICAR_COMPROMISO;
DROP PROCEDURE IF EXISTS LISTAR_COMPROMISOS;
DROP PROCEDURE IF EXISTS INSERTAR_CITAOOIA;
DROP PROCEDURE IF EXISTS MODIFICAR_CITAOOIA;
DROP PROCEDURE IF EXISTS ELIMINAR_CITAOOIA;
DROP PROCEDURE IF EXISTS LISTAR_CITASOOIA;
DROP PROCEDURE IF EXISTS INSERTAR_ENCUESTA_ASESOR;
DROP PROCEDURE IF EXISTS MODIFICAR_ENCUESTA_ASESOR;
DROP PROCEDURE IF EXISTS LISTAR_ENCUESTAS_ASESORES;

drop procedure if exists INSERTAR_COORDINADOR;
drop procedure if exists MODIFICAR_COORDINADOR;
drop procedure if exists ELIMINAR_COORDINADOR;
drop procedure if exists LISTAR_COORDINADOR;

drop procedure if exists INSERTAR_EVENTO;
drop procedure if exists MODIFICAR_EVENTO;
drop procedure if exists ELIMINAR_EVENTO;
drop procedure if exists LISTAR_EVENTO;

drop procedure if exists INSERTAR_ENCUESTA_EVENTO;
drop procedure if exists MODIFICAR_ENCUESTA_EVENTO;
drop procedure if exists ELIMINAR_ENCUESTA_EVENTO;
drop procedure if exists LISTAR_ENCUESTA_EVENTO;

drop procedure if exists INSERTAR_REQUSITO;
drop procedure if exists MODIFICAR_REQUISITO;
drop procedure if exists ELIMINAR_REQUISITO;
drop procedure if exists LISTAR_REQUISITOS;

drop procedure if exists INSERTAR_TIPO_TRAMITE;
drop procedure if exists MODIFICAR_TIPO_TRAMITE;
drop procedure if exists LISTAR_TIPO_TRAMITE;

drop procedure if exists INSERTAR_TRAMITE;
drop procedure if exists MODIFICAR_TRAMITE;
drop procedure if exists ELIMINAR_TRAMITE;
drop procedure if exists LISTAR_TRAMITE;

drop procedure if exists INSERTAR_ARCHIVO;
drop procedure if exists MODIFICAR_ARCHIVO;
drop procedure if exists ELIMINAR_ARCHIVO;
drop procedure if exists LISTAR_ARCHIVO;

drop procedure if exists INSERTAR_PREGUNTA_FRECUENTE;
drop procedure if exists MODIFICAR_PREGUNTA_FRECUENTE;
drop procedure if exists ELIMINAR_PREGUNTA_FRECUENTE;
drop procedure if exists LISTAR_PREGUNTA_FRECUENTE;

drop procedure if exists INSERTAR_TRAMITE_ALUMNO;
drop procedure if exists MODIFICAR_TRAMITE_ALUMNO;
drop procedure if exists ELIMINAR_TRAMITE_ALUMNO;
drop procedure if exists LISTAR_TRAMITE_ALUMNO;

drop procedure if exists INSERTAR_TRAMITE_REQUISITO;
drop procedure if exists MODIFICAR_TRAMITE_REQUISITO;
drop procedure if exists ELIMINAR_TRAMITE_REQUISITO;
drop procedure if exists LISTAR_TRAMITE_REQUISITO;

drop procedure if exists listar_especialidad;
drop procedure if exists insertar_especialidad;
drop procedure if exists modificar_especialidad;

drop procedure if exists listar_alumno;
drop procedure if exists insertar_alumno;
drop procedure if exists modificar_alumno;
drop procedure if exists eliminar_alumno;

drop procedure if exists listar_profesor;
drop procedure if exists insertar_profesor;
drop procedure if exists modificar_profesor;
drop procedure if exists eliminar_profesor;

drop procedure if exists listar_psicologo;
drop procedure if exists insertar_psicologo;
drop procedure if exists modificar_psicologo;
drop procedure if exists eliminar_psicologo;

drop procedure if exists listar_invitado;
drop procedure if exists insertar_invitado;
drop procedure if exists modificar_invitado;
drop procedure if exists eliminar_invitado;


DELIMITER $
CREATE PROCEDURE INSERTAR_CODIGO_ATENCION(
	OUT _id_codigo_atencion INT,
	IN _codigo VARCHAR(100),
    IN _descripcion VARCHAR(300)
)
BEGIN
	INSERT INTO codigo_atencion(codigo,descripcion) VALUES(_codigo,_descripcion);
	SET _id_codigo_atencion = @@last_insert_id;
END$

CREATE PROCEDURE MODIFICAR_CODIGO_ATENCION(
	IN _id_codigo_atencion INT,
	IN _codigo VARCHAR(100),
    IN _descripcion VARCHAR(300)
)
BEGIN
	UPDATE codigo_atencion SET codigo = _codigo, descripcion=_descripcion WHERE id_codigo_atencion = _id_codigo_atencion;
END$

CREATE PROCEDURE LISTAR_CODIGOS_ATENCION()
BEGIN
	SELECT id_codigo_atencion, codigo, descripcion FROM codigo_atencion;
END$

CREATE PROCEDURE INSERTAR_CURSO(
	OUT _id_curso INT,
	IN _codigo_curso VARCHAR(100),
    IN _nombre_curso VARCHAR(300)
)
BEGIN
	INSERT INTO curso(codigo_curso,nombre_curso,estado) VALUES(_codigo_curso,_nombre_curso,1);
	SET _id_curso = @@last_insert_id;
END$

CREATE PROCEDURE MODIFICAR_CURSO(
	IN _id_curso INT,
	IN _codigo_curso VARCHAR(100),
    IN _nombre_curso VARCHAR(300)
)
BEGIN
	UPDATE curso SET codigo_curso = _codigo_curso, nombre_curso=_nombre_curso WHERE id_curso = _id_curso;
END$
CREATE PROCEDURE ELIMINAR_CURSO(
	IN _id_curso INT
)
BEGIN
	UPDATE curso SET estado = 0 WHERE id_curso = _id_curso;
END$
CREATE PROCEDURE LISTAR_CURSOS()
BEGIN
	SELECT id_curso, codigo_curso, nombre_curso FROM curso WHERE estado=1;
END$

CREATE PROCEDURE INSERTAR_CURSOLLEVADO(
	OUT _id_curso_llevado INT,
    IN _fid_alumno INT,
	IN _fid_curso INT,
    IN _ciclo VARCHAR(100),
    IN _vez INT,
    IN _nota_final DECIMAL(2,2),
    IN _retirado BOOLEAN,
    IN _formula_de_calificacion VARCHAR(100)
)
BEGIN
	INSERT INTO curso_llevado(fid_alumno,fid_curso,ciclo,vez,nota_final,retirado,formula_de_calificacion) 
    VALUES(_fid_alumno,_fid_curso,_ciclo,_vez,_nota_final,_retirado,_formula_de_calificacion);
	SET _id_curso_llevado = @@last_insert_id;
END$

CREATE PROCEDURE MODIFICAR_CURSOLLEVADO(
	IN _id_curso_llevado INT,
    IN _fid_alumno INT,
	IN _fid_curso INT,
    IN _ciclo VARCHAR(100),
    IN _vez INT,
    IN _nota_final DECIMAL(2,2),
    IN _retirado BOOLEAN,
    IN _formula_de_calificacion VARCHAR(100)
)
BEGIN
	UPDATE curso_llevado SET  fid_alumno = _fid_alumno, fid_curso=_fid_curso, ciclo = _ciclo,
    vez = _vez, nota_final = _nota_final, retirado = _retirado, formula_de_calificacion = _formula_de_calificacion 
    WHERE id_curso_llevado = _id_curso_llevado;
END$

CREATE PROCEDURE LISTAR_CURSOSLLEVADOS(
	IN _id_alumno INT
)
BEGIN
	SELECT cl.id_curso_llevado, c.codigo_curso, c.nombre_curso, cl.ciclo, cl.vez, cl.nota_final,
    cl.retirado, cl.formula_de_calificacion
    FROM curso_llevado cl inner join curso c on c.id_curso=cl.fid_curso WHERE fid_alumno=_id_alumno;
END$


create procedure LISTAR_CATEGORIA(
)
begin
	select id_categoria,nombre_categoría
	from categoria;
end$

create procedure INSERTAR_CATEGORIA(
	out _id_categoria int,
	in _nombre_categoría varchar(150)
)
begin
	insert into categoria(nombre_categoría) values (_nombre_categoría);
end$

create procedure MODIFICAR_CATEGORIA(
	in _id_categoria int,
	in _nombre_categoría varchar(150)
)
begin
	update categoria set nombre_categoría = _nombre_categoría
    where id_categoria = _id_categoria;
end$

CREATE PROCEDURE INSERTAR_EVALUACION(
	OUT _id_evaluacion INT,
    IN _fid_curso_llevado INT,
    IN _fid_categoria int,
    IN _nombre VARCHAR(100),
    IN _nota INT
)
BEGIN
	INSERT INTO evaluacion(id_curso_llevado,fid_categoria,nombre,nota) 
    VALUES(_fid_curso_llevado,_fid_categoria,_nombre,_nota);
	SET _id_evaluacion = @@last_insert_id;
END$

CREATE PROCEDURE MODIFICAR_EVALUACION(
	IN _id_evaluacion INT,
    IN _fid_curso_llevado INT,
    IN _fid_categoria int,
    IN _nombre VARCHAR(100),
    IN _nota INT
)
BEGIN
	UPDATE evaluacion SET  fid_curso_llevado = _fid_curso_llevado, fid_categoria=_fid_categoria, nombre = _nombre,
    nota = _nota
    WHERE id_evaluacion = _id_evaluacion;
END$

CREATE PROCEDURE LISTAR_EVALUCIONES(
	IN _id_curso_llevado INT
)
BEGIN
	SELECT id_evaluacion, fid_categoria, nombre, nota
    FROM evaluacion WHERE fid_curso_llevado=_id_curso_llevado;
END$

CREATE PROCEDURE INSERTAR_HORARIO(
	OUT _id_horario INT,
    IN _fecha date,
    IN _hora_inicio date,
    IN _hora_fin date,
    IN _fid_asesor int
)
BEGIN
	INSERT INTO horario(fecha,hora_inicio,hora_fin,fid_asesor,estado) 
    VALUES(_fecha,_hora_inicio,_hora_fin,_fid_asesor,1);
	SET _id_horario = @@last_insert_id;
END$

CREATE PROCEDURE MODIFICAR_HORARIO(
	IN _id_horario INT,
    IN _fecha date,
    IN _hora_inicio date,
    IN _hora_fin date,
    IN _fid_asesor int
)
BEGIN
	UPDATE horario SET  fecha = _fecha, hora_inicio=_hora_inicio, hora_fin = _hora_fin,
    fid_asesor = _fid_asesor
    WHERE id_horario = _id_horario;
END$
CREATE PROCEDURE ELIMINAR_HORARIO(
	IN _id_horario INT
)
BEGIN
	UPDATE horario SET estado = 0 WHERE id_horario = _id_horario;
END$
CREATE PROCEDURE LISTAR_HORARIOS(
	IN _id_asesor INT
)
BEGIN
	SELECT id_horario, fecha, hora_inicio, hora_fin
    FROM horario WHERE estado=1 AND _id_asesor=fid_asesor;
END$


CREATE PROCEDURE INSERTAR_COMPROMISO(
	OUT _id_compromiso INT,
	IN _fid_cita INT,
    IN _descripcion VARCHAR(300)
)
BEGIN
	INSERT INTO compromiso(fid_cita,descripcion) VALUES(_fid_cita,_descripcion);
	SET _id_compromiso = @@last_insert_id;
END$

CREATE PROCEDURE MODIFICAR_COMPROMISO(
	IN _id_compromiso INT,
	IN _fid_cita INT,
    IN _descripcion VARCHAR(300)
)
BEGIN
	UPDATE compromiso SET fid_cita = _fid_cita, descripcion=_descripcion WHERE id_compromiso = _id_compromiso;
END$

CREATE PROCEDURE LISTAR_COMPROMISOS(
	IN _id_cita INT
)
BEGIN
	SELECT id_compromiso, descripcion FROM compromiso WHERE fid_cita=_id_cita;
END$


CREATE PROCEDURE INSERTAR_CITAOOIA(
    OUT _id_cita int,
    IN _fecha_registro date,
    IN _fid_alumno int,
    IN _fid_horario int,
    IN _fid_atencion int,
    IN _fid_asesor int,
    IN _motivo varchar(300),
    IN _asistio bool
)
BEGIN
	INSERT INTO cita_ooia(fecha_registro,fid_alumno,fid_horario,fid_atencion,fid_asesor,motivo,asistio,estado) 
    VALUES(_fecha_registro,_fid_alumno,_fid_horario,_fid_atencion,_fid_asesor,_motivo,_asistio,1);
	SET _id_cita = @@last_insert_id;
END$

CREATE PROCEDURE MODIFICAR_CITAOOIA(
    IN _id_cita int,
    IN _fecha_registro date,
    IN _fid_alumno int,
    IN _fid_horario int,
    IN _fid_atencion int,
    IN _fid_asesor int,
    IN _motivo varchar(300),
    IN _asistio bool
)
BEGIN
	UPDATE cita_ooia SET fecha_registro = _fecha_registro, fid_alumno=_fid_alumno, fid_horario=_fid_horario,
    fid_atencion=_fid_atencion, fid_asesor=_fid_asesor, motivo=_motivo, asistio=_asistio WHERE id_cita = _id_cita;
END$
CREATE PROCEDURE ELIMINAR_CITAOOIA(
	IN _id_cita INT
)
BEGIN
	UPDATE cita_ooia SET estado = 0 WHERE id_cita = _id_cita;
END$
CREATE PROCEDURE LISTAR_CITASOOIA(
	IN _id_alumno INT
)
BEGIN
	SELECT c.id_cita,c.fecha_registro,h.fecha as fecha_cita,h.hora_inicio,m.descripcion as atencion,c.fid_asesor,c.motivo,c.asistio 
    FROM cita_ooia c inner join horario h on h.id_horario=c.fid_horario inner join  codigo_atencion m
    on m.id_codigo_atencion=c.fid_atencion
    WHERE fid_alumno=_id_alumno;
END$


CREATE PROCEDURE INSERTAR_ENCUESTA_ASESOR(
	OUT _id_encuesta int,
    IN _puntaje decimal(4,2),
    IN _descripcion varchar(300),
    IN _fid_alumno int,
    IN _fid_asesor int
)
BEGIN
	INSERT INTO encuesta(puntaje,descripcion,fid_alumno,fid_asesor) 
    VALUES(_puntaje,_descripcion,_fid_alumno,_fid_asesor);
	SET _id_encuesta = @@last_insert_id;
END$

CREATE PROCEDURE MODIFICAR_ENCUESTA_ASESOR(
	IN _id_encuesta int,
    IN _puntaje decimal(4,2),
    IN _descripcion varchar(300),
    IN _fid_alumno int,
    IN _fid_asesor int
)
BEGIN
	UPDATE encuesta SET puntaje = _puntaje, descripcion=_descripcion, fid_alumno=_fid_alumno,
    fid_asesor=_fid_asesor WHERE id_encuesta = _id_encuesta;
END$

CREATE PROCEDURE LISTAR_ENCUESTAS_ASESORES(
	IN _id_asesor INT
)
BEGIN
	SELECT id_encuesta,puntaje,descripcion,fid_alumno FROM encuesta
    WHERE fid_asesor=_id_asesor;
END$

-- Alfredo
/*Eliminar Procedimientos almacenados*/



/*Para el coordinador_eventos_ooia*/
delimiter $
create procedure INSERTAR_COORDINADOR(
	out _id_persona int,
    out _id_coordinador int,
    in _nombre varchar(150),
    in _dni varchar(150),
    in _edad int,
    in _direccion varchar(150),
    in _usuario_pucp varchar(150),
    in _fecha_de_inclusion date
)begin
	/*tabla persona*/
	insert into persona(nombre, dni, edad, direccion)
    values (_nombre, _dni, _edad, _direccion);
    set _id_persona = @@last_insert_id;
    /*tabla miembro_pucp*/
    insert into miembro_pucp(usuario_pucp, fecha_de_inclusion)
    values (_usuario_pucp, _fecha_de_inclusion);
    set _id_coordinador = @@last_insert_id;
    /*tabla coordinador, esta no se actualiza para nada*/
    insert into coordinador_eventos_ooia(id_coordinador, estado) 
    values (_id_coordinador,1);
end $

delimiter $
create procedure MODIFICAR_COORDINADOR(
	in _id_persona int,
    in _id_coordinador int,
    in _nombre varchar(150),
    in _dni varchar(150),
    in _edad int,
    in _direccion varchar(150),
    in _usuario_pucp varchar(150),
    in _fecha_de_inclusion date
)begin
	/*tabla persona*/
	update  persona set nombre = _nombre,  dni = _dni,  edad = _edad, 
     direccion = _direccion where id_persona = _id_persona;
    /*tabla miembro_pucp*/
    update miembro_pucp set usuario_pucp = _usuario_pucp,  
    fecha_de_inclusion = _fecha_de_inclusion where id_miembro_pucp = _id_coordinador;
    /*tabla coordinador, esta no se actualizar para nada*/
end $

delimiter $
create procedure ELIMINAR_COORDINADOR(
	in _id_coordinador int
)begin
	update coordinador_eventos_ooia set estado  = 0 where id_coordinador = _id_coordinador;
end $

delimiter $

create procedure LISTAR_COORDINADOR(
)begin
	select p.id_persona , p.nombre, p.dni, p.edad, p.direccion, m.usuario_pucp, 
    m.fecha_de_inclusion, c.nombre as correo 
    from persona p inner join miembro_pucp m on p.id_persona = m.fid_persona
    inner join correo c on c.fid_persona = p.id_persona inner join coordinador_eventos_ooia
    where coordinador_eventos_ooia.estado = 1;
end $

/*Para eventos, faltaria agregar un id_coordinador a la clase evento*/
delimiter $
create procedure INSERTAR_EVENTO(
	in _fid_coordinador int,
    in _id_evento int,
    in _capacidad int,
    in _nombre varchar(150),
    in _fecha_inicio date,
    in _fecha_fin date,
    in _lugar varchar(150)
)begin
	/*tabla evento*/
	insert into evento(fid_coordinador, id_evento, capacidad, nombre, fecha_inicio, fecha_fin,lugar,estado)
    values (_fid_coordinador, _id_evento, _capacidad, _nombre, _fecha_inicio, _fecha_fin,_lugar,1);
end $

delimiter $
create procedure MODIFICAR_EVENTO(
	in _fid_coordinador int,
    in _id_evento int,
    in _capacidad int,
    in _nombre varchar(150),
    in _fecha_inicio date,
    in _fecha_fin date,
    in _lugar varchar(150)
)begin
	/*tabla evento*/
	update evento set fid_coordinador = _fid_coordinador, capacidad = _capacidad, nombre = _nombre, 
    fecha_inicio = _fecha_inicio, fecha_fin = _fecha_fin, lugar = _lugar where id_evento = _id_evento;
end $

delimiter $
create procedure ELIMINAR_EVENTO(
    in _id_evento int
)begin
	/*tabla evento*/
	update evento set estado = 0 where id_evento = _id_evento;
end $

delimiter $
create procedure LISTAR_EVENTO(
)begin
	/*tabla evento*/
	select e.id_evento, e.nombre, e.lugar, e.capacidad, e.fecha_inicio, e.fecha_fin
    from evento e inner join coordinador_eventos_ooia c on e.fid_coordinador = c.id_coordinador where e.estado = 1;
end $

/*Para encuestas, tabla evento_alumno*/
delimiter $
create procedure INSERTAR_ENCUESTA_EVENTO(
	in _id_encuesta int,
    in _fid_alumno int,
    in _fid_evento int,
    in _valoracion_ponentes int,
    in _valoracion_evento int,
    in _valoracion_utilidad int,
    in _asistencia bool,
    in _comentario varchar(200)
    -- estado boolean
)begin
	/*tabla evento*/
	insert into evento_alumno(id_encuesta, fid_alumno, fid_evento, valoracion_ponentes, 
    valoracion_evento, valoracion_utilidad, asistencia, comentario, estado)
    values (_id_encuesta, _id_evento, _fid_alumno, _fid_evento, _valoracion_ponentes, _valoracion_evento,
    _valoracion_utilidad,_asistencia,_comentario,1);
end $


delimiter $
create procedure MODIFICAR_ENCUESTA_EVENTO(
	in _id_encuesta int,
    in _fid_alumno int,
    in _fid_evento int,
    in _valoracion_ponente int,
    in _valoracion_evento int,
    in _valoracion_utilidad int,
    in _asistencia bool,
    in _comentario varchar(200)
)begin
	/*tabla evento*/
	update evento_alumno set fid_alumno = _fid_alumno, fid_evento = _fid_evento, 
    valoracion_ponentes = _valoracion_ponentes,  valoracion_evento = _valoracion_evento,
    valoracion_utilidad = _valoracion_utilidad, asistencia = _asistencia, comentario = _comentario
    where id_encuesta = _id_encuesta;
end $

delimiter $
create procedure ELIMINAR_ENCUESTA_EVENTO(
    in _id_encuesta int
)begin
	/*tabla evento_alumno*/
	update evento_alumno set estado = 0 where id_encuesta = _id_encuesta;
end $


delimiter $
create procedure LISTAR_ENCUESTA_EVENTO(
)begin
	/*tabla evento_alumno*/
	select id_encuesta, fid_alumno, fid_evento, valoracion_ponentes, valoracion_evento,
    valoracion_utilidad, asistencia, comentario from evento_alumno where estado = 1;
end $

-- Alvaro
-- Procedimientos almacenados
-- REQUISITO


DELIMITER $
create procedure INSERTAR_REQUSITO(
out _id_requisito int,
in _descripcion varchar(250),
in _craestMin decimal(10,2),
in _creditosMin decimal(10,2),
in _estadoAlumno int,
in _escala_alumno int
)
begin
insert into requisito(descripcion,craestMin,creditosMin,estadoAlumno,escalaAlumno,estado) values (_descripcion,_craestMin,_creditosMin,_estadoAlumno,_escalaAlumno,true);
set _id_requisito = @@last_insert_id;
end$

 



create procedure MODIFICAR_REQUISITO(
in _id_requisito int,
in _descripcion varchar(250),
in _craestMin decimal(10,2),
in _creditosMin decimal(10,2),
in _estadoAlumno int,
in _escala_alumno int
)
begin
update requisito set descripcion = _descrpcion, craestMin=__craestMin , creditosMin=_creditosMin , estadoAlumno=_estadoAlumno, _escala_alumno= _escala_alumno where id_requisito = _id_requisito and estado=true;
end$

create procedure ELIMINAR_REQUISITO( in _id_requisito int)
begin
update requisito set estado=false where id_requisito=_id_requisito;
end$

create procedure LISTAR_REQUISITOS()
begin
select id_requisito,descripcion,craestMin,creditosMin,estadoAlumno,escalaAlumno from requisito where estado=true;
end$


create procedure LISTAR_TIPO_TRAMITE(
)
begin
	select id_tipo_tramite,nombre_tipo_tramite
	from tipo_tramite;
end$

create procedure INSERTAR_TIPO_TRAMITE(
	out _id_tipo_tramite int,
	in _nombre_tipo_tramite varchar(150)
)
begin
	insert into tipo_tramite(nombre_tipo_tramite) values (_nombre_tipo_tramite);
end$

create procedure MODIFICAR_TIPO_TRAMITE(
	in _id_tipo_tramite int,
	in _nombre_tipo_tramite varchar(150)
)
begin
	update tipo_tramite set nombre_tipo_tramite = _nombre_tipo_tramite
    where id_tipo_tramite = _id_tipo_tramite;
end$

-- TRAMITE
create procedure INSERTAR_TRAMITE(
	out _id_tramite int,
    in _fid_tipo_tramite int,
    in _descripcion varchar(250)
)
begin 
	insert into tramite(fid_tipo_tramite,descripcion,estado) values (_fid_tipo_tramite,_descripcion,true);
    set _id_tramite = @@last_insert_id;
end$

create procedure ELIMINAR_TRAMITE(_id_tramite int)
begin 
update tramite set estado=false where _id_tramite = id_tramite;
end$

create procedure MODIFICAR_TRAMITE(
	in _id_tramite int,
	in _fid_tipo_tramite int,
    in _descripcion varchar(250)
    )
begin 
update tramite set fid_tipo_tramite=_fid_tipo_tramite, descripcion=_descripcion where id_tramite=_id_tramite and estado=true;
end$

create procedure LISTAR_TRAMITE()
begin 
select t.id_tramite,t.fid_tipo_tramite,t.descripcion
from tramite t
where t.estado=true;
end$

-- Archivo
## id_archivo int auto_increment,
## fid_tramite int,
##    nombre varchar(250),
##   estado boolean,

create procedure INSERTAR_ARCHIVO(
	out _id_archivo int,
	in _fid_tramite int,
	in _nombre varchar(250)
)
	begin
	insert into archivo(fid_tramite,nombre,estado) values (_fid_tramite,_nombre,true);
	set _id_archivo=@@last_insert_id;
end$

create procedure MODIFICAR_ARCHIVO(
	in _id_archivo int,
	in _fid_tramite int,
	in _nombre varchar(250)
)	
begin 
	update archivo set fid_tramite=_fid_tramite, nombre=_nombre where id_archivo=_id_archivo and estado=true;
end$

create procedure ELIMINAR_ARCHIVO(
in _id_archivo int
)
begin
	update archivo set estado=false where id_archivo=_id_archivo;
end$

create procedure LISTAR_ARCHIVO()
begin 
select a.id_archivo,a.fid_tramite,a.nombre
from archivo a
where a.estado=true;
end$

-- pregunta frecuente

create procedure INSERTAR_PREGUNTA_FRECUENTE(
	out _id_pregunta_frecuente int,
    in _fid_tramite int,
    in _pregunta varchar(250),
    in _respuesta varchar(250)
)
begin 
insert into pregunta_frecuente(fid_tramite,respuesta,pregunta,estado) values (_fid_tramite,_pregunta,_respuesta,true);
set _id_pregunta_frecuente=	@@last_insert_id;
end$

create procedure MODIFICAR_PREGUNTA_FRECUENTE(
	in _id_pregunta_frecuente int,
    in _fid_tramite int,
    in _pregunta varchar(250),
    in _respuesta varchar(250)
)
begin 
update pregunta_frecuente set  pregunta=_pregunta , respuesta=_respuesta where id_pregunta_frecuente = _id_pregunta_precuente and fid_tramite=_fid_tramite  and estado = true;
end$

create procedure ELIMINAR_PREGUNTA_FRECUENTE(in _id_pregunta_frecuente int, in _fid_tramite int)
begin
	update pregunta_frecuente set estado=false where id_pregunta_frecuente = _id_pregunta_frecuente and fid_tramite=_fid_tramite ;
end$
-- mal
create procedure LISTAR_PREGUNTA_FRECUENTE(in _fid_tramite int)
begin
select pf.id_pregunta_frecuente, pf.fid_tramite, pf.pregunta, pf.respuesta
from pregunta_frecuente as pf
where pf.estado = true AND pf.fid_tramite = _fid_tramite;
end$

/* 
Tramite alumno

id_tramite_alumno int auto_increment,
    fid_alumno int,
    fid_tramite int,
    estado boolean,
	
*/

create procedure INSERTAR_TRAMITE_ALUMNO(
	out _id_tramite_alumno int,
    in _fid_alumno int,
    in _fid_tramite int
)
begin
	insert into tramite_alumno(fid_alumno,fid_tramite,estado) values (_fid_alumno,_fid_tramite,true);
	set _id_tramite_alumno=@@last_insert_id;
end$
-- no se deberia poder modificar, solo cancelar y crear una nueva
create procedure MODIFICAR_TRAMITE_ALUMNO(
	in _id_tramite_alumno int,
    in _fid_alumno int,
    in _fid_tramite int
)
begin 
	update tramite_alumno set fid_alumno=_fid_alumno, fid_tramite=_fid_tramite where id_tramite_alumno=_id_tramite_alumno and estado = true;
end$

create procedure ELIMINAR_TRAMITE_ALUMNO(in _id_tramite_alumno int)
begin 
	update tramite_alumno set estado=false where id_tramite_alumno=_id_tramite_alumno;
end$

create procedure LISTAR_TRAMITE_ALUMNO()
begin 
SELECT ta.id_tramite_alumno,ta.fid_alumno,ta.fid_tramite,ta.estado
FROM tramite_alumno as ta
WHERE estado=true;
end$

/*
TRAMITE REQUISITO
fid_tramite int,
    fid_requisito int,
    estado boolean,
*/
create procedure INSERTAR_TRAMITE_REQUISITO(
    in _fid_tramite int,
    in _fid_requisito int
)
begin
	insert into tramite_requisito(fid_tramite,fid_requisito,estado) values (_fid_tramite,_fid_requisito,true);
end$

/* Para esta tabla no va a existir la opción de modificar, ya que es solo una tabla para relacionar otras dos que tienen relacion muchos a muchos*/

create procedure ELIMINAR_TRAMITE_REQUISITO(in _id_tramite int,in _id_requisito int)
begin 
	update tramite_requisito set estado=false where id_tramite=_id_tramite and id_requisito=_id_requisito;
end$

DELIMITER $
create procedure LISTAR_TRAMITE_REQUISITO(in _id_tramite int)
begin 
select tr.fid_tramite,tr.fid_requisito
from tramite_requisito tr
inner join tramite t
where tr.estado=true and t.id_tramite=tr.fid_tramite;
end$ 

delimiter $

create procedure listar_especialidad(
)
begin
	select id_especialidad,nombre
	from especialidad;
end$

create procedure insertar_especialidad(
	out _id_especialidad int,
	in _nombre varchar(150)
)
begin
	insert into especialidad(nombre) values (_nombre);
end$

create procedure modificar_especialidad(
	in _id_especialidad int,
	in _nombre varchar(150)
)
begin
	update especialidad set nombre = _nombre
    where id_especialidad = _id_especialidad;
end$

/*Procedures de clase Alumno*/

create procedure insertar_alumno(
	out _id_alumno int,
    in _nombre varchar(150),
    in _dni varchar(150),
    in _edad int,
    in _direccion varchar(150),
    in _usuario_pucp varchar(150),
    in _fecha_de_inclusion date,
	in _codigo_pucp varchar(150),
    in _fid_especialidad int,
    in _craest decimal(4,2)
)
begin
	declare _id_persona int; 
    declare _id_miembro_pucp int;
	insert into persona(nombre, dni, edad, direccion) 
    values (_nombre, _dni, _edad, _direccion);
	set _id_persona = @@last_insert_id;
    insert into miembro_pucp(fid_persona, usuario_pucp, fecha_de_inclusion)
    values (_id_persona, _usuario_pucp, _fecha_de_inclusion);
    set _id_miembro_pucp = @@last_insert_id;
    insert into alumno(id_alumno, codigo_pucp, fid_especialidad, craest, estado)
    values (_id_miembro_pucp, _codigo_pucp, _fid_especialidad, _craest, 1);
end$

delimiter $
create procedure modificar_alumno(
	in _id_persona int,
	in _id_alumno int,
    in _nombre varchar(150),
    in _dni varchar(150),
    in _edad int,
    in _direccion varchar(150),
    in _usuario_pucp varchar(150),
    in _fecha_de_inclusion date,
	in _codigo_pucp varchar(150),
    in _fid_especialidad int,
    in _craest decimal(4,2)
)
begin
	update persona set nombre = _nombre,  dni = _dni,  edad = _edad, direccion = _direccion 
    where id_persona = _id_persona;
     
	update miembro_pucp set usuario_pucp = _usuario_pucp, fecha_de_inclusion = _fecha_de_inclusion
    where fid_persona = _id_persona;
    
    update alumno set codigo_pucp = _codigo_pucp, fid_especialidad = _fid_especialidad, craest = _craest
    where id_alumno = _id_alumno;
end$

delimiter $
create procedure eliminar_alumno(
	in _id_alumno int
)
begin
	update alumno set estado  = 0 where id_alumno = _id_alumno;
end$

delimiter $
create procedure listar_alumno(
)begin
	select p.id_persona, p.nombre, p.dni, p.edad, p.direccion, 
		   m.usuario_pucp, m.fecha_de_inclusion, c.nombre as correo,
           a.codigo_pucp, a.fid_especialidad, a.craest
	from persona p inner join miembro_pucp m on p.id_persona = m.fid_persona
				   inner join correo c on c.fid_persona = p.id_persona
                   inner join alumno a on a.id_alumno = m.id_miembro_pucp
	where a.estado = 1;
end$

/*Procedures de clase Profesor*/
delimiter $
create procedure insertar_profesor(
	out _id_profesor int,
    in _nombre varchar(150),
    in _dni varchar(150),
    in _edad int,
    in _direccion varchar(150),
    in _usuario_pucp varchar(150),
    in _fecha_de_inclusion date,
	in _especialidad varchar(150),
    in _facultad varchar(150),
    in _categoria varchar(150)
)
begin
	declare _id_persona int;
    declare _id_miembro_pucp int;
	insert into persona(nombre, dni, edad, direccion) 
    values (_nombre, _dni, _edad, _direccion);
	set _id_persona = @@last_insert_id;
    insert into miembro_pucp(fid_persona, usuario_pucp, fecha_de_inclusion)
    values (_id_persona, _usuario_pucp, _fecha_de_inclusion);
    set _id_miembro_pucp = @@last_insert_id;
    insert into profesor(fid_miembro_pucp, especialidad, facultad, categoria, estado)
    values (_id_miembro_pucp, _especialidad, _facultad, _categoria, 1);
end$

delimiter $
create procedure modificar_profesor(
	in _id_persona int,
	in _id_profesor int,
    in _nombre varchar(150),
    in _dni varchar(150),
    in _edad int,
    in _direccion varchar(150),
    in _usuario_pucp varchar(150),
    in _fecha_de_inclusion date,
    in _especialidad varchar(150),
    in _facultad varchar(150),
    in _categoria varchar(150)
)
begin
	update persona set nombre = _nombre,  dni = _dni,  edad = _edad, direccion = _direccion 
    where id_persona = _id_persona;
     
	update miembro_pucp set usuario_pucp = _usuario_pucp, fecha_de_inclusion = _fecha_de_inclusion
    where fid_persona = _id_persona;
    
    update alumno set especialidad = _especialidad, facultad = _facultad, categoria = _categoria
    where id_profesor = _id_profesor;
end$

delimiter $
create procedure eliminar_profesor(
	in _id_profesor int
)
begin
	update profesor set estado  = 0 where id_profesor = _id_profesor;
end$

delimiter $
create procedure listar_profesor(
)begin
	select p.id_persona, p.nombre, p.dni, p.edad, p.direccion, 
		   m.usuario_pucp, m.fecha_de_inclusion, c.nombre as correo,
           pr.especialidad, pr.facultad, pr.categoria
	from persona p inner join miembro_pucp m on p.id_persona = m.fid_persona
				   inner join correo c on c.fid_persona = p.id_persona
                   inner join profesor pr on pr.fid_miembro_pucp = m.id_miembro_pucp
	where pr.estado = 1;
end$

/*Procedures de la clase Psicologo*/
delimiter $
create procedure insertar_psicologo(
	out _id_profesor int,
    in _nombre varchar(150),
    in _dni varchar(150),
    in _edad int,
    in _direccion varchar(150),
    in _usuario_pucp varchar(150),
    in _fecha_de_inclusion date
)
begin
	declare _id_persona int;
    declare _id_miembro_pucp int;
	insert into persona(nombre, dni, edad, direccion) 
    values (_nombre, _dni, _edad, _direccion);
	set _id_persona = @@last_insert_id;
    insert into miembro_pucp(fid_persona, usuario_pucp, fecha_de_inclusion)
    values (_id_persona, _usuario_pucp, _fecha_de_inclusion);
    set _id_miembro_pucp = @@last_insert_id;
    insert into psicologo(fid_miembro_pucp, estado)
    values (_id_miembro_pucp, 1);
end$

delimiter $
create procedure modificar_psicologo(
	in _id_persona int,
	in _id_psicologo int,
    in _nombre varchar(150),
    in _dni varchar(150),
    in _edad int,
    in _direccion varchar(150),
    in _usuario_pucp varchar(150),
    in _fecha_de_inclusion date
)
begin
	update persona set nombre = _nombre,  dni = _dni,  edad = _edad, direccion = _direccion 
    where id_persona = _id_persona;
     
	update miembro_pucp set usuario_pucp = _usuario_pucp, fecha_de_inclusion = _fecha_de_inclusion
    where fid_persona = _id_persona;
end$

delimiter $
create procedure eliminar_psicologo(
	in _id_psicologo int
)
begin
	update psicologo set estado  = 0 where id_psicologo = _id_psicologo;
end$

delimiter $
create procedure listar_psicologo(
)begin
	select p.id_persona, p.nombre, p.dni, p.edad, p.direccion, 
		   m.usuario_pucp, m.fecha_de_inclusion, c.nombre as correo
	from persona p inner join miembro_pucp m on p.id_persona = m.fid_persona
				   inner join correo c on c.fid_persona = p.id_persona
                   inner join psicologo ps on ps.fid_miembro_pucp = m.id_miembro_pucp
	where ps.estado = 1;
end$

/*Procedures de la clase Invitado*/
delimiter $
create procedure insertar_invitado(
	out _id_invitado int,
    in _nombre varchar(150),
    in _dni varchar(150),
    in _edad int,
    in _direccion varchar(150),
    in _telefono int,
	in _ocupacion varchar(150)
)
begin
	declare _id_persona int;
    declare _id_miembro_externo int;
	insert into persona(nombre, dni, edad, direccion) 
    values (_nombre, _dni, _edad, _direccion);
	set _id_persona = @@last_insert_id;
    insert into miembro_externo(fid_persona, telefono, ocupacion)
    values (_id_persona, _telefono, _ocupacion);
    set _id_miembro_externo= @@last_insert_id;
    insert into invitado(fid_miembro_externo, estado)
    values (_id_miembro_externo, 1);
end$

delimiter $
create procedure modificar_invitado(
	in _id_persona int,
	in _id_invitado int,
    in _nombre varchar(150),
    in _dni varchar(150),
    in _edad int,
    in _direccion varchar(150),
    in _telefono int,
    in _ocupacion varchar(150)
)
begin
	update persona set nombre = _nombre,  dni = _dni,  edad = _edad, direccion = _direccion 
    where id_persona = _id_persona;
     
	update miembro_externo set telefono = _telefono, ocupacion = _ocupacion
    where fid_persona = _id_persona;
end$

delimiter $
create procedure eliminar_invitado(
	in _id_invitado int
)
begin
	update invitado set estado  = 0 where id_invitado = _id_invitado;
end$

delimiter $
create procedure listar_invitado(
)begin
	select p.id_persona, p.nombre, p.dni, p.edad, p.direccion, 
		   m.telefono, m.ocupacion, c.nombre as correo
	from persona p inner join miembro_externo m on p.id_persona = m.fid_persona
				   inner join correo c on c.fid_persona = p.id_persona
                   inner join invitado i on i.fid_miembro_externo = m.id_miembro_externo
	where i.estado = 1;
end$




