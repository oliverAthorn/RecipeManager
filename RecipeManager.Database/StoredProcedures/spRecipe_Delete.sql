CREATE PROCEDURE [dbo].[spRecipe_Delete]
	@Id int
AS
begin
	DELETE
	from dbo.Recipe
	WHERE Id = @Id;
end
