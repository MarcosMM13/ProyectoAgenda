using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    class Contacto : IComparable<Contacto>
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

        public Contacto() { }

        public Contacto(string nombre, int telefono, string email)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Contacto contact = obj as Contacto;

            if (contact == null)
                return false;

            return (Nombre == contact.Nombre) && (Telefono == contact.Telefono);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashNombre = (Nombre != null ? Nombre.GetHashCode() : 0);
                int hashTelefono = (Telefono != null ? Telefono.GetHashCode() : 0);

                return (hashNombre * 397) ^ (hashTelefono);
            }
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0} /nTelefono: +{1} /nE-mail: {2}", Nombre, Telefono, Email);
        }

        public int CompareTo(Contacto other)
        {
            return Nombre.CompareTo(other.Nombre);

            #region Errores
            //Contacto[] contacto = new Contacto[20];

            //for (int i = 0; i < contacto.Length; i++)
            //{
            //    if (Nombre != other.Nombre)
            //        return Nombre[i];

            //    if (Telefono != other.Telefono)
            //        return Telefono;

            //}

            //if (this.Nombre != other.Nombre)
            //    return 1;
            //if (this.Telefono != other.Telefono)
            //    return 1;

            //return -1; 
            #endregion
        }
    }
}