CREATE DATABASE Sales;

USE Sales;
GO

CREATE TABLE tb_Boletos (
    id INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    nome_pagador VARCHAR(MAX) NOT NULL,
    linha_digitavel VARCHAR(MAX) NOT NULL,
    valor DECIMAL(19,2) NOT NULL,
    data_criacao DATETIME NOT NULL,
    data_pagamento DATETIME,
    status_pagamento INT NOT NULL
)

INSERT INTO tb_Boletos VALUES('LUIS', '123213123122131223123232', 3000.99, GETDATE(), NULL, 0);