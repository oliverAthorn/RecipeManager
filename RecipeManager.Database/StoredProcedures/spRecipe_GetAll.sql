CREATE PROCEDURE [dbo].[spRecipe_GetAll]
AS
begin
	SELECT *
	from dbo.Recipe;
end
