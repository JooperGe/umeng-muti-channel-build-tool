﻿#pragma checksum "..\..\UmengWidget.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3A2372E193FD2B8B771A3A08B7AAE5F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
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
using UIControls;


namespace UmengWidget {
    
    
    /// <summary>
    /// UmengWidget
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class UmengWidget : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\UmengWidget.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid bg;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\UmengWidget.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal UIControls.ProgressButton check_button;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\UmengWidget.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\UmengWidget.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock file_name;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\UmengWidget.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock file_size;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\UmengWidget.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel float_layer;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UmengWidget;component/umengwidget.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UmengWidget.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.bg = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.check_button = ((UIControls.ProgressButton)(target));
            
            #line 26 "..\..\UmengWidget.xaml"
            this.check_button.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            
            #line 39 "..\..\UmengWidget.xaml"
            ((System.Windows.Controls.Grid)(target)).AddHandler(System.Windows.DragDrop.DragEnterEvent, new System.Windows.DragEventHandler(this.dragDrop_Event));
            
            #line default
            #line hidden
            
            #line 39 "..\..\UmengWidget.xaml"
            ((System.Windows.Controls.Grid)(target)).AddHandler(System.Windows.DragDrop.DropEvent, new System.Windows.DragEventHandler(this.dragDrop_Event));
            
            #line default
            #line hidden
            
            #line 40 "..\..\UmengWidget.xaml"
            ((System.Windows.Controls.Grid)(target)).AddHandler(System.Windows.DragDrop.DragOverEvent, new System.Windows.DragEventHandler(this.dragDrop_Event));
            
            #line default
            #line hidden
            
            #line 40 "..\..\UmengWidget.xaml"
            ((System.Windows.Controls.Grid)(target)).AddHandler(System.Windows.DragDrop.DragLeaveEvent, new System.Windows.DragEventHandler(this.dragDrop_Event));
            
            #line default
            #line hidden
            return;
            case 5:
            this.file_name = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.file_size = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.float_layer = ((System.Windows.Controls.WrapPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

