using BoletoBusMaMonolitica.Data.Entities;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.Data.Interfaces
{
    public interface IAsientoDb
    {
        void SaveAsiento (AsientoSaveModel asientoSave);
        void UpdateAsiento(AsientoUpdateModel updateModel);
        void RemoveAsiento(AsientoRemoveModel asientoRemove);
        List<AsientoModel> GetAsientos();
        AsientoModel GetAsiento(int IdAsiento);
    }
}
