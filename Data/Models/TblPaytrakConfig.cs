using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblPaytrakConfig
    {
        public string Unique { get; set; }
        public string Provider { get; set; }
        public short? VeriSignMode { get; set; }
        public short? VeriSignDatabaseType { get; set; }
        public string VeriSignUser { get; set; }
        public string VeriSignUserTest { get; set; }
        public string VeriSignVendor { get; set; }
        public string VeriSignVendorTest { get; set; }
        public string VeriSignPartner { get; set; }
        public string VeriSignPartnerTest { get; set; }
        public string VeriSignPassword { get; set; }
        public string VeriSignPasswordTest { get; set; }
        public string VeriSignHostAddress { get; set; }
        public string VeriSignHostAddressTest { get; set; }
        public short? VeriSignHostPort { get; set; }
        public short? VeriSignHostPortTest { get; set; }
        public short? VeriSignTimeout { get; set; }
        public short? VeriSignTimeoutTest { get; set; }
        public bool? VeriSignEncryptCcinserts { get; set; }
        public bool? VeriSignEncryptCcinsertsTest { get; set; }
        public int? VeriSignDefaultPaymentType { get; set; }
        public int? VeriSignDefaultPaymentTypeTest { get; set; }
        public bool? VeriSignEnableCsc { get; set; }
        public bool? VeriSignEnableCsctest { get; set; }
        public string VerisignOptionalProxyAddress { get; set; }
        public string VerisignOptionalProxyAddressTest { get; set; }
        public short? VerisignOptionalProxyPort { get; set; }
        public short? VerisignOptionalProxyPortTest { get; set; }
        public string VerisignOptionalProxyLogon { get; set; }
        public string VerisignOptionalProxyLogonTest { get; set; }
        public string VerisignOptionalProxyPassword { get; set; }
        public string VerisignOptionalProxyPasswordTest { get; set; }
        public short? VerisignOptionalDebug { get; set; }
        public short? VerisignOptionalDebugTest { get; set; }
        public bool? VeriSignUseLogging { get; set; }
        public string VeriSignLogFile { get; set; }
        public string SjSerialNumber { get; set; }
        public string SjRequestFile { get; set; }
        public string SjResponseFile { get; set; }
        public bool? SjProduction { get; set; }
        public bool? SjBatch { get; set; }
        public bool? SjAvsignore { get; set; }
        public short? SjSsltransport { get; set; }
        public bool? SjEnableCsc { get; set; }
        public int? SjDefaultPaymentType { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
