﻿/*
CREATE TABLE pessoas(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	NOME VARCHAR(50),
	SOBRENOME VARCHAR(50),
	TELEFONE VARCHAR(13),
	CPF VARCHAR(11),
	SENHA VARCHAR(20),
	ENDERECO INT,
	FOREIGN KEY (ENDERECO) REFERENCES endereco(ID)
);

CREATE TABLE endereco(
	ID INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	CEP VARCHAR(8),
	ESTADO VARCHAR(25),
	UF VARCHAR(2),
	CIDADE VARCHAR(25),
	BAIRRO VARCHAR(25),
	RUA VARCHAR(25),
	NUMERO VARCHAR(4),
	APARTAMENTO VARCHAR(4),
	COMPLEMENTO VARCHAR(25)
);
*/


select * from endereco
select * from pessoas

SELECT TOP 1 id FROM endereco ORDER BY id DESC


--SELECT TOP 1 id FROM endereco ORDER BY id DESC

--INSERT INTO pessoas (NOME, SOBRENOME, TELEFONE, CPF, SENHA, ENDERECO) VALUES ('Enzo', 'Giacomelli', '(47)984747934', '12345678912', 'teste123', 1)