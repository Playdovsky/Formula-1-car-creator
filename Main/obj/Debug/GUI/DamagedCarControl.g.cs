﻿#pragma checksum "..\..\..\GUI\DamagedCarControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5952F9EFB7CE14AB7BD6FD196B5BBDB69BFFDAC01986A4AD6377CA3636CFB841"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Main;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Main {
    
    
    /// <summary>
    /// DamagedCarControl
    /// </summary>
    public partial class DamagedCarControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\GUI\DamagedCarControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxTyres;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\GUI\DamagedCarControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxNumber;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\GUI\DamagedCarControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxType;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\GUI\DamagedCarControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxEngine;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\GUI\DamagedCarControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxAerodynamics;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\GUI\DamagedCarControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxBrakes;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\GUI\DamagedCarControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBuild;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Main;component/gui/damagedcarcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GUI\DamagedCarControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ComboBoxTyres = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.TextBoxNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextBoxType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ComboBoxEngine = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ComboBoxAerodynamics = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.TextBoxBrakes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ButtonBuild = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\GUI\DamagedCarControl.xaml"
            this.ButtonBuild.Click += new System.Windows.RoutedEventHandler(this.ButtonBuild_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

