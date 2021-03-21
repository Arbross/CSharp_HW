using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Structure_HW
{
    class Client : ICloneable, IComparable, IComparable<Client>
    {
        private ushort code;
        private string PIB;
        private string address;
        private decimal phoneNumber;
        private ushort countOfBuying;
        private ushort allCountOfBuying;
        public override string ToString()
        {
            return $"Code : {Code},\nPIB : {nPIB},\nAddress : {Address},\nPhone number : {PhoneNumber},\nCountOfBuying : {CountOfBuying},\nAll count of buying : {AllCountOfBuying}";
        }
        public Client(ushort code, string PIB, string address, decimal phoneNumber, ushort countOfBuying, ushort allCountOfBuying)
        {
            Code = code;
            PIB = nPIB;
            Address = address;
            PhoneNumber = phoneNumber;
            CountOfBuying = countOfBuying;
            AllCountOfBuying = allCountOfBuying;
        }
        public Client() : this(0, "noPIB", "noAddress", 100000001, 0, 0) { }
        public ushort Code
        {
            get => code;
            set => code = value;
        }
        public string nPIB
        {
            get => PIB;
            set => PIB = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
        public decimal PhoneNumber
        {
            get => phoneNumber;
            set
            {
                //if (phoneNumber >= 100000000 && phoneNumber <= 999999999)
                //{
                //    phoneNumber = value;
                //}
                //else
                //{
                //    throw new Exception();
                //}
                phoneNumber = value;
            }
        }
        public ushort CountOfBuying
        {
            get => countOfBuying;
            set => countOfBuying = value;
        }
        public ushort AllCountOfBuying
        {
            get => allCountOfBuying;
            set => allCountOfBuying = value;
        }
        public object Clone()
        {
            Client client = new Client(this.Code, this.nPIB, this.Address,  this.PhoneNumber, this.CountOfBuying, this.AllCountOfBuying);
            return client;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Client))
            {
                throw new FormatException("obj isn't Client");
            }
            return this.nPIB.CompareTo(((Client)(obj)).nPIB);
        }

        public int CompareTo([AllowNull] Client other)
        {
            return -this.nPIB.CompareTo(other.nPIB);
        }
    }
}
