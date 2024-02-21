using Ejercicio2Adeudo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Adeudo.Servicios
{
    internal class ImplAlta:InterfazAlta
    {
        public void darAlta(List<ClienteDto> listaDatos)
        {
            ClienteDto clienteDto = datosAlta();

            for(int i=0;i<listaDatos.Count;i++)
            {
                clienteDto.Id = listaDatos[i].Id;
                

            }

            listaDatos.Add(clienteDto);
        }

        private ClienteDto datosAlta()
        {
            ClienteDto clienteDto = new ClienteDto();

            Console.Write("\n\tIntroduzca el nombre del acreedor: ");
            clienteDto.Nombre = Console.ReadLine();

            Console.Write("\n\tIdentificador del Acreedor(NIF Empresa): ");
            clienteDto.IdentificadorAcreedor = Console.ReadLine();

            Console.Write("\n\tIntroduzca su dirección: ");
            clienteDto.Direccion = Console.ReadLine();

            Console.Write("\n\tIntroduzca el IBAN: ");
            clienteDto.Iban = Console.ReadLine();

            Console.Write("\n\tCodigo postal: ");
            clienteDto.CodigoPostal=Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\tIntroduzca la población: ");
            clienteDto.Poblacion = Console.ReadLine();

            Console.Write("\n\tPais: ");
            clienteDto.Pais = Console.ReadLine();

            Console.Write("\n\tIntroduzca el BIC: ");
            clienteDto.Bic = Console.ReadLine();

            Console.Write("\n\tDirección del deudor: ");
            clienteDto.DireccionDeudor = Console.ReadLine();

            Console.Write("\n\tNombre del deudor: ");
            clienteDto.NombreDeudor = Console.ReadLine();

            Console.Write("\n\tIntroduzca la población del deudor: ");
            clienteDto.PoblacionD = Console.ReadLine();

            Console.Write("\n\tPais del deudor: ");
            clienteDto.PaisD = Console.ReadLine();

            Console.Write("\n\tCodigo postal deudor: ");
            clienteDto.CodigoPostalD = Console.ReadLine();

            Console.Write("\n\tTipo de pago(R/U): ");
            clienteDto.TipoPago=Console.ReadLine();

            return clienteDto;
        }
    }
}
