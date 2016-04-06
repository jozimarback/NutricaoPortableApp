using System;
using System.ComponentModel;
using System.Windows.Input;
using NutricaoPortableApp.Data;
using NutricaoPortableApp.Model;
using Xamarin.Forms;

namespace NutricaoPortableApp.ViewModel
{
    public class CadastroRefeicaoViewModel : INotifyPropertyChanged
    {
        private string _descricao;
        private double _calorias;
        private RefeicaoDao _dao;
        private ContentPage _page;
        public ICommand SalvaRefeicao { get; private set; }

        public string Descricao
        {
            get { return _descricao; }
            set
            {
                if (value != _descricao)
                {
                    _descricao = value;
                    OnPropertyChanged("Descricao");
                }
            }
        }

        public double Calorias
        {
            get { return _calorias; }
            set
            {
                if (value != _calorias)
                {
                    _calorias = value;
                    OnPropertyChanged("Calorias");
                }
            }
        }

        public CadastroRefeicaoViewModel(RefeicaoDao dao, ContentPage page)
        {
            _dao = dao;
            _page = page;
            SalvaRefeicao = new Command(() => {
                Refeicao refeicao = new Refeicao(_descricao, _calorias);
                _dao.Salvar(refeicao);
                string msg = string.Format("A refeição {0} de {1} foi salva com successo.", _descricao, _calorias);
                this._page.DisplayAlert("Salvar refeição", msg, "Ok");
                
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string nome)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(nome));
        }

    }
}