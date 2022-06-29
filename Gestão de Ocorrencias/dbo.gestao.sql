CREATE TABLE [dbo].[Gestao] (
    [Data]      DATE     NULL,
    [Hora]      DATETIME NULL,
    [Titulo]    TEXT     NULL,
    [Descricao] TEXT     NULL,
    [Gravidade] TEXT     NULL,
    [Operador]  TEXT     NULL,
    [Turno]     TEXT     NULL,
    [ID]        INT      NOT NULL, 
    CONSTRAINT [PK_Gestao] PRIMARY KEY ([ID])
);

