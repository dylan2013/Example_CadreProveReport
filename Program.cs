using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FISCA;
using FISCA.Presentation;
using FISCA.Permission;

namespace K12.Club.CadreProveReport
{
    public class Program
    {
        [MainMethod()]
        static public void Main()
        {

            RibbonBarItem Print = FISCA.Presentation.MotherForm.RibbonBarItems["學生", "資料統計"];
            Print["報表"]["社團相關報表"]["社團幹部證明單"].Enable = Permissions.社團幹部證明單權限;
            Print["報表"]["社團相關報表"]["社團幹部證明單"].Click += delegate
            {
                CadreProveReport cpr = new CadreProveReport();
                cpr.ShowDialog();
            };

            Catalog detail1 = RoleAclSource.Instance["學生"]["報表"];
            detail1.Add(new RibbonFeature(Permissions.社團幹部證明單, "社團幹部證明單"));
        }
    }
}
