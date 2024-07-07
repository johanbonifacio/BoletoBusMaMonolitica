using BoletoBusMaMonolitica.Data.Models.Rut;
using System.Collections.Generic;

namespace BoletoBusMaMonolitica.Data.Interfaces
{
    public interface IRutaDB
    {
        void SaveRuta(RutaSaveModel rutaSave);
        void UpdateRuta(RutaUpdateModel updateModel);
        void RemoveRuta(RutaRemoveModel rutaRemove);
        List<RutaGetModel> GetRutas();
        RutaGetModel GetRuta(int IdRuta);
    }
}