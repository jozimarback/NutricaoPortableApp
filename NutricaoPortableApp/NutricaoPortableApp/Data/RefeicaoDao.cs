using System.Collections.ObjectModel;
using NutricaoPortableApp.Model;
using SQLite;

namespace NutricaoPortableApp.Data
{
    public class RefeicaoDao
    {
        private SQLiteConnection conexao;
        private ObservableCollection<Refeicao> lista;
        public ObservableCollection<Refeicao> Lista
        {
            get { 
                if(lista == null)
                {
                    lista = GetAll();
                }
                return lista;
            }
            private set { lista = value; }
        } 
        public RefeicaoDao(SQLiteConnection connection)
        {
            conexao = connection;
        }

        public void Salvar(Refeicao refeicao)
        {
            conexao.Insert(refeicao);
            lista.Add(refeicao);
        }

        private ObservableCollection<Refeicao> GetAll()
        {
            return new ObservableCollection<Refeicao>(conexao.Table<Refeicao>());
        }

        public void Remove(Refeicao refeicao)
        {
            conexao.Delete<Refeicao>(refeicao.Id);
            lista.Remove(refeicao);
        }
    }
}