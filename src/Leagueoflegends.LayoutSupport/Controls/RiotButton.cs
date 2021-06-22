﻿using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.LayoutSupport.Controls
{
	public class RiotButton : Button
    {
        static RiotButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotButton), new FrameworkPropertyMetadata(typeof(RiotButton)));
        }
    }
}
