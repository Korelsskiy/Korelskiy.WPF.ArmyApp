using Korelskiy.WPF.ArmyApp.ViewModels.Base;
using System;
using System.IO;

namespace Korelskiy.WPF.ArmyApp.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
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
    }
}
