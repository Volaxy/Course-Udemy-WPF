#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87958E80FE0B07B633058EADCF4D09C97ED486C2423D1FBB2017C7679F4A64AD"
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
using _10___TextBox_and_Label_to_Ribbon;


namespace _10___TextBox_and_Label_to_Ribbon {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.Ribbon mainRibbon;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonApplicationMenuItem exitRibbonMenuItem;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonMenuItem pasteRibbonMenuItem;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonMenuItem pasteSpecialRibbonMenuItem;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton cutRibbonButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton copyRibbonButton;
        
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
            System.Uri resourceLocater = new System.Uri("/10 - TextBox and Label to Ribbon;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.mainRibbon = ((System.Windows.Controls.Ribbon.Ribbon)(target));
            return;
            case 2:
            this.exitRibbonMenuItem = ((System.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.exitRibbonMenuItem.Click += new System.Windows.RoutedEventHandler(this.exitRibbonMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.pasteRibbonMenuItem = ((System.Windows.Controls.Ribbon.RibbonMenuItem)(target));
            
            #line 61 "..\..\MainWindow.xaml"
            this.pasteRibbonMenuItem.Click += new System.Windows.RoutedEventHandler(this.pasteRibbonMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pasteSpecialRibbonMenuItem = ((System.Windows.Controls.Ribbon.RibbonMenuItem)(target));
            
            #line 62 "..\..\MainWindow.xaml"
            this.pasteSpecialRibbonMenuItem.Checked += new System.Windows.RoutedEventHandler(this.pasteSpecialRibbonMenuItem_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cutRibbonButton = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 65 "..\..\MainWindow.xaml"
            this.cutRibbonButton.Click += new System.Windows.RoutedEventHandler(this.cutRibbonButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.copyRibbonButton = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 66 "..\..\MainWindow.xaml"
            this.copyRibbonButton.Click += new System.Windows.RoutedEventHandler(this.copyRibbonButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

