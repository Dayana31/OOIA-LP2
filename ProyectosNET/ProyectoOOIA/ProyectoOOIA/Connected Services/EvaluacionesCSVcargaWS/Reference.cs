﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoOOIA.EvaluacionesCSVcargaWS {
    
    
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services/", ConfigurationName="EvaluacionesCSVcargaWS.EvaluacionesCSVcargaWS")]
    public interface EvaluacionesCSVcargaWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services/EvaluacionesCSVcargaWS/CargarCSVevaluacionesRequest", ReplyAction="http://services/EvaluacionesCSVcargaWS/CargarCSVevaluacionesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ProyectoOOIA.EvaluacionesCSVcargaWS.FileNotFoundException), Action="http://services/EvaluacionesCSVcargaWS/CargarCSVevaluaciones/Fault/FileNotFoundEx" +
            "ception", Name="FileNotFoundException")]
        [System.ServiceModel.FaultContractAttribute(typeof(ProyectoOOIA.EvaluacionesCSVcargaWS.ParseException), Action="http://services/EvaluacionesCSVcargaWS/CargarCSVevaluaciones/Fault/ParseException" +
            "", Name="ParseException")]
        [System.ServiceModel.FaultContractAttribute(typeof(ProyectoOOIA.EvaluacionesCSVcargaWS.IOException), Action="http://services/EvaluacionesCSVcargaWS/CargarCSVevaluaciones/Fault/IOException", Name="IOException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EvaluacionesCSVcargaWS.CargarCSVevaluacionesResponse CargarCSVevaluaciones(ProyectoOOIA.EvaluacionesCSVcargaWS.CargarCSVevaluacionesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services/EvaluacionesCSVcargaWS/CargarCSVevaluacionesRequest", ReplyAction="http://services/EvaluacionesCSVcargaWS/CargarCSVevaluacionesResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EvaluacionesCSVcargaWS.CargarCSVevaluacionesResponse> CargarCSVevaluacionesAsync(ProyectoOOIA.EvaluacionesCSVcargaWS.CargarCSVevaluacionesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CargarCSVevaluaciones", WrapperNamespace="http://services/", IsWrapped=true)]
    public partial class CargarCSVevaluacionesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", IsNullable=true)]
        public byte[] RutaArchivo;
        
        public CargarCSVevaluacionesRequest() {
        }
        
        public CargarCSVevaluacionesRequest(byte[] RutaArchivo) {
            this.RutaArchivo = RutaArchivo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CargarCSVevaluacionesResponse", WrapperNamespace="http://services/", IsWrapped=true)]
    public partial class CargarCSVevaluacionesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public CargarCSVevaluacionesResponse() {
        }
        
        public CargarCSVevaluacionesResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EvaluacionesCSVcargaWSChannel : ProyectoOOIA.EvaluacionesCSVcargaWS.EvaluacionesCSVcargaWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EvaluacionesCSVcargaWSClient : System.ServiceModel.ClientBase<ProyectoOOIA.EvaluacionesCSVcargaWS.EvaluacionesCSVcargaWS>, ProyectoOOIA.EvaluacionesCSVcargaWS.EvaluacionesCSVcargaWS {
        
        public EvaluacionesCSVcargaWSClient() {
        }
        
        public EvaluacionesCSVcargaWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EvaluacionesCSVcargaWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EvaluacionesCSVcargaWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EvaluacionesCSVcargaWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.EvaluacionesCSVcargaWS.CargarCSVevaluacionesResponse ProyectoOOIA.EvaluacionesCSVcargaWS.EvaluacionesCSVcargaWS.CargarCSVevaluaciones(ProyectoOOIA.EvaluacionesCSVcargaWS.CargarCSVevaluacionesRequest request) {
            return base.Channel.CargarCSVevaluaciones(request);
        }
        
        public int CargarCSVevaluaciones(byte[] RutaArchivo) {
            ProyectoOOIA.EvaluacionesCSVcargaWS.CargarCSVevaluacionesRequest inValue = new ProyectoOOIA.EvaluacionesCSVcargaWS.CargarCSVevaluacionesRequest();
            inValue.RutaArchivo = RutaArchivo;
            ProyectoOOIA.EvaluacionesCSVcargaWS.CargarCSVevaluacionesResponse retVal = ((ProyectoOOIA.EvaluacionesCSVcargaWS.EvaluacionesCSVcargaWS)(this)).CargarCSVevaluaciones(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EvaluacionesCSVcargaWS.CargarCSVevaluacionesResponse> ProyectoOOIA.EvaluacionesCSVcargaWS.EvaluacionesCSVcargaWS.CargarCSVevaluacionesAsync(ProyectoOOIA.EvaluacionesCSVcargaWS.CargarCSVevaluacionesRequest request) {
            return base.Channel.CargarCSVevaluacionesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EvaluacionesCSVcargaWS.CargarCSVevaluacionesResponse> CargarCSVevaluacionesAsync(byte[] RutaArchivo) {
            ProyectoOOIA.EvaluacionesCSVcargaWS.CargarCSVevaluacionesRequest inValue = new ProyectoOOIA.EvaluacionesCSVcargaWS.CargarCSVevaluacionesRequest();
            inValue.RutaArchivo = RutaArchivo;
            return ((ProyectoOOIA.EvaluacionesCSVcargaWS.EvaluacionesCSVcargaWS)(this)).CargarCSVevaluacionesAsync(inValue);
        }
    }
}
