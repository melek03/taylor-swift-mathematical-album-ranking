﻿#pragma checksum "..\..\Red.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CBACF992298CE59534EE4B79FF012F334CCD3FA499BDE5CA7AE249E85F9E9CB4"
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
using tswift_album_ranking;


namespace tswift_album_ranking {
    
    
    /// <summary>
    /// Red
    /// </summary>
    public partial class Red : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\Red.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Back;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Red.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Red.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Average;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Red.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image debutImage;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Red.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid songDataGrid;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\Red.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AverageDisplay;
        
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
            System.Uri resourceLocater = new System.Uri("/tswift album ranking;component/red.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Red.xaml"
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
            this.Back = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 21 "..\..\Red.xaml"
            this.Back.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Back_MouseEnter);
            
            #line default
            #line hidden
            
            #line 22 "..\..\Red.xaml"
            this.Back.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Back_MouseLeave);
            
            #line default
            #line hidden
            
            #line 24 "..\..\Red.xaml"
            this.Back.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\Red.xaml"
            this.Save.MouseEnter += new System.Windows.Input.MouseEventHandler(this.saveOnEnter);
            
            #line default
            #line hidden
            
            #line 36 "..\..\Red.xaml"
            this.Save.MouseLeave += new System.Windows.Input.MouseEventHandler(this.saveOnLeave);
            
            #line default
            #line hidden
            
            #line 36 "..\..\Red.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.save_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Average = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\Red.xaml"
            this.Average.MouseEnter += new System.Windows.Input.MouseEventHandler(this.averageOnEnter);
            
            #line default
            #line hidden
            
            #line 48 "..\..\Red.xaml"
            this.Average.MouseLeave += new System.Windows.Input.MouseEventHandler(this.averageOnLeave);
            
            #line default
            #line hidden
            
            #line 48 "..\..\Red.xaml"
            this.Average.Click += new System.Windows.RoutedEventHandler(this.average_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.debutImage = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.songDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.AverageDisplay = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
