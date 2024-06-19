using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Models
{
    public class ViajeSaveModel : ViajeModel
    {
        public ViajeSaveModel()
        {
        }

        public Viaje ToEntity()
        {
            return new Viaje
            {
                IdViaje = this.IdViaje,
                Idbus = this.Idbus,
                IdRuta = this.IdRuta,
                FechaSalida = this.FechaSalida,
                HoraSalida = this.HoraSalida,
                Precio = this.Precio,
                TotalAsientos = this.TotalAsientos,
                AsientosReservados = this.AsientosReservados,
                AsientosDisponibles = this.AsientosDisponibles,
                Completo = this.Completo, 
            };
        }
    }
}