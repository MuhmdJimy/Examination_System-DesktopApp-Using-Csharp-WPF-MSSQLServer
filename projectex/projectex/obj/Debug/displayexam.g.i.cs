﻿#pragma checksum "..\..\displayexam.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "087DFEEE3A499BDD567FA84A797D0F927FAE6C1687D4D993487A486EE6A1AB63"
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
using projectex;


namespace projectex {
    
    
    /// <summary>
    /// displayexam
    /// </summary>
    public partial class displayexam : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\displayexam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\displayexam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTime;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\displayexam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label EXName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\displayexam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\displayexam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stackPanel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\displayexam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button prev;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\displayexam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Finish;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\displayexam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button next;
        
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
            System.Uri resourceLocater = new System.Uri("/projectex;component/displayexam.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\displayexam.xaml"
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
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.lblTime = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.EXName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Label = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.stackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.prev = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\displayexam.xaml"
            this.prev.Click += new System.Windows.RoutedEventHandler(this.click_prev);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Finish = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\displayexam.xaml"
            this.Finish.Click += new System.Windows.RoutedEventHandler(this.save);
            
            #line default
            #line hidden
            return;
            case 8:
            this.next = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\displayexam.xaml"
            this.next.Click += new System.Windows.RoutedEventHandler(this.click_Next);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

