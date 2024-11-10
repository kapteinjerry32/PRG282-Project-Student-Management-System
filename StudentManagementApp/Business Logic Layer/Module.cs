using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Business_Logic_Layer
{
    internal class Module
    {
        string moduleCode, moduleName, moduleDesc, resources;

        public Module(string modCode)
        {
            this.moduleCode = modCode;
        }

        public Module(string moduleCode, string moduleName, string moduleDesc, string resources)
        {
            this.moduleCode = moduleCode;
            this.moduleName = moduleName;
            this.moduleDesc = moduleDesc;
            this.resources = resources;
        }

        public string ModuleCode { get => moduleCode; set => moduleCode = value; }
        public string ModuleName { get => moduleName; set => moduleName = value; }
        public string ModuleDesc { get => moduleDesc; set => moduleDesc = value; }
        public string Resources { get => resources; set => resources = value; }
    }
}
