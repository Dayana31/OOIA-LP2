/*OOIA_create_procedures.sql*/

/*Gestión Humana*/
--ESPECIALIDAD
create procedure INSERTAR_ESPECIALIDAD(
	out _id_especialidad int,
	in _nombre varchar(150)
)
begin
	insert into especialidad(nombre) values (_nombre);
end$

create procedure MODIFICAR_ESPECIALIDAD(
	in _id_especialidad int,
	in _nombre varchar(150)
)
begin
	update especialidad set nombre = _nombre
    	where id_especialidad = _id_especialidad;
end$

create procedure ELIMINAR_ESPECIALIDAD(
	in _id_especialidad int
)
begin
	delete from especialidad where id_especialidad = _id_especialidad;
end$

create procedure LISTAR_ESPECIALIDAD(
)
begin
	select id_especialidad, nombre
	from especialidad;
end$

--ALUMNO
delimiter $
create procedure INSERTAR_ALUMNO(
	out _id_alumno int,
	--persona
    	in _nombre varchar(150),
	in _dni varchar(150),
    	in _edad int,
    	in _direccion varchar(150),
	in _correo varchar(150),
	--miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_de_inclusion date,
	in _imagen_perfil longblob,
    	--alumno
	in _codigo varchar(150),
    	in _fid_especialidad int,
    	in _craest decimal(4,2),
    	in _creditos_aprobados decimal(10,2)
)
begin
	declare _id_persona int; 
    	declare _id_miembro_pucp int;
	--persona
	insert into persona(nombre, dni, edad, correo,direccion) 
    	values (_nombre, _dni, _edad,_correo, _direccion);
	set _id_persona = @@last_insert_id;
	--miembro--pucp
    	insert into miembro_pucp(fid_persona, usuario, password, fecha_de_inclusion, imagen_perfil)
    	values (_id_persona, _usuario, MD5(_password), _fecha_de_inclusion, _imagen_perfil);
    	set _id_miembro_pucp = @@last_insert_id;
	--alumno
    	insert into alumno(id_alumno,fid_miembro_pucp, codigo_pucp, fid_especialidad, craest, estado,
    	cursos_por_primera, cursos_por_segunda, cursos_por_tercera,creditos_aprobados)
    	values (_id_miembro_pucp,_id_miembro_pucp, _codigo_pucp, _fid_especialidad, _craest, 1, _creditos_aprobados);
    	set _id_alumno = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_ALUMNO(
	in _id_alumno int,
	--persona
    	in _nombre varchar(150),
    	in _dni varchar(150),
    	in _edad int,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	--miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_de_inclusion date,
    	in _imagen_perfil longblob,
	--alumno
	in _codigo varchar(150),
    	in _fid_especialidad int,
    	in _craest decimal(4,2),
    	in _creditos_aprobados decimal(10,2)
)
begin
	declare aux_persona int;	
    	select  p.id_persona into aux_persona
    	from persona p 
    	inner join miembro_pucp mp on p.id_persona=mp.fid_persona
    	inner join alumno al on al.fid_miembro_pucp= mp.id_miembro_pucp
    	where al.id_alumno=_id_alumno;
    	--persona
	update persona set nombre = _nombre,  dni = _dni,  edad = _edad, direccion = _direccion , correo=_correo
    	where id_persona = aux_persona;
     	--miembro_pucp
	update miembro_pucp set usuario = _usuario, password = _password, fecha_de_inclusion = _fecha_de_inclusion, imagen_perfil = _imagen_perfil
    	where fid_persona = aux_persona;
    	--alumno
    	update alumno set codigo = _codigo, fid_especialidad = _fid_especialidad, craest = _craest, creditos_aprobados = _creditos_aprobados
    	where id_alumno = _id_alumno;
end$

delimiter $
create procedure ELIMINAR_ALUMNO(
	in _id_alumno int
)
begin
	update alumno set estado  = 0 where id_alumno = _id_alumno;
end$

