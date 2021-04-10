using Lib;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8000/TryoutWCF/");

            ServiceHost selfHost = new ServiceHost(typeof(CalculatorService), baseAddress);

            try
            {
                ServiceEndpoint endpoint = selfHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior
                {
                    HttpGetEnabled = true
                };

                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();
                Console.WriteLine("The Service is ready.");

                Console.WriteLine("Press enter to terminate");
                Console.WriteLine();

                Console.ReadLine();
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occured: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}
