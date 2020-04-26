using BNPP.Domain.Interfaces.Repositories;
using BNPP.Domain.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BNPP.Domain.Repositories
{
    internal class ManualMovementsRepository : BaseRepository, IManualMovementsRepository
    {
        public List<ManualMovement> GetAllManualMovements()
        {
            using (var cnn = new SqlConnection(GetConnectionString()))
            {
                cnn.Open();
                List<ManualMovement> result = cnn.Query<ManualMovement>("[GetAllManualMovements]",commandType: System.Data.CommandType.StoredProcedure).ToList();

                return result;
            }
        }

        public int GetAllManualMovementsCount()
        {
            using (var cnn = new SqlConnection(GetConnectionString()))
            {
                cnn.Open();
                int result = cnn.QuerySingle<int>(
                    @"
                    SELECT COUNT(0) FROM [MOVIMENTO_MANUAL] 
                    ");

                return result;
            }
        }
        public void InsertManualMovement(ManualMovement manualMovement)
        {
            using (var cnn = new SqlConnection(GetConnectionString()))
            {
                cnn.Open();
                cnn.Execute(
                    @"
                    INSERT INTO [MOVIMENTO_MANUAL]
                               ([DAT_MES]
                               ,[DAT_ANO]
                               ,[NUM_LANCAMENTO]
                               ,[COD_PRODUTO]
                               ,[COD_COSIF]
                               ,[VAL_VALOR]
                               ,[DES_DESCRICAO]
                               ,[COD_USUARIO])
                         VALUES
                               (@Dat_Mes
                               ,@Dat_Ano
                               ,@Num_Lancamento
                               ,@Cod_Produto
                               ,@Cod_Cosif
                               ,@Val_Valor
                               ,@Des_Descricao
                               ,@Cod_Usuario
                               );
                    ",
                    new
                    {
                        manualMovement.Dat_Mes,
                        manualMovement.Dat_Ano,
                        manualMovement.Num_Lancamento,
                        manualMovement.Cod_Produto,
                        manualMovement.Cod_Cosif,
                        manualMovement.Val_Valor,
                        manualMovement.Des_Descricao,
                        manualMovement.Cod_Usuario
                    });
            }
        }
    }
}