delimiter $
create procedure LISTAR_ALUMNO(
)begin
	select 	p.id_persona, p.nombre, p.dni, p.edad, p.direccion, p.correo,
		m.usuario, m.password, m.fecha_de_inclusion, m.imagen_perfil,
           	a.id_alumno, a.codigo, a.fid_especialidad, e.nombre as nombre_especialidad, a.craest, a.creditos_aprobados
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join alumno a on a.fid_miembro_pucp = m.id_miembro_pucp
        inner join especialidad  e on e.id_especialidad = a.fid_especialidad 
	where a.estado = 1;
end$


--PROFESOR
delimiter $
create procedure INSERTAR_PROFESOR(
	out _id_profesor int,
	--persona
    	in _nombre varchar(150),
    	in _dni varchar(150),
    	in _edad int,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	--miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_de_inclusion date,
    	in _imagen_perfil longblob,
	--profesor
	in _especialidad int,
    	in _facultad varchar(150),
    	in _categoria varchar(150)
)
begin
	declare _id_persona int;
    	declare _id_miembro_pucp int;
	--persona
	insert into persona(nombre, dni, edad, correo, direccion) 
    	values (_nombre, _dni, _edad, _correo, _direccion);
	set _id_persona = @@last_insert_id;
	--miembro_pucp
    	insert into miembro_pucp(fid_persona, usuario, password, fecha_de_inclusion, imagen_perfil)
    	values (_id_persona, _usuario, _password, _fecha_de_inclusion, _imagen_perfil);
    	set _id_miembro_pucp = @@last_insert_id;
	--profesor
    	insert into profesor(fid_miembro_pucp, fid_especialidad, facultad, categoria, estado)
    	values (_id_miembro_pucp, _especialidad, _facultad, _categoria, 1);
    	set _id_profesor=@@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_PROFESOR(
	in _id_profesor int,
	--persona
    	in _nombre varchar(150),
    	in _dni varchar(150),
    	in _edad int,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	--miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_de_inclusion date,
    	in _imagen_perfil longblob,
	--profesor
    	in _especialidad int,
    	in _facultad varchar(150),
    	in _categoria varchar(150)
)
begin
	declare aux_persona  int;	
    	select  p.id_persona into aux_persona
    	from persona p 
    	inner join miembro_pucp mp on p.id_persona=mp.fid_persona
    	inner join profesor pr on pr.fid_miembro_pucp= mp.id_miembro_pucp
    	where pr.id_profesor=_id_profesor;
    	--persona
    	update persona set nombre = _nombre,  dni = _dni,  edad = _edad, direccion = _direccion , correo=_correo
    	where id_persona = aux_persona;
     	--miembro_pucp
	update miembro_pucp set usuario = _usuario, password=_password, fecha_de_inclusion = _fecha_de_inclusion, imagen_perfil = _imagen_perfil
    	where fid_persona = aux_persona;
    	--profesor
    	update profesor set fid_especialidad = _especialidad, facultad = _facultad, categoria = _categoria
    	where id_profesor = _id_profesor;
end$

delimiter $
create procedure ELIMINAR_PROFESOR(
	in _id_profesor int
)
begin
	update profesor set estado  = 0 where id_profesor = _id_profesor;
end$

delimiter $
create procedure LISTAR_PROFESOR(
)begin
	select 	p.id_persona, p.nombre, p.dni, p.edad, p.direccion, p.correo,
		m.usuario, m.password, m.fecha_de_inclusion, m.imagen_perfil,
 		pr.id_profesor, e.nombre as nombre_especialidad, pr.facultad, pr.categoria
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join profesor pr on pr.fid_miembro_pucp = m.id_miembro_pucp
       	inner join especialidad e on e.id_especialidad = pr.fid_especialidad
	where pr.estado = 1;
end$


