USE TVGLojaVirtual
GO

CREATE VIEW MarcaVitrine
AS
SELECT MarcaCodigo, MarcaDescricao, MarcaId
FROM Marca
WHERE MarcaCodigo in (0082,0117,0130,0073,0002,0091,0005,0129)