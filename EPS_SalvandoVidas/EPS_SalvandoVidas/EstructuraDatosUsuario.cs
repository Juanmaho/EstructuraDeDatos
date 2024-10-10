using System;

namespace EPS_SalvandoVidas
{
    public class EstructuraDatosUsuario
    {
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
        public int Estrato { get; set; }
        public string TipoAtencion { get; set; }
        public decimal Copago { get; set; }
        public DateTime FechaRegistro { get; set; }
        public EstructuraDatosUsuario(string tipoIdentificacion, string numeroIdentificacion, string nombreCompleto, int edad, int estrato, string tipoAtencion, DateTime fechaRegistro)
        {
            TipoIdentificacion = tipoIdentificacion;
            NumeroIdentificacion = numeroIdentificacion;
            NombreCompleto = nombreCompleto;
            Edad = edad;
            Estrato = estrato;
            TipoAtencion = tipoAtencion;
            Copago = CalcularCopago(estrato, tipoAtencion);
            FechaRegistro = fechaRegistro;
        }
        public decimal CalcularCopago(int estrato, string tipoAtencion)
        {
            decimal copago = 0;

            if (tipoAtencion == "Medicina General")
            {
                switch (estrato)
                {
                    case 1:
                    case 2:
                        copago = 0;
                        break;
                    case 3:
                        copago = 10000;
                        break;
                    case 4:
                        copago = 15000;
                        break;
                    case 5:
                        copago = 20000;
                        break;
                    case 6:
                        copago = 30000;
                        break;
                }
            }
            else if (tipoAtencion == "Exámenes de Laboratorio")
            {
                switch (estrato)
                {
                    case 1:
                    case 2:
                    case 3:
                        copago = 0;
                        break;
                    case 4:
                        copago = 5000;
                        break;
                    case 5:
                        copago = 10000;
                        break;
                    case 6:
                        copago = 20000;
                        break;
                }
            }

            return copago;
        }
    }
}
