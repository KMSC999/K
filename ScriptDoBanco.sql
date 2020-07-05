
--Criação do banco de dados
create database M
go
use M
go

-----------------------------------------------------------------------------------------------------------------------------------------------
--CRIACAO DAS TABELAS--

create table Usuario(
Id_Usuario int identity(1,1) primary key,
Login_Usuario varchar(20) not null,
Senha_Usuario varchar(50) not null,
Nome_Usuario varchar(50) not null,
Nasc_Usuario date not null,
Cpf_Usuario varchar(14) not null,
Email_Usuario varchar(50) not null,
Telefone_Usuario varchar(15),
Celular_Usuario varchar(16),
Admissao_Usuario date not null,
Permissao_Usuario char(1) not null
)
go

create table Fornecedor(
Id_Fornecedor int identity(1,1) primary key,
Nome_Fornecedor varchar(50),
Tele_Fornecedor varchar(20),
Email_Fornecedor varchar(50),
)
go

create table Medicamento(
Id_Med int identity(1,1) primary key,
Nome_Med varchar(50) not null,
Diluicao_Med varchar(50),
Dose_Med varchar(100) ,
Armazena_med varchar(100),
Incompa_Med varchar(100), 
Infusao_Med varchar(100),
Qtde_Med int not null,
Preco_Med float not null,
Id_Fornecedor int not null,
foreign key (Id_Fornecedor) references Fornecedor(Id_Fornecedor)
)
go

create table MedicamentoRetirado(
Id_Reti_Med int identity(1,1) primary key,
Nome_Med varchar(50) not null,
Qtde_Reti_Med int,
Id_Med int,
Id_Usuario int,
foreign key(Id_Usuario) references Usuario(Id_Usuario),
foreign key(Id_Med) references Medicamento(Id_Med)
)
go

create table Encomenda(
Id_Encomenda int identity(1,1) not null,
Nome_Fornecedor varchar(50) not null,
Med_Encomenda varchar(50) not null,
Qtde_Encomenda int not null,
Preco_Encomenda float not null,
Data_Encomenda date not null,
Data_Entrega_Encomenda date,
N_Lote_Encomenda varchar(50),
Status_Encomenda varchar(50),
Id_Usuario int,
Id_Fornecedor int,
foreign key(Id_Usuario) references Usuario(Id_Usuario),
foreign key(Id_Fornecedor) references Fornecedor(Id_Fornecedor)
)
go

-----------------------------------------------------------------------------------------------------------------------------------------------

--PROCEDURES DA TABELA USUARIO --


insert into Usuario(Login_Usuario, Senha_Usuario, Nome_Usuario, Nasc_Usuario, Cpf_Usuario, Email_Usuario, Telefone_Usuario, Celular_Usuario, Admissao_Usuario, Permissao_Usuario)
values ('K', '1234', 'Kelvin Marcelo Santos', '2000-12-24', '397.801.038-05', 'k@gmail.com', '(11)1111-1111', '(  )     -', '2020-12-24', 'A')
go

insert into Usuario(Login_Usuario, Senha_Usuario, Nome_Usuario, Nasc_Usuario, Cpf_Usuario, Email_Usuario, Telefone_Usuario, Celular_Usuario, Admissao_Usuario, Permissao_Usuario)
values ('G', '11', 'Gerson Almeida', '2000-12-24', '121.212.121-21', 'faa@gmail.com', '(11)1111-1111', '(11)11111-1111', '2020-05-21', 'F')
go

insert into Usuario(Login_Usuario, Senha_Usuario, Nome_Usuario, Nasc_Usuario, Cpf_Usuario, Email_Usuario, Telefone_Usuario, Celular_Usuario, Admissao_Usuario, Permissao_Usuario)
values ('GR', '111', 'German Augusto', '2000-12-24', '121.212.121-21', 'faa@gmail.com', '(11)1111-1111', '(11)11111-1111', '2020-05-21', 'A')
go

create procedure logarUsuario
@Login_Usuario varchar(20),
@Senha_Usuario varchar(50)
as
begin
select Id_Usuario, Nome_Usuario, Permissao_Usuario
from Usuario
where Login_usuario = @Login_Usuario AND Senha_Usuario = @Senha_Usuario
end
go

