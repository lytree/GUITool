using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ViewModels;

public class MenuViewModel : ViewModelBase
{
    public MenuViewModel()
    {
    }


    public ObservableCollection<MenuItemViewModel> MenuItems { get; set; }
}