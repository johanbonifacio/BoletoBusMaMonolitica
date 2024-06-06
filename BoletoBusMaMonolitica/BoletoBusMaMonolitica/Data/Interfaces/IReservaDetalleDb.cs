using BoletoBusMaMonolitica.Data.Entities;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.Data.Interfaces
{
    public interface IReservaDetalleDb
    {
        void SaveReservaDetalle(ReservaDetalleSaveModel reservaDetalleSave);
        void UpdateReservaDetalle(ReservaDetalleUpdateModel updateModel);
        void RemoveReservaDetalle(ReservaDetalleRemoveModel reservaDetalleRemove);
        List<ReservaDetalleModel> GetReservaDetalles();
        ReservaDetalleModel GetReservaDetalle(int IdReservaDetalle);
    }
}
