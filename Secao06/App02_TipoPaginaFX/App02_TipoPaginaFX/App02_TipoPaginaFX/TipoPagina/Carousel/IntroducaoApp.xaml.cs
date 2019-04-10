﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaFX.TipoPagina.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntroducaoApp : CarouselPage
    {
        public IntroducaoApp()
        {
            InitializeComponent();

            Children.Add(new TipoPagina2());
            Children.Add(new TipoPagina3());
        }
    }
}