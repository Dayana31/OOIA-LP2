﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoOOIA.CursoWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", ConfigurationName="CursoWS.CursoWS")]
    public interface CursoWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/CursoWS/listarCursoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/CursoWS/listarCursoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.CursoWS.listarCursoResponse listarCurso(ProyectoOOIA.CursoWS.listarCursoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/CursoWS/listarCursoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/CursoWS/listarCursoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.CursoWS.listarCursoResponse> listarCursoAsync(ProyectoOOIA.CursoWS.listarCursoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/CursoWS/insertarrCursoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/CursoWS/insertarrCursoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.CursoWS.insertarrCursoResponse insertarrCurso(ProyectoOOIA.CursoWS.insertarrCursoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/CursoWS/insertarrCursoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/CursoWS/insertarrCursoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.CursoWS.insertarrCursoResponse> insertarrCursoAsync(ProyectoOOIA.CursoWS.insertarrCursoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/CursoWS/modificarCursoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/CursoWS/modificarCursoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.CursoWS.modificarCursoResponse modificarCurso(ProyectoOOIA.CursoWS.modificarCursoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/CursoWS/modificarCursoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/CursoWS/modificarCursoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.CursoWS.modificarCursoResponse> modificarCursoAsync(ProyectoOOIA.CursoWS.modificarCursoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/CursoWS/eliminarCursoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/CursoWS/eliminarCursoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.CursoWS.eliminarCursoResponse eliminarCurso(ProyectoOOIA.CursoWS.eliminarCursoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/CursoWS/eliminarCursoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/CursoWS/eliminarCursoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.CursoWS.eliminarCursoResponse> eliminarCursoAsync(ProyectoOOIA.CursoWS.eliminarCursoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class curso : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private string codigoCursoField;
        
        private double creditosField;
        
        private int id_cursoField;
        
        private string nombreCursoField;
        
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
        public string codigoCurso {
            get {
                return this.codigoCursoField;
            }
            set {
                this.codigoCursoField = value;
                this.RaisePropertyChanged("codigoCurso");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public double creditos {
            get {
                return this.creditosField;
            }
            set {
                this.creditosField = value;
                this.RaisePropertyChanged("creditos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int id_curso {
            get {
                return this.id_cursoField;
            }
            set {
                this.id_cursoField = value;
                this.RaisePropertyChanged("id_curso");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string nombreCurso {
            get {
                return this.nombreCursoField;
            }
            set {
                this.nombreCursoField = value;
                this.RaisePropertyChanged("nombreCurso");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarCurso", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarCursoRequest {
        
        public listarCursoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarCursoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarCursoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.CursoWS.curso[] @return;
        
        public listarCursoResponse() {
        }
        
        public listarCursoResponse(ProyectoOOIA.CursoWS.curso[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarrCurso", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarrCursoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.CursoWS.curso curso;
        
        public insertarrCursoRequest() {
        }
        
        public insertarrCursoRequest(ProyectoOOIA.CursoWS.curso curso) {
            this.curso = curso;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarrCursoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarrCursoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarrCursoResponse() {
        }
        
        public insertarrCursoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarCurso", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarCursoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.CursoWS.curso curso;
        
        public modificarCursoRequest() {
        }
        
        public modificarCursoRequest(ProyectoOOIA.CursoWS.curso curso) {
            this.curso = curso;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarCursoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarCursoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarCursoResponse() {
        }
        
        public modificarCursoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarCurso", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarCursoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id_curso;
        
        public eliminarCursoRequest() {
        }
        
        public eliminarCursoRequest(int id_curso) {
            this.id_curso = id_curso;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarCursoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarCursoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarCursoResponse() {
        }
        
        public eliminarCursoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CursoWSChannel : ProyectoOOIA.CursoWS.CursoWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CursoWSClient : System.ServiceModel.ClientBase<ProyectoOOIA.CursoWS.CursoWS>, ProyectoOOIA.CursoWS.CursoWS {
        
        public CursoWSClient() {
        }
        
        public CursoWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CursoWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CursoWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CursoWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.CursoWS.listarCursoResponse ProyectoOOIA.CursoWS.CursoWS.listarCurso(ProyectoOOIA.CursoWS.listarCursoRequest request) {
            return base.Channel.listarCurso(request);
        }
        
        public ProyectoOOIA.CursoWS.curso[] listarCurso() {
            ProyectoOOIA.CursoWS.listarCursoRequest inValue = new ProyectoOOIA.CursoWS.listarCursoRequest();
            ProyectoOOIA.CursoWS.listarCursoResponse retVal = ((ProyectoOOIA.CursoWS.CursoWS)(this)).listarCurso(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.CursoWS.listarCursoResponse> ProyectoOOIA.CursoWS.CursoWS.listarCursoAsync(ProyectoOOIA.CursoWS.listarCursoRequest request) {
            return base.Channel.listarCursoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.CursoWS.listarCursoResponse> listarCursoAsync() {
            ProyectoOOIA.CursoWS.listarCursoRequest inValue = new ProyectoOOIA.CursoWS.listarCursoRequest();
            return ((ProyectoOOIA.CursoWS.CursoWS)(this)).listarCursoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.CursoWS.insertarrCursoResponse ProyectoOOIA.CursoWS.CursoWS.insertarrCurso(ProyectoOOIA.CursoWS.insertarrCursoRequest request) {
            return base.Channel.insertarrCurso(request);
        }
        
        public int insertarrCurso(ProyectoOOIA.CursoWS.curso curso) {
            ProyectoOOIA.CursoWS.insertarrCursoRequest inValue = new ProyectoOOIA.CursoWS.insertarrCursoRequest();
            inValue.curso = curso;
            ProyectoOOIA.CursoWS.insertarrCursoResponse retVal = ((ProyectoOOIA.CursoWS.CursoWS)(this)).insertarrCurso(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.CursoWS.insertarrCursoResponse> ProyectoOOIA.CursoWS.CursoWS.insertarrCursoAsync(ProyectoOOIA.CursoWS.insertarrCursoRequest request) {
            return base.Channel.insertarrCursoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.CursoWS.insertarrCursoResponse> insertarrCursoAsync(ProyectoOOIA.CursoWS.curso curso) {
            ProyectoOOIA.CursoWS.insertarrCursoRequest inValue = new ProyectoOOIA.CursoWS.insertarrCursoRequest();
            inValue.curso = curso;
            return ((ProyectoOOIA.CursoWS.CursoWS)(this)).insertarrCursoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.CursoWS.modificarCursoResponse ProyectoOOIA.CursoWS.CursoWS.modificarCurso(ProyectoOOIA.CursoWS.modificarCursoRequest request) {
            return base.Channel.modificarCurso(request);
        }
        
        public int modificarCurso(ProyectoOOIA.CursoWS.curso curso) {
            ProyectoOOIA.CursoWS.modificarCursoRequest inValue = new ProyectoOOIA.CursoWS.modificarCursoRequest();
            inValue.curso = curso;
            ProyectoOOIA.CursoWS.modificarCursoResponse retVal = ((ProyectoOOIA.CursoWS.CursoWS)(this)).modificarCurso(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.CursoWS.modificarCursoResponse> ProyectoOOIA.CursoWS.CursoWS.modificarCursoAsync(ProyectoOOIA.CursoWS.modificarCursoRequest request) {
            return base.Channel.modificarCursoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.CursoWS.modificarCursoResponse> modificarCursoAsync(ProyectoOOIA.CursoWS.curso curso) {
            ProyectoOOIA.CursoWS.modificarCursoRequest inValue = new ProyectoOOIA.CursoWS.modificarCursoRequest();
            inValue.curso = curso;
            return ((ProyectoOOIA.CursoWS.CursoWS)(this)).modificarCursoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.CursoWS.eliminarCursoResponse ProyectoOOIA.CursoWS.CursoWS.eliminarCurso(ProyectoOOIA.CursoWS.eliminarCursoRequest request) {
            return base.Channel.eliminarCurso(request);
        }
        
        public int eliminarCurso(int id_curso) {
            ProyectoOOIA.CursoWS.eliminarCursoRequest inValue = new ProyectoOOIA.CursoWS.eliminarCursoRequest();
            inValue.id_curso = id_curso;
            ProyectoOOIA.CursoWS.eliminarCursoResponse retVal = ((ProyectoOOIA.CursoWS.CursoWS)(this)).eliminarCurso(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.CursoWS.eliminarCursoResponse> ProyectoOOIA.CursoWS.CursoWS.eliminarCursoAsync(ProyectoOOIA.CursoWS.eliminarCursoRequest request) {
            return base.Channel.eliminarCursoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.CursoWS.eliminarCursoResponse> eliminarCursoAsync(int id_curso) {
            ProyectoOOIA.CursoWS.eliminarCursoRequest inValue = new ProyectoOOIA.CursoWS.eliminarCursoRequest();
            inValue.id_curso = id_curso;
            return ((ProyectoOOIA.CursoWS.CursoWS)(this)).eliminarCursoAsync(inValue);
        }
    }
}
