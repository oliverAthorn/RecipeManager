CREATE PROCEDURE [dbo].[spRecipe_Get]
	@Id int
AS
begin
	SELECT *
	from dbo.Recipe
	WHERE Id = @Id;
end
