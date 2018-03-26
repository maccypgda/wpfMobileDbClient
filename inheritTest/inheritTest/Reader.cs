using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritTest
{
    internal class Reader
    {

        private string mobId;
        public string MobId
        {
            get { return mobId; }
            set { mobId = value; }
        }
        private string mobProd;
        public string MobProd
        {
            get { return mobProd; }
            set { mobProd = value; }
        }
        private string mobMod;
        public string MobMod
        {
            get { return mobMod; }
            set { mobMod = value; }
        }
        private string mobImei;
        public string MobImei
        {
            get { return mobImei; }
            set { mobImei = value; }
        }
        private string mobComments;
        public string MobComments
        {
            get { return mobComments; }
            set { mobComments = value; }
        }

        private string mobOwner;
        public string MobOwner
        {
            get { return mobOwner; }
            set { mobOwner = value; }
        }

        private string mobInvoice;
        public string MobInvoice
        {
            get { return mobInvoice; }
            set { mobInvoice = value; }
        }
    }
}
