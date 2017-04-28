﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherMonitor.MelbourneWeatherService {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://MelbourneWeather2")]
    public partial class Exception1 : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Exception exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public Exception Exception {
            get {
                return this.exceptionField;
            }
            set {
                this.exceptionField = value;
                this.RaisePropertyChanged("Exception");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MelbourneWeather2")]
    public partial class Exception : object, System.ComponentModel.INotifyPropertyChanged {
        
        private object exception1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Exception", IsNullable=true, Order=0)]
        public object Exception1 {
            get {
                return this.exception1Field;
            }
            set {
                this.exception1Field = value;
                this.RaisePropertyChanged("Exception1");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://MelbourneWeather2", ConfigurationName="MelbourneWeatherService.MelbourneWeather2PortType")]
    public interface MelbourneWeather2PortType {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:getRainfall", ReplyAction="urn:getRainfallResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeatherMonitor.MelbourneWeatherService.Exception1), Action="urn:getRainfallException", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WeatherMonitor.MelbourneWeatherService.getRainfallResponse getRainfall(WeatherMonitor.MelbourneWeatherService.getRainfallRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getRainfall", ReplyAction="urn:getRainfallResponse")]
        System.Threading.Tasks.Task<WeatherMonitor.MelbourneWeatherService.getRainfallResponse> getRainfallAsync(WeatherMonitor.MelbourneWeatherService.getRainfallRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:getTemperature", ReplyAction="urn:getTemperatureResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeatherMonitor.MelbourneWeatherService.Exception1), Action="urn:getTemperatureException", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WeatherMonitor.MelbourneWeatherService.getTemperatureResponse getTemperature(WeatherMonitor.MelbourneWeatherService.getTemperatureRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getTemperature", ReplyAction="urn:getTemperatureResponse")]
        System.Threading.Tasks.Task<WeatherMonitor.MelbourneWeatherService.getTemperatureResponse> getTemperatureAsync(WeatherMonitor.MelbourneWeatherService.getTemperatureRequest request);
        
        // CODEGEN: Generating message contract since the operation getLocations is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="urn:getLocations", ReplyAction="urn:getLocationsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WeatherMonitor.MelbourneWeatherService.Exception1), Action="urn:getLocationsException", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WeatherMonitor.MelbourneWeatherService.getLocationsResponse getLocations(WeatherMonitor.MelbourneWeatherService.getLocationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getLocations", ReplyAction="urn:getLocationsResponse")]
        System.Threading.Tasks.Task<WeatherMonitor.MelbourneWeatherService.getLocationsResponse> getLocationsAsync(WeatherMonitor.MelbourneWeatherService.getLocationsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getRainfall", WrapperNamespace="http://MelbourneWeather2", IsWrapped=true)]
    public partial class getRainfallRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MelbourneWeather2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string location;
        
        public getRainfallRequest() {
        }
        
        public getRainfallRequest(string location) {
            this.location = location;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getRainfallResponse", WrapperNamespace="http://MelbourneWeather2", IsWrapped=true)]
    public partial class getRainfallResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MelbourneWeather2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string[] @return;
        
        public getRainfallResponse() {
        }
        
        public getRainfallResponse(string[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getTemperature", WrapperNamespace="http://MelbourneWeather2", IsWrapped=true)]
    public partial class getTemperatureRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MelbourneWeather2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string location;
        
        public getTemperatureRequest() {
        }
        
        public getTemperatureRequest(string location) {
            this.location = location;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getTemperatureResponse", WrapperNamespace="http://MelbourneWeather2", IsWrapped=true)]
    public partial class getTemperatureResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MelbourneWeather2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string[] @return;
        
        public getTemperatureResponse() {
        }
        
        public getTemperatureResponse(string[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getLocationsRequest {
        
        public getLocationsRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getLocationsResponse", WrapperNamespace="http://MelbourneWeather2", IsWrapped=true)]
    public partial class getLocationsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MelbourneWeather2", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string[] @return;
        
        public getLocationsResponse() {
        }
        
        public getLocationsResponse(string[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MelbourneWeather2PortTypeChannel : WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MelbourneWeather2PortTypeClient : System.ServiceModel.ClientBase<WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType>, WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType {
        
        public MelbourneWeather2PortTypeClient() {
        }
        
        public MelbourneWeather2PortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MelbourneWeather2PortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MelbourneWeather2PortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MelbourneWeather2PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WeatherMonitor.MelbourneWeatherService.getRainfallResponse WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType.getRainfall(WeatherMonitor.MelbourneWeatherService.getRainfallRequest request) {
            return base.Channel.getRainfall(request);
        }
        
        public string[] getRainfall(string location) {
            WeatherMonitor.MelbourneWeatherService.getRainfallRequest inValue = new WeatherMonitor.MelbourneWeatherService.getRainfallRequest();
            inValue.location = location;
            WeatherMonitor.MelbourneWeatherService.getRainfallResponse retVal = ((WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType)(this)).getRainfall(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WeatherMonitor.MelbourneWeatherService.getRainfallResponse> WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType.getRainfallAsync(WeatherMonitor.MelbourneWeatherService.getRainfallRequest request) {
            return base.Channel.getRainfallAsync(request);
        }
        
        public System.Threading.Tasks.Task<WeatherMonitor.MelbourneWeatherService.getRainfallResponse> getRainfallAsync(string location) {
            WeatherMonitor.MelbourneWeatherService.getRainfallRequest inValue = new WeatherMonitor.MelbourneWeatherService.getRainfallRequest();
            inValue.location = location;
            return ((WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType)(this)).getRainfallAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WeatherMonitor.MelbourneWeatherService.getTemperatureResponse WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType.getTemperature(WeatherMonitor.MelbourneWeatherService.getTemperatureRequest request) {
            return base.Channel.getTemperature(request);
        }
        
        public string[] getTemperature(string location) {
            WeatherMonitor.MelbourneWeatherService.getTemperatureRequest inValue = new WeatherMonitor.MelbourneWeatherService.getTemperatureRequest();
            inValue.location = location;
            WeatherMonitor.MelbourneWeatherService.getTemperatureResponse retVal = ((WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType)(this)).getTemperature(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WeatherMonitor.MelbourneWeatherService.getTemperatureResponse> WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType.getTemperatureAsync(WeatherMonitor.MelbourneWeatherService.getTemperatureRequest request) {
            return base.Channel.getTemperatureAsync(request);
        }
        
        public System.Threading.Tasks.Task<WeatherMonitor.MelbourneWeatherService.getTemperatureResponse> getTemperatureAsync(string location) {
            WeatherMonitor.MelbourneWeatherService.getTemperatureRequest inValue = new WeatherMonitor.MelbourneWeatherService.getTemperatureRequest();
            inValue.location = location;
            return ((WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType)(this)).getTemperatureAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WeatherMonitor.MelbourneWeatherService.getLocationsResponse WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType.getLocations(WeatherMonitor.MelbourneWeatherService.getLocationsRequest request) {
            return base.Channel.getLocations(request);
        }
        
        public string[] getLocations() {
            WeatherMonitor.MelbourneWeatherService.getLocationsRequest inValue = new WeatherMonitor.MelbourneWeatherService.getLocationsRequest();
            WeatherMonitor.MelbourneWeatherService.getLocationsResponse retVal = ((WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType)(this)).getLocations(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WeatherMonitor.MelbourneWeatherService.getLocationsResponse> WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType.getLocationsAsync(WeatherMonitor.MelbourneWeatherService.getLocationsRequest request) {
            return base.Channel.getLocationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WeatherMonitor.MelbourneWeatherService.getLocationsResponse> getLocationsAsync() {
            WeatherMonitor.MelbourneWeatherService.getLocationsRequest inValue = new WeatherMonitor.MelbourneWeatherService.getLocationsRequest();
            return ((WeatherMonitor.MelbourneWeatherService.MelbourneWeather2PortType)(this)).getLocationsAsync(inValue);
        }
    }
}
