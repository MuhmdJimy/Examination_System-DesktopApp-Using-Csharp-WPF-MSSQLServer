﻿#pragma checksum "..\..\addquestion.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CA396D2ECB1467537F3BB31E9092FEC05DA7CFC9386EF0CB49F53F9B6B112BC9"
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
    /// addquestion
    /// </summary>
    public partial class addquestion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\addquestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Courses_CmbBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\addquestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MCQBody_txtBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\addquestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MCQ_CmbBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\addquestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MCQOption_txtBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\addquestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox IsTrue_CmbBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\addquestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TandFBody_txtBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\addquestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TandFQues_CmbBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\addquestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox IsTrue2_CmbBox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\addquestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextQues_txtBox;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\addquestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TextQues_CmbBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\addquestion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextQuesCorrectAnswer_txtBox;
        
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
            System.Uri resourceLocater = new System.Uri("/projectex;component/addquestion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\addquestion.xaml"
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
            this.Courses_CmbBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 16 "..\..\addquestion.xaml"
            this.Courses_CmbBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Courses_CmbBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MCQBody_txtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 25 "..\..\addquestion.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_addMCQ);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MCQ_CmbBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.MCQOption_txtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.IsTrue_CmbBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 35 "..\..\addquestion.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_addOption);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TandFBody_txtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 46 "..\..\addquestion.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_addTandFQ);
            
            #line default
            #line hidden
            return;
            case 10:
            this.TandFQues_CmbBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.IsTrue2_CmbBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            
            #line 55 "..\..\addquestion.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_addCorrectAnswer);
            
            #line default
            #line hidden
            return;
            case 13:
            this.TextQues_txtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            
            #line 68 "..\..\addquestion.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_addTextQues);
            
            #line default
            #line hidden
            return;
            case 15:
            this.TextQues_CmbBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 16:
            this.TextQuesCorrectAnswer_txtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            
            #line 73 "..\..\addquestion.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_addAnswer);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

