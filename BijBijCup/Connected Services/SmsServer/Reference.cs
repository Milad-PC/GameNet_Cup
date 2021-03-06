//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BijBijCup.SmsServer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:smsserver", ConfigurationName="SmsServer.smsserverPortType")]
    public interface smsserverPortType {
        
        // CODEGEN: Generating message contract since the wrapper namespace (188.0.240.110) of message sendPatternSmsRequest does not match the default value (urn:smsserver)
        [System.ServiceModel.OperationContractAttribute(Action="sendPatternSms", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(input_data_type))]
        BijBijCup.SmsServer.sendPatternSmsResponse sendPatternSms(BijBijCup.SmsServer.sendPatternSmsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="sendPatternSms", ReplyAction="*")]
        System.Threading.Tasks.Task<BijBijCup.SmsServer.sendPatternSmsResponse> sendPatternSmsAsync(BijBijCup.SmsServer.sendPatternSmsRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (188.0.240.110) of message GetCreditRequest does not match the default value (urn:smsserver)
        [System.ServiceModel.OperationContractAttribute(Action="GetCredit", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(input_data_type))]
        BijBijCup.SmsServer.GetCreditResponse GetCredit(BijBijCup.SmsServer.GetCreditRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="GetCredit", ReplyAction="*")]
        System.Threading.Tasks.Task<BijBijCup.SmsServer.GetCreditResponse> GetCreditAsync(BijBijCup.SmsServer.GetCreditRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:smsserver")]
    public partial class input_data_type : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
                this.RaisePropertyChanged("key");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("value");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendPatternSms", WrapperNamespace="188.0.240.110", IsWrapped=true)]
    public partial class sendPatternSmsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string fromNum;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string[] toNum;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string user;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string pass;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=4)]
        public string pattern_code;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=5)]
        public BijBijCup.SmsServer.input_data_type[] input_data;
        
        public sendPatternSmsRequest() {
        }
        
        public sendPatternSmsRequest(string fromNum, string[] toNum, string user, string pass, string pattern_code, BijBijCup.SmsServer.input_data_type[] input_data) {
            this.fromNum = fromNum;
            this.toNum = toNum;
            this.user = user;
            this.pass = pass;
            this.pattern_code = pattern_code;
            this.input_data = input_data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendPatternSmsResponse", WrapperNamespace="188.0.240.110", IsWrapped=true)]
    public partial class sendPatternSmsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string @return;
        
        public sendPatternSmsResponse() {
        }
        
        public sendPatternSmsResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCredit", WrapperNamespace="188.0.240.110", IsWrapped=true)]
    public partial class GetCreditRequest {
        
        public GetCreditRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCreditResponse", WrapperNamespace="188.0.240.110", IsWrapped=true)]
    public partial class GetCreditResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string @return;
        
        public GetCreditResponse() {
        }
        
        public GetCreditResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface smsserverPortTypeChannel : BijBijCup.SmsServer.smsserverPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class smsserverPortTypeClient : System.ServiceModel.ClientBase<BijBijCup.SmsServer.smsserverPortType>, BijBijCup.SmsServer.smsserverPortType {
        
        public smsserverPortTypeClient() {
        }
        
        public smsserverPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public smsserverPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public smsserverPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public smsserverPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BijBijCup.SmsServer.sendPatternSmsResponse BijBijCup.SmsServer.smsserverPortType.sendPatternSms(BijBijCup.SmsServer.sendPatternSmsRequest request) {
            return base.Channel.sendPatternSms(request);
        }
        
        public string sendPatternSms(string fromNum, string[] toNum, string user, string pass, string pattern_code, BijBijCup.SmsServer.input_data_type[] input_data) {
            BijBijCup.SmsServer.sendPatternSmsRequest inValue = new BijBijCup.SmsServer.sendPatternSmsRequest();
            inValue.fromNum = fromNum;
            inValue.toNum = toNum;
            inValue.user = user;
            inValue.pass = pass;
            inValue.pattern_code = pattern_code;
            inValue.input_data = input_data;
            BijBijCup.SmsServer.sendPatternSmsResponse retVal = ((BijBijCup.SmsServer.smsserverPortType)(this)).sendPatternSms(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BijBijCup.SmsServer.sendPatternSmsResponse> BijBijCup.SmsServer.smsserverPortType.sendPatternSmsAsync(BijBijCup.SmsServer.sendPatternSmsRequest request) {
            return base.Channel.sendPatternSmsAsync(request);
        }
        
        public System.Threading.Tasks.Task<BijBijCup.SmsServer.sendPatternSmsResponse> sendPatternSmsAsync(string fromNum, string[] toNum, string user, string pass, string pattern_code, BijBijCup.SmsServer.input_data_type[] input_data) {
            BijBijCup.SmsServer.sendPatternSmsRequest inValue = new BijBijCup.SmsServer.sendPatternSmsRequest();
            inValue.fromNum = fromNum;
            inValue.toNum = toNum;
            inValue.user = user;
            inValue.pass = pass;
            inValue.pattern_code = pattern_code;
            inValue.input_data = input_data;
            return ((BijBijCup.SmsServer.smsserverPortType)(this)).sendPatternSmsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BijBijCup.SmsServer.GetCreditResponse BijBijCup.SmsServer.smsserverPortType.GetCredit(BijBijCup.SmsServer.GetCreditRequest request) {
            return base.Channel.GetCredit(request);
        }
        
        public string GetCredit() {
            BijBijCup.SmsServer.GetCreditRequest inValue = new BijBijCup.SmsServer.GetCreditRequest();
            BijBijCup.SmsServer.GetCreditResponse retVal = ((BijBijCup.SmsServer.smsserverPortType)(this)).GetCredit(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BijBijCup.SmsServer.GetCreditResponse> BijBijCup.SmsServer.smsserverPortType.GetCreditAsync(BijBijCup.SmsServer.GetCreditRequest request) {
            return base.Channel.GetCreditAsync(request);
        }
        
        public System.Threading.Tasks.Task<BijBijCup.SmsServer.GetCreditResponse> GetCreditAsync() {
            BijBijCup.SmsServer.GetCreditRequest inValue = new BijBijCup.SmsServer.GetCreditRequest();
            return ((BijBijCup.SmsServer.smsserverPortType)(this)).GetCreditAsync(inValue);
        }
    }
}
