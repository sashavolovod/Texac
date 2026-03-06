using System.Collections.Generic;
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

        public Task<InventoryEntity> GetByIdAsync(long inventoryId)
        {
            return _api.GetAsync<InventoryEntity>("/api/inventory_entities/" + inventoryId);
        }

        public Task<List<InventoryEntity>> GetListAsync()
        {
            return _api.GetAsync<List<InventoryEntity>>("/api/inventory_entities");
        }

        public Task<InventoryEntity> SaveAsync(InventoryEntity inventory)
        {
            if (inventory.inventoryEntityId == 0)
                return _api.PostAsync<InventoryEntity, InventoryEntity>("/api/inventory_entities", inventory);

            return _api.PutAsync<InventoryEntity, InventoryEntity>(
                "/api/inventory_entities/" + inventory.inventoryEntityId, inventory);
        }

        public Task DeleteAsync(long inventoryId)
        {
            return _api.DeleteAsync("/api/inventory_entities/" + inventoryId);
        }
    }
}