SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[senha] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[telefone] [varchar](100) NULL,
	[pais] [varchar](25) NULL,
	[estado] [varchar](25) NULL,
	[cidade] [varchar](50) NULL,
	[status] [bit] NOT NULL,
	[permissao] [varchar](100) NOT NULL,
	[update] [datetime] NULL,
	[create] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
ALTER TABLE [dbo].[usuario] ADD PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[usuario] ADD  DEFAULT (getdate()) FOR [create]
GO
