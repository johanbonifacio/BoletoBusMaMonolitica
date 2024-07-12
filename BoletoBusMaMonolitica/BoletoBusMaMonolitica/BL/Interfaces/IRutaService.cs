using BoletoBusMaMonolitica.BL.Core;
using BoletoBusMaMonolitica.Data.Models.Rut;

namespace BoletoBusMaMonolitica.BL.Interfaces
{
    public interface IRutaService
    {
       ServiceResult GetRutas();

        ServiceResult GetRutas(int id); 
        ServiceResult UpdateRutas(RutaUpdateModel rutaUpdate);

        ServiceResult RemoveRutas(RutaRemoveModel rutaRemove);

        ServiceResult SaveRutas(RutaSaveModel rutaAdd);

    }
}
