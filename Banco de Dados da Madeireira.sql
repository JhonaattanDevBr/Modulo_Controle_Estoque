use Madeireira;


create table Usuarios(
	Id_Usuario int identity not null,
	Nome_Usuario varchar (30) not null,
	Usuario varchar (30) not null,
	Senha varchar (8) not null,
	primary key (Id_Usuario)
)

create table Fornecedores(
	Id_Fornecedor int identity not null,
	Nome_Forne varchar (50) not null,
	Cnpj varchar (18) unique not null,
	Email varchar (100) unique not null,
	Telefone varchar (14) unique not null,
	Cidade varchar (30) not null,
	Bairro varchar (60) not null,
	Rua varchar (100) not null,
	Numero int not null,
	primary key (Id_Fornecedor)
)

create table MateriasPrimas(
	Id_MatP int identity (100,1) not null,
	Nome_MatP varchar (50) unique not null,
	Material_MatP varchar (30) not null,
	Peso varchar (14) not null,
	Valor_Unit_MatP varchar (14) not null,
	Id_Fornecedor int not null,
	primary key (Id_MatP),
	foreign key (Id_Fornecedor) references Fornecedores (Id_Fornecedor)
)

create table BaixasMatP(
	Id_Baixa_MatP int identity (100,1) not null,
	Baixas_MatP varchar (10) not null,
	Quantidade int not null,
	Id_MatP int not null,
	primary key (Id_Baixa_MatP),
	foreign key (Id_MatP) references MateriasPrimas (Id_MatP)
)

create table EntradasMatP(
	Id_Entrada_MatP int identity (100,1) not null,
	Entradas_MatP varchar (10) not null,
	Quantidade int not null,
	Id_MatP int not null,
	primary key (Id_Entrada_MatP),
	foreign key (Id_MatP) references MateriasPrimas (Id_MatP)
)

create table Produtos(
	Id_Prod int identity not null,
	Nome_Prod varchar (50) unique not null,
	Material_Prod varchar (30) not null,
	Valor_Unit_Prod varchar (14) not null,
	primary key (Id_Prod)
)

create table BaixasProd(
	Id_Baixa_Prod int identity (100,1) not null,
	Baixas_Prod varchar (10) not null,
	Quantidade int not null,
	Id_Prod int not null,
	primary key (Id_Baixa_Prod),
	foreign key (Id_Prod) references Produtos (Id_Prod)
)

create table EntradasProd(
	Id_Entrada_Prod int identity (100,1) not null,
	Entradas_Prod varchar (10) not null,
	Quantidade int not null,
	Id_Prod int not null,
	primary key (Id_Entrada_Prod),
	foreign key (Id_Prod) references Produtos (Id_Prod)
)

create table EstoqueMatP(
	Id_Est_MatP int identity (100,1) not null,
	Saldo_MatP int not null,
	Id_MatP int not null,
	Ultima_Entrada_MatP varchar (10) not null,
	Ultima_Baixa_MatP varchar (10),
	primary key (Id_Est_MatP)
)

create table EstoqueProdutos(
	Id_Est_Prod int identity (100,1) not null,
	Saldo_Prod int not null,
	Id_Prod int not null,
	Ultima_Entrada_Prod varchar (10) not null,
	Ultima_Baixa_Prod varchar (10),
	primary key (Id_Est_Prod)
)