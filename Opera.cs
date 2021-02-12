using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Operaciones
{
    public class Opera:ContentPage
    {
        public Opera()
        {
            var label1 = new Label
            {
                Text = "Numero 1",
            };
            var num1 = new Entry
            {
                Placeholder = "Escribe un numero",
                Keyboard = Keyboard.Numeric
            };
            var label2 = new Label
            {
                Text = "Numero 2",
            };
            var num2 = new Entry
            {
                Placeholder = "Escribe un numero",
                Keyboard = Keyboard.Numeric
            };
            var botonS = new Button
            {
                Text="Sumar"
            };
            botonS.Clicked += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
                {
                    int n1 = Convert.ToInt32(num1.Text);
                    int n2 = Convert.ToInt32(num2.Text);
                    int suma = n1 + n2;
                    DisplayAlert("Resultado", suma.ToString(), "Cerrar");
                }
                else
                {
                    DisplayAlert("Error", "Debe llenar todos los campos", "Cerrar");
                }

            };
            var botonR = new Button
            {
                Text = "Restar"
            };
            botonR.Clicked += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
                {
                    int n1 = Convert.ToInt32(num1.Text);
                    int n2 = Convert.ToInt32(num2.Text);
                    int res = n1 - n2;
                    DisplayAlert("Resultado", res.ToString(), "Cerrar");
                }
                else
                {
                    DisplayAlert("Error", "Debe llenar todos los campos", "Cerrar");
                }
                

            };
            var botonM = new Button
            {
                Text = "Multiplicar"
            };
            botonM.Clicked += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
                {
                    int n1 = Convert.ToInt32(num1.Text);
                    int n2 = Convert.ToInt32(num2.Text);
                    int res = n1 * n2;
                    DisplayAlert("Resultado", res.ToString(), "Cerrar");
                }
                else
                {
                    DisplayAlert("Error", "Debe llenar todos los campos", "Cerrar");
                }


            };
            var botonD = new Button
            {
                Text = "Dividir"
            };
            botonD.Clicked += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
                {
                    int n1 = Convert.ToInt32(num1.Text);
                    int n2 = Convert.ToInt32(num2.Text);
                    if (n2 != 0)
                    {
                        int res = n1 / n2;
                        DisplayAlert("Resultado", res.ToString(), "Cerrar");
                    }
                    else
                    {
                        DisplayAlert("ERROR", "No se puede dividir entre 0", "Cerrar");
                    }
                }
                else
                {
                    DisplayAlert("Error", "Debe llenar todos los campos", "Cerrar");
                }



            };
            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = {label1, num1, label2, num2, botonS, botonR, botonM, botonD }
            };
        }
    }
}
