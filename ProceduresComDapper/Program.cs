using System.Data;
using System.Data.SqlClient;
using Dapper;

using (IDbConnection db = new SqlConnection("Server=localhost; Database=Sales; User Id=sa; Password=Corinthians"))
{
    const int id = 1;

    // Executa a procedure e passa os parâmetro id e data_pagamento que ela espera receber
    db.Execute("spMarcarBoletoComoPago", new { id, data_pagamento = DateTime.Now }, commandType: CommandType.StoredProcedure);
}

Console.WriteLine("Boleto marcado como pago.");