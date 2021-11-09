using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContadorManual
{
    public partial class MainPage : ContentPage
    {


        private int _Conteo;
        public MainPage()
        {












            InitializeComponent();




            _Conteo = 0;
















        }

        private void ContarButton_Clicked(object sender, EventArgs e)
        {


            _Conteo++;
            ConteoLabel.Text = _Conteo.ToString();


        }

        private void ReiniciarButton_Clicked(object sender, EventArgs e)
        {



            _Conteo = 0;
            ConteoLabel.Text = _Conteo.ToString();






        }
    }
}