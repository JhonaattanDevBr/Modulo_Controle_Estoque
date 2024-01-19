use Bd_Carpintaria;

CREATE TABLE Usuarios(
	Id_Usuario INT IDENTITY(000,1) NOT NULL,
	Nome VARCHAR (50) NOT NULL,
	Usuario VARCHAR (20) NOT NULL,
	Senha VARCHAR (8) NOT NULL,
	PRIMARY KEY (Id_Usuario)
)

CREATE TABLE Fornecedores(
	Id_Fornecedor INT IDENTITY(000,1) NOT NULL,
	Razao_Sc VARCHAR (80) UNIQUE NOT NULL,
	Cnpj VARCHAR (18) UNIQUE NOT NULL,
	Email VARCHAR (100) UNIQUE NOT NULL,
	Telefone VARCHAR (14) UNIQUE NOT NULL,
	Cidade VARCHAR (40) NOT NULL,
	Regiao VARCHAR (2) NOT NULL,
	Bairro VARCHAR (80) NOT NULL,
	PRIMARY KEY (Id_Fornecedor)
)

CREATE TABLE Materias_Primas(
	Id_MateriaP INT IDENTITY(000,1) NOT NULL,
	Nome_MP VARCHAR (40) NOT NULL,
	Categoria VARCHAR (40) NOT NULL,
	Preco_Unt FLOAT NOT NULL,
	Quantidade INT NOT NULL,
	Id_Fornecedor INT NOT NULL,
	PRIMARY KEY (Id_MateriaP),
	FOREIGN KEY (Id_Fornecedor) REFERENCES Fornecedores (Id_Fornecedor)
)

CREATE TABLE Produtos(
	Id_Produto INT IDENTITY(000,1) NOT NULL,
	Nome_Produto VARCHAR (50) UNIQUE NOT NULL,
	Categoria VARCHAR (40) NOT NULL,
	Preco_Unt FLOAT NOT NULL,
	Quantidade INT NOT NULL,
	PRIMARY KEY (Id_Produto)
)

CREATE TABLE Entrada_Produtos(
	Id_EntradaP INT IDENTITY(000,1) NOT NULL,
	Data_Entrada DATE NOT NULL,
	Quantidade INT NOT NULL,
	Id_Produto INT NOT NULL,
	PRIMARY KEY (Id_EntradaP),
	FOREIGN KEY (Id_Produto) REFERENCES Produtos(Id_Produto)
)

CREATE TABLE Entrada_MP(
	Id_EntradaMP INT IDENTITY(000,1) NOT NULL,
	Data_Entrada DATE NOT NULL,
	Quantidade INT NOT NULL,
	Id_MateriaP INT NOT NULL,
	PRIMARY KEY (Id_EntradaMP),
	FOREIGN KEY (Id_MateriaP) REFERENCES Materias_Primas (Id_MateriaP)
)

CREATE TABLE Saidas(
	Id_Saida INT IDENTITY(000,1) NOT NULL,
	Data_Saida DATE NOT NULL,
	Quantidade INT NOT NULL,
	Id_Produto INT NOT NULL,
	PRIMARY KEY (Id_Saida),
	FOREIGN KEY (Id_Produto) REFERENCES Produtos (Id_Produto)
)