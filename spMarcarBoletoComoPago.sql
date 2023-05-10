CREATE PROCEDURE spMarcarBoletoComoPago @id INT, @data_pagamento DATETIME
AS

SET NOCOUNT ON

UPDATE tb_Boletos SET status_pagamento = 1, data_pagamento = @data_pagamento WHERE id = @id;