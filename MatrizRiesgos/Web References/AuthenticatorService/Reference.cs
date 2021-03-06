//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace MatrizRiesgos.AuthenticatorService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AuthenticatorServiceHttpBinding", Namespace="http://connectivity.service.ews.mincom.com")]
    public partial class AuthenticatorService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback authenticateOperationCompleted;
        
        private System.Threading.SendOrPostCallback flushOperationCompleted;
        
        private System.Threading.SendOrPostCallback getDistrictsOperationCompleted;
        
        private System.Threading.SendOrPostCallback getPositionsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AuthenticatorService() {
            this.Url = global::MatrizRiesgos.Properties.Settings.Default.MatrizRiesgos_AuthenticatorService_AuthenticatorService;
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
        public event authenticateCompletedEventHandler authenticateCompleted;
        
        /// <remarks/>
        public event flushCompletedEventHandler flushCompleted;
        
        /// <remarks/>
        public event getDistrictsCompletedEventHandler getDistrictsCompleted;
        
        /// <remarks/>
        public event getPositionsCompletedEventHandler getPositionsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://connectivity.service.ews.mincom.com", ResponseNamespace="http://connectivity.service.ews.mincom.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void authenticate([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] OperationContext context) {
            this.Invoke("authenticate", new object[] {
                        context});
        }
        
        /// <remarks/>
        public void authenticateAsync(OperationContext context) {
            this.authenticateAsync(context, null);
        }
        
        /// <remarks/>
        public void authenticateAsync(OperationContext context, object userState) {
            if ((this.authenticateOperationCompleted == null)) {
                this.authenticateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnauthenticateOperationCompleted);
            }
            this.InvokeAsync("authenticate", new object[] {
                        context}, this.authenticateOperationCompleted, userState);
        }
        
        private void OnauthenticateOperationCompleted(object arg) {
            if ((this.authenticateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.authenticateCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://connectivity.service.ews.mincom.com", ResponseNamespace="http://connectivity.service.ews.mincom.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void flush([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] OperationContext context) {
            this.Invoke("flush", new object[] {
                        context});
        }
        
        /// <remarks/>
        public void flushAsync(OperationContext context) {
            this.flushAsync(context, null);
        }
        
        /// <remarks/>
        public void flushAsync(OperationContext context, object userState) {
            if ((this.flushOperationCompleted == null)) {
                this.flushOperationCompleted = new System.Threading.SendOrPostCallback(this.OnflushOperationCompleted);
            }
            this.InvokeAsync("flush", new object[] {
                        context}, this.flushOperationCompleted, userState);
        }
        
        private void OnflushOperationCompleted(object arg) {
            if ((this.flushCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.flushCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://connectivity.service.ews.mincom.com", ResponseNamespace="http://connectivity.service.ews.mincom.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("districts", IsNullable=true)]
        public NameValuePair[] getDistricts([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] OperationContext context) {
            object[] results = this.Invoke("getDistricts", new object[] {
                        context});
            return ((NameValuePair[])(results[0]));
        }
        
        /// <remarks/>
        public void getDistrictsAsync(OperationContext context) {
            this.getDistrictsAsync(context, null);
        }
        
        /// <remarks/>
        public void getDistrictsAsync(OperationContext context, object userState) {
            if ((this.getDistrictsOperationCompleted == null)) {
                this.getDistrictsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetDistrictsOperationCompleted);
            }
            this.InvokeAsync("getDistricts", new object[] {
                        context}, this.getDistrictsOperationCompleted, userState);
        }
        
        private void OngetDistrictsOperationCompleted(object arg) {
            if ((this.getDistrictsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getDistrictsCompleted(this, new getDistrictsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://connectivity.service.ews.mincom.com", ResponseNamespace="http://connectivity.service.ews.mincom.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("positions", IsNullable=true)]
        public NameValuePair[] getPositions([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] OperationContext context) {
            object[] results = this.Invoke("getPositions", new object[] {
                        context});
            return ((NameValuePair[])(results[0]));
        }
        
        /// <remarks/>
        public void getPositionsAsync(OperationContext context) {
            this.getPositionsAsync(context, null);
        }
        
        /// <remarks/>
        public void getPositionsAsync(OperationContext context, object userState) {
            if ((this.getPositionsOperationCompleted == null)) {
                this.getPositionsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPositionsOperationCompleted);
            }
            this.InvokeAsync("getPositions", new object[] {
                        context}, this.getPositionsOperationCompleted, userState);
        }
        
        private void OngetPositionsOperationCompleted(object arg) {
            if ((this.getPositionsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPositionsCompleted(this, new getPositionsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connectivity.service.ews.mincom.com")]
    public partial class OperationContext {
        
        private string districtField;
        
        private bool eventDisableField;
        
        private bool eventDisableFieldSpecified;
        
        private int maxInstancesField;
        
        private bool maxInstancesFieldSpecified;
        
        private string positionField;
        
        private bool returnWarningsField;
        
        private bool returnWarningsFieldSpecified;
        
        private RunAs runAsField;
        
        private bool traceField;
        
        private bool traceFieldSpecified;
        
        private string transactionField;
        
        /// <remarks/>
        public string district {
            get {
                return this.districtField;
            }
            set {
                this.districtField = value;
            }
        }
        
        /// <remarks/>
        public bool eventDisable {
            get {
                return this.eventDisableField;
            }
            set {
                this.eventDisableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eventDisableSpecified {
            get {
                return this.eventDisableFieldSpecified;
            }
            set {
                this.eventDisableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int maxInstances {
            get {
                return this.maxInstancesField;
            }
            set {
                this.maxInstancesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxInstancesSpecified {
            get {
                return this.maxInstancesFieldSpecified;
            }
            set {
                this.maxInstancesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
            }
        }
        
        /// <remarks/>
        public bool returnWarnings {
            get {
                return this.returnWarningsField;
            }
            set {
                this.returnWarningsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool returnWarningsSpecified {
            get {
                return this.returnWarningsFieldSpecified;
            }
            set {
                this.returnWarningsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public RunAs runAs {
            get {
                return this.runAsField;
            }
            set {
                this.runAsField = value;
            }
        }
        
        /// <remarks/>
        public bool trace {
            get {
                return this.traceField;
            }
            set {
                this.traceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool traceSpecified {
            get {
                return this.traceFieldSpecified;
            }
            set {
                this.traceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string transaction {
            get {
                return this.transactionField;
            }
            set {
                this.transactionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connectivity.service.ews.mincom.com")]
    public partial class RunAs {
        
        private string districtField;
        
        private string positionField;
        
        private string userField;
        
        /// <remarks/>
        public string district {
            get {
                return this.districtField;
            }
            set {
                this.districtField = value;
            }
        }
        
        /// <remarks/>
        public string position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
            }
        }
        
        /// <remarks/>
        public string user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://connectivity.service.ews.mincom.com")]
    public partial class NameValuePair {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    public delegate void authenticateCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    public delegate void flushCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    public delegate void getDistrictsCompletedEventHandler(object sender, getDistrictsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getDistrictsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getDistrictsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public NameValuePair[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((NameValuePair[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    public delegate void getPositionsCompletedEventHandler(object sender, getPositionsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPositionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPositionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public NameValuePair[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((NameValuePair[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591