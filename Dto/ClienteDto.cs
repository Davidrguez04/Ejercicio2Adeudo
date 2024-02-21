using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Adeudo.Dto
{
    internal class ClienteDto
    {
        //Atributos
        string nombre;
        string direccion;
        string poblacion;
        string pais;
        int id;
        int codigoPostal;
        string iban;
        string identificadorAcreedor;
        string bic;
        string tipoPago;
        
        string nombreDeudor;
        string direccionDeudor;
        string poblacionD;
        string paisD;
        string codigoPostalD;

        //Constructores
        public ClienteDto(string nombre, string direccion, string poblacion,  string pais, int id, int codigoPostal, string iban, string identificadorAcreedor, string bic, string tipoPago, string nombreDeudor, string direccionDeudor, string poblacionD, string paisD, string codigoPostalD)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.poblacion = poblacion;
            
            this.pais = pais;
            this.id = id;
            this.codigoPostal = codigoPostal;
            this.iban = iban;
            this.identificadorAcreedor = identificadorAcreedor;
            this.bic = bic;
            this.tipoPago = tipoPago;
            
            this.nombreDeudor = nombreDeudor;
            this.direccionDeudor = direccionDeudor;
            this.poblacionD= poblacionD;
            this.paisD = paisD;
            this.codigoPostalD= codigoPostalD;
        }

        //Vacío
        public ClienteDto()
        {
        }


        //Getters y setters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
       
        public string Pais { get => pais; set => pais = value; }
        public int Id { get => id; set => id = value; }
        public int CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Iban { get => iban; set => iban = value; }
        public string IdentificadorAcreedor { get => identificadorAcreedor; set => identificadorAcreedor = value; }
        public string Bic { get => bic; set => bic = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public string NombreDeudor { get => nombreDeudor; set => nombreDeudor = value; }
        public string DireccionDeudor { get => direccionDeudor; set => direccionDeudor = value; }
        public string PoblacionD { get => poblacionD; set => poblacionD = value; }
        public string PaisD { get => paisD; set => paisD = value; }
        public string CodigoPostalD { get => codigoPostalD; set => codigoPostalD = value; }


        //Método ToString
        override
            public string ToString()
        {
            string mensaje = "\t\tOrden de domiciliación de adeudo directo SEPA\n\n" +
                "Referencia de la Orden de Domiciliación: \t\t"+this.id+
                "\nIdentificador del Acreedor: \t\t"+this.identificadorAcreedor+
                "\nNombre del Acreedor: \t\t"+this.nombre+
                "\nDirección: \t\t"+this.direccion+
                "\nCodigo postal-Población-País: \t\t"+this.codigoPostal+"- "+this.poblacion+"- "+this.pais+
                "\nNombre del Deudor: \t\t"+this.nombreDeudor+
                "\nDirección del Deudor: \t\t"+this.direccionDeudor+
                "\nCodigo Postal-Población-País:\t\t"+this.codigoPostalD+"- "+this.poblacionD+"- "+this.paisD+
                "\nNumero de Cuenta- IBAN:\t\tSwift-BIC:\n"+this.iban+"\t\t\t\t"+this.bic+
                "\nTipo de pago: "+this.tipoPago;

            return mensaje;
        }
    }
}
