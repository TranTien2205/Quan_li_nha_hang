﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_li_nha_hang
{
     internal static class Program
     {
          /// <summary>
          /// The main entry point for the application.
          /// </summary>
          [STAThread]
          static void Main()
          {
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new Form1());
          }
     }
}
