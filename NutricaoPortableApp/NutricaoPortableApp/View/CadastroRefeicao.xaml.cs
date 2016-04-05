using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutricaoPortableApp.Data;
using NutricaoPortableApp.Model;
using Xamarin.Forms;

namespace NutricaoPortableApp.View
{
    public partial class CadastroRefeicao : ContentPage
    {
        private RefeicaoDao _dao;
        public CadastroRefeicao(RefeicaoDao dao)
        {
            this._dao = dao;
            InitializeComponent();
        }

        public void AtualizaContador(Object sender, EventArgs e)
        {
            double valor = StpCalorias.Value;
            LblCalorias.Text = valor.ToString();
        }

        public void SalvaRefeicao(Object sender, EventArgs e)
        {
            string descricao = EntDescricao.Text;
            double valor = StpCalorias.Value;
            Refeicao refeicao = new Refeicao(descricao, valor);
            _dao.Salvar(refeicao);
            string msg = string.Format("A refeição {0} de {1} foi salva com successo.", descricao, valor);
            DisplayAlert("Salvar refeição", msg, "Ok");
            Clear();
        }

        public void Clear()
        {
            EntDescricao.Text = "";
            StpCalorias.Value = 10;
        }

        //private void MostraLista(object sender, EventArgs e)
        //{
        //    ListaRefeicoes tela = new ListaRefeicoes();
        //    Navigation.PushAsync(tela);
        //}
    }
}
