using SisFarma.model.classes;
using SisFarma.model.DAO;
using SisFarma.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
