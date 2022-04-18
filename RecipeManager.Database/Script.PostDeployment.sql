if not exists (select 1 from dbo.Recipe)
begin
	insert into dbo.Recipe (Name, Description)
	values ('Pasta Bake', 'Wholewheat pasta bake with steaming vegetables'),
	('Margherita', 'A delicious tomato based pizza with cheese');
end