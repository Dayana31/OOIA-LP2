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
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/listarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/listarEspecialidadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EspecialidadWS.listarEspecialidadResponse listarEspecialidad(ProyectoOOIA.EspecialidadWS.listarEspecialidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/listarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/listarEspecialidadResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.listarEspecialidadResponse> listarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.listarEspecialidadRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/insertarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/insertarEspecialidadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EspecialidadWS.insertarEspecialidadResponse insertarEspecialidad(ProyectoOOIA.EspecialidadWS.insertarEspecialidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/insertarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/insertarEspecialidadResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.insertarEspecialidadResponse> insertarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.insertarEspecialidadRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
<<<<<<< HEAD
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/eliminarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/eliminarEspecialidadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EspecialidadWS.eliminarEspecialidadResponse eliminarEspecialidad(ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/eliminarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/eliminarEspecialidadResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.eliminarEspecialidadResponse> eliminarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest request);
=======
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/modificarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/modificarEspecialidadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EspecialidadWS.modificarEspecialidadResponse modificarEspecialidad(ProyectoOOIA.EspecialidadWS.modificarEspecialidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/modificarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/modificarEspecialidadResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.modificarEspecialidadResponse> modificarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.modificarEspecialidadRequest request);
>>>>>>> 998d69151b7b330c8c64cd1804285d795b91d0af
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/insertarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/insertarEspecialidadResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EspecialidadWS.insertarEspecialidadResponse insertarEspecialidad(ProyectoOOIA.EspecialidadWS.insertarEspecialidadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EspecialidadWS/insertarEspecialidadRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EspecialidadWS/insertarEspecialidadResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.insertarEspecialidadResponse> insertarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.insertarEspecialidadRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class especialidad : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private int id_especialidadField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
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
<<<<<<< HEAD
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarEspecialidad", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarEspecialidadRequest {
        
        public listarEspecialidadRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarEspecialidadResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarEspecialidadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.EspecialidadWS.especialidad[] @return;
        
        public listarEspecialidadResponse() {
        }
        
        public listarEspecialidadResponse(ProyectoOOIA.EspecialidadWS.especialidad[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarEspecialidad", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarEspecialidadRequest {
=======
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarEspecialidad", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarEspecialidadRequest {
>>>>>>> 998d69151b7b330c8c64cd1804285d795b91d0af
        
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
<<<<<<< HEAD
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarEspecialidad", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarEspecialidadRequest {
=======
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarEspecialidad", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarEspecialidadRequest {
>>>>>>> 998d69151b7b330c8c64cd1804285d795b91d0af
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id_especialidad;
        
<<<<<<< HEAD
        public eliminarEspecialidadRequest() {
        }
        
        public eliminarEspecialidadRequest(int id_especialidad) {
            this.id_especialidad = id_especialidad;
=======
        public modificarEspecialidadRequest() {
        }
        
        public modificarEspecialidadRequest(ProyectoOOIA.EspecialidadWS.especialidad especialidad) {
            this.especialidad = especialidad;
>>>>>>> 998d69151b7b330c8c64cd1804285d795b91d0af
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
<<<<<<< HEAD
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarEspecialidadResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarEspecialidadResponse {
=======
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarEspecialidadResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarEspecialidadResponse {
>>>>>>> 998d69151b7b330c8c64cd1804285d795b91d0af
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
<<<<<<< HEAD
        public eliminarEspecialidadResponse() {
        }
        
        public eliminarEspecialidadResponse(int @return) {
=======
        public modificarEspecialidadResponse() {
        }
        
        public modificarEspecialidadResponse(int @return) {
>>>>>>> 998d69151b7b330c8c64cd1804285d795b91d0af
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
        ProyectoOOIA.EspecialidadWS.listarEspecialidadResponse ProyectoOOIA.EspecialidadWS.EspecialidadWS.listarEspecialidad(ProyectoOOIA.EspecialidadWS.listarEspecialidadRequest request) {
            return base.Channel.listarEspecialidad(request);
        }
        
        public ProyectoOOIA.EspecialidadWS.especialidad[] listarEspecialidad() {
            ProyectoOOIA.EspecialidadWS.listarEspecialidadRequest inValue = new ProyectoOOIA.EspecialidadWS.listarEspecialidadRequest();
            ProyectoOOIA.EspecialidadWS.listarEspecialidadResponse retVal = ((ProyectoOOIA.EspecialidadWS.EspecialidadWS)(this)).listarEspecialidad(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.listarEspecialidadResponse> ProyectoOOIA.EspecialidadWS.EspecialidadWS.listarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.listarEspecialidadRequest request) {
            return base.Channel.listarEspecialidadAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.listarEspecialidadResponse> listarEspecialidadAsync() {
            ProyectoOOIA.EspecialidadWS.listarEspecialidadRequest inValue = new ProyectoOOIA.EspecialidadWS.listarEspecialidadRequest();
            return ((ProyectoOOIA.EspecialidadWS.EspecialidadWS)(this)).listarEspecialidadAsync(inValue);
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
<<<<<<< HEAD
        ProyectoOOIA.EspecialidadWS.eliminarEspecialidadResponse ProyectoOOIA.EspecialidadWS.EspecialidadWS.eliminarEspecialidad(ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest request) {
            return base.Channel.eliminarEspecialidad(request);
        }
        
        public int eliminarEspecialidad(int id_especialidad) {
            ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest inValue = new ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest();
            inValue.id_especialidad = id_especialidad;
            ProyectoOOIA.EspecialidadWS.eliminarEspecialidadResponse retVal = ((ProyectoOOIA.EspecialidadWS.EspecialidadWS)(this)).eliminarEspecialidad(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.eliminarEspecialidadResponse> ProyectoOOIA.EspecialidadWS.EspecialidadWS.eliminarEspecialidadAsync(ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest request) {
            return base.Channel.eliminarEspecialidadAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EspecialidadWS.eliminarEspecialidadResponse> eliminarEspecialidadAsync(int id_especialidad) {
            ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest inValue = new ProyectoOOIA.EspecialidadWS.eliminarEspecialidadRequest();
            inValue.id_especialidad = id_especialidad;
            return ((ProyectoOOIA.EspecialidadWS.EspecialidadWS)(this)).eliminarEspecialidadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.EspecialidadWS.insertarEspecialidadResponse ProyectoOOIA.EspecialidadWS.EspecialidadWS.insertarEspecialidad(ProyectoOOIA.EspecialidadWS.insertarEspecialidadRequest request) {
            return base.Channel.insertarEspecialidad(request);
=======
        ProyectoOOIA.EspecialidadWS.modificarEspecialidadResponse ProyectoOOIA.EspecialidadWS.EspecialidadWS.modificarEspecialidad(ProyectoOOIA.EspecialidadWS.modificarEspecialidadRequest request) {
            return base.Channel.modificarEspecialidad(request);
>>>>>>> 998d69151b7b330c8c64cd1804285d795b91d0af
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
    }
}
