using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.Models
{
    internal partial class Count : ObservableObject
    {
        public static Count Instance { get; } = new Count();

        public int MyCount { get; set; } = 0;

        [ObservableProperty]
        private string _msg = string.Empty;

        [ObservableProperty]
        private string _msg1 = string.Empty;
        //public string Msg1
        //{
        //    get => _msg1;
        //    set
        //    {
        //        _msg1 = value;
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Msg1)));
        //    }
        //}

        [RelayCommand]
        public void AddCount()
        {

        }
    }
}
