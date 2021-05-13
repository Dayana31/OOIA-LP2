/*Script*/
drop table if exists evaluacion;
drop table if exists curso_llevado;
drop table if exists curso;
drop table if exists encuesta;
drop table if exists compromiso;
drop table if exists cita_ooia;
drop table if exists horario;
drop table if exists motivo;

drop table if exists archivo;
drop table if exists pregunta_frecuente;
drop table if exists tramite_requisito;
drop table if exists tramite_alumno;
drop table if exists requisito;
drop table if exists tramite;

drop table if exists coordinador_eventos_ooia, evento, evento_alumno, evento_ponente, evento_organizador
,valoracion_ponente;


drop table if exists correo;
drop table if exists invitado;
drop table if exists miembro_externo;
drop table if exists profesor;
drop table if exists psicologo;
drop table if exists alumno;
drop table if exists miembro_pucp;
drop table if exists persona;


create table persona(
	id_persona int auto_increment,
    nombre varchar(150),
    dni varchar(150),
    edad int,
    direccion varchar(150),
    primary key(id_persona)
)engine = innodb;

create table correo(
	fid_persona int,
	id_correo int,
    nombre varchar(150),
    primary key(id_correo),
    foreign key(fid_persona) references persona(id_persona)
)engine = innodb;

create table miembro_pucp(
	id_miembro_pucp int auto_increment,
    fid_persona int,
    usuario_pucp varchar(150),
    fecha_de_inclusion date,
    primary key (id_miembro_pucp),
    foreign key(fid_persona) references persona(id_persona)
)engine = innodb;

create table alumno(
	id_alumno int,
	codigo_pucp varchar(150),
    especialidad varchar(150),
    craest decimal(4,2),
    estado int,
    cursos_por_primera int,
    cursos_por_segunda int,
    cursos_por_tercera int,
    creditos_aprobados decimal(4,2),
    
    primary key(id_alumno),
    foreign key(id_alumno) references miembro_pucp(id_miembro_pucp)
)engine = innodb;



create table miembro_externo(
	id_miembro_externo int auto_increment,
    fid_persona int,
    telefono int,
    ocupacion varchar(150),
    primary key (id_miembro_externo),
    foreign key(fid_persona) references persona(id_persona)
)engine = innodb;

create table profesor(
	id_profesor int auto_increment,
	fid_miembro_pucp int(150),
    especialidad varchar(150),
    facultad varchar(150),
    categoria varchar(150),
    estado int,
    primary key(id_profesor),
    foreign key(fid_miembro_pucp) references miembro_pucp(id_miembro_pucp)
)engine = innodb;

create table psicologo(
	id_psicologo int auto_increment,
	fid_miembro_pucp int,
    estado int,
    primary key(id_psicologo),
    foreign key(fid_miembro_pucp) references miembro_pucp(id_miembro_pucp)
)engine = innodb;

create table invitado(
	id_invitado int auto_increment,
    fid_miembro_externo int,
    estado int,
    primary key(id_invitado),
    foreign key(fid_miembro_externo) references miembro_externo(id_miembro_externo)
)engine = innodb;




create table curso(
    id_curso int auto_increment,
    codigo_curso varchar(150),
    nombre_curso varchar(150),
    estado int,
    primary key (id_curso)
)engine = innodb;

create table curso_llevado(
	id_curso_llevado int auto_increment,
	fid_alumno int,
    fid_curso int,
    ciclo varchar(100),
    vez int,
    nota_final decimal(2,2),
    retirado bool,
    formula_de_calificacion varchar(100),
    primary key(id_curso_llevado),
    foreign key (fid_alumno) references alumno(id_alumno),
    foreign key (fid_curso) references curso(id_curso)
)engine = innodb;

create table evaluacion(
	id_evaluacion int auto_increment,
	fid_curso_llevado int,
    categoria varchar(150),
    nombre varchar(150),
    nota int,
    primary key(id_evaluacion),
    foreign key (fid_curso_llevado) references curso_llevado(id_curso_llevado)
)engine = innodb;

create table horario(
	id_horario int auto_increment,
    fecha date,
    hora_inicio date,
    hora_fin date,
    fid_asesor int,
    estado int,
    primary key(id_horario),
    foreign key (fid_asesor) references miembro_pucp(id_miembro_pucp)
)engine = innodb;

create table motivo(
	id_motivo int auto_increment,
    codigo_motivo varchar(100),
    descripcion varchar(300),
    primary key(id_motivo)
)engine = innodb;


