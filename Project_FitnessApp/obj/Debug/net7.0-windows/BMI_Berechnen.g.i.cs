﻿#pragma checksum "..\..\..\BMI_Berechnen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "309175D5905B0302F6DA3407A5BE4605BBD20801"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Project_FitnessApp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Project_FitnessApp {
    
    
    /// <summary>
    /// BMI_Berechnen
    /// </summary>
    public partial class BMI_Berechnen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\BMI_Berechnen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Eingabe_Kilogramm;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\BMI_Berechnen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Eingabe_Groeße;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\BMI_Berechnen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Berechnen_BMI;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\BMI_Berechnen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AusgabeBMI;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Project_FitnessApp;component/bmi_berechnen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BMI_Berechnen.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Eingabe_Kilogramm = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\BMI_Berechnen.xaml"
            this.Eingabe_Kilogramm.KeyUp += new System.Windows.Input.KeyEventHandler(this.Eingabe_Kilogramm_KeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Eingabe_Groeße = ((System.Windows.Controls.TextBox)(target));
            
            #line 75 "..\..\..\BMI_Berechnen.xaml"
            this.Eingabe_Groeße.KeyUp += new System.Windows.Input.KeyEventHandler(this.Eingabe_Groeße_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Berechnen_BMI = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\BMI_Berechnen.xaml"
            this.Berechnen_BMI.Click += new System.Windows.RoutedEventHandler(this.Berechnen_BMI_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AusgabeBMI = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

