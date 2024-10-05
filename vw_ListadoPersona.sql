use Edifia
select p.nombre as 'Nombre', p.apellido as 'Apellido' , p.documento as 'DNI', e.nombre as 'Edificio' , d.numero as 'Departamento',h.es_propietario as 'Tipo_id',
CASE
WHEN h.es_propietario = 1 THEN 'Propietario' 
	ELSE 'Inquilino' 
END AS 'Tipo',
CASE 
        WHEN c.numero IS NULL THEN 'No posee' 
        ELSE CAST(c.numero AS NVARCHAR(10)) 
    END AS 'Cochera',
ISNULL(m.tipo,'No posee') as 'Mascota'
FROM 
    Tb_Persona p
inner join Tb_Habitante h on h.nombre = p.nombre
inner join Tb_Departamento d on d.id = h.departamento_id
inner join Tb_Edificio e on e.id = d.edificio_id
left join Tb_Cochera c on c.persona_id = p.id
left join Tb_Mascota m on m.departamento_id = d.id