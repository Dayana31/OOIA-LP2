﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoOOIA.PsicologoWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", ConfigurationName="PsicologoWS.PsicologoWS")]
    public interface PsicologoWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/PsicologoWS/listarPsicologoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/PsicologoWS/listarPsicologoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.PsicologoWS.listarPsicologoResponse listarPsicologo(ProyectoOOIA.PsicologoWS.listarPsicologoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/PsicologoWS/listarPsicologoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/PsicologoWS/listarPsicologoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.PsicologoWS.listarPsicologoResponse> listarPsicologoAsync(ProyectoOOIA.PsicologoWS.listarPsicologoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/PsicologoWS/modificarPsicologoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/PsicologoWS/modificarPsicologoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.PsicologoWS.modificarPsicologoResponse modificarPsicologo(ProyectoOOIA.PsicologoWS.modificarPsicologoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/PsicologoWS/modificarPsicologoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/PsicologoWS/modificarPsicologoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.PsicologoWS.modificarPsicologoResponse> modificarPsicologoAsync(ProyectoOOIA.PsicologoWS.modificarPsicologoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/PsicologoWS/insertarPsicologoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/PsicologoWS/insertarPsicologoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.PsicologoWS.insertarPsicologoResponse insertarPsicologo(ProyectoOOIA.PsicologoWS.insertarPsicologoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/PsicologoWS/insertarPsicologoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/PsicologoWS/insertarPsicologoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.PsicologoWS.insertarPsicologoResponse> insertarPsicologoAsync(ProyectoOOIA.PsicologoWS.insertarPsicologoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/PsicologoWS/eliminarPsicologoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/PsicologoWS/eliminarPsicologoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.PsicologoWS.eliminarPsicologoResponse eliminarPsicologo(ProyectoOOIA.PsicologoWS.eliminarPsicologoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/PsicologoWS/eliminarPsicologoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/PsicologoWS/eliminarPsicologoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.PsicologoWS.eliminarPsicologoResponse> eliminarPsicologoAsync(ProyectoOOIA.PsicologoWS.eliminarPsicologoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class psicologo : miembroPUCP {
        
        private horario[] horariosDisponiblsField;
        
        private int id_psicologoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("horariosDisponibls", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public horario[] horariosDisponibls {
            get {
                return this.horariosDisponiblsField;
            }
            set {
                this.horariosDisponiblsField = value;
                this.RaisePropertyChanged("horariosDisponibls");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int id_psicologo {
            get {
                return this.id_psicologoField;
            }
            set {
                this.id_psicologoField = value;
                this.RaisePropertyChanged("id_psicologo");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class horario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int diaField;
        
        private int estadoField;
        
        private time horaFinField;
        
        private time horaInicioField;
        
        private int id_horarioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int estado {
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(miembroPUCP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(psicologo))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(psicologo))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public abstract partial class miembroPUCP : persona {
        
        private string contraseñaField;
        
        private System.DateTime fecha_inclusionField;
        
        private bool fecha_inclusionFieldSpecified;
        
        private int id_miembro_pucpField;
        
        private byte[] imagenDePerfilField;
        
        private string usuario_pucpField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string contraseña {
            get {
                return this.contraseñaField;
            }
            set {
                this.contraseñaField = value;
                this.RaisePropertyChanged("contraseña");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string usuario_pucp {
            get {
                return this.usuario_pucpField;
            }
            set {
                this.usuario_pucpField = value;
                this.RaisePropertyChanged("usuario_pucp");
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarPsicologo", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarPsicologoRequest {
        
        public listarPsicologoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarPsicologoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarPsicologoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.PsicologoWS.psicologo[] @return;
        
        public listarPsicologoResponse() {
        }
        
        public listarPsicologoResponse(ProyectoOOIA.PsicologoWS.psicologo[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarPsicologo", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarPsicologoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.PsicologoWS.psicologo invitado;
        
        public modificarPsicologoRequest() {
        }
        
        public modificarPsicologoRequest(ProyectoOOIA.PsicologoWS.psicologo invitado) {
            this.invitado = invitado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarPsicologoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarPsicologoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarPsicologoResponse() {
        }
        
        public modificarPsicologoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarPsicologo", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarPsicologoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.PsicologoWS.psicologo invitado;
        
        public insertarPsicologoRequest() {
        }
        
        public insertarPsicologoRequest(ProyectoOOIA.PsicologoWS.psicologo invitado) {
            this.invitado = invitado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarPsicologoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarPsicologoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarPsicologoResponse() {
        }
        
        public insertarPsicologoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarPsicologo", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarPsicologoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.PsicologoWS.psicologo invitado;
        
        public eliminarPsicologoRequest() {
        }
        
        public eliminarPsicologoRequest(ProyectoOOIA.PsicologoWS.psicologo invitado) {
            this.invitado = invitado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarPsicologoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarPsicologoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarPsicologoResponse() {
        }
        
        public eliminarPsicologoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PsicologoWSChannel : ProyectoOOIA.PsicologoWS.PsicologoWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PsicologoWSClient : System.ServiceModel.ClientBase<ProyectoOOIA.PsicologoWS.PsicologoWS>, ProyectoOOIA.PsicologoWS.PsicologoWS {
        
        public PsicologoWSClient() {
        }
        
        public PsicologoWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PsicologoWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PsicologoWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PsicologoWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.PsicologoWS.listarPsicologoResponse ProyectoOOIA.PsicologoWS.PsicologoWS.listarPsicologo(ProyectoOOIA.PsicologoWS.listarPsicologoRequest request) {
            return base.Channel.listarPsicologo(request);
        }
        
        public ProyectoOOIA.PsicologoWS.psicologo[] listarPsicologo() {
            ProyectoOOIA.PsicologoWS.listarPsicologoRequest inValue = new ProyectoOOIA.PsicologoWS.listarPsicologoRequest();
            ProyectoOOIA.PsicologoWS.listarPsicologoResponse retVal = ((ProyectoOOIA.PsicologoWS.PsicologoWS)(this)).listarPsicologo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.PsicologoWS.listarPsicologoResponse> ProyectoOOIA.PsicologoWS.PsicologoWS.listarPsicologoAsync(ProyectoOOIA.PsicologoWS.listarPsicologoRequest request) {
            return base.Channel.listarPsicologoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.PsicologoWS.listarPsicologoResponse> listarPsicologoAsync() {
            ProyectoOOIA.PsicologoWS.listarPsicologoRequest inValue = new ProyectoOOIA.PsicologoWS.listarPsicologoRequest();
            return ((ProyectoOOIA.PsicologoWS.PsicologoWS)(this)).listarPsicologoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.PsicologoWS.modificarPsicologoResponse ProyectoOOIA.PsicologoWS.PsicologoWS.modificarPsicologo(ProyectoOOIA.PsicologoWS.modificarPsicologoRequest request) {
            return base.Channel.modificarPsicologo(request);
        }
        
        public int modificarPsicologo(ProyectoOOIA.PsicologoWS.psicologo invitado) {
            ProyectoOOIA.PsicologoWS.modificarPsicologoRequest inValue = new ProyectoOOIA.PsicologoWS.modificarPsicologoRequest();
            inValue.invitado = invitado;
            ProyectoOOIA.PsicologoWS.modificarPsicologoResponse retVal = ((ProyectoOOIA.PsicologoWS.PsicologoWS)(this)).modificarPsicologo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.PsicologoWS.modificarPsicologoResponse> ProyectoOOIA.PsicologoWS.PsicologoWS.modificarPsicologoAsync(ProyectoOOIA.PsicologoWS.modificarPsicologoRequest request) {
            return base.Channel.modificarPsicologoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.PsicologoWS.modificarPsicologoResponse> modificarPsicologoAsync(ProyectoOOIA.PsicologoWS.psicologo invitado) {
            ProyectoOOIA.PsicologoWS.modificarPsicologoRequest inValue = new ProyectoOOIA.PsicologoWS.modificarPsicologoRequest();
            inValue.invitado = invitado;
            return ((ProyectoOOIA.PsicologoWS.PsicologoWS)(this)).modificarPsicologoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.PsicologoWS.insertarPsicologoResponse ProyectoOOIA.PsicologoWS.PsicologoWS.insertarPsicologo(ProyectoOOIA.PsicologoWS.insertarPsicologoRequest request) {
            return base.Channel.insertarPsicologo(request);
        }
        
        public int insertarPsicologo(ProyectoOOIA.PsicologoWS.psicologo invitado) {
            ProyectoOOIA.PsicologoWS.insertarPsicologoRequest inValue = new ProyectoOOIA.PsicologoWS.insertarPsicologoRequest();
            inValue.invitado = invitado;
            ProyectoOOIA.PsicologoWS.insertarPsicologoResponse retVal = ((ProyectoOOIA.PsicologoWS.PsicologoWS)(this)).insertarPsicologo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.PsicologoWS.insertarPsicologoResponse> ProyectoOOIA.PsicologoWS.PsicologoWS.insertarPsicologoAsync(ProyectoOOIA.PsicologoWS.insertarPsicologoRequest request) {
            return base.Channel.insertarPsicologoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.PsicologoWS.insertarPsicologoResponse> insertarPsicologoAsync(ProyectoOOIA.PsicologoWS.psicologo invitado) {
            ProyectoOOIA.PsicologoWS.insertarPsicologoRequest inValue = new ProyectoOOIA.PsicologoWS.insertarPsicologoRequest();
            inValue.invitado = invitado;
            return ((ProyectoOOIA.PsicologoWS.PsicologoWS)(this)).insertarPsicologoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.PsicologoWS.eliminarPsicologoResponse ProyectoOOIA.PsicologoWS.PsicologoWS.eliminarPsicologo(ProyectoOOIA.PsicologoWS.eliminarPsicologoRequest request) {
            return base.Channel.eliminarPsicologo(request);
        }
        
        public int eliminarPsicologo(ProyectoOOIA.PsicologoWS.psicologo invitado) {
            ProyectoOOIA.PsicologoWS.eliminarPsicologoRequest inValue = new ProyectoOOIA.PsicologoWS.eliminarPsicologoRequest();
            inValue.invitado = invitado;
            ProyectoOOIA.PsicologoWS.eliminarPsicologoResponse retVal = ((ProyectoOOIA.PsicologoWS.PsicologoWS)(this)).eliminarPsicologo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.PsicologoWS.eliminarPsicologoResponse> ProyectoOOIA.PsicologoWS.PsicologoWS.eliminarPsicologoAsync(ProyectoOOIA.PsicologoWS.eliminarPsicologoRequest request) {
            return base.Channel.eliminarPsicologoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.PsicologoWS.eliminarPsicologoResponse> eliminarPsicologoAsync(ProyectoOOIA.PsicologoWS.psicologo invitado) {
            ProyectoOOIA.PsicologoWS.eliminarPsicologoRequest inValue = new ProyectoOOIA.PsicologoWS.eliminarPsicologoRequest();
            inValue.invitado = invitado;
            return ((ProyectoOOIA.PsicologoWS.PsicologoWS)(this)).eliminarPsicologoAsync(inValue);
        }
    }
}