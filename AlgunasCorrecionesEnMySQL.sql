select * from alumno;
select * from profesor;
select * from psicologo;
select * from miembro_pucp;
select * from persona;
select * from especialidad;
alter table alumno drop column fecha_inclusion;
alter table miembro_pucp 

delete from alumno where id_alumno >= 6 and id_alumno <=10;
delete from miembro_pucp where id_miembro_pucp >= 6 and id_miembro_pucp <=10;
delete from persona where id_persona >= 6 and id_persona <=10;
