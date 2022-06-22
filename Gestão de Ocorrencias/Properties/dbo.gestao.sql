CREATE TABLE [dbo].[gestao] (
    [dtmData]      DATE           NOT NULL,
    [hHora]        TIME (7)       NULL,
    [txtTitulo]    TEXT           NULL,
    [txtDescricao] TEXT           NULL,
    [cboGravidade] TEXT           NULL,
    [cboOperador]  TEXT           NULL,
    [txtTurno]     NCHAR (10)     NULL,
    [ID]           NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_gestão] PRIMARY KEY CLUSTERED ([dtmData] ASC)
);

