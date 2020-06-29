﻿#pragma checksum "..\..\..\..\Graphics\WnMain.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96897A4094DF9DB831F4682B3F3B858711E0FF7A"
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


namespace WxInjector.Graphics {
    
    
    /// <summary>
    /// WnMain
    /// </summary>
    public partial class WnMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\Graphics\WnMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LbProcesses;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Graphics\WnMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbProcess;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Graphics\WnMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbLibrary;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Graphics\WnMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbMethod;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Graphics\WnMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbFlag;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WxInjector;component/graphics/wnmain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Graphics\WnMain.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 15 "..\..\..\..\Graphics\WnMain.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RefreshProcesses);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LbProcesses = ((System.Windows.Controls.ListBox)(target));
            
            #line 17 "..\..\..\..\Graphics\WnMain.xaml"
            this.LbProcesses.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProcessSelected);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TbProcess = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TbLibrary = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 32 "..\..\..\..\Graphics\WnMain.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BrowseLibrary);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CbMethod = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.CbFlag = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 51 "..\..\..\..\Graphics\WnMain.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Inject);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 53 "..\..\..\..\Graphics\WnMain.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CheckForUpdates);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 58 "..\..\..\..\Graphics\WnMain.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
