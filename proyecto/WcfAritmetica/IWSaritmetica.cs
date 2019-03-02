﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAritmetica
{
        [ServiceContract]
    public interface IWaritmetica
    {
        [OperationContract]
        clsAritmetica sumar(int numero1, int numbero2);

    }
    [DataContract]

    public class clsAritmetica
    {   [DataMember]
        public int numeroA { get; set; }
        [DataMember]
        public int numeroB { get; set; }
        [DataMember]
        public int repuesta { get; set; }
    }
}
