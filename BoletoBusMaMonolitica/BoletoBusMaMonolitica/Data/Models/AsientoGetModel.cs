using BoletoBusMaMonolitica.Data.Entities;

    namespace BoletoBusMaMonolitica.Data.Models
    {
        public class AsientoGetModel : AsientoBaseModel
            {
                public static AsientoGetModel FromEntity(Asiento asiento)
                {
                    return new AsientoGetModel
                    {
                        IdAsiento = asiento.IdAsiento,
                        IdBus = asiento.IdBus,
                        NumeroPiso = asiento.NumeroPiso,
                        NumeroAsiento = asiento.NumeroAsiento,
                        FechaCreacion = asiento.FechaCreacion
                    };
                }
            }
    }
    
