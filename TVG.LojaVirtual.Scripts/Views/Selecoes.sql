USE TVGLojaVirtual
GO

/****** Object:  View [dbo].[ClubesNacionais]    Script Date: 20/09/2015 09:55:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Selecoes]
AS
SELECT        LinhaCodigo, LinhaDescricao
FROM            dbo.Linha
WHERE        (LinhaCodigo IN (0001, 0007, 0015, 0018, 0019, 0020, 0021, 0022, 0026, 0319, 0261, 0262, 0263))

GO
