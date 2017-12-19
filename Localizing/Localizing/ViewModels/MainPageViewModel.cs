using Localizing.Resx;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Localizing.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";

            //AppResources.Culture = new CultureInfo("en-US");


            NotesLabel = AppResources.NotesLabel;
            AddButton = AppResources.AddButton;
        }
    }
}
