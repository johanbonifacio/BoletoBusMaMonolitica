using BoletoBusMaMonolitica.BL.Core;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.BL.Interfaces
{
    public interface IAsientoService
    {
        ServiceResult GetAsientos();
        ServiceResult GetAsiento(int id);
        ServiceResult UpdateAsiento(AsientoUpdateModel asientoUpdate);
        ServiceResult RemoveAsiento(AsientoRemoveModel asientoRemove);
        ServiceResult SaveAsiento(AsientoSaveModel asientoAdd);
    }
}

