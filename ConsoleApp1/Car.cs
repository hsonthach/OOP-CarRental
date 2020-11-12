using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{


    public class Car
    {



        private class MaintenanceStatus
        {
            public DateTime LastestMaintenanceDate;
            public List<DateTime> MaintenanceHistory;

            public MaintenanceStatus()
            {
                LastestMaintenanceDate = DateTime.Now;
                MaintenanceHistory = new List<DateTime>();
            }

            public MaintenanceStatus(DateTime lastestDate)
            {
                LastestMaintenanceDate = lastestDate;
                MaintenanceHistory = new List<DateTime>();
            }
        }

        private class HiringStatus
        {
            public bool IsHired;
            public List<DateTime> HiringHistory;
            public HiringStatus()
            {
                IsHired = false;
                HiringHistory = new List<DateTime>();
            }


        }

        private class InsuranceStatus
        {
            public bool IsExpired;
            public DateTime ExpiredDate;
            public int RenewvalFee;

            // insurance status with enough info
            public InsuranceStatus(DateTime expiredDate, int renewvalFee)
            {
                // expiredDate later than now -> true -> isExpired false
                IsExpired = (DateTime.Compare(expiredDate, DateTime.Now) > 0);
                ExpiredDate = expiredDate;
                RenewvalFee = renewvalFee;
            }

            // insurance status with no info 
            public InsuranceStatus()
            {
                IsExpired = true;
                ExpiredDate = DateTime.MaxValue;
                RenewvalFee = int.MaxValue;
            }


        }
        private class CleaningStatus
        {
            public DateTime LastTimeClean;
            public List<DateTime> CleanHistory;
            public CleaningStatus()
            {
                LastTimeClean = DateTime.Now;
                CleanHistory = new List<DateTime>();
            }
        }

        static private int _amountOfCars;
        static private int _maxID = 1;
        private int _id;

        private string _plateCode;
        private DateTime _buyDate;
        CleaningStatus _cleaningStatus = new CleaningStatus();
        InsuranceStatus _insuranceStatus = new InsuranceStatus();
        HiringStatus _hiringStatus = new HiringStatus();
        MaintenanceStatus _maintenanceStatus = new MaintenanceStatus();



        // Add a brand new car 
        public Car(string plateCode, DateTime buyDate)
        {
            _amountOfCars += 1;
            _id = _maxID;
            _maxID++;
            _plateCode = plateCode;
            _buyDate = buyDate;
        }


        // Add an old car with known insurance status
        public Car(string plateCode, DateTime buyDate, DateTime expiredDate, int renewvalFee)
        {
            _amountOfCars += 1;
            _maxID += 1;
            _id = _maxID + 1;
            _plateCode = plateCode;
            _buyDate = buyDate;
            _insuranceStatus = new InsuranceStatus(expiredDate, renewvalFee);
        }

        // Add an old car with known insurance status and maintenance status
        public Car(string plateCode, DateTime buyDate, DateTime expiredDate, int renewvalFee, DateTime lastestMaintenanceDate)
        {
            _amountOfCars += 1;
            _maxID += 1;
            _id = _maxID + 1;
            _plateCode = plateCode;
            _buyDate = buyDate;
            _insuranceStatus = new InsuranceStatus(expiredDate, renewvalFee);
            _maintenanceStatus = new MaintenanceStatus(lastestMaintenanceDate);
        }

        // Add an old car with known maintenance status
        public Car(string plateCode, DateTime buyDate, DateTime lastestMaintenanceDate)
        {
            _amountOfCars += 1;
            _maxID += 1;
            _id = _maxID + 1;
            _plateCode = plateCode;
            _buyDate = buyDate;
            _maintenanceStatus = new MaintenanceStatus(lastestMaintenanceDate);
        }


        public bool StoreVehicleData()
        {
            return true;
        }

        public bool IsVehicleExist(int id)
        {
            return false;
        }

        public int getID()
        {
            return _id;
        }


        public void PrintCarDate()
        {
            Console.WriteLine(_id);
            Console.WriteLine(_buyDate);
            Console.WriteLine(_plateCode);

            //TODO: Print status too 
        }

    }
}
