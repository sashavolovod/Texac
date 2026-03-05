using System.Threading.Tasks;
using Texac.Ekon.Inventory;
using Texac.Net;

namespace Texac.Services
{
    public class InventoryService
    {
        private readonly TexacApiClient _api;

        public InventoryService()
        {
            _api = TexacApi.Client;
        }

        public Task<InventoryEntity> GetByIdAsync(int inventoryId)
        {
            return _api.GetAsync<InventoryEntity>("/api/inventory_entities/" + inventoryId);
        }

        public Task<InventoryEntity> SaveAsync(InventoryEntity inventory)
        {
            if (inventory.inventoryEntityId == 0)
                return _api.PostAsync<InventoryEntity, InventoryEntity>("/api/inventory_entities", inventory);

            return _api.PutAsync<InventoryEntity, InventoryEntity>(
                "/api/inventory_entities/" + inventory.inventoryEntityId, inventory);
        }
    }
}