using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NutricaoPortableApp.Data;
using NutricaoPortableApp.Model;
using NutricaoPortableApp.ViewModel;
using Xamarin.Forms;

namespace NutricaoPortableApp.View
{
    public partial class CadastroRefeicao : ContentPage
    {
        public CadastroRefeicao(RefeicaoDao dao)
        {
            CadastroRefeicaoViewModel vm = new CadastroRefeicaoViewModel(dao,this);
            BindingContext = vm;
            InitializeComponent();
        }


        //private void MostraLista(object sender, EventArgs e)
        //{
        //    ListaRefeicoes tela = new ListaRefeicoes();
        //    Navigation.PushAsync(tela);
        //}
    }
}
