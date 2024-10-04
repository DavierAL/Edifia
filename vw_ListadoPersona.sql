use Edifia

create view vw_ListadoPersonas with encryption
as
select p.nombre, p.apellido, p.documento, e.nombre as 'Edificio' , d.numero as 'Departamento' from Tb_Persona p
inner join Tb_Habitante h on h.nombre = p.nombre
inner join Tb_Departamento d on d.id = h.departamento_id
inner join Tb_Edificio e on e.id = d.edificio_id
