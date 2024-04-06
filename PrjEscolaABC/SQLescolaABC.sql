--create table Aluno(
--idAluno int identity (1,1),
--nomeAluno varchar (60),
--dataDeNascimentoAluno date,
--cpfAluno char(11),
--celularAluno char(11),
--enderecoAluno varchar(60),
--emailAluno varchar(60)
--constraint pk_Aluno primary key (idAluno)
--)

--create table Funcionario (
--idFuncionario int identity (1,1),
--nomeFuncionario varchar (50),
--dataDeNascimentoFuncionario date,
--cpfFuncionario char(11),
--celularFuncionario char(11),
--enderecoFuncionario varchar(60),
--emailFuncionario varchar(50),
--senhaFuncionario varchar(30),
--tipoFuncionario varchar(20),
--constraint pk_Funcionario primary key (idFuncionario)
--)

--create table Curso(
--idCurso int identity(1,1),
--nomeProfessor varchar(50) not null,
--PeriodoCurso date not null,
--PeriodoCurso2 date not null,
--horarioCurso time not null,
--salaCurso int not null,
--idiomaCurso varchar (50) not null,
--valorCurso decimal not null
--constraint pk_Curso primary key (idCurso)
--)

--create table Matricula(
--idMatricula int identity(1,1),
--idAluno int not null,
--idCurso int not null
--constraint pk_Matricula primary key(idMatricula),
--constraint fk_Matricula_Aluno foreign key (idAluno) references Aluno (idAluno),
--constraint fk_Matricula_Curso foreign key (idCurso) references Curso (idCurso)
--)

--drop table Matricula
--drop procedure pi_Matricula

--create procedure pi_Matricula(
--@idAluno int,
--@idCurso int 
--)
--as
--insert into Matricula
--(idAluno, idCurso)
--values
--(@idAluno, @idCurso)

--constraint fk_Matricula_Curso foreign key (idCurso) references Curso (idCurso) 

CREATE PROCEDURE ps_Matricula
@nomeAluno varchar (60)
as
select nomeAluno, Aluno.idAluno, idTurma, Curso.idCurso from Turma
inner join Aluno
on Turma.idAluno = Aluno.idAluno
inner join Curso
on Turma.idCurso = Curso.idCurso
where nomeAluno LIKE @nomeAluno +'%'
order by nomeAluno asc

--CREATE PROCEDURE pd_Matricula
--@idMatricula int
--as
--delete from Matricula
--where idMatricula = @idMatricula

drop procedure pd_Matricula

drop procedure ps_Matricula

--------CREATE PROCEDURE pd_Matricula
--------@idAluno int
--------as
--------delete from Matricula
--------where idAluno = @idAluno

drop procedure pd_Matricula

select*from Funcionario
select*from matricula
select*from Funcionario
select * from Aluno
select * from Curso



select nomeAluno, idMatricula, idTurma, idiomaCurso from Turma
inner join idMatricula
on Turma.idMatricula = Matricula.idMatricula
inner join idCurso
on Turma.idCurso = Curso.idCurso
inner join idAluno
on Turma.idAluno = Aluno.idAluno
order by nomeAluno asc

drop table Curso
drop table Cadastro
drop table Aluno
drop table Funcionario
drop table Matricula


--create procedure ps_Acessar
--(
--	@emailFuncionario	varchar(60),
--	@senhaFuncionario  varchar(30)
--)
--as
--select*from Cadastro
--where emailFuncionario=@emailFuncionario and
--senhaFuncionario=@senhaFuncionario

--drop procedure ps_Acessar


--create procedure pi_Aluno(
--@nomeAluno varchar (50),
--@dataDeNascimentoAluno date,
--@cpfAluno char(11),
--@celularAluno char(11),
--@enderecoAluno varchar(60),
--@emailAluno varchar(60)
--)
--as
--insert into Aluno
--(nomeAluno,dataDeNascimentoAluno,cpfAluno,celularAluno,enderecoAluno,emailAluno)
--values
--(@nomeAluno,@dataDeNascimentoAluno,@cpfAluno,@celularAluno,@enderecoAluno,@emailAluno)

