using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingHub
{
    public class Package
    {
        private string m_strAddress; // package address
        private string m_strCity; // package city
        private string m_strState; // package state
        private int m_intZip; // package zip code
        private DateTime m_dtmTime; // arrival time
        private int m_intPackageNumber; // package number
        public Package(int intPackage)
        {
            ArrivalTime = DateTime.Now;
            SetPackage("", "", "", 99999, "");
            PackageNumber = intPackage; // unique package number
        }
        private void SetPackage( // set properties of Package object
        string strAddress, string strCity,
        string strState, int intZip, string strDestination)
        {
            Address = strAddress;
            City = strCity;
            State = strState;
            Zip = intZip;
        }
        public string Address
        {
            get { return m_strAddress; }
            set { m_strAddress = value; }
        } 
        public string City
        { 
            get { return m_strCity; }
            set { m_strCity = value; }
        } 
        public string State
        { 
            get { return m_strState; }
            set { m_strState = value; }
        } 
        public int Zip
        { 
            get { return m_intZip; }
            set { m_intZip = value; }
        } 
        public int PackageNumber
        { 
            get { return m_intPackageNumber; }
            set { m_intPackageNumber = value; }
        } 
        public DateTime ArrivalTime
        { 
            get { return m_dtmTime; }
            set { m_dtmTime = value; }
        }
    }
}
