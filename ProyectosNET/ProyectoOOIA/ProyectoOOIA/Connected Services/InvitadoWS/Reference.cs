﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoOOIA.InvitadoWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", ConfigurationName="InvitadoWS.InvitadoWS")]
    public interface InvitadoWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/InvitadoWS/modificarInvitadoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/InvitadoWS/modificarInvitadoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.InvitadoWS.modificarInvitadoResponse modificarInvitado(ProyectoOOIA.InvitadoWS.modificarInvitadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/InvitadoWS/modificarInvitadoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/InvitadoWS/modificarInvitadoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.InvitadoWS.modificarInvitadoResponse> modificarInvitadoAsync(ProyectoOOIA.InvitadoWS.modificarInvitadoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/InvitadoWS/eliminarInvitadoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/InvitadoWS/eliminarInvitadoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.InvitadoWS.eliminarInvitadoResponse eliminarInvitado(ProyectoOOIA.InvitadoWS.eliminarInvitadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/InvitadoWS/eliminarInvitadoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/InvitadoWS/eliminarInvitadoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.InvitadoWS.eliminarInvitadoResponse> eliminarInvitadoAsync(ProyectoOOIA.InvitadoWS.eliminarInvitadoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/InvitadoWS/insertarInvitadoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/InvitadoWS/insertarInvitadoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.InvitadoWS.insertarInvitadoResponse insertarInvitado(ProyectoOOIA.InvitadoWS.insertarInvitadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/InvitadoWS/insertarInvitadoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/InvitadoWS/insertarInvitadoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.InvitadoWS.insertarInvitadoResponse> insertarInvitadoAsync(ProyectoOOIA.InvitadoWS.insertarInvitadoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/InvitadoWS/listarInvitadoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/InvitadoWS/listarInvitadoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.InvitadoWS.listarInvitadoResponse listarInvitado(ProyectoOOIA.InvitadoWS.listarInvitadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/InvitadoWS/listarInvitadoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/InvitadoWS/listarInvitadoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.InvitadoWS.listarInvitadoResponse> listarInvitadoAsync(ProyectoOOIA.InvitadoWS.listarInvitadoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class invitado : miembroExterno {
        
        private int id_invitadoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int id_invitado {
            get {
                return this.id_invitadoField;
            }
            set {
                this.id_invitadoField = value;
                this.RaisePropertyChanged("id_invitado");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(invitado))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public abstract partial class miembroExterno : persona {
        
        private int id_miembro_externoField;
        
        private string ocupacionField;
        
        private int telefonoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int id_miembro_externo {
            get {
                return this.id_miembro_externoField;
            }
            set {
                this.id_miembro_externoField = value;
                this.RaisePropertyChanged("id_miembro_externo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ocupacion {
            get {
                return this.ocupacionField;
            }
            set {
                this.ocupacionField = value;
                this.RaisePropertyChanged("ocupacion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("telefono");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(miembroExterno))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(invitado))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public abstract partial class persona : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string correoField;
        
        private string direccionField;
        
        private string dniField;
        
        private int edadField;
        
        private int id_personaField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("correo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
                this.RaisePropertyChanged("direccion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string dni {
            get {
                return this.dniField;
            }
            set {
                this.dniField = value;
                this.RaisePropertyChanged("dni");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int edad {
            get {
                return this.edadField;
            }
            set {
                this.edadField = value;
                this.RaisePropertyChanged("edad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int id_persona {
            get {
                return this.id_personaField;
            }
            set {
                this.id_personaField = value;
                this.RaisePropertyChanged("id_persona");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarInvitado", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarInvitadoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.InvitadoWS.invitado invitado;
        
        public modificarInvitadoRequest() {
        }
        
        public modificarInvitadoRequest(ProyectoOOIA.InvitadoWS.invitado invitado) {
            this.invitado = invitado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarInvitadoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarInvitadoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarInvitadoResponse() {
        }
        
        public modificarInvitadoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarInvitado", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarInvitadoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.InvitadoWS.invitado invitado;
        
        public eliminarInvitadoRequest() {
        }
        
        public eliminarInvitadoRequest(ProyectoOOIA.InvitadoWS.invitado invitado) {
            this.invitado = invitado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarInvitadoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarInvitadoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarInvitadoResponse() {
        }
        
        public eliminarInvitadoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarInvitado", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarInvitadoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.InvitadoWS.invitado invitado;
        
        public insertarInvitadoRequest() {
        }
        
        public insertarInvitadoRequest(ProyectoOOIA.InvitadoWS.invitado invitado) {
            this.invitado = invitado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarInvitadoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarInvitadoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarInvitadoResponse() {
        }
        
        public insertarInvitadoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarInvitado", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarInvitadoRequest {
        
        public listarInvitadoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarInvitadoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarInvitadoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.InvitadoWS.invitado[] @return;
        
        public listarInvitadoResponse() {
        }
        
        public listarInvitadoResponse(ProyectoOOIA.InvitadoWS.invitado[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface InvitadoWSChannel : ProyectoOOIA.InvitadoWS.InvitadoWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InvitadoWSClient : System.ServiceModel.ClientBase<ProyectoOOIA.InvitadoWS.InvitadoWS>, ProyectoOOIA.InvitadoWS.InvitadoWS {
        
        public InvitadoWSClient() {
        }
        
        public InvitadoWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InvitadoWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InvitadoWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InvitadoWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.InvitadoWS.modificarInvitadoResponse ProyectoOOIA.InvitadoWS.InvitadoWS.modificarInvitado(ProyectoOOIA.InvitadoWS.modificarInvitadoRequest request) {
            return base.Channel.modificarInvitado(request);
        }
        
        public int modificarInvitado(ProyectoOOIA.InvitadoWS.invitado invitado) {
            ProyectoOOIA.InvitadoWS.modificarInvitadoRequest inValue = new ProyectoOOIA.InvitadoWS.modificarInvitadoRequest();
            inValue.invitado = invitado;
            ProyectoOOIA.InvitadoWS.modificarInvitadoResponse retVal = ((ProyectoOOIA.InvitadoWS.InvitadoWS)(this)).modificarInvitado(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.InvitadoWS.modificarInvitadoResponse> ProyectoOOIA.InvitadoWS.InvitadoWS.modificarInvitadoAsync(ProyectoOOIA.InvitadoWS.modificarInvitadoRequest request) {
            return base.Channel.modificarInvitadoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.InvitadoWS.modificarInvitadoResponse> modificarInvitadoAsync(ProyectoOOIA.InvitadoWS.invitado invitado) {
            ProyectoOOIA.InvitadoWS.modificarInvitadoRequest inValue = new ProyectoOOIA.InvitadoWS.modificarInvitadoRequest();
            inValue.invitado = invitado;
            return ((ProyectoOOIA.InvitadoWS.InvitadoWS)(this)).modificarInvitadoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.InvitadoWS.eliminarInvitadoResponse ProyectoOOIA.InvitadoWS.InvitadoWS.eliminarInvitado(ProyectoOOIA.InvitadoWS.eliminarInvitadoRequest request) {
            return base.Channel.eliminarInvitado(request);
        }
        
        public int eliminarInvitado(ProyectoOOIA.InvitadoWS.invitado invitado) {
            ProyectoOOIA.InvitadoWS.eliminarInvitadoRequest inValue = new ProyectoOOIA.InvitadoWS.eliminarInvitadoRequest();
            inValue.invitado = invitado;
            ProyectoOOIA.InvitadoWS.eliminarInvitadoResponse retVal = ((ProyectoOOIA.InvitadoWS.InvitadoWS)(this)).eliminarInvitado(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.InvitadoWS.eliminarInvitadoResponse> ProyectoOOIA.InvitadoWS.InvitadoWS.eliminarInvitadoAsync(ProyectoOOIA.InvitadoWS.eliminarInvitadoRequest request) {
            return base.Channel.eliminarInvitadoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.InvitadoWS.eliminarInvitadoResponse> eliminarInvitadoAsync(ProyectoOOIA.InvitadoWS.invitado invitado) {
            ProyectoOOIA.InvitadoWS.eliminarInvitadoRequest inValue = new ProyectoOOIA.InvitadoWS.eliminarInvitadoRequest();
            inValue.invitado = invitado;
            return ((ProyectoOOIA.InvitadoWS.InvitadoWS)(this)).eliminarInvitadoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.InvitadoWS.insertarInvitadoResponse ProyectoOOIA.InvitadoWS.InvitadoWS.insertarInvitado(ProyectoOOIA.InvitadoWS.insertarInvitadoRequest request) {
            return base.Channel.insertarInvitado(request);
        }
        
        public int insertarInvitado(ProyectoOOIA.InvitadoWS.invitado invitado) {
            ProyectoOOIA.InvitadoWS.insertarInvitadoRequest inValue = new ProyectoOOIA.InvitadoWS.insertarInvitadoRequest();
            inValue.invitado = invitado;
            ProyectoOOIA.InvitadoWS.insertarInvitadoResponse retVal = ((ProyectoOOIA.InvitadoWS.InvitadoWS)(this)).insertarInvitado(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.InvitadoWS.insertarInvitadoResponse> ProyectoOOIA.InvitadoWS.InvitadoWS.insertarInvitadoAsync(ProyectoOOIA.InvitadoWS.insertarInvitadoRequest request) {
            return base.Channel.insertarInvitadoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.InvitadoWS.insertarInvitadoResponse> insertarInvitadoAsync(ProyectoOOIA.InvitadoWS.invitado invitado) {
            ProyectoOOIA.InvitadoWS.insertarInvitadoRequest inValue = new ProyectoOOIA.InvitadoWS.insertarInvitadoRequest();
            inValue.invitado = invitado;
            return ((ProyectoOOIA.InvitadoWS.InvitadoWS)(this)).insertarInvitadoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.InvitadoWS.listarInvitadoResponse ProyectoOOIA.InvitadoWS.InvitadoWS.listarInvitado(ProyectoOOIA.InvitadoWS.listarInvitadoRequest request) {
            return base.Channel.listarInvitado(request);
        }
        
        public ProyectoOOIA.InvitadoWS.invitado[] listarInvitado() {
            ProyectoOOIA.InvitadoWS.listarInvitadoRequest inValue = new ProyectoOOIA.InvitadoWS.listarInvitadoRequest();
            ProyectoOOIA.InvitadoWS.listarInvitadoResponse retVal = ((ProyectoOOIA.InvitadoWS.InvitadoWS)(this)).listarInvitado(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.InvitadoWS.listarInvitadoResponse> ProyectoOOIA.InvitadoWS.InvitadoWS.listarInvitadoAsync(ProyectoOOIA.InvitadoWS.listarInvitadoRequest request) {
            return base.Channel.listarInvitadoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.InvitadoWS.listarInvitadoResponse> listarInvitadoAsync() {
            ProyectoOOIA.InvitadoWS.listarInvitadoRequest inValue = new ProyectoOOIA.InvitadoWS.listarInvitadoRequest();
            return ((ProyectoOOIA.InvitadoWS.InvitadoWS)(this)).listarInvitadoAsync(inValue);
        }
    }
}
