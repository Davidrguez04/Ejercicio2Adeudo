/*Con la arquitectura vista en clase, desarrolla una aplicación que solicitando por consola todos los datos 
 * necesarios, genere un archivo de ADEUDO SEPA.
El archivo se generará en el escritorio, en una carpeta llamada "Adeudos". El nombre del archivo tendrá el 
formato: "NombreApellido1.txt".

El campo "Referencia de orden de domiciliación" es un número entero correlativo (como un id). Debe generarse 
automáticamente.
El campo "Identificador del acreedor" es el NIF de la empresa que va a cobrar al cliente.
El switch es el identificador el banco de la persona a la que van a cobrar.
Tipo de pago puede ser: recurrente (R) o único (U).

Los recuadros en los campos iban, tipo de pago y switch, no son necesarios, basta que exista el mismo espacio 
de escritura.*/

using Ejercicio2Adeudo.Dto;
using Ejercicio2Adeudo.Servicios;

namespace Ejercicio2Adeudo.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfazAlta cliente=new ImplAlta();
            ClienteDto clienteDto = new ClienteDto();
            List<ClienteDto> listaClientes = new List<ClienteDto>();

            cliente.darAlta(listaClientes);

            string rutaArchivo = "DavidRodriguez.txt";

            StreamWriter sw = new StreamWriter(rutaArchivo);
            
            foreach(ClienteDto clientes in listaClientes)
            {
                clienteDto = clientes;
                sw.WriteLine(clientes);
            }
            

            sw.Close();
        }
    }
}
