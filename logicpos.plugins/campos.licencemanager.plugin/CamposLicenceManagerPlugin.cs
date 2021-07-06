using System;
using System.Collections;
using logicpos.plugin.contracts;


namespace campos.licencemanager.plugin
{
    public class CamposLicenceManagerPlugin : ILicenceManager
    {
       
        public string Name { get => "AcmeSoftwareVendorPlugin"; }

        public Type BaseType { get => typeof(IPlugin); }

        public Type Interface { get => typeof(ISoftwareVendor); }

        public CamposLicenceManagerPlugin()
        {
        }

        public void Do()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string GetHardwareID()
        {
            throw new NotImplementedException();
        }

        public byte[] GetLicence(string hardwareID, string version, bool haveLicence)
        {
            throw new NotImplementedException();
        }

        public SortedList GetLicenseInformation()
        {
            throw new NotImplementedException();
        }

        public string GetLicenseFilename()
        {
            throw new NotImplementedException();
        }

        public bool IsLicensed()
        {
            throw new NotImplementedException();
        }

        public bool ConnectToWS()
        {
            throw new NotImplementedException();
        }

        public byte[] ActivateLicense(string name, string company, string fiscalNumber, string address, string email, string phone, string hardwareId, string assemblyVersion)
        {
            throw new NotImplementedException();
        }

        public string GetCurrentVersion()
        {
            throw new NotImplementedException();
        }
    }
}
