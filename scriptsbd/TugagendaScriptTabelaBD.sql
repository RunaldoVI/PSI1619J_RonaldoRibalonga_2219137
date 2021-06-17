
--Tabela Filmes 

CREATE TABLE Filmes (
    IDFilme int identity (1,1),
	Nome varchar(50),
	Descricao varchar(max),
	Genero varchar(50),
	Imagem varchar(max)
	Constraint PK Primary Key(IDFilme)
);

--Tabela Historico Filmes

CREATE TABLE HistoricoF (
    IDHistorico int identity (1,1),
	FilmeID Int,
	FilmeNome varchar(50),
	IDRegisto int,
	Username varchar(50),
	Visto bit,
	QuerVer bit,
	AVer bit,
	Constraint PK Primary Key(IDHistorico)	
);
ALTER TABLE HistoricoF ADD CONSTRAINT [Fk_HistoricoF_Registo] FOREIGN KEY ( IDRegisto ) REFERENCES Registo( IDRegisto ) ON DELETE NO ACTION ON UPDATE NO ACTION

--Tabela Series

CREATE TABLE Series (
    IDSerie int identity (1,1),
	Nome varchar(50),
	Temporada int,
	Descricao varchar(max),	
	Genero varchar(50),
	Imagem varchar(max)
	Constraint PK Primary Key(IDSerie)	
);

--Tabela Temporada 

CREATE TABLE Temporada (
    IDTemporada int identity (1,1),
	Temporada int,
	Episodios int,	
	SerieID int
	Constraint PK Primary Key(IDTemporada)	
);
ALTER TABLE Temporada ADD CONSTRAINT [Fk_Temporada_Series] FOREIGN KEY ( SerieID ) REFERENCES Series( IDSerie ) ON DELETE NO ACTION ON UPDATE NO ACTION

--Tabela Historico Series

CREATE TABLE HistoricoS (
    IDHistoricoS int identity (1,1),
	IDRegisto int,
	Username varchar(50),
	SerieID int,
	SerieNome varchar(50),
	Temporada int,
	Episodio int,
	Visto bit,
	QuerVer bit,
	AVer bit,
	Constraint PK Primary Key(IDHistoricoS)	
);
ALTER TABLE HistoricoF ADD CONSTRAINT [Fk_HistoricoS_Registo] FOREIGN KEY ( IDRegisto ) REFERENCES Registo( IDRegisto ) ON DELETE NO ACTION ON UPDATE NO ACTION

--Registo

CREATE TABLE Registo (
    IDRegisto int identity (1,1),
	Username varchar(50),
	Password varchar(50),	
	Email varchar(50)
	Constraint PK Primary Key(IDRegisto)	
);

