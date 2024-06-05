﻿using BoletoBusMaMonolitica.Data.Entities;

namespace BoletoBusMaMonolitica.Data.Exceptions
{
    public class AsientoException : Exception
    {
        public AsientoException(string message) : base(message)
        {
        }
        public static void VerifyExistence(Asiento asiento, int idAsiento)
        {
            if (asiento == null)
            {
                throw new AsientoException($"El asiento con la id {idAsiento} no está registrado.");
            }
        }
    }
}

