﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorClient.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfInt", Namespace="ipcalculator", ItemName="int")]
    [System.SerializableAttribute()]
    public class ArrayOfInt : System.Collections.Generic.List<int> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="ipcalculator", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="ipcalculator", ConfigurationName="ServiceReference.CalculatorSoap")]
    public interface CalculatorSoap {
        
        // CODEGEN: Контракт генерации сообщений с именем bits из пространства имен ipcalculator не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="ipcalculator/Calculate", ReplyAction="*")]
        CalculatorClient.ServiceReference.CalculateResponse Calculate(CalculatorClient.ServiceReference.CalculateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="ipcalculator/Calculate", ReplyAction="*")]
        System.Threading.Tasks.Task<CalculatorClient.ServiceReference.CalculateResponse> CalculateAsync(CalculatorClient.ServiceReference.CalculateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Calculate", Namespace="ipcalculator", Order=0)]
        public CalculatorClient.ServiceReference.CalculateRequestBody Body;
        
        public CalculateRequest() {
        }
        
        public CalculateRequest(CalculatorClient.ServiceReference.CalculateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="ipcalculator")]
    public partial class CalculateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CalculatorClient.ServiceReference.ArrayOfInt bits;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int mask;
        
        public CalculateRequestBody() {
        }
        
        public CalculateRequestBody(CalculatorClient.ServiceReference.ArrayOfInt bits, int mask) {
            this.bits = bits;
            this.mask = mask;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculateResponse", Namespace="ipcalculator", Order=0)]
        public CalculatorClient.ServiceReference.CalculateResponseBody Body;
        
        public CalculateResponse() {
        }
        
        public CalculateResponse(CalculatorClient.ServiceReference.CalculateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="ipcalculator")]
    public partial class CalculateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CalculatorClient.ServiceReference.ArrayOfString CalculateResult;
        
        public CalculateResponseBody() {
        }
        
        public CalculateResponseBody(CalculatorClient.ServiceReference.ArrayOfString CalculateResult) {
            this.CalculateResult = CalculateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorSoapChannel : CalculatorClient.ServiceReference.CalculatorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorSoapClient : System.ServiceModel.ClientBase<CalculatorClient.ServiceReference.CalculatorSoap>, CalculatorClient.ServiceReference.CalculatorSoap {
        
        public CalculatorSoapClient() {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CalculatorClient.ServiceReference.CalculateResponse CalculatorClient.ServiceReference.CalculatorSoap.Calculate(CalculatorClient.ServiceReference.CalculateRequest request) {
            return base.Channel.Calculate(request);
        }
        
        public CalculatorClient.ServiceReference.ArrayOfString Calculate(CalculatorClient.ServiceReference.ArrayOfInt bits, int mask) {
            CalculatorClient.ServiceReference.CalculateRequest inValue = new CalculatorClient.ServiceReference.CalculateRequest();
            inValue.Body = new CalculatorClient.ServiceReference.CalculateRequestBody();
            inValue.Body.bits = bits;
            inValue.Body.mask = mask;
            CalculatorClient.ServiceReference.CalculateResponse retVal = ((CalculatorClient.ServiceReference.CalculatorSoap)(this)).Calculate(inValue);
            return retVal.Body.CalculateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CalculatorClient.ServiceReference.CalculateResponse> CalculatorClient.ServiceReference.CalculatorSoap.CalculateAsync(CalculatorClient.ServiceReference.CalculateRequest request) {
            return base.Channel.CalculateAsync(request);
        }
        
        public System.Threading.Tasks.Task<CalculatorClient.ServiceReference.CalculateResponse> CalculateAsync(CalculatorClient.ServiceReference.ArrayOfInt bits, int mask) {
            CalculatorClient.ServiceReference.CalculateRequest inValue = new CalculatorClient.ServiceReference.CalculateRequest();
            inValue.Body = new CalculatorClient.ServiceReference.CalculateRequestBody();
            inValue.Body.bits = bits;
            inValue.Body.mask = mask;
            return ((CalculatorClient.ServiceReference.CalculatorSoap)(this)).CalculateAsync(inValue);
        }
    }
}
