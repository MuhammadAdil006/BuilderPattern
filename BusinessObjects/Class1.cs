using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    //driver
    //builder pattern
    public interface Driver
    {
        int CabId { get; set; }
        String Name { get; set; }
        String LiscenseNo { get; set; }
        String Address { get; set; }
        String PermanentAddress { get; set; }
        String DutyDuration { get; set; }
        DateTime joinDate { get; set; }
        DateTime LeavingDate { get; set; }

    }
    public abstract class Driverbuild1 : Driver
    {
        public abstract int CabId { get; set; }
        public abstract string Name { get; set; }
        public abstract string LiscenseNo { get; set; }
        public abstract string Address { get; set; }
        public abstract string PermanentAddress { get; set; }
        public abstract string DutyDuration { get; set; }
        public abstract DateTime joinDate { get; set; }
        public abstract DateTime LeavingDate { get; set; }
    }
    public class DriverBulder : Driverbuild1
    {
        public override int CabId { get; set; }
        public override string Name { get; set; }
        public override string LiscenseNo { get; set ; }
        public override string Address { get ; set; }
        public override string PermanentAddress { get; set ; }
        public override string DutyDuration { get ; set ; }
        public override DateTime joinDate { get ; set ; }
        public override DateTime LeavingDate { get ; set ; }
    }

}
