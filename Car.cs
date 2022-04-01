using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegistration
{
    class Car
    {
        string type;
        string numberPlate;
        string owner;
        int yearOfProduction;
        DateTime motTestExpireDate;
        bool isGasoline; // gasoline or diesel

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string NumberPlate
        {
            get { return numberPlate; }
            set { numberPlate = value; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public int YearOfProduction
        {
            get { return yearOfProduction; }
            set { yearOfProduction = value; }
        }

        public DateTime MotTestExpireDate
        {
            get { return motTestExpireDate; }
            set { motTestExpireDate = value; }
        }

        public bool IsGasoline
        {
            get { return isGasoline; }
            set { isGasoline = value; }
        }
    }
}
