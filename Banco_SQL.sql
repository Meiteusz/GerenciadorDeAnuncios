create table Anuncios(
Id int primary key identity not null,
Nome varchar(250) not null,
Cliente varchar(80) not null,
Data_Inicio smalldatetime not null,
Data_Termino smalldatetime not null,
Investimento_Dia float(53) not null
);

create table Relatorios(
Id int primary key identity not null,
Anuncio_Id int not null,
Valor_Total_Investido float(53) not null,
Qtd_Maxima_Visualizacoes int not null,
Qtd_Maxima_Cliques int not null,
Qtd_Maxima_Compartilhamentos int not null,

Constraint FK_Anuncio_Relatorios foreign key (Anuncio_Id) references Anuncios(Id)
);