using Korelskiy.StyudingWPF1.Infrastructure.Commands;
using Korelskiy.WPF.ArmyApp.Models.Aircrafts;
using Korelskiy.WPF.ArmyApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Input;

namespace Korelskiy.WPF.ArmyApp.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {


        public ICommand ChangeAircraftCommand { get;}

        public ICommand CloseApplicationCommand { get; }

        private bool CanChangeAircraftCommandExecute(object p) => true;

        private void OnChangeAircraftCommandExecuted(object p)
        {

        }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {

        }
        public ObservableCollection<ProducingCountry> Countries { get; }

        #region Картинка
        private string _Src = Path.GetFullPath(@"Images\Su-24.jpg");

        ///<summary>Картинка</summary>
        public string Src {get => _Src; set => Set(ref _Src, value);}

        #endregion

        #region Заголовок
        private string _Title = "ВВС РФ";



        ///<summary>Заголовок</summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        #endregion

        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LyambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            ChangeAircraftCommand = new LyambdaCommand(OnChangeAircraftCommandExecuted, CanChangeAircraftCommandExecute);

            List<Plane> planes = new List<Plane>()
            {
                new Plane(){Name = "Су-24", Type = "Фронтовой бомбардирвщик", FirstFlight = Convert.ToDateTime("17.01.1970").ToShortDateString(), ImagePath = Path.GetFullPath(@"Images\Su-24.jpg"), InService = 274 },
                new Plane(){Name = "МиГ-29", Type = "Истребитель", FirstFlight = Convert.ToDateTime("06.10.1977").ToShortDateString(), ImagePath = Path.GetFullPath(@"Images\MiG-29.jpg"), InService = 249 },
                new Plane(){Name = "Су-27", Type = "Истребитель", FirstFlight = Convert.ToDateTime("20.05.1977").ToShortDateString(), ImagePath = Path.GetFullPath(@"Images\Su-27.jpg"), InService = 229 }
            };


            List<ProducingCountry> countries = new List<ProducingCountry>()
            {
                new ProducingCountry(){Name = "Россия", Planes = planes}
            };
       
            Countries = new ObservableCollection<ProducingCountry>(countries);
        }
    }
}
