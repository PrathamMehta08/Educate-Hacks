﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Air
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Book : Popup
    {
        public Book()
        {
            InitializeComponent();
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            Dismiss(null);
        }

        private void Redeem_Clicked(object sender, EventArgs e)
        {
            Dismiss(null);
        }
    }
}