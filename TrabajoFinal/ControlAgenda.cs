using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    class ControlAgenda
    {
        private Agenda _agenda;

        public ControlAgenda (Agenda agenda)
        {
            _agenda = agenda;
        }

        public void VerContactos()
        {
            Limpiar();
            MostrarMenu();

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Mostrar Contactos de Forma Ascendente");
                    _agenda.MostrarOrdenados();
                    break;
                case "2":
                    Console.WriteLine("Mostrar Contactos de Forma Descendente");
                    _agenda.MostrarOrdenadosDesc();
                    break;
                case "3":
                    return;
                    
                default:
                    Console.WriteLine("Opcion No Valida.");
                    break;
            }
        }
        public void AgregarContacto()
        {
            Limpiar();
            Console.WriteLine("Nuevo Contacto");
            Contacto contacto = new Contacto();

            Console.WriteLine("Nombre: ");
            contacto.Nombre = Console.ReadLine();

            Console.WriteLine("Telefono: ");
            contacto.Telefono = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Email: ");
            contacto.Email = Console.ReadLine();

            _agenda.AgregarContacto(contacto);
            Console.WriteLine("Contacto Agregado Exitosamente");
            PresionaParaContinuar();
        }

        public void BorrarContacto()
        {
            Limpiar();
            _agenda.BorrarUltimoContacto();
            Console.WriteLine("Ultimo contacto borrado exitosamente.");
            PresionaParaContinuar();
        }
        public void BuscarPorNombre()
        {
            Limpiar();
            Console.WriteLine("Buscar Contacto");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Contacto contacto = _agenda.BuscarPorNombre(nombre);
            if (contacto != null)
            {
                Console.WriteLine("Contacto: /n" + contacto);
            }
            else
            {
                Console.WriteLine("Contacto no encontrado");
            }

            PresionaParaContinuar();
        }
        public void AcercaDe()
        {
            Console.WriteLine("Nombre: Marcos Mateos");
            PresionaParaContinuar();
        }
        public void MostrarMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Mostrar orden ascendente");
            sb.AppendLine("2. Mostrar orden descendente");
            sb.AppendLine("3. Volver al Menu Principal");
            sb.Append("Seleccione una Opción: ");

            Console.Write(sb.ToString());
        }
        private static void Limpiar()
        {
            Console.Clear();
        }
        private static void PresionaParaContinuar()
        {
            Console.WriteLine("Presiona para continuar");
            Console.ReadKey();
        }
    }
}
