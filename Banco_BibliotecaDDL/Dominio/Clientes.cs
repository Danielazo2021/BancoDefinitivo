namespace Banco_BibliotecaDDL.Dominio
{
    public class Cliente
    {
        public List<Cuenta> Cuentas { get; set; }
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string mail { get; set; }
        public EstadoCivil estadoCiv { get; set; }



        public Cliente()
        {
            this.idCliente = 0;
            this.nombre = "";
            this.apellido = "";
            this.dni = 0;
            Cuentas = new List<Cuenta>();
            this.mail = "";
            this.estadoCiv = new EstadoCivil();

        }
        public Cliente(int cliente, string nombre, string apellido, int dni, List<Cuenta> cuentas, string mail, EstadoCivil estCivil)
        {
            this.idCliente = cliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            Cuentas = cuentas;
            this.mail = mail;
            this.estadoCiv = estCivil;
        }

        public void AgregarCuenta(Cuenta nueva)
        {
            Cuentas.Add(nueva);
        }
        public void EliminarCuenta(int cbu)
        {
            Cuentas.RemoveAt(cbu);
        }
        public override string ToString()
        {
            return "Cliente: " + this.nombre + ", " + this.apellido + " dni: " +
                this.dni;
        }
    }
}
