﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoOOIA.EventoAlumnoWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", ConfigurationName="EventoAlumnoWS.EventoAlumnoWS")]
    public interface EventoAlumnoWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/eliminarEncuestaEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/eliminarEncuestaEventoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EventoAlumnoWS.eliminarEncuestaEventoResponse eliminarEncuestaEvento(ProyectoOOIA.EventoAlumnoWS.eliminarEncuestaEventoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/eliminarEncuestaEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/eliminarEncuestaEventoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoAlumnoWS.eliminarEncuestaEventoResponse> eliminarEncuestaEventoAsync(ProyectoOOIA.EventoAlumnoWS.eliminarEncuestaEventoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/listarEncuestaEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/listarEncuestaEventoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EventoAlumnoWS.listarEncuestaEventoResponse listarEncuestaEvento(ProyectoOOIA.EventoAlumnoWS.listarEncuestaEventoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/listarEncuestaEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/listarEncuestaEventoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoAlumnoWS.listarEncuestaEventoResponse> listarEncuestaEventoAsync(ProyectoOOIA.EventoAlumnoWS.listarEncuestaEventoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/modificarEncuestaEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/modificarEncuestaEventoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EventoAlumnoWS.modificarEncuestaEventoResponse modificarEncuestaEvento(ProyectoOOIA.EventoAlumnoWS.modificarEncuestaEventoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/modificarEncuestaEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/modificarEncuestaEventoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoAlumnoWS.modificarEncuestaEventoResponse> modificarEncuestaEventoAsync(ProyectoOOIA.EventoAlumnoWS.modificarEncuestaEventoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/insertarEncuestaEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/insertarEncuestaEventoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.EventoAlumnoWS.insertarEncuestaEventoResponse insertarEncuestaEvento(ProyectoOOIA.EventoAlumnoWS.insertarEncuestaEventoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/insertarEncuestaEventoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/EventoAlumnoWS/insertarEncuestaEventoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoAlumnoWS.insertarEncuestaEventoResponse> insertarEncuestaEventoAsync(ProyectoOOIA.EventoAlumnoWS.insertarEncuestaEventoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class eventoAlumno : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool asistioField;
        
        private string comentarioField;
        
        private int id_alumnoField;
        
        private int id_encuestaField;
        
        private int id_eventoField;
        
        private int valoracionEventoField;
        
        private int valoracionPonentesField;
        
        private int valoracionUtilidadField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool asistio {
            get {
                return this.asistioField;
            }
            set {
                this.asistioField = value;
                this.RaisePropertyChanged("asistio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string comentario {
            get {
                return this.comentarioField;
            }
            set {
                this.comentarioField = value;
                this.RaisePropertyChanged("comentario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int id_alumno {
            get {
                return this.id_alumnoField;
            }
            set {
                this.id_alumnoField = value;
                this.RaisePropertyChanged("id_alumno");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int id_encuesta {
            get {
                return this.id_encuestaField;
            }
            set {
                this.id_encuestaField = value;
                this.RaisePropertyChanged("id_encuesta");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int valoracionEvento {
            get {
                return this.valoracionEventoField;
            }
            set {
                this.valoracionEventoField = value;
                this.RaisePropertyChanged("valoracionEvento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int valoracionPonentes {
            get {
                return this.valoracionPonentesField;
            }
            set {
                this.valoracionPonentesField = value;
                this.RaisePropertyChanged("valoracionPonentes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int valoracionUtilidad {
            get {
                return this.valoracionUtilidadField;
            }
            set {
                this.valoracionUtilidadField = value;
                this.RaisePropertyChanged("valoracionUtilidad");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarEncuestaEvento", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarEncuestaEventoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.EventoAlumnoWS.eventoAlumno evento;
        
        public eliminarEncuestaEventoRequest() {
        }
        
        public eliminarEncuestaEventoRequest(ProyectoOOIA.EventoAlumnoWS.eventoAlumno evento) {
            this.evento = evento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarEncuestaEventoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarEncuestaEventoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarEncuestaEventoResponse() {
        }
        
        public eliminarEncuestaEventoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarEncuestaEvento", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarEncuestaEventoRequest {
        
        public listarEncuestaEventoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarEncuestaEventoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarEncuestaEventoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.EventoAlumnoWS.eventoAlumno[] @return;
        
        public listarEncuestaEventoResponse() {
        }
        
        public listarEncuestaEventoResponse(ProyectoOOIA.EventoAlumnoWS.eventoAlumno[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarEncuestaEvento", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarEncuestaEventoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.EventoAlumnoWS.eventoAlumno evento;
        
        public modificarEncuestaEventoRequest() {
        }
        
        public modificarEncuestaEventoRequest(ProyectoOOIA.EventoAlumnoWS.eventoAlumno evento) {
            this.evento = evento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarEncuestaEventoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarEncuestaEventoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarEncuestaEventoResponse() {
        }
        
        public modificarEncuestaEventoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarEncuestaEvento", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarEncuestaEventoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.EventoAlumnoWS.eventoAlumno evento;
        
        public insertarEncuestaEventoRequest() {
        }
        
        public insertarEncuestaEventoRequest(ProyectoOOIA.EventoAlumnoWS.eventoAlumno evento) {
            this.evento = evento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarEncuestaEventoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarEncuestaEventoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarEncuestaEventoResponse() {
        }
        
        public insertarEncuestaEventoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EventoAlumnoWSChannel : ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EventoAlumnoWSClient : System.ServiceModel.ClientBase<ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS>, ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS {
        
        public EventoAlumnoWSClient() {
        }
        
        public EventoAlumnoWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EventoAlumnoWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventoAlumnoWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventoAlumnoWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.EventoAlumnoWS.eliminarEncuestaEventoResponse ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS.eliminarEncuestaEvento(ProyectoOOIA.EventoAlumnoWS.eliminarEncuestaEventoRequest request) {
            return base.Channel.eliminarEncuestaEvento(request);
        }
        
        public int eliminarEncuestaEvento(ProyectoOOIA.EventoAlumnoWS.eventoAlumno evento) {
            ProyectoOOIA.EventoAlumnoWS.eliminarEncuestaEventoRequest inValue = new ProyectoOOIA.EventoAlumnoWS.eliminarEncuestaEventoRequest();
            inValue.evento = evento;
            ProyectoOOIA.EventoAlumnoWS.eliminarEncuestaEventoResponse retVal = ((ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS)(this)).eliminarEncuestaEvento(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoAlumnoWS.eliminarEncuestaEventoResponse> ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS.eliminarEncuestaEventoAsync(ProyectoOOIA.EventoAlumnoWS.eliminarEncuestaEventoRequest request) {
            return base.Channel.eliminarEncuestaEventoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EventoAlumnoWS.eliminarEncuestaEventoResponse> eliminarEncuestaEventoAsync(ProyectoOOIA.EventoAlumnoWS.eventoAlumno evento) {
            ProyectoOOIA.EventoAlumnoWS.eliminarEncuestaEventoRequest inValue = new ProyectoOOIA.EventoAlumnoWS.eliminarEncuestaEventoRequest();
            inValue.evento = evento;
            return ((ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS)(this)).eliminarEncuestaEventoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.EventoAlumnoWS.listarEncuestaEventoResponse ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS.listarEncuestaEvento(ProyectoOOIA.EventoAlumnoWS.listarEncuestaEventoRequest request) {
            return base.Channel.listarEncuestaEvento(request);
        }
        
        public ProyectoOOIA.EventoAlumnoWS.eventoAlumno[] listarEncuestaEvento() {
            ProyectoOOIA.EventoAlumnoWS.listarEncuestaEventoRequest inValue = new ProyectoOOIA.EventoAlumnoWS.listarEncuestaEventoRequest();
            ProyectoOOIA.EventoAlumnoWS.listarEncuestaEventoResponse retVal = ((ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS)(this)).listarEncuestaEvento(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoAlumnoWS.listarEncuestaEventoResponse> ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS.listarEncuestaEventoAsync(ProyectoOOIA.EventoAlumnoWS.listarEncuestaEventoRequest request) {
            return base.Channel.listarEncuestaEventoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EventoAlumnoWS.listarEncuestaEventoResponse> listarEncuestaEventoAsync() {
            ProyectoOOIA.EventoAlumnoWS.listarEncuestaEventoRequest inValue = new ProyectoOOIA.EventoAlumnoWS.listarEncuestaEventoRequest();
            return ((ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS)(this)).listarEncuestaEventoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.EventoAlumnoWS.modificarEncuestaEventoResponse ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS.modificarEncuestaEvento(ProyectoOOIA.EventoAlumnoWS.modificarEncuestaEventoRequest request) {
            return base.Channel.modificarEncuestaEvento(request);
        }
        
        public int modificarEncuestaEvento(ProyectoOOIA.EventoAlumnoWS.eventoAlumno evento) {
            ProyectoOOIA.EventoAlumnoWS.modificarEncuestaEventoRequest inValue = new ProyectoOOIA.EventoAlumnoWS.modificarEncuestaEventoRequest();
            inValue.evento = evento;
            ProyectoOOIA.EventoAlumnoWS.modificarEncuestaEventoResponse retVal = ((ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS)(this)).modificarEncuestaEvento(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoAlumnoWS.modificarEncuestaEventoResponse> ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS.modificarEncuestaEventoAsync(ProyectoOOIA.EventoAlumnoWS.modificarEncuestaEventoRequest request) {
            return base.Channel.modificarEncuestaEventoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EventoAlumnoWS.modificarEncuestaEventoResponse> modificarEncuestaEventoAsync(ProyectoOOIA.EventoAlumnoWS.eventoAlumno evento) {
            ProyectoOOIA.EventoAlumnoWS.modificarEncuestaEventoRequest inValue = new ProyectoOOIA.EventoAlumnoWS.modificarEncuestaEventoRequest();
            inValue.evento = evento;
            return ((ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS)(this)).modificarEncuestaEventoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.EventoAlumnoWS.insertarEncuestaEventoResponse ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS.insertarEncuestaEvento(ProyectoOOIA.EventoAlumnoWS.insertarEncuestaEventoRequest request) {
            return base.Channel.insertarEncuestaEvento(request);
        }
        
        public int insertarEncuestaEvento(ProyectoOOIA.EventoAlumnoWS.eventoAlumno evento) {
            ProyectoOOIA.EventoAlumnoWS.insertarEncuestaEventoRequest inValue = new ProyectoOOIA.EventoAlumnoWS.insertarEncuestaEventoRequest();
            inValue.evento = evento;
            ProyectoOOIA.EventoAlumnoWS.insertarEncuestaEventoResponse retVal = ((ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS)(this)).insertarEncuestaEvento(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.EventoAlumnoWS.insertarEncuestaEventoResponse> ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS.insertarEncuestaEventoAsync(ProyectoOOIA.EventoAlumnoWS.insertarEncuestaEventoRequest request) {
            return base.Channel.insertarEncuestaEventoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.EventoAlumnoWS.insertarEncuestaEventoResponse> insertarEncuestaEventoAsync(ProyectoOOIA.EventoAlumnoWS.eventoAlumno evento) {
            ProyectoOOIA.EventoAlumnoWS.insertarEncuestaEventoRequest inValue = new ProyectoOOIA.EventoAlumnoWS.insertarEncuestaEventoRequest();
            inValue.evento = evento;
            return ((ProyectoOOIA.EventoAlumnoWS.EventoAlumnoWS)(this)).insertarEncuestaEventoAsync(inValue);
        }
    }
}
