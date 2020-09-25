using Korelskiy.StyudingWPF1.Infrastructure.Commands;
using Korelskiy.WPF.ArmyApp.Models.Aircrafts;
using Korelskiy.WPF.ArmyApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Korelskiy.WPF.ArmyApp.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        

        public ICommand GetRussiaPlanes { get;}

        public ICommand GetChinaPlanes { get; }

        public ICommand CloseApplicationCommand { get; }

        private bool CanGetRussiaPlanesExecute(object p) => true;

        private void OnGetRussiaPlanesExecuted(object p)
        {
            SelectedCountry = Countries[0];
            SelectedPlane = Countries[0].Planes[0];
            
        }

        private bool CanGetChinaPlanesExecute(object p) => true;

        private void OnGetChinaPlanesExecuted(object p)
        {
            SelectedCountry = Countries[1];
            SelectedPlane = Countries[1].Planes[0];

        }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }
        public List<ProducingCountry> Countries { get; } = ProducingCountry.PrCountries;

        private Plane _SelectedPlane;

        public Plane SelectedPlane { get => _SelectedPlane; set => Set(ref _SelectedPlane, value); }


        private ProducingCountry _SelectedCountry;

        public ProducingCountry SelectedCountry { get => _SelectedCountry; set => Set(ref _SelectedCountry, value); }
        #region Картинка
        private string _Src = Path.GetFullPath(@"Images\Su-24.jpg");

        ///<summary>Картинка</summary>
        public string Src {get => _Src; set => Set(ref _Src, value);}

        #endregion

        #region Заголовок
        private string _Title = "ВВС";



        ///<summary>Заголовок</summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        #endregion

        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LyambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            GetRussiaPlanes = new LyambdaCommand(OnGetRussiaPlanesExecuted, CanGetRussiaPlanesExecute);
            GetChinaPlanes = new LyambdaCommand(OnGetChinaPlanesExecuted, CanGetChinaPlanesExecute);

            SelectedCountry = Countries[1];
            SelectedPlane = Countries[1].Planes[0];
        }
    }
}
