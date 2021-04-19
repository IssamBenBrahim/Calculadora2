using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

         private void Boton_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text + ((Button)sender).Text;
        }

        private void BotonDividir_Clicked(object sender, EventArgs e)
        {

            if (!Resultado.Text.Equals(""))
            {
                string signo_operacion = Resultado.Text.Substring(Resultado.Text.Length - 1);

                if (!(signo_operacion.Equals("/") || signo_operacion.Equals("x") ||
                    signo_operacion.Equals("-") || signo_operacion.Equals("+")))
                {
                    Resultado.Text = Resultado.Text + "/";
                }
            } 
        }

        private void BotonMultiplicar_Clicked(object sender, EventArgs e)
        {
            if (!Resultado.Text.Equals(""))
            {
                string signo_operacion = Resultado.Text.Substring(Resultado.Text.Length - 1);

                if (!(signo_operacion.Equals("/") || signo_operacion.Equals("x") ||
                    signo_operacion.Equals("-") || signo_operacion.Equals("+")))
                {
                    Resultado.Text = Resultado.Text + "x";
                }
            }
        }

        private void BotonRestar_Clicked(object sender, EventArgs e)
        {
            if (!Resultado.Text.Equals(""))
            {
                string signo_operacion = Resultado.Text.Substring(Resultado.Text.Length - 1);

                if (!(signo_operacion.Equals("/") || signo_operacion.Equals("x") ||
                    signo_operacion.Equals("-") || signo_operacion.Equals("+")))
                {
                    Resultado.Text = Resultado.Text + "-";
                }
            }
        }

        private void BotonSumar_Clicked(object sender, EventArgs e)
        {
            if (!Resultado.Text.Equals(""))
            {
                string signo_operacion = Resultado.Text.Substring(Resultado.Text.Length - 1);

                if (!(signo_operacion.Equals("/") || signo_operacion.Equals("x") ||
                    signo_operacion.Equals("-") || signo_operacion.Equals("+")))
                {
                    Resultado.Text = Resultado.Text + "+";
                }
            }
        }

        private void BotonBorrar_Clicked(object sender, EventArgs e)
        {
            Resultado.Text = "";
        }

        private void BotonIgual_Clicked(object sender, EventArgs e)
        {
            Historial.Children.Add(new Label() { Text = Resultado.Text });
           
        }

    }
}