create table cita_ooia(
    id_cita int auto_increment,
    fecha_registro date,
    fid_alumno int,
    fid_horario int,
    fid_motivo int,
    fid_asesor int,
    asistio bool,
    estado int,
    primary key(id_cita),
    foreign key (fid_alumno) references alumno(id_alumno),
    foreign key (fid_horario) references horario(id_horario),
    foreign key (fid_asesor) references miembro_pucp(id_miembro_pucp),
    foreign key (fid_motivo) references motivo(id_motivo)
)engine = innodb;


create table encuesta(
	id_encuesta int auto_increment,
    puntaje decimal(4,2),
    descripcion varchar(300),
    fid_alumno int,
    fid_asesor int,
    primary key(id_encuesta),
    foreign key(fid_alumno) references alumno(id_alumno),
    foreign key(fid_asesor) references miembro_pucp(id_miembro_pucp)
)engine = innodb;

create table compromiso(
	id_compromiso int auto_increment,
    fid_cita int,
    descripcion varchar(300),
    primary key(id_compromiso,fid_cita),
    foreign key(fid_cita) references cita_ooia(id_cita)
)engine = innodb;





create table tramite(
	id_tramite int auto_increment,
    tipo_tramite int,
    descripcion varchar(250),
    estado boolean,
    primary key(id_tramite)
    
)engine innodb;

create table archivo(
	id_archivo int auto_increment,
    fid_tramite int,
    nombre varchar(250),
    estado boolean,
    primary key(id_archivo),
    foreign key(fid_tramite) references tramite(id_tramite)
)engine = innodb;

create table pregunta_frecuente(
	id_pregunta_frecuente int auto_increment,
    fid_tramite int,
    pregunta varchar(250),
    respuesta varchar(250),
    estado boolean,
    primary key(id_pregunta_frecuente),
    foreign key(fid_tramite) references tramite(id_tramite)
)engine = innodb;

create table requisito(
	id_requisito int auto_increment,
    descripcion varchar(250),
    craestMin decimal(10,2),
    creditosMin decimal(10,2),
    estadoAlumno int,
    escalaAlumno int,
    estado boolean,
    primary key(id_requisito)
)engine innodb;

create table tramite_requisito(
	fid_tramite int,
    fid_requisito int,
    estado boolean,
    foreign key(fid_tramite) references tramite(id_tramite),
    foreign key(fid_requisito) references requisito(id_requisito)
)engine = innodb;

create table tramite_alumno(
	id_tramite_alumno int auto_increment,
    fid_alumno int,
    fid_tramite int,
    estado boolean,
    primary key (id_tramite_alumno),
    foreign key(fid_alumno) references alumno(id_alumno),
    foreign key(fid_tramite) references tramite(id_tramite)
)engine = innodb;


create table coordinador_eventos_ooia(
	fid_miembro_pucp int,
    id_coordinador int,
    estado boolean,
    primary key(id_coordinador),
    foreign key(fid_miembro_pucp) references miembro_pucp(id_miembro_pucp) 
)engine = innodb;

create table evento(
	fid_coordinador int,
    id_evento int,
    capacidad int,
    nombre varchar(150),
    fecha_inicio date,
    fecha_fin date,
    lugar varchar(150),
    estado boolean,
    primary key(id_evento),
    foreign key(fid_coordinador) references coordinador_eventos_ooia(id_coordinador)
)engine = innodb;

create table evento_alumno(
	id_encuesta int,
    fid_alumno int,
    fid_evento int,
    valoracion_ponentes int,
    valoracion_evento int,
    valoracion_utilidad int,
    asistencia bool,
    comentario varchar(200),
    estado boolean,
    primary key(id_encuesta),
    foreign key (fid_alumno) references alumno(id_alumno),
    foreign key (fid_evento) references evento(id_evento)
)engine = innodb;



create table evento_ponente(
	id_evento_ponente int,
	fid_persona int,
    fid_evento int,
    primary key(id_evento_ponente),
    foreign key (fid_persona) references persona(id_persona),
    foreign key (fid_evento) references evento(id_evento)
)engine = innodb;

create table evento_organizador(
	id_evento_organizador int,
	fid_persona int,
    fid_evento int,
    primary key (id_evento_organizador),
	foreign key (fid_persona) references persona(id_persona),
    foreign key (fid_evento) references evento(id_evento)
)
