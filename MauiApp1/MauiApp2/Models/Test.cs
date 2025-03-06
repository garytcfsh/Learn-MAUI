﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models;

internal class Test
{
    public string Filename { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public DateTime Date { get; set; }

    public void StartTest()
    {
        Models.Count countModel = Models.Count.Instance;

        if (int.TryParse(Text, out int count))
        {
            Task.Run(() => {
                for (int i = 0; i < count; i++)
                {
                    Thread.Sleep(100);
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        //Debug.WriteLine("")
                        countModel.MyCount = i;
                        countModel.Msg =  $"Clicked {countModel.MyCount} time";
                        countModel.Msg1 = $"Clicked {countModel.MyCount} time";
                    });
                }
            });
        }
    }
}