create procedure obterUsuarioId
@Id_Usuario int
as
begin
select Id_Usuario, Login_Usuario, Senha_Usuario, Nome_Usuario, Nasc_Usuario, Cpf_Usuario, Email_Usuario, Telefone_Usuario, Celular_Usuario, Admissao_Usuario, Permissao_Usuario
from Usuario
where Id_Usuario = @Id_Usuario
end
go

create procedure listarUsuarios
@Id_Usuario int
as
begin
select Id_Usuario as 'ID', Nome_Usuario as 'Nome', Nasc_Usuario as 'Data de Nascimento', Email_Usuario as 'Email', Telefone_Usuario as 'Telefone', Celular_Usuario as 'Celular', Permissao_Usuario as 'Permissão' from Usuario where Id_Usuario <> @Id_Usuario
end
go

create procedure cadastrarUsuario
@Login_Usuario varchar(20),
@Senha_Usuario varchar(50),
@Nome_Usuario varchar(50),
@Nasc_Usuario date,
@Cpf_Usuario varchar(14),
@Email_Usuario varchar(50),
@Telefone_Usuario varchar(15),
@Celular_Usuario varchar(16),
@Admissao_Usuario varchar(50),
@Permissao_Usuario char(1)
as
begin
insert into Usuario(Login_Usuario, Senha_Usuario, Nome_Usuario, Nasc_Usuario, Cpf_Usuario, Email_Usuario, Telefone_Usuario, Celular_Usuario, Admissao_Usuario, Permissao_Usuario)
values(@Login_Usuario, @Senha_Usuario, @Nome_Usuario, @Nasc_Usuario, @Cpf_Usuario, @Email_Usuario, @Telefone_Usuario, @Celular_Usuario, @Admissao_Usuario, @Permissao_Usuario)
end
go

create procedure editarUsuario
@Id_Usuario int,
@Login_Usuario varchar(20),
@Senha_Usuario varchar(50),
@Nome_Usuario varchar(50),
@Nasc_Usuario date,
@Cpf_Usuario varchar(14),
@Email_Usuario varchar(50),
@Telefone_Usuario varchar(15),
@Celular_Usuario varchar(16),
@Admissao_Usuario date,
@Permissao_Usuario char
as
begin
update Usuario set
Login_Usuario = @Login_Usuario,
Senha_Usuario = @Senha_Usuario,
Nome_Usuario = @Nome_Usuario,
Nasc_Usuario = @Nasc_Usuario,
Cpf_Usuario = @Cpf_Usuario,
Email_Usuario = @Email_Usuario,
Telefone_Usuario = @Telefone_Usuario,
Celular_Usuario = @Celular_Usuario,
Admissao_Usuario = @Admissao_Usuario,
Permissao_Usuario = @Permissao_Usuario
where Id_Usuario = @Id_Usuario
end
go
-----------------------------------------------------------------------------------------------------------------------------------------------

--PROCEDURES DA TABELA FORNECEDOR--

insert into Fornecedor(Nome_Fornecedor, Tele_Fornecedor, Email_Fornecedor)
values ('Ca', '(11)3985-2103', 'das@gmail.com')
go

insert into Fornecedor(Nome_Fornecedor, Tele_Fornecedor, Email_Fornecedor)
values ('Kaz', '(11)3333-2222', 'sas@gmail.com')
go

insert into Fornecedor(Nome_Fornecedor, Tele_Fornecedor, Email_Fornecedor)
values ('Gama', '(27)5685-5512', 'siis@gmail.com')
go

create procedure cadastrarFornecedor
@Nome_Fornecedor varchar(50),
@Tele_Fornecedor varchar(50),
@Email_Fornecedor varchar(20)
as
begin
insert into Fornecedor(Nome_Fornecedor, Tele_Fornecedor, Email_Fornecedor)
values (@Nome_Fornecedor, @Tele_Fornecedor, @Email_Fornecedor)
end
go

create procedure editarFornecedor
@Id_Fornecedor int,
@Nome_Fornecedor varchar(50),
@Tele_Fornecedor varchar(50),
@Email_Fornecedor varchar(20)
as
begin
update Fornecedor
set
Nome_Fornecedor = @Nome_Fornecedor,
Tele_Fornecedor = @Tele_Fornecedor,
Email_Fornecedor = @Email_Fornecedor
where
Id_Fornecedor = @Id_Fornecedor
end
go

