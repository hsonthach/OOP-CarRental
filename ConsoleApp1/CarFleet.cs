using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CarFleet
    {
        private int _id;
        private List<int> _listOfVehicleID;
        static private int _maxID = 1;

        // car fleet with no car 
        public CarFleet()
        {
            _listOfVehicleID = new List<int>();
            _id = _maxID + 1;
            _maxID++;
        }

        // car fleet with a list of car id 
        public CarFleet(List<int> listOfVehicleID)
        {
            _listOfVehicleID = listOfVehicleID;
            _id = _maxID + 1;
            _maxID++;
        }

        public bool AddVehicleIDIntoVehicleFleet(int carID)
        {
            bool isExist = false ;  
            for (int i = 0; i < _listOfVehicleID.Count(); i++)
            {
                if (_listOfVehicleID[i] == carID)
                {
                    isExist = true;
                    break; 
                }
            }
            if (isExist) return false;
            _listOfVehicleID.Add(carID);
            return true;
        }

        public void PrintAllVehicleIDInVehicleFleet()
        {
            _listOfVehicleID.ForEach(x => Console.WriteLine(x));
        }


    }
}
