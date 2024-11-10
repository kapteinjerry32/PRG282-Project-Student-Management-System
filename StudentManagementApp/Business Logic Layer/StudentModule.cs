using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Business_Logic_Layer
{
    internal class StudentModule
    {
        int stdNum;
        string modCode;

        public StudentModule()
        {
            
        }

        public StudentModule(int stdNum, string modCode)
        {
            this.stdNum = stdNum;
            this.modCode = modCode;
        }

        public int StdNum { get => stdNum; set => stdNum = value; }
        public string ModCode { get => modCode; set => modCode = value; }
    }
}
