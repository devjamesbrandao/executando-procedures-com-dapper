using System.Data;
using System.Data.SqlClient;
using Dapper;

using (IDbConnection db = new SqlConnection("CONNECTION STRING"))
{
    const int id = 1;

    // Executa a procedure e passa os parâmetro id e data_pagamento que ela espera receber
    db.Execute(
        "spMarcarBoletoComoPago", // nome da procedure
        new { id, data_pagamento = DateTime.Now }, // parâmetros que a procedure espera
        commandType: CommandType.StoredProcedure // tipo de comando Procedure
    );
}

Console.WriteLine("Boleto marcado como pago.");