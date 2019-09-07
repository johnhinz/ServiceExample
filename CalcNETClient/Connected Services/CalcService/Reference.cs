﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalcNETClient.CalcService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalcService.ICalculate")]
    public interface ICalculate {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculate/Add", ReplyAction="http://tempuri.org/ICalculate/AddResponse")]
        int Add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculate/Add", ReplyAction="http://tempuri.org/ICalculate/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculate/Subtract", ReplyAction="http://tempuri.org/ICalculate/SubtractResponse")]
        int Subtract(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculate/Subtract", ReplyAction="http://tempuri.org/ICalculate/SubtractResponse")]
        System.Threading.Tasks.Task<int> SubtractAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculate/Multiply", ReplyAction="http://tempuri.org/ICalculate/MultiplyResponse")]
        int Multiply(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculate/Multiply", ReplyAction="http://tempuri.org/ICalculate/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculate/Divide", ReplyAction="http://tempuri.org/ICalculate/DivideResponse")]
        double Divide(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculate/Divide", ReplyAction="http://tempuri.org/ICalculate/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculateChannel : CalcNETClient.CalcService.ICalculate, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculateClient : System.ServiceModel.ClientBase<CalcNETClient.CalcService.ICalculate>, CalcNETClient.CalcService.ICalculate {
        
        public CalculateClient() {
        }
        
        public CalculateClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculateClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculateClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculateClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int x, int y) {
            return base.Channel.Add(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int x, int y) {
            return base.Channel.AddAsync(x, y);
        }
        
        public int Subtract(int x, int y) {
            return base.Channel.Subtract(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SubtractAsync(int x, int y) {
            return base.Channel.SubtractAsync(x, y);
        }
        
        public int Multiply(int x, int y) {
            return base.Channel.Multiply(x, y);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int x, int y) {
            return base.Channel.MultiplyAsync(x, y);
        }
        
        public double Divide(int x, int y) {
            return base.Channel.Divide(x, y);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(int x, int y) {
            return base.Channel.DivideAsync(x, y);
        }
    }
}
