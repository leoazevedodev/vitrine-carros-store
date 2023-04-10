SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carros](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
    [marca] [varchar](100) NOT NULL,
    [modelo] [varchar](100) NOT NULL,
    [ano] INT NOT NULL,
    [cor] [varchar](25) NOT NULL,
    [cidade] VARCHAR(100) NOT NULL,
    [quilometragem] NUMERIC (18,2) NOT NULL,
    [valor] NUMERIC (18,2) NOT NULL,
    [update] [datetime] NULL,
	[create] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
ALTER TABLE [dbo].[usuario] ADD  DEFAULT (getdate()) FOR [create]
GO
