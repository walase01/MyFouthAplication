﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fourthAplicattion.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemView : StackLayout
    {
        public ItemView()
        {
            InitializeComponent();
        }
    }
}