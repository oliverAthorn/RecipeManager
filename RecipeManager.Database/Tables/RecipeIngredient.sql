CREATE TABLE [dbo].[RecipeIngredient]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RecipeId] INT NOT NULL, 
    [QuantityId] INT NOT NULL, 
    [MeasurementUnitId] INT NOT NULL,  
    [IngredientId] INT NOT NULL,
    CONSTRAINT FK_RecipeIngredient_Recipe FOREIGN KEY (RecipeId) REFERENCES Recipe(Id),
    CONSTRAINT FK_RecipeIngredient_Quantity FOREIGN KEY (QuantityId) REFERENCES Quantity(Id),
    CONSTRAINT FK_RecipeIngredient_Measurement FOREIGN KEY (MeasurementUnitId) REFERENCES MeasurementUnit(Id),
    CONSTRAINT FK_RecipeIngredient_Ingredient FOREIGN KEY (IngredientId) REFERENCES MeasurementUnit(Id)
)
