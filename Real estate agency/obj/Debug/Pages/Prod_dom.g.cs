﻿#pragma checksum "..\..\..\Pages\Prod_dom.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DFF7BE1D5FFEE3F72C852E32E0F6F3A8DADDB716383D3164A1D4C54EFE197F1E"
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
    /// Prod_dom
    /// </summary>
    public partial class Prod_dom : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 23 "..\..\..\Pages\Prod_dom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid buy_kvartir_tabl;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\Prod_dom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCurrentPage;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Pages\Prod_dom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblTotalPages;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Pages\Prod_dom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb1;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Pages\Prod_dom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb2;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Pages\Prod_dom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb3;
        
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
            System.Uri resourceLocater = new System.Uri("/Real estate agency;component/pages/prod_dom.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Prod_dom.xaml"
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
            
            #line 17 "..\..\..\Pages\Prod_dom.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.revers_btn_click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buy_kvartir_tabl = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            
            #line 55 "..\..\..\Pages\Prod_dom.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_add);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 58 "..\..\..\Pages\Prod_dom.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.button_delete_click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 63 "..\..\..\Pages\Prod_dom.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToFirstPage);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 64 "..\..\..\Pages\Prod_dom.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToPreviousPage);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TxtCurrentPage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.LblTotalPages = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            
            #line 67 "..\..\..\Pages\Prod_dom.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToNextPage);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 68 "..\..\..\Pages\Prod_dom.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToLastPage);
            
            #line default
            #line hidden
            return;
            case 13:
            this.cb1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 82 "..\..\..\Pages\Prod_dom.xaml"
            this.cb1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox_cb1);
            
            #line default
            #line hidden
            return;
            case 14:
            this.cb2 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 86 "..\..\..\Pages\Prod_dom.xaml"
            this.cb2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox_cb2);
            
            #line default
            #line hidden
            return;
            case 15:
            this.cb3 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 90 "..\..\..\Pages\Prod_dom.xaml"
            this.cb3.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox_cb3);
            
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
            
            #line 35 "..\..\..\Pages\Prod_dom.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Redact);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 42 "..\..\..\Pages\Prod_dom.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_copy);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
