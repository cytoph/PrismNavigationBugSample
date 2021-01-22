using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismSample.ViewModels
{
    public class ViewBViewModel : ViewModelBase
    {
        public ViewBViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "View B";
            Command = new DelegateCommand(async () =>
            {
                await navigationService.GoBackAsync();
            });
        }
    }
}
