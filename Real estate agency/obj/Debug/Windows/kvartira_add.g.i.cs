﻿#pragma checksum "..\..\..\Windows\kvartira_add.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2C92D554196D0C7933A6E8A786472A0E0435EB5452E0FBB276BB1F8DE47CCD6A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Real_estate_agency.Windows;
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


namespace Real_estate_agency.Windows {
    
    
    /// <summary>
    /// kvartira_add
    /// </summary>
    public partial class kvartira_add : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Windows\kvartira_add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_back;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\kvartira_add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tip_box;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\kvartira_add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox status_box;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Windows\kvartira_add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox owner_box;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Windows\kvartira_add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ob_box;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Windows\kvartira_add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textblock_1;
        
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
            System.Uri resourceLocater = new System.Uri("/Real estate agency;component/windows/kvartira_add.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\kvartira_add.xaml"
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
            this.Button_back = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Windows\kvartira_add.xaml"
            this.Button_back.Click += new System.Windows.RoutedEventHandler(this.Button_back_click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tip_box = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.status_box = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.owner_box = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ob_box = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            
            #line 70 "..\..\..\Windows\kvartira_add.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.button_s_click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textblock_1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            
            #line 77 "..\..\..\Windows\kvartira_add.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.button_save_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

