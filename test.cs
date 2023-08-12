using System;
using System.Collection.Generic;
using System.ComponenetModel;
using System.Text;
using System.Linq;
using System.ThreadingTasks;
using Xamarin.Forms;

namespace App1
{
    public partial class class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComnent();
        }

        protected override void OnAppearing()
        {
            StackLayout stack = new StackLayout();
            Label label = new Label();
            Label.Text = "uran";
            Label.TextTransform = TextTransform.Uppercase;
            Label.FontSize = 25;

            Button button = new Button();
            button.Text = "open"
            button.TextColor = Color.Red;
            button.Clicked += ButtonClick;
            
            
            stack.Children.Add(label);
            stack.Children.Add(button);
            Content = stack;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            button.Text = "acess";
            button.TextColor = Color.Red;
        }
    }
}