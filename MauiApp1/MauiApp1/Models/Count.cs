using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    internal class Count
    {
        public static Count Instance { get; } = new Count();

        public int MyCount { get; set; } = 0;
    }
}
