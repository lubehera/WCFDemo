﻿using System.Runtime.Serialization;
using System.ServiceModel;

namespace Lib
{
    [ServiceContract(Namespace = "http://lubehera.servicemodel.samples")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double n1, double n2);
        [OperationContract]
        double Subtract(double n1, double n2);
        [OperationContract]
        double Multiply(double n1, double n2);
        [OperationContract]
        double Divide(double n1, double n2);
    }
}
