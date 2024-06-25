using BoletoBusMaMonolitica.BL.Core;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.BL.Interfaces
{
    public interface IBusService
    {
        ServiceResult GetBuses();
        ServiceResult GetBus(int id);
        ServiceResult UpdateBuses(BusUpdateModel busUpdate);
        ServiceResult RemoveBuses(BusRemoveModel busRemove);
        ServiceResult SaveBus (BusSaveModel busAdd);
    }
}
