﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoOOIA.EventoWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", ConfigurationName="EventoWS.EventoWS")]
    public interface EventoWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoWS/listarEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoWS/listarEventoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EventoWS.listarEventoResponse listarEvento(ProyectoOOIA.EventoWS.listarEventoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoWS/listarEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoWS/listarEventoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoWS.listarEventoResponse> listarEventoAsync(ProyectoOOIA.EventoWS.listarEventoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoWS/insertarEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoWS/insertarEventoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EventoWS.insertarEventoResponse insertarEvento(ProyectoOOIA.EventoWS.insertarEventoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoWS/insertarEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoWS/insertarEventoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoWS.insertarEventoResponse> insertarEventoAsync(ProyectoOOIA.EventoWS.insertarEventoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoWS/modificarEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoWS/modificarEventoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EventoWS.modificarEventoResponse modificarEvento(ProyectoOOIA.EventoWS.modificarEventoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoWS/modificarEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoWS/modificarEventoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoWS.modificarEventoResponse> modificarEventoAsync(ProyectoOOIA.EventoWS.modificarEventoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoWS/eliminarEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoWS/eliminarEventoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EventoWS.eliminarEventoResponse eliminarEvento(ProyectoOOIA.EventoWS.eliminarEventoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoWS/eliminarEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoWS/eliminarEventoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoWS.eliminarEventoResponse> eliminarEventoAsync(ProyectoOOIA.EventoWS.eliminarEventoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class evento : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int capacidadField;
        
        private bool estadoField;
        
        private System.DateTime fechaField;
        
        private bool fechaFieldSpecified;
        
        private System.DateTime horaFinaField;
        
        private bool horaFinaFieldSpecified;
        
        private System.DateTime horaInicioField;
        
        private bool horaInicioFieldSpecified;
        
        private int id_coordinadorField;
        
        private int id_eventoField;
        
        private string lugarField;
        
        private string nombreField;
        
        private persona[] ponentesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int capacidad {
            get {
                return this.capacidadField;
            }
            set {
                this.capacidadField = value;
                this.RaisePropertyChanged("capacidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public bool estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
                this.RaisePropertyChanged("estado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
                this.RaisePropertyChanged("fecha");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaSpecified {
            get {
                return this.fechaFieldSpecified;
            }
            set {
                this.fechaFieldSpecified = value;
                this.RaisePropertyChanged("fechaSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public System.DateTime horaFina {
            get {
                return this.horaFinaField;
            }
            set {
                this.horaFinaField = value;
                this.RaisePropertyChanged("horaFina");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horaFinaSpecified {
            get {
                return this.horaFinaFieldSpecified;
            }
            set {
                this.horaFinaFieldSpecified = value;
                this.RaisePropertyChanged("horaFinaSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime horaInicio {
            get {
                return this.horaInicioField;
            }
            set {
                this.horaInicioField = value;
                this.RaisePropertyChanged("horaInicio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horaInicioSpecified {
            get {
                return this.horaInicioFieldSpecified;
            }
            set {
                this.horaInicioFieldSpecified = value;
                this.RaisePropertyChanged("horaInicioSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int id_coordinador {
            get {
                return this.id_coordinadorField;
            }
            set {
                this.id_coordinadorField = value;
                this.RaisePropertyChanged("id_coordinador");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int id_evento {
            get {
                return this.id_eventoField;
            }
            set {
                this.id_eventoField = value;
                this.RaisePropertyChanged("id_evento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string lugar {
            get {
                return this.lugarField;
            }
            set {
                this.lugarField = value;
                this.RaisePropertyChanged("lugar");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ponentes", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=9)]
        public persona[] ponentes {
            get {
                return this.ponentesField;
            }
            set {
                this.ponentesField = value;
                this.RaisePropertyChanged("ponentes");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarEvento", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarEventoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombre;
        
        public listarEventoRequest() {
        }
        
        public listarEventoRequest(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarEventoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarEventoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.EventoWS.evento[] @return;
        
        public listarEventoResponse() {
        }
        
        public listarEventoResponse(ProyectoOOIA.EventoWS.evento[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarEvento", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarEventoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.EventoWS.evento evento;
        
        public insertarEventoRequest() {
        }
        
        public insertarEventoRequest(ProyectoOOIA.EventoWS.evento evento) {
            this.evento = evento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarEventoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarEventoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarEventoResponse() {
        }
        
        public insertarEventoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarEvento", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarEventoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.EventoWS.evento evento;
        
        public modificarEventoRequest() {
        }
        
        public modificarEventoRequest(ProyectoOOIA.EventoWS.evento evento) {
            this.evento = evento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarEventoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarEventoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarEventoResponse() {
        }
        
        public modificarEventoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarEvento", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarEventoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.EventoWS.evento evento;
        
        public eliminarEventoRequest() {
        }
        
        public eliminarEventoRequest(ProyectoOOIA.EventoWS.evento evento) {
            this.evento = evento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarEventoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarEventoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarEventoResponse() {
        }
        
        public eliminarEventoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EventoWSChannel : ProyectoOOIA.EventoWS.EventoWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EventoWSClient : System.ServiceModel.ClientBase<ProyectoOOIA.EventoWS.EventoWS>, ProyectoOOIA.EventoWS.EventoWS {
        
        public EventoWSClient() {
        }
        
        public EventoWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EventoWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventoWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventoWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.EventoWS.listarEventoResponse ProyectoOOIA.EventoWS.EventoWS.listarEvento(ProyectoOOIA.EventoWS.listarEventoRequest request) {
            return base.Channel.listarEvento(request);
        }
        
        public ProyectoOOIA.EventoWS.evento[] listarEvento(string nombre) {
            ProyectoOOIA.EventoWS.listarEventoRequest inValue = new ProyectoOOIA.EventoWS.listarEventoRequest();
            inValue.nombre = nombre;
            ProyectoOOIA.EventoWS.listarEventoResponse retVal = ((ProyectoOOIA.EventoWS.EventoWS)(this)).listarEvento(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoWS.listarEventoResponse> ProyectoOOIA.EventoWS.EventoWS.listarEventoAsync(ProyectoOOIA.EventoWS.listarEventoRequest request) {
            return base.Channel.listarEventoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EventoWS.listarEventoResponse> listarEventoAsync(string nombre) {
            ProyectoOOIA.EventoWS.listarEventoRequest inValue = new ProyectoOOIA.EventoWS.listarEventoRequest();
            inValue.nombre = nombre;
            return ((ProyectoOOIA.EventoWS.EventoWS)(this)).listarEventoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.EventoWS.insertarEventoResponse ProyectoOOIA.EventoWS.EventoWS.insertarEvento(ProyectoOOIA.EventoWS.insertarEventoRequest request) {
            return base.Channel.insertarEvento(request);
        }
        
        public int insertarEvento(ProyectoOOIA.EventoWS.evento evento) {
            ProyectoOOIA.EventoWS.insertarEventoRequest inValue = new ProyectoOOIA.EventoWS.insertarEventoRequest();
            inValue.evento = evento;
            ProyectoOOIA.EventoWS.insertarEventoResponse retVal = ((ProyectoOOIA.EventoWS.EventoWS)(this)).insertarEvento(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoWS.insertarEventoResponse> ProyectoOOIA.EventoWS.EventoWS.insertarEventoAsync(ProyectoOOIA.EventoWS.insertarEventoRequest request) {
            return base.Channel.insertarEventoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EventoWS.insertarEventoResponse> insertarEventoAsync(ProyectoOOIA.EventoWS.evento evento) {
            ProyectoOOIA.EventoWS.insertarEventoRequest inValue = new ProyectoOOIA.EventoWS.insertarEventoRequest();
            inValue.evento = evento;
            return ((ProyectoOOIA.EventoWS.EventoWS)(this)).insertarEventoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.EventoWS.modificarEventoResponse ProyectoOOIA.EventoWS.EventoWS.modificarEvento(ProyectoOOIA.EventoWS.modificarEventoRequest request) {
            return base.Channel.modificarEvento(request);
        }
        
        public int modificarEvento(ProyectoOOIA.EventoWS.evento evento) {
            ProyectoOOIA.EventoWS.modificarEventoRequest inValue = new ProyectoOOIA.EventoWS.modificarEventoRequest();
            inValue.evento = evento;
            ProyectoOOIA.EventoWS.modificarEventoResponse retVal = ((ProyectoOOIA.EventoWS.EventoWS)(this)).modificarEvento(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoWS.modificarEventoResponse> ProyectoOOIA.EventoWS.EventoWS.modificarEventoAsync(ProyectoOOIA.EventoWS.modificarEventoRequest request) {
            return base.Channel.modificarEventoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EventoWS.modificarEventoResponse> modificarEventoAsync(ProyectoOOIA.EventoWS.evento evento) {
            ProyectoOOIA.EventoWS.modificarEventoRequest inValue = new ProyectoOOIA.EventoWS.modificarEventoRequest();
            inValue.evento = evento;
            return ((ProyectoOOIA.EventoWS.EventoWS)(this)).modificarEventoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.EventoWS.eliminarEventoResponse ProyectoOOIA.EventoWS.EventoWS.eliminarEvento(ProyectoOOIA.EventoWS.eliminarEventoRequest request) {
            return base.Channel.eliminarEvento(request);
        }
        
        public int eliminarEvento(ProyectoOOIA.EventoWS.evento evento) {
            ProyectoOOIA.EventoWS.eliminarEventoRequest inValue = new ProyectoOOIA.EventoWS.eliminarEventoRequest();
            inValue.evento = evento;
            ProyectoOOIA.EventoWS.eliminarEventoResponse retVal = ((ProyectoOOIA.EventoWS.EventoWS)(this)).eliminarEvento(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoWS.eliminarEventoResponse> ProyectoOOIA.EventoWS.EventoWS.eliminarEventoAsync(ProyectoOOIA.EventoWS.eliminarEventoRequest request) {
            return base.Channel.eliminarEventoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EventoWS.eliminarEventoResponse> eliminarEventoAsync(ProyectoOOIA.EventoWS.evento evento) {
            ProyectoOOIA.EventoWS.eliminarEventoRequest inValue = new ProyectoOOIA.EventoWS.eliminarEventoRequest();
            inValue.evento = evento;
            return ((ProyectoOOIA.EventoWS.EventoWS)(this)).eliminarEventoAsync(inValue);
        }
    }
}
