//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoOOIA.HorarioWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", ConfigurationName="HorarioWS.HorarioWS")]
    public interface HorarioWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/HorarioWS/modificarHorarioRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/HorarioWS/modificarHorarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.HorarioWS.modificarHorarioResponse modificarHorario(ProyectoOOIA.HorarioWS.modificarHorarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/HorarioWS/modificarHorarioRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/HorarioWS/modificarHorarioResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.HorarioWS.modificarHorarioResponse> modificarHorarioAsync(ProyectoOOIA.HorarioWS.modificarHorarioRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/HorarioWS/insertarHorarioRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/HorarioWS/insertarHorarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.HorarioWS.insertarHorarioResponse insertarHorario(ProyectoOOIA.HorarioWS.insertarHorarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/HorarioWS/insertarHorarioRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/HorarioWS/insertarHorarioResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.HorarioWS.insertarHorarioResponse> insertarHorarioAsync(ProyectoOOIA.HorarioWS.insertarHorarioRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/HorarioWS/listarHorarioRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/HorarioWS/listarHorarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.HorarioWS.listarHorarioResponse listarHorario(ProyectoOOIA.HorarioWS.listarHorarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/HorarioWS/listarHorarioRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/HorarioWS/listarHorarioResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.HorarioWS.listarHorarioResponse> listarHorarioAsync(ProyectoOOIA.HorarioWS.listarHorarioRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/HorarioWS/eliminarHorarioRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/HorarioWS/eliminarHorarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.HorarioWS.eliminarHorarioResponse eliminarHorario(ProyectoOOIA.HorarioWS.eliminarHorarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/HorarioWS/eliminarHorarioRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/HorarioWS/eliminarHorarioResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.HorarioWS.eliminarHorarioResponse> eliminarHorarioAsync(ProyectoOOIA.HorarioWS.eliminarHorarioRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class horario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private int diaField;
        
        private time horaFinField;
        
        private time horaInicioField;
        
        private int id_horarioField;
        
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
        public int dia {
            get {
                return this.diaField;
            }
            set {
                this.diaField = value;
                this.RaisePropertyChanged("dia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public time horaFin {
            get {
                return this.horaFinField;
            }
            set {
                this.horaFinField = value;
                this.RaisePropertyChanged("horaFin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public time horaInicio {
            get {
                return this.horaInicioField;
            }
            set {
                this.horaInicioField = value;
                this.RaisePropertyChanged("horaInicio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int id_horario {
            get {
                return this.id_horarioField;
            }
            set {
                this.id_horarioField = value;
                this.RaisePropertyChanged("id_horario");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class time : object, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarHorario", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarHorarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.HorarioWS.horario horario;
        
        public modificarHorarioRequest() {
        }
        
        public modificarHorarioRequest(ProyectoOOIA.HorarioWS.horario horario) {
            this.horario = horario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarHorarioResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarHorarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarHorarioResponse() {
        }
        
        public modificarHorarioResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarHorario", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarHorarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.HorarioWS.horario horario;
        
        public insertarHorarioRequest() {
        }
        
        public insertarHorarioRequest(ProyectoOOIA.HorarioWS.horario horario) {
            this.horario = horario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarHorarioResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarHorarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarHorarioResponse() {
        }
        
        public insertarHorarioResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarHorario", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarHorarioRequest {
        
        public listarHorarioRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarHorarioResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarHorarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.HorarioWS.horario[] @return;
        
        public listarHorarioResponse() {
        }
        
        public listarHorarioResponse(ProyectoOOIA.HorarioWS.horario[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarHorario", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarHorarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.HorarioWS.horario horario;
        
        public eliminarHorarioRequest() {
        }
        
        public eliminarHorarioRequest(ProyectoOOIA.HorarioWS.horario horario) {
            this.horario = horario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarHorarioResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarHorarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarHorarioResponse() {
        }
        
        public eliminarHorarioResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HorarioWSChannel : ProyectoOOIA.HorarioWS.HorarioWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HorarioWSClient : System.ServiceModel.ClientBase<ProyectoOOIA.HorarioWS.HorarioWS>, ProyectoOOIA.HorarioWS.HorarioWS {
        
        public HorarioWSClient() {
        }
        
        public HorarioWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HorarioWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HorarioWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HorarioWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.HorarioWS.modificarHorarioResponse ProyectoOOIA.HorarioWS.HorarioWS.modificarHorario(ProyectoOOIA.HorarioWS.modificarHorarioRequest request) {
            return base.Channel.modificarHorario(request);
        }
        
        public int modificarHorario(ProyectoOOIA.HorarioWS.horario horario) {
            ProyectoOOIA.HorarioWS.modificarHorarioRequest inValue = new ProyectoOOIA.HorarioWS.modificarHorarioRequest();
            inValue.horario = horario;
            ProyectoOOIA.HorarioWS.modificarHorarioResponse retVal = ((ProyectoOOIA.HorarioWS.HorarioWS)(this)).modificarHorario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.HorarioWS.modificarHorarioResponse> ProyectoOOIA.HorarioWS.HorarioWS.modificarHorarioAsync(ProyectoOOIA.HorarioWS.modificarHorarioRequest request) {
            return base.Channel.modificarHorarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.HorarioWS.modificarHorarioResponse> modificarHorarioAsync(ProyectoOOIA.HorarioWS.horario horario) {
            ProyectoOOIA.HorarioWS.modificarHorarioRequest inValue = new ProyectoOOIA.HorarioWS.modificarHorarioRequest();
            inValue.horario = horario;
            return ((ProyectoOOIA.HorarioWS.HorarioWS)(this)).modificarHorarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.HorarioWS.insertarHorarioResponse ProyectoOOIA.HorarioWS.HorarioWS.insertarHorario(ProyectoOOIA.HorarioWS.insertarHorarioRequest request) {
            return base.Channel.insertarHorario(request);
        }
        
        public int insertarHorario(ProyectoOOIA.HorarioWS.horario horario) {
            ProyectoOOIA.HorarioWS.insertarHorarioRequest inValue = new ProyectoOOIA.HorarioWS.insertarHorarioRequest();
            inValue.horario = horario;
            ProyectoOOIA.HorarioWS.insertarHorarioResponse retVal = ((ProyectoOOIA.HorarioWS.HorarioWS)(this)).insertarHorario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.HorarioWS.insertarHorarioResponse> ProyectoOOIA.HorarioWS.HorarioWS.insertarHorarioAsync(ProyectoOOIA.HorarioWS.insertarHorarioRequest request) {
            return base.Channel.insertarHorarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.HorarioWS.insertarHorarioResponse> insertarHorarioAsync(ProyectoOOIA.HorarioWS.horario horario) {
            ProyectoOOIA.HorarioWS.insertarHorarioRequest inValue = new ProyectoOOIA.HorarioWS.insertarHorarioRequest();
            inValue.horario = horario;
            return ((ProyectoOOIA.HorarioWS.HorarioWS)(this)).insertarHorarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.HorarioWS.listarHorarioResponse ProyectoOOIA.HorarioWS.HorarioWS.listarHorario(ProyectoOOIA.HorarioWS.listarHorarioRequest request) {
            return base.Channel.listarHorario(request);
        }
        
        public ProyectoOOIA.HorarioWS.horario[] listarHorario() {
            ProyectoOOIA.HorarioWS.listarHorarioRequest inValue = new ProyectoOOIA.HorarioWS.listarHorarioRequest();
            ProyectoOOIA.HorarioWS.listarHorarioResponse retVal = ((ProyectoOOIA.HorarioWS.HorarioWS)(this)).listarHorario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.HorarioWS.listarHorarioResponse> ProyectoOOIA.HorarioWS.HorarioWS.listarHorarioAsync(ProyectoOOIA.HorarioWS.listarHorarioRequest request) {
            return base.Channel.listarHorarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.HorarioWS.listarHorarioResponse> listarHorarioAsync() {
            ProyectoOOIA.HorarioWS.listarHorarioRequest inValue = new ProyectoOOIA.HorarioWS.listarHorarioRequest();
            return ((ProyectoOOIA.HorarioWS.HorarioWS)(this)).listarHorarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.HorarioWS.eliminarHorarioResponse ProyectoOOIA.HorarioWS.HorarioWS.eliminarHorario(ProyectoOOIA.HorarioWS.eliminarHorarioRequest request) {
            return base.Channel.eliminarHorario(request);
        }
        
        public int eliminarHorario(ProyectoOOIA.HorarioWS.horario horario) {
            ProyectoOOIA.HorarioWS.eliminarHorarioRequest inValue = new ProyectoOOIA.HorarioWS.eliminarHorarioRequest();
            inValue.horario = horario;
            ProyectoOOIA.HorarioWS.eliminarHorarioResponse retVal = ((ProyectoOOIA.HorarioWS.HorarioWS)(this)).eliminarHorario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.HorarioWS.eliminarHorarioResponse> ProyectoOOIA.HorarioWS.HorarioWS.eliminarHorarioAsync(ProyectoOOIA.HorarioWS.eliminarHorarioRequest request) {
            return base.Channel.eliminarHorarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.HorarioWS.eliminarHorarioResponse> eliminarHorarioAsync(ProyectoOOIA.HorarioWS.horario horario) {
            ProyectoOOIA.HorarioWS.eliminarHorarioRequest inValue = new ProyectoOOIA.HorarioWS.eliminarHorarioRequest();
            inValue.horario = horario;
            return ((ProyectoOOIA.HorarioWS.HorarioWS)(this)).eliminarHorarioAsync(inValue);
        }
    }
}
