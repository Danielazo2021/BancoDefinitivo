namespace Banco_BibliotecaDDL.Dominio
{
   

    public class Cuenta
    {


        public TipoCuenta tpCuenta { get; set; }

        // public TipoCuenta tp { get; set; }

        public double Cbu { get; set; }
        public double Saldo { get; set; }
        public DateTime UltimoMovimiento { get; set; }



        public Cuenta()
        {
            this.Cbu = 0;
            this.Saldo = 0;
            this.UltimoMovimiento = DateTime.Today;
            tpCuenta = new TipoCuenta();

        }
        public Cuenta(double cbu, double saldo, DateTime ultimoMovimiento, int id_tipo, string nomCuenta)
        {
            this.Cbu = cbu;
            this.Saldo = saldo;
            this.UltimoMovimiento = ultimoMovimiento;
            tpCuenta = new TipoCuenta(id_tipo, nomCuenta);
            // tp.id = tipo;
            // tp.nom_tipo_cta= nomCuenta;
        }
        public override string ToString()
        {
            return "cbu: " + this.Cbu + ", Saldo: " + this.Saldo + "$";
        }
    }



}

