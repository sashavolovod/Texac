using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace Texac.PreparatorySection
{
    public static class DbHelper
    {
        public static List<MaterialOrderGridRow> GetMaterialData(List<int> requirementIds)
        {
            var result = new List<MaterialOrderGridRow>();
            if (requirementIds == null || requirementIds.Count == 0)
                return result;

            string ids = string.Join(",", requirementIds);

            string query = $@"
SELECT tblTrebovanie.TrebovanieId AS RequirementId,
       tblTrebovanie.Sclad AS WarehouseId,
       tblTrebovanieDetails.ASUPCODE AS MaterialId,
       tblTrebovanieDetails.Material AS MaterialName,
       tblTrebovanieDetails.Ed AS UnitName,
       tblTrebovanie.DocNumber AS RequirementNumber,
       tblTrebovanie.DocDate AS RequirementDate,
       tblTrebovanieDetails.OrderId,
       tblTrebovanieDetails.Kol1 AS TotalRequested
FROM tblTrebovanie
INNER JOIN tblTrebovanieDetails 
    ON tblTrebovanie.TrebovanieId = tblTrebovanieDetails.tblTrebovanielId
WHERE tblTrebovanie.TrebovanieId IN ({ids})
ORDER BY tblTrebovanie.TrebovanieId";

            using (var connection = new OleDbConnection(Texac.Properties.Settings.Default.connStr))
            using (var command = new OleDbCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    // ключ: MaterialId, чтобы сгруппировать все заказы одного материала
                    var materialDict = new Dictionary<int, MaterialOrderGridRow>();

                    while (reader.Read())
                    {
                        int materialId = reader.GetInt32(reader.GetOrdinal("MaterialId"));

                        // создаём материал, если ещё нет
                        if (!materialDict.ContainsKey(materialId))
                        {
                            var material = new MaterialOrderGridRow
                            {
                                MaterialId = materialId,
                                MaterialName = reader["MaterialName"].ToString(),
                                UnitName = reader["UnitName"].ToString(),
                                WarehouseId = Convert.ToInt32(reader["WarehouseId"]),
                                TotalRequested = 0,
                                TotalReceived = 0
                            };
                            materialDict[materialId] = material;
                        }

                        var currentMaterial = materialDict[materialId];

                        // создаём заказ
                        var order = new OrderMaterialInfo
                        {
                            OrderId = reader["OrderId"] != DBNull.Value ? (int?)Convert.ToInt32(reader["OrderId"]) : null,
                            OrderNumber = reader["OrderId"] != DBNull.Value ? Convert.ToInt32(reader["OrderId"]) : 0,
                            RequirementId = Convert.ToInt32(reader["RequirementId"]),
                            RequirementNumber = Convert.ToInt32(reader["RequirementNumber"]),
                            RequirementDate = Convert.ToDateTime(reader["RequirementDate"]),
                            RequestedQuantity = Convert.ToDouble(reader["TotalRequested"]),
                            ReceivedQuantity = 0  // пока считаем, что ничего не получено
                        };

                        currentMaterial.Orders[order.OrderNumber] = order;

                        // обновляем итоги по материалу
                        currentMaterial.TotalRequested += order.RequestedQuantity;
                    }

                    // добавляем все материалы в результат
                    result.AddRange(materialDict.Values);
                }
            }

            return result;
        }
    }
}
