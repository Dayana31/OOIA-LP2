/*Script*/
drop table if exists evaluacion;
drop table if exists categoria;
drop table if exists curso_llevado;
drop table if exists curso;
drop table if exists encuesta;
drop table if exists compromiso;
drop table if exists cita_ooia;
drop table if exists horario_asesor;
drop table if exists horario;
drop table if exists codigo_atencion;

drop table if exists archivo;
drop table if exists pregunta_frecuente;
drop table if exists tramite_requisito;
drop table if exists tramite_alumno;
drop table if exists requisito;
drop table if exists tramite;
drop table if exists tipo_tramite;

drop table if exists coordinador_eventos_ooia, evento, evento_alumno, evento_ponente, evento_organizador;


drop table if exists invitado;
drop table if exists miembro_externo;
drop table if exists profesor;
drop table if exists psicologo;
drop table if exists alumno;
drop table if exists especialidad;
drop table if exists miembro_pucp;
drop table if exists persona;


create table persona(
	id_persona int auto_increment,
    nombre varchar(150),
    dni varchar(150),
    edad int,
	correo varchar(150),
    direccion varchar(150),
    primary key(id_persona)
)engine = innodb;


create table miembro_pucp(
	id_miembro_pucp int auto_increment,
    fid_persona int,
    usuario varchar(150),
    password varchar(150),
    fecha_de_inclusion date,
    imagen_perfil longblob,
    primary key (id_miembro_pucp),
    foreign key(fid_persona) references persona(id_persona)
)engine = innodb;

create table especialidad(
	id_especialidad int auto_increment,
	nombre varchar(150),
    primary key (id_especialidad)
)engine = innodb;

create table alumno(
	id_alumno int,
	fid_especialidad int,
    fid_miembro_pucp int,
	codigo_pucp varchar(150),
    craest decimal(4,2),
    estado int,
    cursos_por_primera int,
    cursos_por_segunda int,
    cursos_por_tercera int,
    creditos_aprobados decimal(4,2),
    
    primary key(id_alumno),
    foreign key(id_alumno) references miembro_pucp(id_miembro_pucp),
    foreign key(fid_miembro_pucp) references miembro_pucp(id_miembro_pucp),
	foreign key(fid_especialidad) references especialidad(id_especialidad)
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
	fid_miembro_pucp int,
    fid_especialidad int,
    facultad varchar(150),
    categoria varchar(150),
    estado int,
    primary key(id_profesor),
    foreign key(fid_miembro_pucp) references miembro_pucp(id_miembro_pucp),
    foreign key(fid_especialidad) references especialidad(id_especialidad)
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

create table categoria(
    id_categoria int auto_increment,
    nombre_categoría varchar(150),
    primary key (id_categoria)
)engine = innodb;

create table evaluacion(
	id_evaluacion int auto_increment,
	fid_curso_llevado int,
    fid_categoria int,
    nombre varchar(150),
    nota int,
    primary key(id_evaluacion),
    foreign key (fid_curso_llevado) references curso_llevado(id_curso_llevado),
    foreign key (fid_categoria) references categoria(id_categoria)
)engine = innodb;

create table horario(
	id_horario int auto_increment,
    dia int,
    hora_inicio time,
    hora_fin time,
    estado int,
    primary key(id_horario)
)engine = innodb;

create table horario_asesor(
	id_horario_asesor int auto_increment,
	fid_horario int,
	fid_asesor int,
    estado varchar(50),
    primary key(id_horario_asesor),
    foreign key (fid_horario) references horario(id_horario),
    foreign key (fid_asesor) references miembro_pucp(id_miembro_pucp)
)engine = innodb;

create table codigo_atencion(
	id_codigo_atencion int auto_increment,
    codigo varchar(100),
    descripcion varchar(300),
    primary key(id_codigo_atencion)
)engine = innodb;


create table cita_ooia(
     id_cita int auto_increment,
	fid_alumno int,
    fid_horario int,
    fid_atencion int,
    fecha_registro date,
    motivo varchar(300),
    asistio bool,
    estado int,
    primary key(id_cita),
    foreign key (fid_alumno) references alumno(id_alumno),
    foreign key (fid_horario) references horario(id_horario),
    foreign key (fid_atencion) references codigo_atencion(id_codigo_atencion)
)engine = innodb;


create table encuesta(
	id_encuesta int auto_increment,
	fid_alumno int,
    fid_asesor int,
    puntaje decimal(4,2),
    descripcion varchar(300),
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

create table tipo_tramite(
	id_tipo_tramite int auto_increment,
    nombre_tipo_tramite varchar(100),
    primary key(id_tipo_tramite)
)engine innodb;



create table tramite(
	id_tramite int auto_increment,
    fid_tipo_tramite int,
    descripcion varchar(250),
    estado boolean,
    primary key(id_tramite),
	foreign key(fid_tipo_tramite) references tipo_tramite(id_tipo_tramite)
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
    id_coordinador int,
	fid_miembro_pucp int,
    estado boolean,
    primary key(id_coordinador),
    foreign key(fid_miembro_pucp) references miembro_pucp(id_miembro_pucp) 
)engine = innodb;

create table evento(
	id_evento int,
	fid_coordinador int,
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
