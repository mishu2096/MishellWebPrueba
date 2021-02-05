using System;

namespace MishellLogica
{
    public class Logica
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Resultado { get; set; }
        public object Profesion { get; set; }
        public string Grupo { get; set; }


        public void Datos()
        {
            Resultado = Nombre + Apellido;
        }

        public void DatosProfesion()
        {
            Resultado = Profesion + Grupo;
        }
    }
}
