using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicSystemModels
{
    public class DODrSchedule
    {
        private int _ConsultantID;
        private int _EmployeeID;
        private int _StartTime;
        private int _EndTime;

        public int ConsultantID
        {
            get
            {
                return _ConsultantID;
            }
            set
            {
                _ConsultantID = value;
            }
        }

        public int EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                _EmployeeID = value;
            }
        }
        public int StartTime
        {
            get
            {
                return _StartTime;
            }
            set
            {
                _StartTime = value;
            }
        }

        public int EndTime
        {
            get
            {
                return _EndTime;
            }
            set
            {
                _EndTime= value;
            }
        }

    }
}
