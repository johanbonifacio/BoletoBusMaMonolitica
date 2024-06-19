using BoletoBusMaMonolitica.Data.Entities;
using BoletoBusMaMonolitica.Data.Models;

using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Interfaces
{
    public interface IViajesDb
    {
        void SaveViaje(ViajeSaveModel viaje);
        void UpdateViaje(ViajeUpdateModel updateModel);
        void RemoveViaje(ViajeRemoveModel viajeRemove);
        List<ViajeModel> GetViajes();
        ViajeModel GetViaje(int IdViaje);
    }
}
