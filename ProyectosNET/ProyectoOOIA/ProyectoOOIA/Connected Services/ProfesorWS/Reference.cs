﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoOOIA.ProfesorWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", ConfigurationName="ProfesorWS.ProfesorWS")]
    public interface ProfesorWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/ProfesorWS/listarProfesorRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/ProfesorWS/listarProfesorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.ProfesorWS.listarProfesorResponse listarProfesor(ProyectoOOIA.ProfesorWS.listarProfesorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/ProfesorWS/listarProfesorRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/ProfesorWS/listarProfesorResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.ProfesorWS.listarProfesorResponse> listarProfesorAsync(ProyectoOOIA.ProfesorWS.listarProfesorRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/ProfesorWS/eliminarProfesorRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/ProfesorWS/eliminarProfesorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.ProfesorWS.eliminarProfesorResponse eliminarProfesor(ProyectoOOIA.ProfesorWS.eliminarProfesorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/ProfesorWS/eliminarProfesorRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/ProfesorWS/eliminarProfesorResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.ProfesorWS.eliminarProfesorResponse> eliminarProfesorAsync(ProyectoOOIA.ProfesorWS.eliminarProfesorRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/ProfesorWS/insertarProfesorRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/ProfesorWS/insertarProfesorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.ProfesorWS.insertarProfesorResponse insertarProfesor(ProyectoOOIA.ProfesorWS.insertarProfesorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/ProfesorWS/insertarProfesorRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/ProfesorWS/insertarProfesorResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.ProfesorWS.insertarProfesorResponse> insertarProfesorAsync(ProyectoOOIA.ProfesorWS.insertarProfesorRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/ProfesorWS/modificarProfesorRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/ProfesorWS/modificarProfesorResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.ProfesorWS.modificarProfesorResponse modificarProfesor(ProyectoOOIA.ProfesorWS.modificarProfesorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/ProfesorWS/modificarProfesorRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/ProfesorWS/modificarProfesorResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.ProfesorWS.modificarProfesorResponse> modificarProfesorAsync(ProyectoOOIA.ProfesorWS.modificarProfesorRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class profesor : miembroPUCP {
        
        private bool activoField;
        
        private string categoriaField;
        
        private especialidad especialidadField;
        
        private string facultadField;
        
        private int id_profesorField;
        
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
        public string categoria {
            get {
                return this.categoriaField;
            }
            set {
                this.categoriaField = value;
                this.RaisePropertyChanged("categoria");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public especialidad especialidad {
            get {
                return this.especialidadField;
            }
            set {
                this.especialidadField = value;
                this.RaisePropertyChanged("especialidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string facultad {
            get {
                return this.facultadField;
            }
            set {
                this.facultadField = value;
                this.RaisePropertyChanged("facultad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int id_profesor {
            get {
                return this.id_profesorField;
            }
            set {
                this.id_profesorField = value;
                this.RaisePropertyChanged("id_profesor");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(miembroPUCP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(profesor))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public abstract partial class persona : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string correoField;
        
        private string direccionField;
        
        private string dniField;
        
        private System.DateTime fecha_nacimientoField;
        
        private bool fecha_nacimientoFieldSpecified;
        
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
        public System.DateTime fecha_nacimiento {
            get {
                return this.fecha_nacimientoField;
            }
            set {
                this.fecha_nacimientoField = value;
                this.RaisePropertyChanged("fecha_nacimiento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fecha_nacimientoSpecified {
            get {
                return this.fecha_nacimientoFieldSpecified;
            }
            set {
                this.fecha_nacimientoFieldSpecified = value;
                this.RaisePropertyChanged("fecha_nacimientoSpecified");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(profesor))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public abstract partial class miembroPUCP : persona {
        
        private System.DateTime fecha_inclusionField;
        
        private bool fecha_inclusionFieldSpecified;
        
        private int id_miembro_pucpField;
        
        private byte[] imagenDePerfilField;
        
        private string passwordField;
        
        private string usuarioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public System.DateTime fecha_inclusion {
            get {
                return this.fecha_inclusionField;
            }
            set {
                this.fecha_inclusionField = value;
                this.RaisePropertyChanged("fecha_inclusion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fecha_inclusionSpecified {
            get {
                return this.fecha_inclusionFieldSpecified;
            }
            set {
                this.fecha_inclusionFieldSpecified = value;
                this.RaisePropertyChanged("fecha_inclusionSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int id_miembro_pucp {
            get {
                return this.id_miembro_pucpField;
            }
            set {
                this.id_miembro_pucpField = value;
                this.RaisePropertyChanged("id_miembro_pucp");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=2)]
        public byte[] imagenDePerfil {
            get {
                return this.imagenDePerfilField;
            }
            set {
                this.imagenDePerfilField = value;
                this.RaisePropertyChanged("imagenDePerfil");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string usuario {
            get {
                return this.usuarioField;
            }
            set {
                this.usuarioField = value;
                this.RaisePropertyChanged("usuario");
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarProfesor", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarProfesorRequest {
        
        public listarProfesorRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarProfesorResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarProfesorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.ProfesorWS.profesor[] @return;
        
        public listarProfesorResponse() {
        }
        
        public listarProfesorResponse(ProyectoOOIA.ProfesorWS.profesor[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarProfesor", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarProfesorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id_profesor;
        
        public eliminarProfesorRequest() {
        }
        
        public eliminarProfesorRequest(int id_profesor) {
            this.id_profesor = id_profesor;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarProfesorResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarProfesorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarProfesorResponse() {
        }
        
        public eliminarProfesorResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarProfesor", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarProfesorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.ProfesorWS.profesor profesor;
        
        public insertarProfesorRequest() {
        }
        
        public insertarProfesorRequest(ProyectoOOIA.ProfesorWS.profesor profesor) {
            this.profesor = profesor;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarProfesorResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarProfesorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarProfesorResponse() {
        }
        
        public insertarProfesorResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarProfesor", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarProfesorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.ProfesorWS.profesor profesor;
        
        public modificarProfesorRequest() {
        }
        
        public modificarProfesorRequest(ProyectoOOIA.ProfesorWS.profesor profesor) {
            this.profesor = profesor;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarProfesorResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarProfesorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarProfesorResponse() {
        }
        
        public modificarProfesorResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProfesorWSChannel : ProyectoOOIA.ProfesorWS.ProfesorWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProfesorWSClient : System.ServiceModel.ClientBase<ProyectoOOIA.ProfesorWS.ProfesorWS>, ProyectoOOIA.ProfesorWS.ProfesorWS {
        
        public ProfesorWSClient() {
        }
        
        public ProfesorWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProfesorWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProfesorWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProfesorWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.ProfesorWS.listarProfesorResponse ProyectoOOIA.ProfesorWS.ProfesorWS.listarProfesor(ProyectoOOIA.ProfesorWS.listarProfesorRequest request) {
            return base.Channel.listarProfesor(request);
        }
        
        public ProyectoOOIA.ProfesorWS.profesor[] listarProfesor() {
            ProyectoOOIA.ProfesorWS.listarProfesorRequest inValue = new ProyectoOOIA.ProfesorWS.listarProfesorRequest();
            ProyectoOOIA.ProfesorWS.listarProfesorResponse retVal = ((ProyectoOOIA.ProfesorWS.ProfesorWS)(this)).listarProfesor(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.ProfesorWS.listarProfesorResponse> ProyectoOOIA.ProfesorWS.ProfesorWS.listarProfesorAsync(ProyectoOOIA.ProfesorWS.listarProfesorRequest request) {
            return base.Channel.listarProfesorAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.ProfesorWS.listarProfesorResponse> listarProfesorAsync() {
            ProyectoOOIA.ProfesorWS.listarProfesorRequest inValue = new ProyectoOOIA.ProfesorWS.listarProfesorRequest();
            return ((ProyectoOOIA.ProfesorWS.ProfesorWS)(this)).listarProfesorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.ProfesorWS.eliminarProfesorResponse ProyectoOOIA.ProfesorWS.ProfesorWS.eliminarProfesor(ProyectoOOIA.ProfesorWS.eliminarProfesorRequest request) {
            return base.Channel.eliminarProfesor(request);
        }
        
        public int eliminarProfesor(int id_profesor) {
            ProyectoOOIA.ProfesorWS.eliminarProfesorRequest inValue = new ProyectoOOIA.ProfesorWS.eliminarProfesorRequest();
            inValue.id_profesor = id_profesor;
            ProyectoOOIA.ProfesorWS.eliminarProfesorResponse retVal = ((ProyectoOOIA.ProfesorWS.ProfesorWS)(this)).eliminarProfesor(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.ProfesorWS.eliminarProfesorResponse> ProyectoOOIA.ProfesorWS.ProfesorWS.eliminarProfesorAsync(ProyectoOOIA.ProfesorWS.eliminarProfesorRequest request) {
            return base.Channel.eliminarProfesorAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.ProfesorWS.eliminarProfesorResponse> eliminarProfesorAsync(int id_profesor) {
            ProyectoOOIA.ProfesorWS.eliminarProfesorRequest inValue = new ProyectoOOIA.ProfesorWS.eliminarProfesorRequest();
            inValue.id_profesor = id_profesor;
            return ((ProyectoOOIA.ProfesorWS.ProfesorWS)(this)).eliminarProfesorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.ProfesorWS.insertarProfesorResponse ProyectoOOIA.ProfesorWS.ProfesorWS.insertarProfesor(ProyectoOOIA.ProfesorWS.insertarProfesorRequest request) {
            return base.Channel.insertarProfesor(request);
        }
        
        public int insertarProfesor(ProyectoOOIA.ProfesorWS.profesor profesor) {
            ProyectoOOIA.ProfesorWS.insertarProfesorRequest inValue = new ProyectoOOIA.ProfesorWS.insertarProfesorRequest();
            inValue.profesor = profesor;
            ProyectoOOIA.ProfesorWS.insertarProfesorResponse retVal = ((ProyectoOOIA.ProfesorWS.ProfesorWS)(this)).insertarProfesor(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.ProfesorWS.insertarProfesorResponse> ProyectoOOIA.ProfesorWS.ProfesorWS.insertarProfesorAsync(ProyectoOOIA.ProfesorWS.insertarProfesorRequest request) {
            return base.Channel.insertarProfesorAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.ProfesorWS.insertarProfesorResponse> insertarProfesorAsync(ProyectoOOIA.ProfesorWS.profesor profesor) {
            ProyectoOOIA.ProfesorWS.insertarProfesorRequest inValue = new ProyectoOOIA.ProfesorWS.insertarProfesorRequest();
            inValue.profesor = profesor;
            return ((ProyectoOOIA.ProfesorWS.ProfesorWS)(this)).insertarProfesorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.ProfesorWS.modificarProfesorResponse ProyectoOOIA.ProfesorWS.ProfesorWS.modificarProfesor(ProyectoOOIA.ProfesorWS.modificarProfesorRequest request) {
            return base.Channel.modificarProfesor(request);
        }
        
        public int modificarProfesor(ProyectoOOIA.ProfesorWS.profesor profesor) {
            ProyectoOOIA.ProfesorWS.modificarProfesorRequest inValue = new ProyectoOOIA.ProfesorWS.modificarProfesorRequest();
            inValue.profesor = profesor;
            ProyectoOOIA.ProfesorWS.modificarProfesorResponse retVal = ((ProyectoOOIA.ProfesorWS.ProfesorWS)(this)).modificarProfesor(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.ProfesorWS.modificarProfesorResponse> ProyectoOOIA.ProfesorWS.ProfesorWS.modificarProfesorAsync(ProyectoOOIA.ProfesorWS.modificarProfesorRequest request) {
            return base.Channel.modificarProfesorAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.ProfesorWS.modificarProfesorResponse> modificarProfesorAsync(ProyectoOOIA.ProfesorWS.profesor profesor) {
            ProyectoOOIA.ProfesorWS.modificarProfesorRequest inValue = new ProyectoOOIA.ProfesorWS.modificarProfesorRequest();
            inValue.profesor = profesor;
            return ((ProyectoOOIA.ProfesorWS.ProfesorWS)(this)).modificarProfesorAsync(inValue);
        }
    }
}
