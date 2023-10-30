using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace tool_box
{
    internal class IP
    {
        public static HashSet<String> getLocalIp()
        {
            HashSet<String> ipSet = new HashSet<String>();

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface iface in interfaces)
            {
                if ((iface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || iface.NetworkInterfaceType == NetworkInterfaceType.Ethernet) && iface.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties interfaceProperties = iface.GetIPProperties();

                    foreach (var address in interfaceProperties.UnicastAddresses)
                    {
                        if (address.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) // 检查是否已经输出过相同的IP地址
                        {
                            ipSet.Add(address.Address.ToString()); // 记录已经输出过的IP地址
                        }
                    }
                }
            }

            return ipSet;
        }
    }
}
