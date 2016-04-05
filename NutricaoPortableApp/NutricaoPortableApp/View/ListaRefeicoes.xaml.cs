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
    public partial class ListaRefeicoes : ContentPage
    {
        private RefeicaoDao _dao;
        public ObservableCollection<Refeicao> ListaRefeicao { get; set; }
        public ListaRefeicoes(RefeicaoDao dao)
        {
            _dao = dao;
            ListaRefeicao = _dao.Lista;
            BindingContext = this;
            InitializeComponent();
        }

        public async void AcaoItem(object sender, ItemTappedEventArgs e)
        {
            Refeicao refeicao = e.Item as Refeicao;

            var resposta = await DisplayAlert("Remover Item", string.Format("Você tem certeza que deseja remover a refeição {0}?", refeicao.Descricao), "Sim", "Não");
            if (resposta)
            {
                _dao.Remove(refeicao);
                await DisplayAlert("Remover Item", "Removido com sucesso", "Ok");
            }
        }
    }
}
