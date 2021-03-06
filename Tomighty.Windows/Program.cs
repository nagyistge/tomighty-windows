﻿//
//  Tomighty - http://www.tomighty.org
//
//  This software is licensed under the Apache License Version 2.0:
//  http://www.apache.org/licenses/LICENSE-2.0.txt
//

using System;
using System.ComponentModel;
using System.Windows.Forms;
using Tomighty.Windows.Notifications;
using Tomighty.Windows.Preferences;
using Tomighty.Windows.Timer;
using Tomighty.Windows.Tray;

namespace Tomighty.Windows
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TomightyApplication());
        }
    }
}
