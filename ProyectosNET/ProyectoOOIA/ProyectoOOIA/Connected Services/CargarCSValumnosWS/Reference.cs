﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoOOIA.CargarCSValumnosWS {
    
    
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services/", ConfigurationName="CargarCSValumnosWS.AlumnosCSVcargaWS1")]
    public interface AlumnosCSVcargaWS1 {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services/AlumnosCSVcargaWS1/CargarCSValumnosRequest", ReplyAction="http://services/AlumnosCSVcargaWS1/CargarCSValumnosResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ProyectoOOIA.CargarCSValumnosWS.FileNotFoundException), Action="http://services/AlumnosCSVcargaWS1/CargarCSValumnos/Fault/FileNotFoundException", Name="FileNotFoundException")]
        [System.ServiceModel.FaultContractAttribute(typeof(ProyectoOOIA.CargarCSValumnosWS.ParseException), Action="http://services/AlumnosCSVcargaWS1/CargarCSValumnos/Fault/ParseException", Name="ParseException")]
        [System.ServiceModel.FaultContractAttribute(typeof(ProyectoOOIA.CargarCSValumnosWS.IOException), Action="http://services/AlumnosCSVcargaWS1/CargarCSValumnos/Fault/IOException", Name="IOException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.CargarCSValumnosWS.CargarCSValumnosResponse CargarCSValumnos(ProyectoOOIA.CargarCSValumnosWS.CargarCSValumnosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services/AlumnosCSVcargaWS1/CargarCSValumnosRequest", ReplyAction="http://services/AlumnosCSVcargaWS1/CargarCSValumnosResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.CargarCSValumnosWS.CargarCSValumnosResponse> CargarCSValumnosAsync(ProyectoOOIA.CargarCSValumnosWS.CargarCSValumnosRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CargarCSValumnos", WrapperNamespace="http://services/", IsWrapped=true)]
    public partial class CargarCSValumnosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", IsNullable=true)]
        public byte[] Rutaarchivo;
        
        public CargarCSValumnosRequest() {
        }
        
        public CargarCSValumnosRequest(byte[] Rutaarchivo) {
            this.Rutaarchivo = Rutaarchivo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CargarCSValumnosResponse", WrapperNamespace="http://services/", IsWrapped=true)]
    public partial class CargarCSValumnosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public CargarCSValumnosResponse() {
        }
        
        public CargarCSValumnosResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AlumnosCSVcargaWS1Channel : ProyectoOOIA.CargarCSValumnosWS.AlumnosCSVcargaWS1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AlumnosCSVcargaWS1Client : System.ServiceModel.ClientBase<ProyectoOOIA.CargarCSValumnosWS.AlumnosCSVcargaWS1>, ProyectoOOIA.CargarCSValumnosWS.AlumnosCSVcargaWS1 {
        
        public AlumnosCSVcargaWS1Client() {
        }
        
        public AlumnosCSVcargaWS1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AlumnosCSVcargaWS1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlumnosCSVcargaWS1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlumnosCSVcargaWS1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.CargarCSValumnosWS.CargarCSValumnosResponse ProyectoOOIA.CargarCSValumnosWS.AlumnosCSVcargaWS1.CargarCSValumnos(ProyectoOOIA.CargarCSValumnosWS.CargarCSValumnosRequest request) {
            return base.Channel.CargarCSValumnos(request);
        }
        
        public int CargarCSValumnos(byte[] Rutaarchivo) {
            ProyectoOOIA.CargarCSValumnosWS.CargarCSValumnosRequest inValue = new ProyectoOOIA.CargarCSValumnosWS.CargarCSValumnosRequest();
            inValue.Rutaarchivo = Rutaarchivo;
            ProyectoOOIA.CargarCSValumnosWS.CargarCSValumnosResponse retVal = ((ProyectoOOIA.CargarCSValumnosWS.AlumnosCSVcargaWS1)(this)).CargarCSValumnos(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.CargarCSValumnosWS.CargarCSValumnosResponse> ProyectoOOIA.CargarCSValumnosWS.AlumnosCSVcargaWS1.CargarCSValumnosAsync(ProyectoOOIA.CargarCSValumnosWS.CargarCSValumnosRequest request) {
            return base.Channel.CargarCSValumnosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.CargarCSValumnosWS.CargarCSValumnosResponse> CargarCSValumnosAsync(byte[] Rutaarchivo) {
            ProyectoOOIA.CargarCSValumnosWS.CargarCSValumnosRequest inValue = new ProyectoOOIA.CargarCSValumnosWS.CargarCSValumnosRequest();
            inValue.Rutaarchivo = Rutaarchivo;
            return ((ProyectoOOIA.CargarCSValumnosWS.AlumnosCSVcargaWS1)(this)).CargarCSValumnosAsync(inValue);
        }
    }
}
