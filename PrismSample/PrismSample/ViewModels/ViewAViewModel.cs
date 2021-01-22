using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismSample.ViewModels
{
    public class ViewAViewModel : ViewModelBase
    {
        public ViewAViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "View A";
            Command = new DelegateCommand(async () =>
            {
                await navigationService.NavigateAsync("ViewM", null, true, true);
            });
        }
    }
}
