using System;
using System.ComponentModel;

namespace PracticaMaui_AlejandroPisonero
{
    public enum Genero
    {
        Hombre, Mujer
    }



    public class Usuario
    {
        public string codigoUsu { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool Socio { get; set; }
        public Genero genero { get; set; } //true=Hombre, false=Mujer
        

        public Usuario()
        {
            
        }

        public Usuario(string codigoUsu, string nombre, string apellidos, DateTime fechaNacimiento, bool socio, Genero genero)
        {
            this.codigoUsu = codigoUsu;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            Socio = socio;
            this.genero = genero;
            
        }

       
    }
}

