﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab7b.WS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Telephone", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Telephone : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string surnameField;
        
        private int numberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string surname {
            get {
                return this.surnameField;
            }
            set {
                if ((object.ReferenceEquals(this.surnameField, value) != true)) {
                    this.surnameField = value;
                    this.RaisePropertyChanged("surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int number {
            get {
                return this.numberField;
            }
            set {
                if ((this.numberField.Equals(value) != true)) {
                    this.numberField = value;
                    this.RaisePropertyChanged("number");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WS.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Контракт генерации сообщений с именем GetAllResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        Lab7b.WS.GetAllResponse GetAll(Lab7b.WS.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab7b.WS.GetAllResponse> GetAllAsync(Lab7b.WS.GetAllRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем GetDictResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDict", ReplyAction="*")]
        Lab7b.WS.GetDictResponse GetDict(Lab7b.WS.GetDictRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDict", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab7b.WS.GetDictResponse> GetDictAsync(Lab7b.WS.GetDictRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем surname из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddDict", ReplyAction="*")]
        Lab7b.WS.AddDictResponse AddDict(Lab7b.WS.AddDictRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddDict", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab7b.WS.AddDictResponse> AddDictAsync(Lab7b.WS.AddDictRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем surname из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdDict", ReplyAction="*")]
        Lab7b.WS.UpdDictResponse UpdDict(Lab7b.WS.UpdDictRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdDict", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab7b.WS.UpdDictResponse> UpdDictAsync(Lab7b.WS.UpdDictRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем DelDictResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DelDict", ReplyAction="*")]
        Lab7b.WS.DelDictResponse DelDict(Lab7b.WS.DelDictRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DelDict", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab7b.WS.DelDictResponse> DelDictAsync(Lab7b.WS.DelDictRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public Lab7b.WS.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(Lab7b.WS.GetAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllRequestBody {
        
        public GetAllRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public Lab7b.WS.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(Lab7b.WS.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(string GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDictRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDict", Namespace="http://tempuri.org/", Order=0)]
        public Lab7b.WS.GetDictRequestBody Body;
        
        public GetDictRequest() {
        }
        
        public GetDictRequest(Lab7b.WS.GetDictRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetDictRequestBody {
        
        public GetDictRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDictResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDictResponse", Namespace="http://tempuri.org/", Order=0)]
        public Lab7b.WS.GetDictResponseBody Body;
        
        public GetDictResponse() {
        }
        
        public GetDictResponse(Lab7b.WS.GetDictResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetDictResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Lab7b.WS.Telephone[] GetDictResult;
        
        public GetDictResponseBody() {
        }
        
        public GetDictResponseBody(Lab7b.WS.Telephone[] GetDictResult) {
            this.GetDictResult = GetDictResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddDictRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddDict", Namespace="http://tempuri.org/", Order=0)]
        public Lab7b.WS.AddDictRequestBody Body;
        
        public AddDictRequest() {
        }
        
        public AddDictRequest(Lab7b.WS.AddDictRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddDictRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string surname;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int number;
        
        public AddDictRequestBody() {
        }
        
        public AddDictRequestBody(string surname, int number) {
            this.surname = surname;
            this.number = number;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddDictResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddDictResponse", Namespace="http://tempuri.org/", Order=0)]
        public Lab7b.WS.AddDictResponseBody Body;
        
        public AddDictResponse() {
        }
        
        public AddDictResponse(Lab7b.WS.AddDictResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddDictResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AddDictResult;
        
        public AddDictResponseBody() {
        }
        
        public AddDictResponseBody(string AddDictResult) {
            this.AddDictResult = AddDictResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdDictRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdDict", Namespace="http://tempuri.org/", Order=0)]
        public Lab7b.WS.UpdDictRequestBody Body;
        
        public UpdDictRequest() {
        }
        
        public UpdDictRequest(Lab7b.WS.UpdDictRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdDictRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string surname;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int number;
        
        public UpdDictRequestBody() {
        }
        
        public UpdDictRequestBody(int id, string surname, int number) {
            this.id = id;
            this.surname = surname;
            this.number = number;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdDictResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdDictResponse", Namespace="http://tempuri.org/", Order=0)]
        public Lab7b.WS.UpdDictResponseBody Body;
        
        public UpdDictResponse() {
        }
        
        public UpdDictResponse(Lab7b.WS.UpdDictResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdDictResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string UpdDictResult;
        
        public UpdDictResponseBody() {
        }
        
        public UpdDictResponseBody(string UpdDictResult) {
            this.UpdDictResult = UpdDictResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DelDictRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DelDict", Namespace="http://tempuri.org/", Order=0)]
        public Lab7b.WS.DelDictRequestBody Body;
        
        public DelDictRequest() {
        }
        
        public DelDictRequest(Lab7b.WS.DelDictRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DelDictRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public DelDictRequestBody() {
        }
        
        public DelDictRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DelDictResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DelDictResponse", Namespace="http://tempuri.org/", Order=0)]
        public Lab7b.WS.DelDictResponseBody Body;
        
        public DelDictResponse() {
        }
        
        public DelDictResponse(Lab7b.WS.DelDictResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DelDictResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DelDictResult;
        
        public DelDictResponseBody() {
        }
        
        public DelDictResponseBody(string DelDictResult) {
            this.DelDictResult = DelDictResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : Lab7b.WS.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<Lab7b.WS.WebServiceSoap>, Lab7b.WS.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab7b.WS.GetAllResponse Lab7b.WS.WebServiceSoap.GetAll(Lab7b.WS.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public string GetAll() {
            Lab7b.WS.GetAllRequest inValue = new Lab7b.WS.GetAllRequest();
            inValue.Body = new Lab7b.WS.GetAllRequestBody();
            Lab7b.WS.GetAllResponse retVal = ((Lab7b.WS.WebServiceSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab7b.WS.GetAllResponse> Lab7b.WS.WebServiceSoap.GetAllAsync(Lab7b.WS.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab7b.WS.GetAllResponse> GetAllAsync() {
            Lab7b.WS.GetAllRequest inValue = new Lab7b.WS.GetAllRequest();
            inValue.Body = new Lab7b.WS.GetAllRequestBody();
            return ((Lab7b.WS.WebServiceSoap)(this)).GetAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab7b.WS.GetDictResponse Lab7b.WS.WebServiceSoap.GetDict(Lab7b.WS.GetDictRequest request) {
            return base.Channel.GetDict(request);
        }
        
        public Lab7b.WS.Telephone[] GetDict() {
            Lab7b.WS.GetDictRequest inValue = new Lab7b.WS.GetDictRequest();
            inValue.Body = new Lab7b.WS.GetDictRequestBody();
            Lab7b.WS.GetDictResponse retVal = ((Lab7b.WS.WebServiceSoap)(this)).GetDict(inValue);
            return retVal.Body.GetDictResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab7b.WS.GetDictResponse> Lab7b.WS.WebServiceSoap.GetDictAsync(Lab7b.WS.GetDictRequest request) {
            return base.Channel.GetDictAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab7b.WS.GetDictResponse> GetDictAsync() {
            Lab7b.WS.GetDictRequest inValue = new Lab7b.WS.GetDictRequest();
            inValue.Body = new Lab7b.WS.GetDictRequestBody();
            return ((Lab7b.WS.WebServiceSoap)(this)).GetDictAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab7b.WS.AddDictResponse Lab7b.WS.WebServiceSoap.AddDict(Lab7b.WS.AddDictRequest request) {
            return base.Channel.AddDict(request);
        }
        
        public string AddDict(string surname, int number) {
            Lab7b.WS.AddDictRequest inValue = new Lab7b.WS.AddDictRequest();
            inValue.Body = new Lab7b.WS.AddDictRequestBody();
            inValue.Body.surname = surname;
            inValue.Body.number = number;
            Lab7b.WS.AddDictResponse retVal = ((Lab7b.WS.WebServiceSoap)(this)).AddDict(inValue);
            return retVal.Body.AddDictResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab7b.WS.AddDictResponse> Lab7b.WS.WebServiceSoap.AddDictAsync(Lab7b.WS.AddDictRequest request) {
            return base.Channel.AddDictAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab7b.WS.AddDictResponse> AddDictAsync(string surname, int number) {
            Lab7b.WS.AddDictRequest inValue = new Lab7b.WS.AddDictRequest();
            inValue.Body = new Lab7b.WS.AddDictRequestBody();
            inValue.Body.surname = surname;
            inValue.Body.number = number;
            return ((Lab7b.WS.WebServiceSoap)(this)).AddDictAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab7b.WS.UpdDictResponse Lab7b.WS.WebServiceSoap.UpdDict(Lab7b.WS.UpdDictRequest request) {
            return base.Channel.UpdDict(request);
        }
        
        public string UpdDict(int id, string surname, int number) {
            Lab7b.WS.UpdDictRequest inValue = new Lab7b.WS.UpdDictRequest();
            inValue.Body = new Lab7b.WS.UpdDictRequestBody();
            inValue.Body.id = id;
            inValue.Body.surname = surname;
            inValue.Body.number = number;
            Lab7b.WS.UpdDictResponse retVal = ((Lab7b.WS.WebServiceSoap)(this)).UpdDict(inValue);
            return retVal.Body.UpdDictResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab7b.WS.UpdDictResponse> Lab7b.WS.WebServiceSoap.UpdDictAsync(Lab7b.WS.UpdDictRequest request) {
            return base.Channel.UpdDictAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab7b.WS.UpdDictResponse> UpdDictAsync(int id, string surname, int number) {
            Lab7b.WS.UpdDictRequest inValue = new Lab7b.WS.UpdDictRequest();
            inValue.Body = new Lab7b.WS.UpdDictRequestBody();
            inValue.Body.id = id;
            inValue.Body.surname = surname;
            inValue.Body.number = number;
            return ((Lab7b.WS.WebServiceSoap)(this)).UpdDictAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab7b.WS.DelDictResponse Lab7b.WS.WebServiceSoap.DelDict(Lab7b.WS.DelDictRequest request) {
            return base.Channel.DelDict(request);
        }
        
        public string DelDict(int id) {
            Lab7b.WS.DelDictRequest inValue = new Lab7b.WS.DelDictRequest();
            inValue.Body = new Lab7b.WS.DelDictRequestBody();
            inValue.Body.id = id;
            Lab7b.WS.DelDictResponse retVal = ((Lab7b.WS.WebServiceSoap)(this)).DelDict(inValue);
            return retVal.Body.DelDictResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab7b.WS.DelDictResponse> Lab7b.WS.WebServiceSoap.DelDictAsync(Lab7b.WS.DelDictRequest request) {
            return base.Channel.DelDictAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab7b.WS.DelDictResponse> DelDictAsync(int id) {
            Lab7b.WS.DelDictRequest inValue = new Lab7b.WS.DelDictRequest();
            inValue.Body = new Lab7b.WS.DelDictRequestBody();
            inValue.Body.id = id;
            return ((Lab7b.WS.WebServiceSoap)(this)).DelDictAsync(inValue);
        }
    }
}
