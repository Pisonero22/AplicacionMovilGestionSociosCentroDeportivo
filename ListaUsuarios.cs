using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PracticaMaui_AlejandroPisonero
{
    public class ListaUsuarios : List<Usuario>
    {
        public ListaUsuarios()
        {
        }


        public Usuario BuscarUsuario(string codUsu)
        {


            foreach (Usuario usuario in this)
            {
                if (usuario.codigoUsu.Equals(codUsu))
                {
                    return usuario;
                }

            }
            return null;

        }

        public bool AñadirUsuario(Usuario usuario)
        {
            if (BuscarUsuario(usuario.codigoUsu) == null)
            {
                this.Add(usuario);
                return true;
            }


            return false;
        }

        
      

        public void DatosMock()
        {

            this.Add(new Usuario("1111", "Alejandro", "Pisonero Lopez", new DateTime(2003, 01, 14), true, Genero.Hombre));
            this.Add(new Usuario("2222", "Laura", "Garcia Parra", new DateTime(2003, 05, 17), false, Genero.Mujer));
            this.Add(new Usuario("3333", "Marcos", "Garcia Lopez", new DateTime(2001, 01, 17), false, Genero.Hombre));
            this.Add(new Usuario("4444", "Lucas", "Marcos Lopez", new DateTime(1999, 04, 11), false, Genero.Hombre));
        }

    }
}

