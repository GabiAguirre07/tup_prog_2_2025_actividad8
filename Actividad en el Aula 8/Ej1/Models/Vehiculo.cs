using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ej1.Models
{
    class Vehiculo : IExportable
    {
        public string Patente { get; set; }
        
        public double Importe { get; set; }
        public Vehiculo() { }
        public Vehiculo(string patente, double importe)
        {
            Match match = Regex.Match(patente, @"^[A-Z]{2}\s?[0-9]{3}\s?[A-Z]{2}$");
            if (match.Success) { Patente = patente; }
            else { throw new PatenteNoValidaException(); }
            Importe = importe;
        }
        public void Importar(string cadena)
        {
            cadena = cadena.Trim();
            string[] separador = cadena.Split(";");
            string patente = separador[0];
            Match match = Regex.Match(patente, @"^[A-Z]{2}\s?[0-9]{3}\s?[A-Z]{2}$");
            Importe = Convert.ToDouble(separador[1]);
            if (match.Success)
            {
                Patente = patente;
            }
            else { throw new PatenteNoValidaException(); }
        }
        public string Exportar()
        {
            return $"{Patente};{Importe}";
        }
        public override string ToString()
        {
            return $"Patente:{Patente},Importe:{Importe}";
        }
    }
}
