﻿#pragma checksum "..\..\Home.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "71D706B44D5EC0B009AF8031BE886DC7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18444
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ChatingInterfaces;
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


namespace ClientApp {
    
    
    /// <summary>
    /// Home
    /// </summary>
    public partial class Home : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label JetonLable;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LoginLabel;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BonjourLable;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu MenuItems;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem LogoutItem;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ExitItem;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ProfItems;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CoursPrevuButton;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CoursEncourButton;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CoursPrevuListBox;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CoursOnlinListBox;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox MesCourListBox;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button creatCourButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ClientApp;component/home.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Home.xaml"
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
            
            #line 5 "..\..\Home.xaml"
            ((ClientApp.Home)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.JetonLable = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.LoginLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.BonjourLable = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.MenuItems = ((System.Windows.Controls.Menu)(target));
            return;
            case 6:
            this.LogoutItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 53 "..\..\Home.xaml"
            this.LogoutItem.Click += new System.Windows.RoutedEventHandler(this.LogoutItem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ExitItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 55 "..\..\Home.xaml"
            this.ExitItem.Click += new System.Windows.RoutedEventHandler(this.ExitItem_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ProfItems = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 9:
            this.CoursPrevuButton = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.CoursEncourButton = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.CoursPrevuListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 12:
            this.CoursOnlinListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 108 "..\..\Home.xaml"
            this.CoursOnlinListBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.CoursOnlinListBox_MouseDoubleClick_1);
            
            #line default
            #line hidden
            return;
            case 13:
            this.MesCourListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 124 "..\..\Home.xaml"
            this.MesCourListBox.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MesCourListBox_MouseRightButtonDown);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 127 "..\..\Home.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 130 "..\..\Home.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_1);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 132 "..\..\Home.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_2);
            
            #line default
            #line hidden
            return;
            case 17:
            this.creatCourButton = ((System.Windows.Controls.Button)(target));
            
            #line 138 "..\..\Home.xaml"
            this.creatCourButton.Click += new System.Windows.RoutedEventHandler(this.creatCourButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
