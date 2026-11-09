using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
namespace hello_world
{
    public class Class1
    {
        [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
        public class HelloWorld: IExternalCommand
        {
         public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
            {
                MessageBox.Show("Hello World");
                for(int i=0;i<6;i++)
                {
                    MessageBox.Show(i.ToString());

                }
                MessageBox.Show("check");
                return Result.Succeeded;
            }
        }
    }
}
