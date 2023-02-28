
using System;

namespace LegacyApp
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContract(ConfigurationName = "LegacyApp.IUserCreditService")]
    public interface IUserCreditService
    {
        [System.ServiceModel.OperationContract(Action = "https://credit.contoso.com/GetCreditLimit")]
        int GetCreditLimit(string firstname, string surname, System.DateTime dateOfBirth);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserCreditServiceChannel : IUserCreditService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserCreditServiceClient : System.ServiceModel.ClientBase<IUserCreditService>
    {
        public UserCreditServiceClient()
            :base()
        {
        }

        public UserCreditServiceClient(string endpointConfigurationName)
            : base(endpointConfigurationName)
        {
        }

        public UserCreditServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress)
            :base(endpointConfigurationName, remoteAddress)
        {
        }

        public UserCreditServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress)
            :base(binding, remoteAddress)
        {
        }

        public int GetCreditLimit(string firstName, string surname, DateTime dateOfBirth)
        {
            return base.Channel.GetCreditLimit(firstName, surname, dateOfBirth);
        }
    }
}