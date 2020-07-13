using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Controles_practica_1
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnProcesar_Clicked(object sender, EventArgs e)
        {
            if (txtNom.Text != null && txtApe.Text != null)
            {
                if(txtLugNac.Text != null)
                {
                    if(!Soltero.IsChecked && !Casado.IsChecked)
                    {
                        DisplayAlert("Alerta", "Favor Seleccionar un Estado Civil Antes de Pulsar el Boton", "OK");
                    }
                    else
                    {
                        string CivilState = null;
                        if (Soltero.IsChecked)
                        {
                            CivilState = "Solter@";
                        }

                        if (Casado.IsChecked)
                        {
                            CivilState = "Casad@";
                        }

                        if (FechaNac.Date != DateTime.MinValue)
                        {
                            var year = FechaNac.Date.Year;
                            var Actualyear = DateTime.Today.Year;
                            var yearsOld = Actualyear - year;

                            DisplayAlert("Bienvenido", "Hola Mi Nombre es " + txtNom.Text + " " + txtApe.Text + " Tengo " + yearsOld + " Años de Edad y Naci en " + txtLugNac.Text +
                            " En la Actualidad Estoy " + CivilState + " y Soy Profesional en el Area de " + Profesiones.SelectedItem, "OK");
                        }
                        else
                        {
                            DisplayAlert("Alerta", "Favor Seleccionar Una Fecha de Nacimiento Antes de Pulsar el Boton", "OK");
                        }
                    }
                }
            }
            else
            {
                DisplayAlert("Alerta", "Favor Introducir un Nombre y Apellido Antes de Pulsar el Boton", "OK");
            }
        }
    }
}
