﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Titanium.Web.Proxy.Extensions
{
    internal static class DotNetStandardExtensions
    {
        /// <summary>
        /// Disposes the specified client.
        /// Int .NET framework 4.5 the TcpClient class has no Dispose method, 
        /// it is available from .NET 4.6, see
        /// https://msdn.microsoft.com/en-us/library/dn823304(v=vs.110).aspx
        /// </summary>
        /// <param name="client">The client.</param>
        internal static void Dispose(this TcpClient client)
        {
            client.Close();
        }


        /// <summary>
        /// Disposes the specified client.
        /// Int .NET framework 4.5 the X509Store class has no Dispose method, 
        /// it is available from .NET 4.6, see
        /// https://msdn.microsoft.com/en-us/library/system.security.cryptography.x509certificates.x509store.dispose(v=vs.110).aspx
        /// </summary>
        /// <param name="client">The client.</param>
        internal static void Dispose(this X509Store client)
        {
            client.Close();
        }

    }
}
