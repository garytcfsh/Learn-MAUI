using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    internal class Count : INotifyPropertyChanged
    {
        public static Count Instance { get; } = new Count();

        public event PropertyChangedEventHandler? PropertyChanged;

        public int MyCount { get; set; } = 0;

        // Data Binding
        public string Msg { get; set; } = string.Empty;

        // Data Binding with Property Changed
        private string _msg1 = string.Empty;
        public string Msg1
        {
            get => _msg1;
            set
            {
                _msg1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Msg1)));
            }
        }
    }
}
