#pragma checksum "..\..\..\..\MVVM\View\KlantenView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F522E8291B66CB4FF58FBCC5DE43511873CDFF8490BEB6286910BC3B4D54FA4A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Clean_UI.MVVM.View;
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


namespace Clean_UI.MVVM.View {
    
    
    /// <summary>
    /// KlantenView
    /// </summary>
    public partial class KlantenView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\..\MVVM\View\KlantenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_klanten;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\MVVM\View\KlantenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inv_first_name;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\MVVM\View\KlantenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inv_last_name;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\MVVM\View\KlantenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inv_city;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\MVVM\View\KlantenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inv_phonenumber;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\..\MVVM\View\KlantenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox inv_email;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\..\MVVM\View\KlantenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_submit;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\..\MVVM\View\KlantenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_change;
        
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
            System.Uri resourceLocater = new System.Uri("/Clean UI;component/mvvm/view/klantenview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\KlantenView.xaml"
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
            this.dg_klanten = ((System.Windows.Controls.DataGrid)(target));
            
            #line 49 "..\..\..\..\MVVM\View\KlantenView.xaml"
            this.dg_klanten.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dg_klanten_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.inv_first_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.inv_last_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.inv_city = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.inv_phonenumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.inv_email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btn_submit = ((System.Windows.Controls.Button)(target));
            
            #line 159 "..\..\..\..\MVVM\View\KlantenView.xaml"
            this.btn_submit.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_change = ((System.Windows.Controls.Button)(target));
            
            #line 167 "..\..\..\..\MVVM\View\KlantenView.xaml"
            this.btn_change.Click += new System.Windows.RoutedEventHandler(this.btn_change_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

