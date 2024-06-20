using BoletoBusMaMonolitica.Data.Entities;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.Data.Interfaces
{
    public interface IAsientoDb
    {
        void SaveAsiento (AsientoSaveModel asientoSave);
        void UpdateAsiento(AsientoUpdateModel updateModel);
        void RemoveAsiento(AsientoRemoveModel asientoRemove);
        List<AsientoGetModel> GetAsientos();
        AsientoGetModel GetAsiento(int IdAsiento);
    }
}
