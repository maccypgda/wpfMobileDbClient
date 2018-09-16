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
        public string ID
        {
            get { return mobId; }
            set { mobId = value; }
        }
        private string mobProd;
        public string Producer
        {
            get { return mobProd; }
            set { mobProd = value; }
        }
        private string mobMod;
        public string Model
        {
            get { return mobMod; }
            set { mobMod = value; }
        }
        private string mobImei;
        public string IMEI
        {
            get { return mobImei; }
            set { mobImei = value; }
        }
        private string mobComments;
        public string Comments
        {
            get { return mobComments; }
            set { mobComments = value; }
        }

        private string mobOwner;
        public string Owner
        {
            get { return mobOwner; }
            set { mobOwner = value; }
        }

        private string mobInvoice;
        public string InvoiceNr
        {
            get { return mobInvoice; }
            set { mobInvoice = value; }
        }
    }
}
