﻿#pragma checksum "..\..\..\Pages\Tip_nedviz.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CF0ABBF2009C83B62CA4CE19B0C08E0BDE42BF813801D4A7BEA0495C070FE4D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Real_estate_agency.Pages;
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


namespace Real_estate_agency.Pages {
    
    
    /// <summary>
    /// Tip_nedviz
    /// </summary>
    public partial class Tip_nedviz : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 22 "..\..\..\Pages\Tip_nedviz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tip_nedviz;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\Tip_nedviz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCurrentPage;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\Tip_nedviz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblTotalPages;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\Tip_nedviz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_serach;
        
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
            System.Uri resourceLocater = new System.Uri("/Real estate agency;component/pages/tip_nedviz.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Tip_nedviz.xaml"
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
            
            #line 17 "..\..\..\Pages\Tip_nedviz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.revers_btn_click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tip_nedviz = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            
            #line 41 "..\..\..\Pages\Tip_nedviz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_add);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 44 "..\..\..\Pages\Tip_nedviz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.button_delete_click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 49 "..\..\..\Pages\Tip_nedviz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToFirstPage);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 50 "..\..\..\Pages\Tip_nedviz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToPreviousPage);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TxtCurrentPage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.LblTotalPages = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            
            #line 53 "..\..\..\Pages\Tip_nedviz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToNextPage);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 54 "..\..\..\Pages\Tip_nedviz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToLastPage);
            
            #line default
            #line hidden
            return;
            case 12:
            this.textbox_serach = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\..\Pages\Tip_nedviz.xaml"
            this.textbox_serach.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textSearchClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 28 "..\..\..\Pages\Tip_nedviz.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Redact);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

