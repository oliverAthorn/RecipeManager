CREATE PROCEDURE [dbo].[spRecipe_Insert]
	@Name nvarchar(max),
	@Description nvarchar(max)
AS
BEGIN
	insert into dbo.Recipe (Name, Description)
	values (@Name, @Description);
END
