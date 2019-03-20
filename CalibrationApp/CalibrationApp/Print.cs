using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalibrationApp
{
    class Print : IEquatable<Print>
    {
        public Print(int ID, DateTimeOffset Date , string Name, string Descritpion, bool? Calibration)
        {
            this.ID = ID;
            this.Date = Date;
            this.Name = Name;
            this.Description = Descritpion;
            this.Calibration = Calibration;
        }

        public int ID;

        private DateTimeOffset date;
        private string name;
        private string descritpion;
        private bool? calibration;

        public DateTimeOffset Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Description
        {
            get { return this.descritpion; }
            set { this.descritpion = value; }
        }
        public bool? Calibration
        {
            get { return this.calibration; }
            set { this.calibration = value; }
        }

        public override string ToString()
        {
            return "ID: " + ID + "   Name: " + Name;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Print objAsPrint = obj as Print;
            if (objAsPrint == null) return false;
            else return Equals(objAsPrint);
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public bool Equals(Print other)
        {
            if (other == null) return false;
            return (this.ID.Equals(other.ID));
        }
     }
}
