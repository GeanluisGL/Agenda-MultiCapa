using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_EA
{
    public class E_Agenda
    {

        private int _ID;
        private string _Nombre;
        private string _Apellido;
        private string _Genero;
        private string _Correo;

        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
    }
}
