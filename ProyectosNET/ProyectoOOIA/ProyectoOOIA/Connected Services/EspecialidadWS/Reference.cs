﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoOOIA.EspecialidadWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", ConfigurationName="EspecialidadWS.EspecialidadWS")]
    public interface EspecialidadWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/listarEsppecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/listarEsppecialidadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EspecialidadWS.listarEsppecialidadResponse listarEsppecialidad(ProyectoOOIA.EspecialidadWS.listarEsppecialidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/listarEsppecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/listarEsppecialidadResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.listarEsppecialidadResponse> listarEsppecialidadAsync(ProyectoOOIA.EspecialidadWS.listarEsppecialidadRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/insertarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/insertarEspecialidadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EspecialidadWS.insertarEspecialidadResponse insertarEspecialidad(ProyectoOOIA.EspecialidadWS.insertarEspecialidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/insertarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/insertarEspecialidadResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.insertarEspecialidadResponse> insertarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.insertarEspecialidadRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/modificarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/modificarEspecialidadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EspecialidadWS.modificarEspecialidadResponse modificarEspecialidad(ProyectoOOIA.EspecialidadWS.modificarEspecialidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/modificarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/modificarEspecialidadResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.modificarEspecialidadResponse> modificarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.modificarEspecialidadRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/eliminarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/eliminarEspecialidadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EspecialidadWS.eliminarEspecialidadResponse eliminarEspecialidad(ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/eliminarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/eliminarEspecialidadResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.eliminarEspecialidadResponse> eliminarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class especialidad : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int id_especialidadField;
        
        private string nombre_especialidadField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int id_especialidad {
            get {
                return this.id_especialidadField;
            }
            set {
                this.id_especialidadField = value;
                this.RaisePropertyChanged("id_especialidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string nombre_especialidad {
            get {
                return this.nombre_especialidadField;
            }
            set {
                this.nombre_especialidadField = value;
                this.RaisePropertyChanged("nombre_especialidad");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarEsppecialidad", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarEsppecialidadRequest {
        
        public listarEsppecialidadRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarEsppecialidadResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarEsppecialidadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.EspecialidadWS.especialidad[] @return;
        
        public listarEsppecialidadResponse() {
        }
        
        public listarEsppecialidadResponse(ProyectoOOIA.EspecialidadWS.especialidad[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarEspecialidad", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarEspecialidadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.EspecialidadWS.especialidad especialidad;
        
        public insertarEspecialidadRequest() {
        }
        
        public insertarEspecialidadRequest(ProyectoOOIA.EspecialidadWS.especialidad especialidad) {
            this.especialidad = especialidad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarEspecialidadResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarEspecialidadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarEspecialidadResponse() {
        }
        
        public insertarEspecialidadResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarEspecialidad", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarEspecialidadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.EspecialidadWS.especialidad especialidad;
        
        public modificarEspecialidadRequest() {
        }
        
        public modificarEspecialidadRequest(ProyectoOOIA.EspecialidadWS.especialidad especialidad) {
            this.especialidad = especialidad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarEspecialidadResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarEspecialidadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarEspecialidadResponse() {
        }
        
        public modificarEspecialidadResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarEspecialidad", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarEspecialidadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.EspecialidadWS.especialidad especialidad;
        
        public eliminarEspecialidadRequest() {
        }
        
        public eliminarEspecialidadRequest(ProyectoOOIA.EspecialidadWS.especialidad especialidad) {
            this.especialidad = especialidad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarEspecialidadResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarEspecialidadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarEspecialidadResponse() {
        }
        
        public eliminarEspecialidadResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EspecialidadWSChannel : ProyectoOOIA.EspecialidadWS.EspecialidadWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EspecialidadWSClient : System.ServiceModel.ClientBase<ProyectoOOIA.EspecialidadWS.EspecialidadWS>, ProyectoOOIA.EspecialidadWS.EspecialidadWS {
        
        public EspecialidadWSClient() {
        }
        
        public EspecialidadWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EspecialidadWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EspecialidadWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EspecialidadWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.EspecialidadWS.listarEsppecialidadResponse ProyectoOOIA.EspecialidadWS.EspecialidadWS.listarEsppecialidad(ProyectoOOIA.EspecialidadWS.listarEsppecialidadRequest request) {
            return base.Channel.listarEsppecialidad(request);
        }
        
        public ProyectoOOIA.EspecialidadWS.especialidad[] listarEsppecialidad() {
            ProyectoOOIA.EspecialidadWS.listarEsppecialidadRequest inValue = new ProyectoOOIA.EspecialidadWS.listarEsppecialidadRequest();
            ProyectoOOIA.EspecialidadWS.listarEsppecialidadResponse retVal = ((ProyectoOOIA.EspecialidadWS.EspecialidadWS)(this)).listarEsppecialidad(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.listarEsppecialidadResponse> ProyectoOOIA.EspecialidadWS.EspecialidadWS.listarEsppecialidadAsync(ProyectoOOIA.EspecialidadWS.listarEsppecialidadRequest request) {
            return base.Channel.listarEsppecialidadAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.listarEsppecialidadResponse> listarEsppecialidadAsync() {
            ProyectoOOIA.EspecialidadWS.listarEsppecialidadRequest inValue = new ProyectoOOIA.EspecialidadWS.listarEsppecialidadRequest();
            return ((ProyectoOOIA.EspecialidadWS.EspecialidadWS)(this)).listarEsppecialidadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.EspecialidadWS.insertarEspecialidadResponse ProyectoOOIA.EspecialidadWS.EspecialidadWS.insertarEspecialidad(ProyectoOOIA.EspecialidadWS.insertarEspecialidadRequest request) {
            return base.Channel.insertarEspecialidad(request);
        }
        
        public int insertarEspecialidad(ProyectoOOIA.EspecialidadWS.especialidad especialidad) {
            ProyectoOOIA.EspecialidadWS.insertarEspecialidadRequest inValue = new ProyectoOOIA.EspecialidadWS.insertarEspecialidadRequest();
            inValue.especialidad = especialidad;
            ProyectoOOIA.EspecialidadWS.insertarEspecialidadResponse retVal = ((ProyectoOOIA.EspecialidadWS.EspecialidadWS)(this)).insertarEspecialidad(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.insertarEspecialidadResponse> ProyectoOOIA.EspecialidadWS.EspecialidadWS.insertarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.insertarEspecialidadRequest request) {
            return base.Channel.insertarEspecialidadAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.insertarEspecialidadResponse> insertarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.especialidad especialidad) {
            ProyectoOOIA.EspecialidadWS.insertarEspecialidadRequest inValue = new ProyectoOOIA.EspecialidadWS.insertarEspecialidadRequest();
            inValue.especialidad = especialidad;
            return ((ProyectoOOIA.EspecialidadWS.EspecialidadWS)(this)).insertarEspecialidadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.EspecialidadWS.modificarEspecialidadResponse ProyectoOOIA.EspecialidadWS.EspecialidadWS.modificarEspecialidad(ProyectoOOIA.EspecialidadWS.modificarEspecialidadRequest request) {
            return base.Channel.modificarEspecialidad(request);
        }
        
        public int modificarEspecialidad(ProyectoOOIA.EspecialidadWS.especialidad especialidad) {
            ProyectoOOIA.EspecialidadWS.modificarEspecialidadRequest inValue = new ProyectoOOIA.EspecialidadWS.modificarEspecialidadRequest();
            inValue.especialidad = especialidad;
            ProyectoOOIA.EspecialidadWS.modificarEspecialidadResponse retVal = ((ProyectoOOIA.EspecialidadWS.EspecialidadWS)(this)).modificarEspecialidad(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.modificarEspecialidadResponse> ProyectoOOIA.EspecialidadWS.EspecialidadWS.modificarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.modificarEspecialidadRequest request) {
            return base.Channel.modificarEspecialidadAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.modificarEspecialidadResponse> modificarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.especialidad especialidad) {
            ProyectoOOIA.EspecialidadWS.modificarEspecialidadRequest inValue = new ProyectoOOIA.EspecialidadWS.modificarEspecialidadRequest();
            inValue.especialidad = especialidad;
            return ((ProyectoOOIA.EspecialidadWS.EspecialidadWS)(this)).modificarEspecialidadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.EspecialidadWS.eliminarEspecialidadResponse ProyectoOOIA.EspecialidadWS.EspecialidadWS.eliminarEspecialidad(ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest request) {
            return base.Channel.eliminarEspecialidad(request);
        }
        
        public int eliminarEspecialidad(ProyectoOOIA.EspecialidadWS.especialidad especialidad) {
            ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest inValue = new ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest();
            inValue.especialidad = especialidad;
            ProyectoOOIA.EspecialidadWS.eliminarEspecialidadResponse retVal = ((ProyectoOOIA.EspecialidadWS.EspecialidadWS)(this)).eliminarEspecialidad(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.eliminarEspecialidadResponse> ProyectoOOIA.EspecialidadWS.EspecialidadWS.eliminarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest request) {
            return base.Channel.eliminarEspecialidadAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.eliminarEspecialidadResponse> eliminarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.especialidad especialidad) {
            ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest inValue = new ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest();
            inValue.especialidad = especialidad;
            return ((ProyectoOOIA.EspecialidadWS.EspecialidadWS)(this)).eliminarEspecialidadAsync(inValue);
        }
    }
}
