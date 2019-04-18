select * from AspNetUsers
select * from AspNetRoles
select * from AspNetUserRoles
select * from AspNetUserLogins

insert into AspNetRoles
Values (2, 'User')

delete from AspNetUserRoles
where RoleId = 2

insert AspNetUserRoles
values('e37ca221-f262-48e7-bb30-203c321505fe', 1)