--PSICOLOGO
delimiter $
create procedure INSERTAR_PSICOLOGO(
	out _id_psicologo int,
	--persona
    	in _nombre varchar(150),
    	in _dni varchar(150),
    	in _edad int,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	--miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_de_inclusion date,
    	in _imagen_perfil longblob
)
begin
	declare _id_persona int;
    	declare _id_miembro_pucp int;
	--persona
	insert into persona(nombre, dni, edad, correo,direccion) 
    	values (_nombre, _dni, _edad,_correo, _direccion);
	set _id_persona = @@last_insert_id;
	--miembro_pucp
    	insert into miembro_pucp(fid_persona, usuario, password, fecha_de_inclusion, imagen_perfil)
    	values (_id_persona, _usuario, MD5(_password), _fecha_de_inclusion, _imagen_perfil);
    	set _id_miembro_pucp = @@last_insert_id;
	--psicologo
    	insert into psicologo(fid_miembro_pucp, estado)
    	values (_id_miembro_pucp, 1);
    	set _id_psicologo= @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_PSICOLOGO(
	in _id_psicologo int,
	--persona
    	in _nombre varchar(150),
    	in _dni varchar(150),
    	in _edad int,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	--miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_de_inclusion date,
    	in _imagen_perfil longblob
)
begin
	declare aux_persona int;	
    	select p.id_persona into aux_persona
    	from persona p 
    	inner join miembro_pucp mp on p.id_persona=mp.fid_persona
    	inner join psicologo ps on ps.fid_miembro_pucp= mp.id_miembro_pucp
    	where ps.id_psicologo=_id_psicologo;
	--persona
    	update persona set nombre = _nombre,  dni = _dni,  edad = _edad, direccion = _direccion , correo=_correo
    	where id_persona = aux_persona;
     	--miembro_pucp
	update miembro_pucp set usuario = _usuario, password = _password, fecha_de_inclusion = _fecha_de_inclusion, imagen_perfil = _imagen_perfil
    	where fid_persona = aux_persona;
end$

delimiter $
create procedure ELIMINAR_PSICOLOGO(
	in _id_psicologo int
)
begin
	update psicologo set estado  = 0 where id_psicologo = _id_psicologo;
end$

delimiter $
create procedure LISTAR_PSICOLOGO(
)begin
	select 	p.id_persona, p.nombre, p.dni, p.edad, p.direccion, p.correo,
		m.usuario, m.password, m.fecha_de_inclusion, m.imagen_perfil,
		ps.id_psicologo
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join psicologo ps on ps.fid_miembro_pucp = m.id_miembro_pucp
	where ps.estado = 1;
end$

--COORDINADOR
delimiter $
create procedure INSERTAR_COORDINADOR(
	out _id_coordinador int,
	--persona
	in _nombre varchar(150),
    	in _dni varchar(150),
    	in _edad int,
	in _direccion varchar(150),
    	in _correo varchar(150),
	--miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_de_inclusion date,
    	in _imagen_perfil longblob
)
begin
	declare _id_persona int;
    	declare _id_miembro_pucp int;
	--persona
	insert into persona(nombre, dni, edad, correo, direccion) 
    	values (_nombre, _dni, _edad,_correo, _direccion);
	set _id_persona = @@last_insert_id;
	--miembro_pucp
    	insert into miembro_pucp(fid_persona, usuario, password, fecha_de_inclusion, imagen_perfil)
    	values (_id_persona, _usuario, MD5(_password), _fecha_de_inclusion, _imagen_perfil);
    	set _id_miembro_pucp = @@last_insert_id;
	--psicologo
    	insert into coordinador(fid_miembro_pucp, estado)
    	values (_id_miembro_pucp, 1);
    	set _id_coordinador= @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_COORDINADOR(
	in _id_coordinador int,
	--persona
    	in _nombre varchar(150),
    	in _dni varchar(150),
    	in _edad int,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	--miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_de_inclusion date,
    	in _imagen_perfil longblob
)
begin
	declare aux_persona int;	
    	select p.id_persona into aux_persona
    	from persona p 
    	inner join miembro_pucp mp on p.id_persona=mp.fid_persona
    	inner join coordinador a on a.fid_miembro_pucp= mp.id_miembro_pucp
    	where a.id_coordinador =_id_coordinador;
	--persona
    	update persona set nombre = _nombre,  dni = _dni,  edad = _edad, direccion = _direccion, correo=_correo
    	where id_persona = aux_persona;
     	--miembro_pucp
	update miembro_pucp set usuario = _usuario, password = _password, fecha_de_inclusion = _fecha_de_inclusion, imagen_perfil = _imagen_perfil
    	where fid_persona = aux_persona;
