using System;
using Ooui;
using Xamarin.Forms;

namespace MyPWA
{
    class Program
    {
        static void Main(string[] args)
        {
			Forms.Init();

			var mainPage = new MainPage();
			UI.Publish("/", mainPage.GetOouiElement());

		}
    }
}
