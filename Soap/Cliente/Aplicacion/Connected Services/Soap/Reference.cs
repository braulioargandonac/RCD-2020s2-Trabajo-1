﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Soap
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sssoap", ConfigurationName="Soap.servi")]
    public interface servi
    {
        
        // CODEGEN: El parámetro "args" requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es "Microsoft.Xml.Serialization.XmlElementAttribute".
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Soap.mainResponse main(Soap.mainRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<Soap.mainResponse> mainAsync(Soap.mainRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="validadigitoReturn")]
        string validadigito(string x);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="validadigitoReturn")]
        System.Threading.Tasks.Task<string> validadigitoAsync(string x);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="validarutReturn")]
        string validarut(string x);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="validarutReturn")]
        System.Threading.Tasks.Task<string> validarutAsync(string x);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="convertirAmayusculaReturn")]
        string convertirAmayuscula(string Nombres, string ApellidoPaterno, string ApellidoMaterno, string Sexo);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="convertirAmayusculaReturn")]
        System.Threading.Tasks.Task<string> convertirAmayusculaAsync(string Nombres, string ApellidoPaterno, string ApellidoMaterno, string Sexo);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="main", WrapperNamespace="http://sssoap", IsWrapped=true)]
    public partial class mainRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sssoap", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("args")]
        public string[] args;
        
        public mainRequest()
        {
        }
        
        public mainRequest(string[] args)
        {
            this.args = args;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="mainResponse", WrapperNamespace="http://sssoap", IsWrapped=true)]
    public partial class mainResponse
    {
        
        public mainResponse()
        {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface serviChannel : Soap.servi, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class serviClient : System.ServiceModel.ClientBase<Soap.servi>, Soap.servi
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public serviClient() : 
                base(serviClient.GetDefaultBinding(), serviClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.servi.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public serviClient(EndpointConfiguration endpointConfiguration) : 
                base(serviClient.GetBindingForEndpoint(endpointConfiguration), serviClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public serviClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(serviClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public serviClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(serviClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public serviClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Soap.mainResponse Soap.servi.main(Soap.mainRequest request)
        {
            return base.Channel.main(request);
        }
        
        public void main(string[] args)
        {
            Soap.mainRequest inValue = new Soap.mainRequest();
            inValue.args = args;
            Soap.mainResponse retVal = ((Soap.servi)(this)).main(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Soap.mainResponse> Soap.servi.mainAsync(Soap.mainRequest request)
        {
            return base.Channel.mainAsync(request);
        }
        
        public System.Threading.Tasks.Task<Soap.mainResponse> mainAsync(string[] args)
        {
            Soap.mainRequest inValue = new Soap.mainRequest();
            inValue.args = args;
            return ((Soap.servi)(this)).mainAsync(inValue);
        }
        
        public string validadigito(string x)
        {
            return base.Channel.validadigito(x);
        }
        
        public System.Threading.Tasks.Task<string> validadigitoAsync(string x)
        {
            return base.Channel.validadigitoAsync(x);
        }
        
        public string validarut(string x)
        {
            return base.Channel.validarut(x);
        }
        
        public System.Threading.Tasks.Task<string> validarutAsync(string x)
        {
            return base.Channel.validarutAsync(x);
        }
        
        public string convertirAmayuscula(string Nombres, string ApellidoPaterno, string ApellidoMaterno, string Sexo)
        {
            return base.Channel.convertirAmayuscula(Nombres, ApellidoPaterno, ApellidoMaterno, Sexo);
        }
        
        public System.Threading.Tasks.Task<string> convertirAmayusculaAsync(string Nombres, string ApellidoPaterno, string ApellidoMaterno, string Sexo)
        {
            return base.Channel.convertirAmayusculaAsync(Nombres, ApellidoPaterno, ApellidoMaterno, Sexo);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.servi))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.servi))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8080/WebServiceProject/services/servi");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return serviClient.GetBindingForEndpoint(EndpointConfiguration.servi);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return serviClient.GetEndpointAddress(EndpointConfiguration.servi);
        }
        
        public enum EndpointConfiguration
        {
            
            servi,
        }
    }
}
