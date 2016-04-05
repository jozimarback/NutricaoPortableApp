using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace NutricaoPortableApp.Model
{
    public class Refeicao
    {
        public Refeicao(string descricao, double calorias)
        {
            Descricao = descricao;
            Calorias = calorias;
        }

        public Refeicao()
        {
        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Descricao { get; set; }
        public double Calorias { get; set; }
    }
}
