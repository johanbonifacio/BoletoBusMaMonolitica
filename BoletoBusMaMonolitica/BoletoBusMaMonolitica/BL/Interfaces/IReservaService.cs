
using BoletoBusMaMonolitica.BL.Core;
using BoletoBusMaMonolitica.Data.Models;

namespace BoletoBusMaMonolitica.BL.Interfaces
{
    public interface IReservaService
    {


        ServiceResult GetReservas();
        ServiceResult GetReserva(int id);
        ServiceResult UpdateReserva(ReservaUpdateModel reservaUpdate);
        ServiceResult RemoveReserva(ReservaRemoveModel reservaRemove);
        ServiceResult SaveReserva(ReservaSaveModel reservaAdd);
    }
}
