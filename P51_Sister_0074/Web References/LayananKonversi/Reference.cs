﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace P51_Sister_0074.LayananKonversi {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://tempuri.org/")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CelciusToReamurOperationCompleted;
        
        private System.Threading.SendOrPostCallback CelciusToFahrenhetOperationCompleted;
        
        private System.Threading.SendOrPostCallback CelciusToKelvinOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service() {
            this.Url = global::P51_Sister_0074.Properties.Settings.Default.P51_Sister_0074_LayananKonversi_Service;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event CelciusToReamurCompletedEventHandler CelciusToReamurCompleted;
        
        /// <remarks/>
        public event CelciusToFahrenhetCompletedEventHandler CelciusToFahrenhetCompleted;
        
        /// <remarks/>
        public event CelciusToKelvinCompletedEventHandler CelciusToKelvinCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CelciusToReamur", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double CelciusToReamur(int C) {
            object[] results = this.Invoke("CelciusToReamur", new object[] {
                        C});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void CelciusToReamurAsync(int C) {
            this.CelciusToReamurAsync(C, null);
        }
        
        /// <remarks/>
        public void CelciusToReamurAsync(int C, object userState) {
            if ((this.CelciusToReamurOperationCompleted == null)) {
                this.CelciusToReamurOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCelciusToReamurOperationCompleted);
            }
            this.InvokeAsync("CelciusToReamur", new object[] {
                        C}, this.CelciusToReamurOperationCompleted, userState);
        }
        
        private void OnCelciusToReamurOperationCompleted(object arg) {
            if ((this.CelciusToReamurCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CelciusToReamurCompleted(this, new CelciusToReamurCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CelciusToFahrenhet", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double CelciusToFahrenhet(int C) {
            object[] results = this.Invoke("CelciusToFahrenhet", new object[] {
                        C});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void CelciusToFahrenhetAsync(int C) {
            this.CelciusToFahrenhetAsync(C, null);
        }
        
        /// <remarks/>
        public void CelciusToFahrenhetAsync(int C, object userState) {
            if ((this.CelciusToFahrenhetOperationCompleted == null)) {
                this.CelciusToFahrenhetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCelciusToFahrenhetOperationCompleted);
            }
            this.InvokeAsync("CelciusToFahrenhet", new object[] {
                        C}, this.CelciusToFahrenhetOperationCompleted, userState);
        }
        
        private void OnCelciusToFahrenhetOperationCompleted(object arg) {
            if ((this.CelciusToFahrenhetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CelciusToFahrenhetCompleted(this, new CelciusToFahrenhetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CelciusToKelvin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double CelciusToKelvin(int C) {
            object[] results = this.Invoke("CelciusToKelvin", new object[] {
                        C});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void CelciusToKelvinAsync(int C) {
            this.CelciusToKelvinAsync(C, null);
        }
        
        /// <remarks/>
        public void CelciusToKelvinAsync(int C, object userState) {
            if ((this.CelciusToKelvinOperationCompleted == null)) {
                this.CelciusToKelvinOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCelciusToKelvinOperationCompleted);
            }
            this.InvokeAsync("CelciusToKelvin", new object[] {
                        C}, this.CelciusToKelvinOperationCompleted, userState);
        }
        
        private void OnCelciusToKelvinOperationCompleted(object arg) {
            if ((this.CelciusToKelvinCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CelciusToKelvinCompleted(this, new CelciusToKelvinCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void CelciusToReamurCompletedEventHandler(object sender, CelciusToReamurCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CelciusToReamurCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CelciusToReamurCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void CelciusToFahrenhetCompletedEventHandler(object sender, CelciusToFahrenhetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CelciusToFahrenhetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CelciusToFahrenhetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void CelciusToKelvinCompletedEventHandler(object sender, CelciusToKelvinCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CelciusToKelvinCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CelciusToKelvinCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591