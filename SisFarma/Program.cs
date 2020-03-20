using SisFarma.controller.controllers;
using SisFarma.view;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainView());
        }
    }
}
