﻿#pragma checksum "..\..\BilgiYarisması.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D228D2AC1BF9F4AD5EF65BAF8FEA9731D3D5379A76175D8BFA11C9DC0BD36B64"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfExamplee;


namespace WpfExamplee {
    
    
    /// <summary>
    /// BilgiYarisması
    /// </summary>
    public partial class BilgiYarisması : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\BilgiYarisması.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtsoru;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\BilgiYarisması.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnA;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\BilgiYarisması.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnB;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\BilgiYarisması.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnC;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\BilgiYarisması.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock puann;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\BilgiYarisması.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtdogru;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfExamplee;component/bilgiyarismas%c4%b1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BilgiYarisması.xaml"
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
            this.txtsoru = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnA = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\BilgiYarisması.xaml"
            this.btnA.Click += new System.Windows.RoutedEventHandler(this.btnA_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnB = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\BilgiYarisması.xaml"
            this.btnB.Click += new System.Windows.RoutedEventHandler(this.btnB_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnC = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\BilgiYarisması.xaml"
            this.btnC.Click += new System.Windows.RoutedEventHandler(this.btnC_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.puann = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtdogru = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