end$

delimiter $
create procedure ELIMINAR_COORDINADOR(
	in _id_coordinador int
)
begin
	update coordinador set estado  = 0 where id_coordinador = _id_coordinador;
end$

delimiter $
create procedure LISTAR_COORDINADOR(
)begin
	select 	p.id_persona, p.nombre, p.dni, p.edad, p.direccion, p.correo,
		m.usuario, m.password, m.fecha_de_inclusion, m.imagen_perfil,
		a.id_coordinador
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join coordinador a on a.fid_miembro_pucp = m.id_miembro_pucp
	where ps.estado = 1;
end$

--INVITADO
delimiter $
create procedure INSERTAR_INVITADO(
	out _id_invitado int,
	--persona
    	in _nombre varchar(150),
    	in _dni varchar(150),
    	in _edad int,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	--miembro_externo
    	in _telefono int,
	in _ocupacion varchar(150)
)
begin
	declare _id_persona int;
    	declare _id_miembro_externo int;
	--persona
	insert into persona(nombre, dni, edad, correo, direccion) 
    	values (_nombre, _dni, _edad, _correo, _direccion);
	set _id_persona = @@last_insert_id;
	--miembro_externo
    	insert into miembro_externo(fid_persona, telefono, ocupacion)
    	values (_id_persona, _telefono, _ocupacion);
    	set _id_miembro_externo= @@last_insert_id;
	--invitado
    	insert into invitado(fid_miembro_externo, estado)
    	values (_id_miembro_externo, 1);
    	set _id_invitado=@@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_INVITADO(
	in _id_invitado int,
	--persona
    	in _nombre varchar(150),
    	in _dni varchar(150),
    	in _edad int,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	--miembro_externo
    	in _telefono int,
    	in _ocupacion varchar(150)
)
begin
    	declare aux_persona int;	
    	select p.id_persona into aux_persona
    	from persona p 
    	inner join miembro_externo  me on p.id_persona=me.fid_persona
    	inner join invitado i on i.fid_miembro_externo= me.id_miembro_externo
    	where i.id_invitado=_id_invitado;
    	--persona
	update persona set nombre = _nombre,  dni = _dni,  edad = _edad, direccion = _direccion , correo=_correo
    	where id_persona = aux_persona;
     	--miembro_externo
	update miembro_externo set telefono = _telefono, ocupacion = _ocupacion
    	where fid_persona = aux_persona;
end$

delimiter $
create procedure ELIMINAR_INVITADO(
	in _id_invitado int
)
begin
	update invitado set estado  = 0 where id_invitado = _id_invitado;
end$

delimiter $
create procedure LISTAR_INVITADO(
)begin
	select 	p.id_persona, p.nombre, p.dni, p.edad, p.direccion, p.correo,
		m.telefono, m.ocupacion
	from persona p 
	inner join miembro_externo m on p.id_persona = m.fid_persona
        inner join invitado i on i.fid_miembro_externo = m.id_miembro_externo
	where i.estado = 1;
end$


/*Gestión Académica*/
--CURSO
delimiter $
create procedure INSERTAR_CURSO(
	out _id_curso inT,
	in _codigo_curso VARCHAR(100),
    	in _nombre_curso VARCHAR(300)
)
BEGIN
	insert inTO curso(codigo_curso,nombre_curso,estado) VALUES(_codigo_curso,_nombre_curso,1);
	SET _id_curso = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_CURSO(
	in _id_curso inT,
	in _codigo_curso VARCHAR(100),
    	in _nombre_curso VARCHAR(300)
)
BEGIN
	update curso SET codigo_curso = _codigo_curso, nombre_curso=_nombre_curso 
	where id_curso = _id_curso;
end$

