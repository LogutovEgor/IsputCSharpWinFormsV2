using System;
using System.Collections.Generic;
using System.Text;

namespace IsputCSharpWinFormsV2
{
    class Manager
    {
        private static Manager InstanceVar;

        public Test CurrentTest { get; set; }

        Manager()
        {
            CurrentTest = new Test();
        }

        public static Manager Instance
        {
            get
            {
                if (InstanceVar == null)
                    InstanceVar = new Manager();
                return InstanceVar;
            }
        }

        
    }

}
