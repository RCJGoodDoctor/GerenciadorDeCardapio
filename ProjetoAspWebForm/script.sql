DROP SCHEMA IF EXISTS avaliacao_4bim_2n;
CREATE SCHEMA avaliacao_4bim_2n;
USE avaliacao_4bim_2n;

CREATE TABLE salada 
(
  cd_salada INT,
  nm_salada VARCHAR(100),
  CONSTRAINT pk_salada PRIMARY KEY (cd_salada)
);


CREATE TABLE proteina 
(
  cd_proteina INT,
  nm_proteina VARCHAR(45),
  CONSTRAINT pk_proteina PRIMARY KEY (cd_proteina)
);


CREATE TABLE acompanhamento 
(
  cd_acompanhamento INT,
  nm_acompanhamento VARCHAR(100),
  CONSTRAINT pk_acompanhamento PRIMARY KEY (cd_acompanhamento)
);

CREATE TABLE prato 
(
  cd_prato INT,
  cd_proteina INT,
  nm_detalhe VARCHAR(100),
  cd_acompanhamento INT,  
  cd_salada INT,
  CONSTRAINT pk_prato PRIMARY KEY (cd_prato),
  CONSTRAINT fk_prato_salada FOREIGN KEY (cd_salada)
    REFERENCES salada (cd_salada),
  CONSTRAINT fk_prato_proteina FOREIGN KEY (cd_proteina)
    REFERENCES proteina (cd_proteina),
  CONSTRAINT fk_prato_acompanhamento FOREIGN KEY (cd_acompanhamento)
    REFERENCES acompanhamento (cd_acompanhamento)
);

CREATE TABLE cardapio 
(
  dt_cardapio DATE,
  cd_prato INT,
  CONSTRAINT pk_cardapio PRIMARY KEY (dt_cardapio, cd_prato),
  CONSTRAINT fk_cardapio_prato FOREIGN KEY (cd_prato)
    REFERENCES prato (cd_prato)
);

Insert into salada values (1,'Salada de Alface e Tomate');
Insert into salada values (2,'Salada de Pepino');
Insert into salada values (3,'Salada de Cenoura');
Insert into salada values (4,'Repolho Refogado');

Insert into proteina values (1, 'Ovo');
Insert into proteina values (2, 'Carne');
Insert into proteina values (3, 'Frango');
Insert into proteina values (4, 'Peixe');
Insert into proteina values (5, 'Suíno');

Insert into acompanhamento values (1,'Arroz e Feijão');
Insert into acompanhamento values (2,'Arroz e Feijão Preto');
Insert into acompanhamento values (3,'Arroz à Grega');
Insert into acompanhamento values (4,'Macarrão com Molho de Tomate');
Insert into acompanhamento values (5,'Macarrão com Molho Branco');
Insert into acompanhamento values (6,'Arroz com Brócolis');

Insert into prato values (1, 1, 'Mexidos', 1, 1);
Insert into prato values (2, 2, 'Patinho em Iscas', 2, 4);
Insert into prato values (3, 3, 'Sobrecoxa Cozida', 3, 2);

Insert into cardapio values ('2023-12-07', 1);
Insert into cardapio values ('2023-12-08', 3);
Insert into cardapio values ('2023-12-11', 2);