--drop procedure pi_Aluno


--create procedure pi_Funcionario (
--@nomeFuncionario varchar (50),
--@dataDeNascimentoFuncionario date,
--@cpfFuncionario char(11),
--@celularFuncionario char(11),
--@enderecoFuncionario varchar(60),
--@emailFuncionario varchar(50),
--@senhaFuncionario varchar(30),
--@tipoFuncionario varchar(20)
--)
--as
--insert into Funcionario
--(nomeFuncionario,dataDeNascimentoFuncionario,cpfFuncionario,celularFuncionario,enderecoFuncionario,emailFuncionario,senhaFuncionario,tipoFuncionario) 
--values
--(@nomeFuncionario,@dataDeNascimentoFuncionario,@cpfFuncionario,@celularFuncionario,@enderecoFuncionario,@emailFuncionario,@senhaFuncionario,@tipoFuncionario) 

--create procedure pi_Curso(
--@nomeProfessor varchar(50),
--@PeriodoCurso date,
--@PeriodoCurso2 date,
--@horarioCurso time,
--@salaCurso int,
--@idiomaCurso varchar (50),
--@valorCurso decimal
--)
--as
--insert into Curso
--(nomeProfessor, PeriodoCurso,PeriodoCurso2, horarioCurso, salaCurso, idiomaCurso, valorCurso)
--Values
--(@nomeProfessor, @PeriodoCurso, @PeriodoCurso2, @horarioCurso, @salaCurso, @idiomaCurso, @valorCurso)

----drop procedure pi_Curso

select*from Curso

select*from Matricula

select*from Funcionario

select * from Aluno

select*from Aluno

--create procedure ps_Aluno
--(
--@cpfAluno char(11) =NULL
--)
--as
--	if(@cpfAluno is Null)
--	select*from Aluno

--create procedure ps_Aluno2
--(
--@idAluno int =NULL
--)
--as
--select idAluno
--from Aluno

drop procedure ps_Aluno2

--Select*from Aluno 

--Select idAluno 
--from Aluno 

--Where cpfAluno=@cpfAluno

--create procedure ps_Funcionario
--(
--	@cpfFuncionario	char(11)
--)
--as
--select nomeFuncionario as 'Nome do Funcionario',
--       dataDeNascimentoFuncionario as 'Data de Nascimento',
--	   cpfFuncionario as 'CPF do Aluno',
--	   celularFuncionario as 'Celular',
--	   enderecoFuncionario as 'Endereço',
--	   emailFuncionario as 'Email',
--	   senhaFuncionario as 'Senha',
--	   tipoFuncionario as 'Cargo/Função'
--from Funcionario
--where cpfFuncionario=@cpfFuncionario

--drop procedure ps_Funcionario

--CREATE PROCEDURE pd_Aluno
--(
--@cpfAluno varchar (60)
--)
--as
--delete from Aluno
--where cpfAluno = @cpfAluno

drop procedure pd_Aluno

--create procedure pu_Aluno
--@nomeAluno varchar (60),
--@dataDeNascimentoAluno date,
--@cpfAluno char(11),
--@celularAluno char(11),
--@enderecoAluno varchar(60),
--@emailAluno varchar(60),
--@cpfAlunoBusca char(11)
--as
--update Aluno
--set
--nomeAluno=@nomeAluno,
--dataDeNascimentoAluno=@dataDeNascimentoAluno,
--cpfAluno=@cpfAluno,
--celularAluno=@celularAluno,
--enderecoAluno=@enderecoAluno,
--emailAluno=@emailAluno
--where cpfAluno=@cpfAlunoBusca

----drop procedure pu_Aluno

--create procedure ps_LoginFuncionario
--(
--@emailFuncionario varchar(50),
--@senhaFuncionario varchar(30)
--)
--as
--select*from Funcionario
--where emailFuncionario = @emailFuncionario and
--senhaFuncionario = @senhaFuncionario

