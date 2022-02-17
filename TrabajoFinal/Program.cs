using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    class Program
    {
        static ControlAgenda control = new ControlAgenda(new Agenda());

        static void Main(string[] args)
        {
            string opcio = "";

            do
            {
                Console.Clear();
                Console.WriteLine("*******Agenda de Contactos*******");
                MostrarMenu();
                opcio = Console.ReadLine();

                switch (opcio)
                {
                    case "1":
                        control.VerContactos();
                        break;
                    case "2":
                        control.AgregarContacto();
                        break;
                    case "3":
                        control.BorrarContacto();
                        break;
                    case "4":
                        control.BuscarPorNombre();
                        break;
                    case "5":
                        control.AcercaDe();
                        break;
                    case "6":
                        break;

                    default:
                        Console.WriteLine("Opcion No Valida");
                        break;
                } 
            } while (opcio != "6");
        }

        static void MostrarMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Ver Contactos");
            sb.AppendLine("2. Agregar Contactos");
            sb.AppendLine("3. Borrar ultimo contacto");
            sb.AppendLine("4. Buscar Contactos por Nombre");
            sb.AppendLine("5. Acerca De");
            sb.AppendLine("6. Salir");
            sb.Append("Seleccione una Opcion");

            Console.WriteLine(sb.ToString());

        }
    }
}
