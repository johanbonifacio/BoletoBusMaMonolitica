using BoletoBusMaMonolitica.Data.Entities;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.Data.Interfaces
{
    public interface IReservaDb
    {
        void SaveReserva (ReservaSaveModel reservaSave);
        void UpdateReserva (ReservaUpdateModel updateModel);

        void RemoveReserva(ReservaRemoveModel reservaRemove);
        List<ReservaModel>  GetReservas ();
        ReservaModel GetReservas (int IdReserva);
    }
}
