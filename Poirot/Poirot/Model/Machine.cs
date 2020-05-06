namespace Poirot.Model
{
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Machine
    {
        private int id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int printShopId;
        [Indexed]
        public int PrintShopId
        {
            get { return printShopId; }
            set 
            { printShopId = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string serialNumber;

        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        private string yearOfProduction;

        public string YearOfProduction
        {
            get { return yearOfProduction; }
            set { yearOfProduction = value; }
        }

        private string numberOfSheetPrinted;

        public string NumberOfSheetPrinted
        {
            get { return numberOfSheetPrinted; }
            set { numberOfSheetPrinted = value; }
        }
    }
}
