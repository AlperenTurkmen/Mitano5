//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Qos.Http;



namespace Unity.Services.Qos.Models
{
    /// <summary>
    /// QosServiceServersList model
    /// </summary>
    [Preserve]
    [DataContract(Name = "QosServiceServersList")]
    internal class QosServiceServersList
    {
        /// <summary>
        /// Creates an instance of QosServiceServersList.
        /// </summary>
        /// <param name="servers">An array of connection information for QoS servers.</param>
        [Preserve]
        public QosServiceServersList(List<QosServiceServer> servers)
        {
            Servers = servers;
        }

        /// <summary>
        /// An array of connection information for QoS servers.
        /// </summary>
        [Preserve]
        [DataMember(Name = "servers", IsRequired = true, EmitDefaultValue = true)]
        public List<QosServiceServer> Servers{ get; }
    
        /// <summary>
        /// Formats a QosServiceServersList into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Servers != null)
            {
                serializedModel += "servers," + Servers.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a QosServiceServersList as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            return dictionary;
        }
    }
}