delimiter $
create procedure ELIMINAR_CURSO(
	in _id_curso inT
)
BEGIN
	update curso SET estado = 0 where id_curso = _id_curso;
end$

delimiter $
create procedure LISTAR_CURSO()
BEGIN
	select id_curso, codigo_curso, nombre_curso
	from curso
	where estado=1;
end$

--CURSO_LLEVADO
delimiter $
create procedure INSERTAR_CURSOLLEVADO(
	out _id_curso_llevado inT,
    	in _fid_alumno inT,
	in _fid_curso inT,
    	in _ciclo VARCHAR(100),
    	in _vez inT,
    	in _nota_final DECIMAL(4,2),
    	in _retirado BOOLEAN,
    	in _formula_de_calificacion VARCHAR(100)
)
BEGIN
	insert inTO curso_llevado(fid_alumno, fid_curso, ciclo, vez, nota_final, retirado, formula_de_calificacion) 
    	VALUES(_fid_alumno, _fid_curso, _ciclo, _vez, _nota_final, _retirado, _formula_de_calificacion);
	SET _id_curso_llevado = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_CURSOLLEVADO(
	in _id_curso_llevado inT,
    	in _fid_alumno inT,
	in _fid_curso inT,
    	in _ciclo VARCHAR(100),	
    	in _vez inT,
    	in _nota_final DECIMAL(4,2),
    	in _retirado BOOLEAN,
    	in _formula_de_calificacion VARCHAR(100)
)
BEGIN
	update curso_llevado SET  fid_alumno = _fid_alumno, fid_curso=_fid_curso, ciclo = _ciclo,
    	vez = _vez, nota_final = _nota_final, retirado = _retirado, formula_de_calificacion = _formula_de_calificacion 
    	where id_curso_llevado = _id_curso_llevado;
end$

delimiter $
create procedure LISTAR_CURSOSLLEVADO(
	in _id_alumno inT
)
BEGIN
	select cl.id_curso_llevado,c.id_curso ,c.codigo_curso, c.nombre_curso, cl.ciclo, cl.vez, cl.nota_final,
    	cl.retirado, cl.formula_de_calificacion
    	from curso_llevado cl inner join curso c on c.id_curso=cl.fid_curso
	where fid_alumno=_id_alumno;
end$

--CATEGORIA
delimiter $
create procedure INSERTAR_CATEGORIA(
	out _id_categoria int,
	in _nombre_categoría varchar(150)
)
begin
	insert into categoria(nombre_categoría) values (_nombre_categoría);
    SET _id_categoria = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_CATEGORIA(
	in _id_categoria int,
	in _nombre_categoría varchar(150)
)
begin
	update categoria set nombre_categoría = _nombre_categoría
    where id_categoria = _id_categoria;
end$

delimiter $
create procedure LISTAR_CATEGORIA(
)
begin
	select id_categoria,nombre_categoría
	from categoria;
end$

delimiter $
create procedure INSERTAR_EVALUACION(
	out _id_evaluacion inT,
    in _fid_curso_llevado inT,
    in _fid_categoria int,
    in _nombre VARCHAR(100),
    in _nota inT
)
BEGIN
	insert inTO evaluacion(id_curso_llevado,fid_categoria,nombre,nota) 
    VALUES(_fid_curso_llevado,_fid_categoria,_nombre,_nota);
	SET _id_evaluacion = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_EVALUACION(
	in _id_evaluacion inT,
    in _fid_curso_llevado inT,
    in _fid_categoria int,
    in _nombre VARCHAR(100),
    in _nota inT
)
BEGIN
	update evaluacion SET  fid_curso_llevado = _fid_curso_llevado, fid_categoria=_fid_categoria, nombre = _nombre,
    nota = _nota
    where id_evaluacion = _id_evaluacion;
end$

delimiter $
create procedure LISTAR_EVALUCIONES(
	in _id_curso_llevado inT
)
BEGIN
	select id_evaluacion, fid_categoria, nombre, nota
    from evaluacion where fid_curso_llevado=_id_curso_llevado;
end$

