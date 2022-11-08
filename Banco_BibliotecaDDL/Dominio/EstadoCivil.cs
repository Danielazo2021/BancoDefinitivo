using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_BibliotecaDDL.Dominio
{
    public class EstadoCivil
    {
        public int id_estado { get; set; }
        public string nom_estado { get; set; }

        public EstadoCivil()
        {
            id_estado = 0;
            nom_estado = "";
        }
        public EstadoCivil(int id, string nom_estado)
        {
            this.id_estado = id;
            this.nom_estado = nom_estado;
        }

    }
}
