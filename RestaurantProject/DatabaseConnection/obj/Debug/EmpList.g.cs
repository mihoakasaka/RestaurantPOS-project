﻿#pragma checksum "..\..\EmpList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "19B75473BB8A8B75798D2ABDDC339632"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ManagerPOS;
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


namespace ManagerPOS {
    
    
    /// <summary>
    /// EmpList
    /// </summary>
    public partial class EmpList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\EmpList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstEmployees;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\EmpList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFName;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\EmpList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLName;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\EmpList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPhone;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\EmpList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\EmpList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPostal;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\EmpList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStreet;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\EmpList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCity;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\EmpList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSIN;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\EmpList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblID;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\EmpList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAdd;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\EmpList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btUpdate;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\EmpList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/DatabaseConnection;component/emplist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EmpList.xaml"
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
            this.lstEmployees = ((System.Windows.Controls.ListView)(target));
            
            #line 14 "..\..\EmpList.xaml"
            this.lstEmployees.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstEmployees_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtFName = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\EmpList.xaml"
            this.txtFName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtFName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtLName = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\EmpList.xaml"
            this.txtLName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtLName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtPhone = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\EmpList.xaml"
            this.txtPhone.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPhone_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtPassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\EmpList.xaml"
            this.txtPassword.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPassword_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtPostal = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\EmpList.xaml"
            this.txtPostal.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtCity_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtStreet = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\EmpList.xaml"
            this.txtStreet.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtStreet_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtCity = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\EmpList.xaml"
            this.txtCity.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPostal_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtSIN = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\EmpList.xaml"
            this.txtSIN.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSIN_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.lblID = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.btAdd = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\EmpList.xaml"
            this.btAdd.Click += new System.Windows.RoutedEventHandler(this.btAdd_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\EmpList.xaml"
            this.btUpdate.Click += new System.Windows.RoutedEventHandler(this.btUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btDelete = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\EmpList.xaml"
            this.btDelete.Click += new System.Windows.RoutedEventHandler(this.btDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

