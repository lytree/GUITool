using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App.ViewModels;


public enum ControlStatus
{
    New,
    Beta,
    Stable,
}

public class MenuItemViewModel : ViewModelBase
{
    public string? MenuHeader { get; set; }
    public string? MenuIconName { get; set; }
    public string? Key { get; set; }
    public string? Status { get; set; }

    public bool IsSeparator { get; set; }
    public ObservableCollection<MenuItemViewModel> Children { get; set; } = new();

    public ICommand ActivateCommand { get; set; }

    public MenuItemViewModel()
    {
        ActivateCommand = new RelayCommand(OnActivate);
    }

    private void OnActivate()
    {
        if (IsSeparator || Key is null) return;
        WeakReferenceMessenger.Default.Send(Key);
    }
}