﻿using Lol.LayoutSupport.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lol.Profile.UI.Views
{
    public class SummaryView : View
    {
        #region DefaultStyleKey

        static SummaryView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SummaryView), new FrameworkPropertyMetadata(typeof(SummaryView)));
        }
        #endregion
    }
}