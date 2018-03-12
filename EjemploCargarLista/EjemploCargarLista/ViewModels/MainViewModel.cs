using EjemploCargarLista.Models;
using EjemploCargarLista.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EjemploCargarLista.ViewModels
{
    public class MainViewModel: INotifyPropertyChanged
    {
        public List<AmortizacionModel> datos { get; set; }
        public List<AmortizacionModel> Datos
        {
            get { return datos; }
            set { datos = value;  }
        }

        ApiServices apiService;
         public  MainViewModel()
        {
            apiService = new ApiServices();
            cargar();
        }
        async void cargar()
        {
            Datos = await apiService.Datos();
            OnPropertyChanged(nameof(Datos));

        }

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #endregion
    }
}