/*Gestión Atención*/
--CODIGO_ATENCION
delimiter $
create procedure INSERTAR_CODIGO_ATENCION(
	out _id_codigo_atencion inT,
	in _codigo VARCHAR(100),
    in _descripcion VARCHAR(300)
)
BEGIN
	insert inTO codigo_atencion(codigo,descripcion) VALUES(_codigo,_descripcion);
	SET _id_codigo_atencion = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_CODIGO_ATENCION(
	in _id_codigo_atencion inT,
	in _codigo VARCHAR(100),
    in _descripcion VARCHAR(300)
)
BEGIN
	update codigo_atencion SET codigo = _codigo, descripcion=_descripcion where id_codigo_atencion = _id_codigo_atencion;
end$

delimiter $
create procedure LISTAR_CODIGOS_ATENCION()
BEGIN
	select id_codigo_atencion, codigo, descripcion from codigo_atencion;
end$

--HORARIO
delimiter $
create procedure INSERTAR_HORARIO(
	out _id_horario inT,
    	in _dia int,
    	in _hora_inicio time,
    	in _hora_fin time
)
BEGIN
	insert inTO horario(dia,hora_inicio,hora_fin,estado) 
    	VALUES(_dia,_hora_inicio,_hora_fin,1);
	SET _id_horario = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_HORARIO(
	in _id_horario inT,
    	in _dia int,
    	in _hora_inicio time,
    	in _hora_fin time
)
BEGIN
	update horario SET  dia = _dia, hora_inicio=_hora_inicio, hora_fin = _hora_fin
    	where id_horario = _id_horario;
end$

delimiter $
create procedure ELIMINAR_HORARIO(
	in _id_horario inT
)
BEGIN
	update horario SET estado = 0 where id_horario = _id_horario;
end$

delimiter $
create procedure LISTAR_HORARIOS(
	in _id_asesor inT
)
BEGIN
	select h.dia, h.hora_inicio, h.hora_fin, h.estado
    	from horario_asesor ha inner join horario h on h.id_horario=ha.fid_horario
    	where _id_asesor=ha.fid_asesor;
end$

--CITA
delimiter $
create procedure INSERTAR_CITA(
    	out _id_cita int,
    	in _fecha_registro date,
    	in _fid_alumno int,
    	in _fid_horario int,
    	in _fid_atencion int,
    	in _motivo varchar(300),
    	in _asistio bool
)
BEGIN
	insert inTO cita(fecha_registro,fid_alumno,fid_horario,fid_atencion,motivo,asistio,estado) 
    	VALUES(_fecha_registro,_fid_alumno,_fid_horario,_fid_atencion,_motivo,_asistio,1);
	SET _id_cita = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_CITA(
    	in _id_cita int,
    	in _fecha_registro date,
    	in _fid_alumno int,
    	in _fid_horario int,
    	in _fid_atencion int,
    	in _motivo varchar(300),
    	in _asistio bool
)
BEGIN
	update cita SET fecha_registro = _fecha_registro, fid_alumno=_fid_alumno, fid_horario=_fid_horario,
    	fid_atencion=_fid_atencion, motivo=_motivo, asistio=_asistio where id_cita = _id_cita;
end$

delimiter $
create procedure ELIMINAR_CITA(
	in _id_cita inT
)
BEGIN
	update cita SET estado = 0 where id_cita = _id_cita;
end$

delimiter $
create procedure LISTAR_CITAS_PENDIENTES(
	in _id_alumno inT
)
BEGIN
	select c.id_cita,c.fecha_registro,h.fecha as fecha_cita,h.hora_inicio,h.hora_fin,m.descripcion as descripcion_atencion,
	p.nombre as asesor, c.motivo ,c.asistio 
    	from cita c inner join horario h on h.id_horario =c.fid_horario
    	inner join miembro_pucp mp on h.fid_asesor = mp.id_miembro_pucp
    	inner join persona p on mp.fid_persona=p.id_persona
    	inner join  codigo_atencion m on m.id_codigo_atencion=c.fid_atencion
    	where c.fid_alumno=_id_alumno and h.fecha >= CURDATE();
