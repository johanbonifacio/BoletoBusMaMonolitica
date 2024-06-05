namespace BoletoBusMaMonolitica.Data.Core
{
    public abstract class BaseEntity
    {
        protected BaseEntity() 
        {
            this.FechaCreacion = DateTime.Now;
        }
        public DateTime FechaCreacion { get; set; }
        public int IdReserva { get; set; }

        public int IdViaje { get; set; }

        public int IdPasajero { get; set; }

        public int AsientosReservados { get; set; }

        public decimal MontoTotal { get; set; }

        


    }
}