create procedure listarFornecedores
as
begin
select Id_Fornecedor as 'ID', Nome_Fornecedor as 'Nome do Fornecedor', Tele_Fornecedor as 'Telefone', Email_Fornecedor as 'Email' from Fornecedor
end
go

create procedure fornecedorId
@Id_Fornecedor int
as
begin
select Id_Fornecedor, Nome_Fornecedor, Tele_Fornecedor, Email_Fornecedor from Fornecedor where Id_Fornecedor = @Id_Fornecedor
end
go
-----------------------------------------------------------------------------------------------------------------------------------------------

--PROCEDURES DA TABELA MEDICAMENTO

insert into Medicamento(Nome_Med, Diluicao_Med, Dose_Med, Armazena_med, Incompa_Med, Infusao_Med, Qtde_Med, Preco_Med, Id_Fornecedor)
values (
'Aciclovir', 
'SF, SG e AD', 
'20mg/kg 8/8h 14dias Supressão 75mg/kg/dose 12/12h', 
'12 horas temp. ambiente', 
'', 
'1h', 
100, 
2.5,
1
)
go

insert into Medicamento(Nome_Med, Diluicao_Med, Dose_Med, Armazena_med, Incompa_Med, Infusao_Med, Qtde_Med, Preco_Med, Id_Fornecedor)
values (
'Amicacina', 
'SF, SG e AD', 
'ver tabela', 
'', 
'', 
'30m', 
100,
4.5,
1
)
go

insert into Medicamento(Nome_Med, Diluicao_Med, Dose_Med, Armazena_med, Incompa_Med, Infusao_Med, Qtde_Med, Preco_Med, Id_Fornecedor)
values (
'Anfotericina B', 
'', 
'0,5 a 1 mg/Kg 24/24h', 
'7 dias refrigeração', 
'SF', 
'2 a 6 h', 
100,
3.5,
2
)
go

insert into Medicamento(Nome_Med, Diluicao_Med, Dose_Med, Armazena_med, Incompa_Med, Infusao_Med, Qtde_Med, Preco_Med, Id_Fornecedor)
values (
'Anfotericina B lipossomal', 
'sg', 
'5mg/kg 24/24h', 
'24 horas refrigeração', 
'sf e npp', 
'2h', 
100,
1.5,
2
)
go

insert into Medicamento(Nome_Med, Diluicao_Med, Dose_Med, Armazena_med, Incompa_Med, Infusao_Med, Qtde_Med, Preco_Med, Id_Fornecedor)
values (
'Ampicilina', 
'ad', 
'25 a 50mg/kg por dose /1oomg para meningite, intervalo ver tabela', 
'10 dias após abertura (VO) 7 dias refrigeracção (IV)', 
'', 
'1h', 
100,
3.2,
3
)
go

insert into Medicamento(Nome_Med, Diluicao_Med, Dose_Med, Armazena_med, Incompa_Med, Infusao_Med, Qtde_Med, Preco_Med, Id_Fornecedor)
values (
'Azitromicina', 
'ad', 
'10mg/kg por dose 1x dia 5 dias', 
'10 dias geladeira', 
'', 
'push lento', 
100,
2,
3
)
go

create procedure cadastrarMedicamento
  @Nome_Med varchar(50), 
  @Diluicao_Med varchar(50),
  @Dose_Med varchar(50) ,
  @Armazena_Med varchar(50),
  @Incompa_Med varchar(50),
  @Infusao_Med varchar(50),
  @Qtde_Med int,
  @Preco_Med float,
  @Id_Fornecedor int
  as
  begin
  insert into Medicamento(Nome_Med, Diluicao_Med, Dose_Med, Armazena_Med, Incompa_Med, Infusao_Med, Qtde_Med, Preco_Med, Id_Fornecedor)
  values (@Nome_Med, @Diluicao_Med, @Dose_Med, @Armazena_Med, @Incompa_Med, @Infusao_Med, @Qtde_Med, @Preco_Med, @Id_Fornecedor)
  end
  go