end$

delimiter $
create procedure LISTAR_CITAS_HISTORICO(
	in _id_alumno inT
)
BEGIN
	select c.id_cita,c.fecha_registro,h.fecha as fecha_cita,h.hora_inicio,h.hora_fin,m.descripcion as descripcion_atencion,
	p.nombre as asesor, c.motivo ,c.asistio 
    	from cita c inner join horario h on h.id_horario =c.fid_horario
    	inner join miembro_pucp mp on h.fid_asesor = mp.id_miembro_pucp
    	inner join persona p on mp.fid_persona=p.id_persona
    	inner join  codigo_atencion m on m.id_codigo_atencion=c.fid_atencion
    	where fid_alumno=_id_alumno and h.fecha < CURDATE();
end$

delimiter $
create procedure INSERTAR_ENCUESTA_ASESOR(
	out _id_encuesta int,
    	in _puntaje decimal(4,2),
    	in _descripcion varchar(300),
    	in _fid_alumno int,
    	in _fid_asesor int
)
BEGIN
	insert inTO encuesta(puntaje,descripcion,fid_alumno,fid_asesor) 
    	VALUES(_puntaje,_descripcion,_fid_alumno,_fid_asesor);
	SET _id_encuesta = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_ENCUESTA_ASESOR(
	in _id_encuesta int,
    	in _puntaje decimal(4,2),
    	in _descripcion varchar(300),
    	in _fid_alumno int,
    	in _fid_asesor int
)
BEGIN
	update encuesta SET puntaje = _puntaje, descripcion=_descripcion, fid_alumno=_fid_alumno,
    	fid_asesor=_fid_asesor where id_encuesta = _id_encuesta;
end$

delimiter $
create procedure LISTAR_ENCUESTAS_ASESORES(
	in _id_asesor inT
)
BEGIN
	select id_encuesta,puntaje,descripcion,fid_alumno from encuesta
    	where fid_asesor=_id_asesor;
end$

/*Gestión Eventos*/
--EVENTO
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
	insert into evento(fid_coordinador, id_evento, capacidad, nombre, fecha_inicio, fecha_fin, lugar, estado)
    	values (_fid_coordinador, _id_evento, _capacidad, _nombre, _fecha_inicio, _fecha_fin,_lugar, 1);
end$

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
	update evento set fid_coordinador = _fid_coordinador, capacidad = _capacidad, nombre = _nombre, 
  	  fecha_inicio = _fecha_inicio, fecha_fin = _fecha_fin, lugar = _lugar 
	where id_evento = _id_evento;
end$

delimiter $
create procedure ELIMINAR_EVENTO(
    	in _id_evento int
)begin
	update evento set estado = 0 where id_evento = _id_evento;
end$

delimiter $
create procedure LISTAR_EVENTO(
)begin
	select e.id_evento, e.nombre, e.lugar, e.capacidad, e.fecha_inicio, e.fecha_fin
    	from evento e inner join coordinador_eventos_ooia c on e.fid_coordinador = c.id_coordinador 
	where e.estado = 1;
end$

--ENCUESTA_EVENTO
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
	insert into evento_alumno(id_encuesta, fid_alumno, fid_evento, valoracion_ponentes, valoracion_evento, valoracion_utilidad, 	asistencia, comentario, estado) 
    	values(_id_encuesta, _id_evento, _fid_alumno, _fid_evento, _valoracion_ponentes, _valoracion_evento, _valoracion_utilidad, _asistencia, 	_comentario, 1);
end$

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
end$

delimiter $
create procedure ELIMINAR_ENCUESTA_EVENTO(
    	in _id_encuesta int
)begin
	/*tabla evento_alumno*/
	update evento_alumno set estado = 0 where id_encuesta = _id_encuesta;
end$

delimiter $
create procedure LISTAR_ENCUESTA_EVENTO(
)begin
	select id_encuesta, fid_alumno, fid_evento, valoracion_ponentes, valoracion_evento,
    	valoracion_utilidad, asistencia, comentario from evento_alumno where estado = 1;
end$