﻿#pragma checksum "..\..\..\Pages\Staff_pages.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F8DE0063775DC0ADCA8102E509EDC1C9B6A7FB0FF3844DF9148D361F3DADEDB1"
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
    /// Staff_pages
    /// </summary>
    public partial class Staff_pages : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 22 "..\..\..\Pages\Staff_pages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Staff_tabl;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\Staff_pages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCurrentPage;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Pages\Staff_pages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblTotalPages;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Pages\Staff_pages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_serach;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Pages\Staff_pages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_serach1;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Pages\Staff_pages.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb;
        
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
            System.Uri resourceLocater = new System.Uri("/Real estate agency;component/pages/staff_pages.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Staff_pages.xaml"
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
            
            #line 17 "..\..\..\Pages\Staff_pages.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.revers_btn_click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Staff_tabl = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            
            #line 46 "..\..\..\Pages\Staff_pages.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_add);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 49 "..\..\..\Pages\Staff_pages.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.button_delete_click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 54 "..\..\..\Pages\Staff_pages.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToFirstPage);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 55 "..\..\..\Pages\Staff_pages.xaml"
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
            
            #line 58 "..\..\..\Pages\Staff_pages.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToNextPage);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 59 "..\..\..\Pages\Staff_pages.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToLastPage);
            
            #line default
            #line hidden
            return;
            case 12:
            this.textbox_serach = ((System.Windows.Controls.TextBox)(target));
            
            #line 72 "..\..\..\Pages\Staff_pages.xaml"
            this.textbox_serach.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textSearchClick);
            
            #line default
            #line hidden
            return;
            case 13:
            this.textbox_serach1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\..\Pages\Staff_pages.xaml"
            this.textbox_serach1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textSearchClick1);
            
            #line default
            #line hidden
            return;
            case 14:
            this.cb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 80 "..\..\..\Pages\Staff_pages.xaml"
            this.cb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox_cb);
            
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
            
            #line 33 "..\..\..\Pages\Staff_pages.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Redact);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

