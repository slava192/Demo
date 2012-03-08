﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17020
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abbyy.AnalysisService.Test.AnalysisService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ComprenoErrorInfo", Namespace="http://abbyy.com/AnalysisService")]
    [System.SerializableAttribute()]
    public partial class ComprenoErrorInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorCode CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorCode Code {
            get {
                return this.CodeField;
            }
            set {
                if ((this.CodeField.Equals(value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ComprenoErrorCode", Namespace="http://abbyy.com/AnalysisService")]
    public enum ComprenoErrorCode : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ServiceIsUnavailable = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TaskError = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InvalidArgs = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FileError = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LicenseUnavailable = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AuthorizationFailed = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnknownError = 7,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserCredentials", Namespace="http://abbyy.com/AnalysisService")]
    [System.SerializableAttribute()]
    public partial class UserCredentials : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsCustomUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsCustomUser {
            get {
                return this.IsCustomUserField;
            }
            set {
                if ((this.IsCustomUserField.Equals(value) != true)) {
                    this.IsCustomUserField = value;
                    this.RaisePropertyChanged("IsCustomUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileContainer", Namespace="http://abbyy.com/AnalysisService")]
    [System.SerializableAttribute()]
    public partial class FileContainer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ContentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExtensionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Contents {
            get {
                return this.ContentsField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentsField, value) != true)) {
                    this.ContentsField = value;
                    this.RaisePropertyChanged("Contents");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Extension {
            get {
                return this.ExtensionField;
            }
            set {
                if ((object.ReferenceEquals(this.ExtensionField, value) != true)) {
                    this.ExtensionField = value;
                    this.RaisePropertyChanged("Extension");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaskState", Namespace="http://abbyy.com/AnalysisService")]
    public enum TaskState : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotLoaded = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotProcessed = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InQueue = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Processing = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProcessingFailed = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProcessingSuccessfull = 5,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://abbyy.com/AnalysisService", ConfigurationName="AnalysisService.IAnalysisService")]
    public interface IAnalysisService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://abbyy.com/AnalysisService/IAnalysisService/Languages", ReplyAction="http://abbyy.com/AnalysisService/IAnalysisService/LanguagesResponse")]
        Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo Languages([System.ServiceModel.MessageParameterAttribute(Name="languages")] out string[] languages1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://abbyy.com/AnalysisService/IAnalysisService/MarkupLanguages", ReplyAction="http://abbyy.com/AnalysisService/IAnalysisService/MarkupLanguagesResponse")]
        Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo MarkupLanguages(out string[] languages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://abbyy.com/AnalysisService/IAnalysisService/XmlParameters", ReplyAction="http://abbyy.com/AnalysisService/IAnalysisService/XmlParametersResponse")]
        Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo XmlParameters([System.ServiceModel.MessageParameterAttribute(Name="xmlParameters")] out string[] xmlParameters1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://abbyy.com/AnalysisService/IAnalysisService/Extensions", ReplyAction="http://abbyy.com/AnalysisService/IAnalysisService/ExtensionsResponse")]
        Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo Extensions([System.ServiceModel.MessageParameterAttribute(Name="extensions")] out string[] extensions1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://abbyy.com/AnalysisService/IAnalysisService/IsAuthorizationNecessary", ReplyAction="http://abbyy.com/AnalysisService/IAnalysisService/IsAuthorizationNecessaryRespons" +
            "e")]
        Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo IsAuthorizationNecessary(out bool authorizationNecessary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://abbyy.com/AnalysisService/IAnalysisService/CreateTask", ReplyAction="http://abbyy.com/AnalysisService/IAnalysisService/CreateTaskResponse")]
        Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo CreateTask(out string taskId, Abbyy.AnalysisService.Test.AnalysisService.UserCredentials credentials);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://abbyy.com/AnalysisService/IAnalysisService/ProcessTask", ReplyAction="http://abbyy.com/AnalysisService/IAnalysisService/ProcessTaskResponse")]
        Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo ProcessTask(string taskId, int timeout);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://abbyy.com/AnalysisService/IAnalysisService/CancelProcessingTask", ReplyAction="http://abbyy.com/AnalysisService/IAnalysisService/CancelProcessingTaskResponse")]
        Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo CancelProcessingTask(string taskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://abbyy.com/AnalysisService/IAnalysisService/DeleteTask", ReplyAction="http://abbyy.com/AnalysisService/IAnalysisService/DeleteTaskResponse")]
        Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo DeleteTask(string taskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://abbyy.com/AnalysisService/IAnalysisService/SetTaskSource", ReplyAction="http://abbyy.com/AnalysisService/IAnalysisService/SetTaskSourceResponse")]
        Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo SetTaskSource(string taskId, Abbyy.AnalysisService.Test.AnalysisService.FileContainer source);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://abbyy.com/AnalysisService/IAnalysisService/SetTaskParams", ReplyAction="http://abbyy.com/AnalysisService/IAnalysisService/SetTaskParamsResponse")]
        Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo SetTaskParams(string taskId, string sourceLanguage, string markupLanguage, string[] xmlParameters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://abbyy.com/AnalysisService/IAnalysisService/GetTaskState", ReplyAction="http://abbyy.com/AnalysisService/IAnalysisService/GetTaskStateResponse")]
        Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo GetTaskState(out Abbyy.AnalysisService.Test.AnalysisService.TaskState taskState, out int percent, out string errorDescription, string taskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://abbyy.com/AnalysisService/IAnalysisService/GetTaskResult", ReplyAction="http://abbyy.com/AnalysisService/IAnalysisService/GetTaskResultResponse")]
        Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo GetTaskResult(out Abbyy.AnalysisService.Test.AnalysisService.FileContainer result, string taskId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAnalysisServiceChannel : Abbyy.AnalysisService.Test.AnalysisService.IAnalysisService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AnalysisServiceClient : System.ServiceModel.ClientBase<Abbyy.AnalysisService.Test.AnalysisService.IAnalysisService>, Abbyy.AnalysisService.Test.AnalysisService.IAnalysisService {
        
        public AnalysisServiceClient() {
        }
        
        public AnalysisServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AnalysisServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AnalysisServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AnalysisServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo Languages(out string[] languages1) {
            return base.Channel.Languages(out languages1);
        }
        
        public Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo MarkupLanguages(out string[] languages) {
            return base.Channel.MarkupLanguages(out languages);
        }
        
        public Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo XmlParameters(out string[] xmlParameters1) {
            return base.Channel.XmlParameters(out xmlParameters1);
        }
        
        public Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo Extensions(out string[] extensions1) {
            return base.Channel.Extensions(out extensions1);
        }
        
        public Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo IsAuthorizationNecessary(out bool authorizationNecessary) {
            return base.Channel.IsAuthorizationNecessary(out authorizationNecessary);
        }
        
        public Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo CreateTask(out string taskId, Abbyy.AnalysisService.Test.AnalysisService.UserCredentials credentials) {
            return base.Channel.CreateTask(out taskId, credentials);
        }
        
        public Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo ProcessTask(string taskId, int timeout) {
            return base.Channel.ProcessTask(taskId, timeout);
        }
        
        public Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo CancelProcessingTask(string taskId) {
            return base.Channel.CancelProcessingTask(taskId);
        }
        
        public Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo DeleteTask(string taskId) {
            return base.Channel.DeleteTask(taskId);
        }
        
        public Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo SetTaskSource(string taskId, Abbyy.AnalysisService.Test.AnalysisService.FileContainer source) {
            return base.Channel.SetTaskSource(taskId, source);
        }
        
        public Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo SetTaskParams(string taskId, string sourceLanguage, string markupLanguage, string[] xmlParameters) {
            return base.Channel.SetTaskParams(taskId, sourceLanguage, markupLanguage, xmlParameters);
        }
        
        public Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo GetTaskState(out Abbyy.AnalysisService.Test.AnalysisService.TaskState taskState, out int percent, out string errorDescription, string taskId) {
            return base.Channel.GetTaskState(out taskState, out percent, out errorDescription, taskId);
        }
        
        public Abbyy.AnalysisService.Test.AnalysisService.ComprenoErrorInfo GetTaskResult(out Abbyy.AnalysisService.Test.AnalysisService.FileContainer result, string taskId) {
            return base.Channel.GetTaskResult(out result, taskId);
        }
    }
}