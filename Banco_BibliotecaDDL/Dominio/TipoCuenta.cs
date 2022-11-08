namespace Banco_BibliotecaDDL.Dominio
{
    public class TipoCuenta
    {
        public int id { get; set; }
        public string nom_tipo_cta { get; set; }

        public TipoCuenta(int id, string tipo)
        {
            this.nom_tipo_cta = tipo;
            this.id = id;
        }

        public TipoCuenta()
        {
            id = 0;
            nom_tipo_cta = "";

        }
        public override string ToString()
        {
            return nom_tipo_cta;
        }
    }
}

