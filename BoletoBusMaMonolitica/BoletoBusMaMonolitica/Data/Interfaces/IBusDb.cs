using BoletoBusMaMonolitica.Data.Entities;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.Data.Interfaces
{
    public interface IBusDb
    {
        void SaveBus (BusSaveModel bus);
        void UpdateBus (BusUpdateModel updateModel);
        void RemoveBus(BusRemoveModel busRemove);
        List<BusModel> GetBuses();  
        BusModel GetBus(int IdBus);
    }
}
