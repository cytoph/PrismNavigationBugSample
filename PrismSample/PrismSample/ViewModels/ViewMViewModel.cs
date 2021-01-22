using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrismSample.ViewModels
{
    public class ViewMViewModel : ViewModelBase
    {

        public ViewMViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "View M";
            Command = new DelegateCommand(async () =>
            {
                await navigationService.GoBackAsync(null, true, true);
                await navigationService.NavigateAsync("ViewB");
            });
        }
    }
}
