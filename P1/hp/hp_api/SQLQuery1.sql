CREATE TABLE hp_personagens (
    id INT IDENTITY (1, 1) NOT NULL,
    nome VARCHAR (30) NOT NULL,
    especie VARCHAR (10) NULL,
    casa VARCHAR (20) NULL,
    ator VARCHAR (30) NULL,
    imagem VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);
Insert into hp_personagens (nome,especie,casa,ator,imagem) values ('Harry Potter','human','Gryffindor','Daniel Radcliffe','harry.jpg');
Insert into hp_personagens (nome,especie,casa,ator,imagem) values ('Hermione Granger','human','Gryffindor','Emma Watson','hermione.jpg');
Insert into hp_personagens (nome,especie,casa,ator,imagem) values ('Ron Weasley','human','Gryffindor','Rupert Grint','ron.jpg');
Insert into hp_personagens (nome,especie,casa,ator,imagem) values ('Draco Malfoy','human','Slytherin','Tom Felton','draco.jpg');
Insert into hp_personagens (nome,especie,casa,ator,imagem) values ('Minerva McGonagall','human','Gryffindor','Dame Maggie Smith','minerva.jpg');
Insert into hp_personagens (nome,especie,casa,ator,imagem) values ('Cedric Diggory','human','Hufflepuff','Robert Pattinson','cedric.jpg');
Insert into hp_personagens (nome,especie,casa,ator,imagem) values ('Severus Snape','human','Slytherin','Alan Rickman','severus.jpg');
Insert into hp_personagens (nome,especie,casa,ator,imagem) values ('Rubeus Hagrid','half-giant','Gryffindor','Robbie Coltrane','hagrid.jpg');

select * from hp_personagens

drop table hp_personagens