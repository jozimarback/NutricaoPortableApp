using System.Collections.ObjectModel;
using NutricaoPortableApp.Data;
using NutricaoPortableApp.Model;
using NutricaoPortableApp.View;
using SQLite;
using Xamarin.Forms;

namespace NutricaoPortableApp
{
    public class HomeTabbledPage : TabbedPage
    {
        public HomeTabbledPage()
        {
            SQLiteConnection conexao = DependencyService.Get<ISqlite>().ObterConexao();
            RefeicaoDao refeicaoDao = new RefeicaoDao(conexao);
            this.Children.Add(new ListaRefeicoes(refeicaoDao));
            this.Children.Add(new CadastroRefeicao(refeicaoDao));
        }
    }
}