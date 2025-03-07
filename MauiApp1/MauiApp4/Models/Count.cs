using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4.Models
{
    internal partial class Count : ObservableObject
    {
        public static Count Instance { get; } = new Count();

        public int MyCount { get; set; } = 0;
    }
}