select * from funcionario
select * from Aluno
select * from Turma
select * from curso
select * from Matricula
--insert into Funcionario
--(nomeFuncionario,dataDeNascimentoFuncionario,cpfFuncionario,celularFuncionario,enderecoFuncionario,emailFuncionario,senhaFuncionario,tipoFuncionario) 
--values
--('Guilherme','2002/09/24','99988855500','13512345678','rua r6','123','123','administrador') 

delete from Funcionario
where idFuncionario=5

--create procedure ps_LoginFuncionario
--(
--@emailFuncionario varchar(50),
--@senhaFuncionario varchar(30)
--)
--as
--select*from Funcionario
--where emailFuncionario = @emailFuncionario and
--senhaFuncionario = @senhaFuncionario

--create procedure pu_Funcionario(
--@nomeFuncionario varchar (50),
--@dataDeNascimentoFuncionario date,
--@cpfFuncionario char(11),
--@celularFuncionario char(11),
--@enderecoFuncionario varchar(60),
--@emailFuncionario varchar(50),
--@senhaFuncionario varchar(30),
--@tipoFuncionario varchar(20),
--@cpfFuncionarioBusca char(11)
--)
--as
--update Funcionario
--set
--nomeFuncionario=@nomeFuncionario,
--dataDeNascimentoFuncionario=@dataDeNascimentoFuncionario, 
--cpfFuncionario=@cpfFuncionario,
--celularFuncionario=@celularFuncionario,
--enderecoFuncionario=@enderecoFuncionario, 
--emailFuncionario=@emailFuncionario,
--senhaFuncionario=@senhaFuncionario,
--tipoFuncionario=@tipoFuncionario 
--where cpfFuncionario=@cpfFuncionarioBusca

--CREATE PROCEDURE pd_Funcionario
--(
--@cpfFuncionario char (11)
--)
--as
--delete from Funcionario
--where cpfFuncionario = @cpfFuncionario

--create procedure ps_Funcionario
--(
--@cpfFuncionario char(11) =NULL
--)
--as
--	if(@cpfFuncionario is Null)
--	select*from Funcionario

--Select*from Funcionario 
--Where cpfFuncionario=@cpfFuncionario

create procedure ps_Turma
(
@nomeAluno varchar (60)
)
as
select nomeAluno, Aluno.idAluno, Curso.idiomaCurso from Turma 
inner join Curso 
on Turma.idCurso = Curso.idCurso
inner join Aluno 
on Turma.idAluno = Aluno.idAluno
where nomeAluno LIKE @nomeAluno + '%'
order by nomeAluno asc

drop procedure ps_Turma

--CREATE TABLE Turma(
--idTurma int identity (1,1),
--idAluno int not null,
--idCurso int not null
--constraint pk_Turma primary key(idTurma),
--constraint fk_Turma_Aluno foreign key (idAluno) references Aluno (idAluno),
--constraint fk_Turma_Curso foreign key (idCurso) references Curso (idCurso)
--)

CREATE PROCEDURE pd_Turma
(
@idAluno int
)
as
delete from Turma
where idAluno = @idAluno

drop procedure pd_Turma

--CREATE PROCEDURE pi_Turma
--@idAluno int,
--@idCurso int
--as
--insert into Turma
--(idAluno, idCurso)
--values
--(@idAluno, @idCurso)

--CREATE PROCEDURE pi_ControleTurma
--(
--@idAluno int,
--@idCurso int
--)
--AS
--BEGIN
--DECLARE @quantidade INT
--DECLARE @limite INT = 11
--SELECT @quantidade = COUNT(Aluno.idAluno)
--FROM Aluno
--inner join matricula
--on matricula.idAluno = Aluno.idAluno
--IF (@quantidade < @limite)
--BEGIN
--insert into matricula (idAluno, idCurso)
--values (@idAluno, @idCurso)
--END
--END

exec pd_Matricula 1
select*from Matricula