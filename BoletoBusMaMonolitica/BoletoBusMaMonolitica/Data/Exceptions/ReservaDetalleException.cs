namespace BoletoBusMaMonolitica.Data.Exceptions
{
    public static class ReservaDetalleException
    {
        public static void VerifyExistence(object entity, int id)
        {
            if (entity == null)
            {
                throw new Exception($"ReservaDetalle with ID {id} does not exist.");
            }
        }
    }
}