create procedure alterarMedicamento
  @Id_Med int,
  @Nome_Med varchar(50), 
  @Diluicao_Med varchar(50),
  @Dose_Med varchar(50) ,
  @Armazena_Med varchar(50),
  @Incompa_Med varchar(50),
  @Infusao_Med varchar(50),
  @Qtde_Med int,
  @Preco_Med float,
  @Id_Fornecedor int
  as
  begin
  update Medicamento set 
  Nome_Med = @Nome_Med,
  Diluicao_Med = @Diluicao_Med,
  Dose_Med = @Dose_Med,
  Armazena_Med = @Armazena_Med,
  Incompa_Med = @Incompa_Med,
  Infusao_Med = @Infusao_Med, 
  Qtde_Med = @Qtde_Med,
  Preco_Med = @Preco_Med,
  Id_Fornecedor = @Id_Fornecedor
  where
  Id_Med = @Id_Med
  end
  go

create procedure listarMedicamentos
as
begin
select m.Id_Med as 'ID', m.Nome_Med as 'Nome do Medicamento', m.Diluicao_Med as 'Diluicao', 
m.Dose_Med as 'Dose', m.Armazena_Med as 'Armazenamento', m.Incompa_Med as 'Incompatibilidade', 
m.Infusao_Med as 'Infusão', m.Qtde_Med as 'Quantidade', f.Nome_Fornecedor as 'Fornecedor'
from Medicamento as m
inner join Fornecedor as f
on m.Id_Fornecedor = f.Id_Fornecedor
end
go

create procedure listarMedicamentosParaEncomenda
as
begin
select m.Id_Med, m.Nome_Med, m.Preco_Med, f.Id_Fornecedor, f.Nome_Fornecedor
from Medicamento as m
inner join Fornecedor as f
on m.Id_Fornecedor = f.Id_Fornecedor
end
go

create procedure obterMedicamentoId
@id int
as
begin
select Id_Med, Nome_Med, Diluicao_Med, Dose_Med, Armazena_Med, Incompa_Med, Infusao_Med, Qtde_Med, Preco_Med, Id_Fornecedor
from Medicamento 
where Id_Med = @id
end
go

-----------------------------------------------------------------------------------------------------------------------------------------------

--PROCEDIMENTOS DA TABELA MEDICAMENTORETIRADO--

create procedure retirarMedicamento
@Nome_Med varchar(50),
@Qtde_Reti_Med int,
@Id_Med int,
@Id_Usuario int
as
begin
insert into MedicamentoRetirado (Nome_Med, Qtde_Reti_Med, Id_Med, Id_Usuario)
values (@Nome_Med, @Qtde_Reti_Med, @Id_Med, @Id_Usuario)
update Medicamento set
Qtde_Med = Qtde_Med - @Qtde_Reti_Med
where Id_Med = @Id_Med
end
go

create procedure listarMedicamentosRetirados
@Id_Usuario int
as
begin
select Nome_Med, Qtde_Reti_Med from MedicamentoRetirado where Id_Usuario = @Id_Usuario
end
go
-----------------------------------------------------------------------------------------------------------------------------------------------

--PROCEDIMENTOS DA TABELA ENCOMENDA--

create procedure realizarEncomenda
@Nome_Fornecedor varchar(50),
@Med_Encomenda varchar(50),
@Qtde_Encomenda int,
@Preco_Encomenda varchar(50),
@Data_Encomenda varchar(50),
@Data_Entrega_Encomenda varchar(50),
@N_Lote_Encomenda varchar(50),
@Status_Encomenda varchar(50),
@Id_Usuario int,
@Id_Fornecedor int
as
begin
insert into Encomenda (Nome_Fornecedor, Med_Encomenda, Qtde_Encomenda, Preco_Encomenda, 
Data_Encomenda, Data_Entrega_Encomenda, N_Lote_Encomenda, Status_Encomenda,
Id_Usuario, Id_Fornecedor)
values(@Nome_Fornecedor, @Med_Encomenda, @Qtde_Encomenda, @Preco_Encomenda, 
@Data_Encomenda, @Data_Entrega_Encomenda, @N_Lote_Encomenda, @Status_Encomenda,
@Id_Usuario, @Id_Fornecedor)
end
go