using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace VaneInternet.unit {
    public static class InternetTool {
        public static IPAddress GetGateway() => NetworkInterface.GetAllNetworkInterfaces()
            .Where(n => n.OperationalStatus == OperationalStatus.Up)
            .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
            .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
            .Select(g => g?.Address)
            .FirstOrDefault(a => a != null);
        
        public static IPAddress GetSubnet() {
            var ipAddress = GetIp();
            return NetworkInterface.GetAllNetworkInterfaces()
                .SelectMany(a => a.GetIPProperties().UnicastAddresses)
                .Where(n => n.Address.AddressFamily == AddressFamily.InterNetwork)
                .Where(n => ipAddress.Equals(n.Address))
                .Select(n => n.IPv4Mask)
                .FirstOrDefault();
        }

        public static IPAddress GetIp() => Dns.GetHostEntry(Dns.GetHostName()).AddressList
            .FirstOrDefault(d => d.AddressFamily == AddressFamily.InterNetwork);
    }
}