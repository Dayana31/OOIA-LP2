﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoOOIA.PsicologosCSVcargaWS {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services/")]
    public partial class FileNotFoundException : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services/")]
    public partial class ParseException : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int errorOffsetField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int errorOffset {
            get {
                return this.errorOffsetField;
            }
            set {
                this.errorOffsetField = value;
                this.RaisePropertyChanged("errorOffset");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services/")]
    public partial class IOException : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services/", ConfigurationName="PsicologosCSVcargaWS.PsicologosCSVcargaWS")]
    public interface PsicologosCSVcargaWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services/PsicologosCSVcargaWS/CargarCSVpsicologosRequest", ReplyAction="http://services/PsicologosCSVcargaWS/CargarCSVpsicologosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ProyectoOOIA.PsicologosCSVcargaWS.FileNotFoundException), Action="http://services/PsicologosCSVcargaWS/CargarCSVpsicologos/Fault/FileNotFoundExcept" +
            "ion", Name="FileNotFoundException")]
        [System.ServiceModel.FaultContractAttribute(typeof(ProyectoOOIA.PsicologosCSVcargaWS.ParseException), Action="http://services/PsicologosCSVcargaWS/CargarCSVpsicologos/Fault/ParseException", Name="ParseException")]
        [System.ServiceModel.FaultContractAttribute(typeof(ProyectoOOIA.PsicologosCSVcargaWS.IOException), Action="http://services/PsicologosCSVcargaWS/CargarCSVpsicologos/Fault/IOException", Name="IOException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.PsicologosCSVcargaWS.CargarCSVpsicologosResponse CargarCSVpsicologos(ProyectoOOIA.PsicologosCSVcargaWS.CargarCSVpsicologosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services/PsicologosCSVcargaWS/CargarCSVpsicologosRequest", ReplyAction="http://services/PsicologosCSVcargaWS/CargarCSVpsicologosResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.PsicologosCSVcargaWS.CargarCSVpsicologosResponse> CargarCSVpsicologosAsync(ProyectoOOIA.PsicologosCSVcargaWS.CargarCSVpsicologosRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CargarCSVpsicologos", WrapperNamespace="http://services/", IsWrapped=true)]
    public partial class CargarCSVpsicologosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", IsNullable=true)]
        public byte[] RutaArchivo;
        
        public CargarCSVpsicologosRequest() {
        }
        
        public CargarCSVpsicologosRequest(byte[] RutaArchivo) {
            this.RutaArchivo = RutaArchivo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CargarCSVpsicologosResponse", WrapperNamespace="http://services/", IsWrapped=true)]
    public partial class CargarCSVpsicologosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public CargarCSVpsicologosResponse() {
        }
        
        public CargarCSVpsicologosResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PsicologosCSVcargaWSChannel : ProyectoOOIA.PsicologosCSVcargaWS.PsicologosCSVcargaWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PsicologosCSVcargaWSClient : System.ServiceModel.ClientBase<ProyectoOOIA.PsicologosCSVcargaWS.PsicologosCSVcargaWS>, ProyectoOOIA.PsicologosCSVcargaWS.PsicologosCSVcargaWS {
        
        public PsicologosCSVcargaWSClient() {
        }
        
        public PsicologosCSVcargaWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PsicologosCSVcargaWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PsicologosCSVcargaWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PsicologosCSVcargaWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.PsicologosCSVcargaWS.CargarCSVpsicologosResponse ProyectoOOIA.PsicologosCSVcargaWS.PsicologosCSVcargaWS.CargarCSVpsicologos(ProyectoOOIA.PsicologosCSVcargaWS.CargarCSVpsicologosRequest request) {
            return base.Channel.CargarCSVpsicologos(request);
        }
        
        public int CargarCSVpsicologos(byte[] RutaArchivo) {
            ProyectoOOIA.PsicologosCSVcargaWS.CargarCSVpsicologosRequest inValue = new ProyectoOOIA.PsicologosCSVcargaWS.CargarCSVpsicologosRequest();
            inValue.RutaArchivo = RutaArchivo;
            ProyectoOOIA.PsicologosCSVcargaWS.CargarCSVpsicologosResponse retVal = ((ProyectoOOIA.PsicologosCSVcargaWS.PsicologosCSVcargaWS)(this)).CargarCSVpsicologos(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.PsicologosCSVcargaWS.CargarCSVpsicologosResponse> ProyectoOOIA.PsicologosCSVcargaWS.PsicologosCSVcargaWS.CargarCSVpsicologosAsync(ProyectoOOIA.PsicologosCSVcargaWS.CargarCSVpsicologosRequest request) {
            return base.Channel.CargarCSVpsicologosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.PsicologosCSVcargaWS.CargarCSVpsicologosResponse> CargarCSVpsicologosAsync(byte[] RutaArchivo) {
            ProyectoOOIA.PsicologosCSVcargaWS.CargarCSVpsicologosRequest inValue = new ProyectoOOIA.PsicologosCSVcargaWS.CargarCSVpsicologosRequest();
            inValue.RutaArchivo = RutaArchivo;
            return ((ProyectoOOIA.PsicologosCSVcargaWS.PsicologosCSVcargaWS)(this)).CargarCSVpsicologosAsync(inValue);
        }
    }
}