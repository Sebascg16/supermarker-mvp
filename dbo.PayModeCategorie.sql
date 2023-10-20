CREATE TABLE [dbo].[PayModeCategorie] (
    [Categorie_Id]          INT           IDENTITY (100000, 1) NOT NULL,
    [Categorie_Name]        NVARCHAR (50) NOT NULL,
    [Categorie_Observation] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Categorie_Id] ASC)
);

