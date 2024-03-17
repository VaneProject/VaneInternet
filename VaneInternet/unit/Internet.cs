using System;

namespace VaneInternet.unit {
    [Serializable]
    public class Internet {
        private readonly string _name;
        private string _ip;
        private string _subnet;
        private string _gateway;
        private string _dns;

        // 생성자
        public Internet(string name) {
            _name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public Internet(string name, string ip, string subnet, string gateway, string dns) : this(name) {
            Ip = ip;
            Subnet = subnet;
            Gateway = gateway;
            Dns = dns;
        }

        // 프로퍼티
        public string Name => _name;
        
        public string Ip {
            get => _ip;
            set => _ip = value;
        }
        public string Subnet {
            get => _subnet;
            set => _subnet = value;
        }
        public string Gateway {
            get => _gateway;
            set => _gateway = value;
        }
        public string Dns {
            get => _dns;
            set => _dns = value;
        }
    }
}