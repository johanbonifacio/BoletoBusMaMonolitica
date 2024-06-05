using BoletoBusMaMonolitica.Data.Entities;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.Data.Interfaces
{
    public interface IRutaDB
    {
        void SaveRuta(RutaSaveModel rutaSave);
        void UpdateRuta(RutaUpdateModel updateModel);
        void RemoveRuta(RutaRemoveModel rutaRemove);
        List<RutaModel> GetRutas();
        RutaModel GetRuta(int IdRuta);
    }
}