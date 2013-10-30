using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K12.Club.CadreProveReport
{
    class Permissions
    {
        public static string 社團幹部證明單 { get { return "K12.Club.Universal.CadreProveReport.cs"; } }
        public static bool 社團幹部證明單權限
        {
            get
            {
                return FISCA.Permission.UserAcl.Current[社團幹部證明單].Executable;
            }
        }
    }
}
