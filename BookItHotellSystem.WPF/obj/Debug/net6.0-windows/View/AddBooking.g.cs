#pragma checksum "..\..\..\..\View\AddBooking.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DA6F17633C503D7ECF61100A963C829C2B0BCDBF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BookItHotellSystem.WPF.View;
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


namespace BookItHotellSystem.WPF.View {
    
    
    /// <summary>
    /// AddBooking
    /// </summary>
    public partial class AddBooking : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 84 "..\..\..\..\View\AddBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox chosenGuest;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\View\AddBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox chosenRoom;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\View\AddBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker checkInDate;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\View\AddBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker checkOutDate;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\View\AddBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox days;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\View\AddBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox costPerDay;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\View\AddBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox totalCost;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BookItHotellSystem.WPF;component/view/addbooking.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\AddBooking.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.chosenGuest = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.chosenRoom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.checkInDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.checkOutDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.days = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.costPerDay = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.totalCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 138 "..\..\..\..\View\AddBooking.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Register_Booking);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

