CREATE PROCEDURE [dbo].[spRecipe_Update]
	@Id int,
	@Name nvarchar(max),
	@Description nvarchar(max)
AS
BEGIN
	update dbo.Recipe
	set Name = @Name, Description = @Description
	where Id = @Id;
END
