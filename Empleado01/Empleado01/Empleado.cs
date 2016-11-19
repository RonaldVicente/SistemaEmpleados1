using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado01
{
    class Empleado
    {
        // Campos
        private string _codigo;
        private string _nombre;
        private string _cargo;
        private double _sueldo;
        private double _desc;
        private double _boni;
        private double _neto;
        private string _msg;
        //propiedades
        public string Codigo
        {
            get { return _codigo; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                GeneraCodigo();
            }
        }
        public double Sueldo
        {
            set
            {
                _sueldo = value;
                Procesar();
            }
        }
        public double Bonificacion
        {
            get { return _boni; }
        }
        public double Descuento
        {
            get { return _desc; }
        }
        public double Neto
        {
            get { return _neto; }
        }
        public string Fecha
        {
            get { return DateTime.Now.ToShortDateString(); }
        }
        public string Hora
        {
            get { return DateTime.Now.ToLongTimeString(); }
        }
        public string Mensaje
        {
            get { return _msg; }
        }
        //constructor
        public Empleado()
        {
        }
        // metodos para procesar datos
        private void Procesar()
        {
            _boni = _sueldo * 0.50;
            _desc = (_sueldo + _boni) * 0.10;
            _neto = (_sueldo + _boni) - _desc;
            if (_neto >= 5000)
                _msg = "Buen Sueldo...";
            else if (_neto >= 1500 && _neto < 5000)
                _msg = "Sueldo promedio...";
            else
                _msg = "Sueldo Minimo...";
        }

        private void GeneraCodigo()
        {
            _codigo = _nombre.Substring(0, 2).ToUpper() + DateTime.Now.Year.ToString();
        }
    }
}
