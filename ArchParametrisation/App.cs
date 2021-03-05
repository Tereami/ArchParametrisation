using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;

namespace ArchParametrisation
{
    public class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {

            string assemblyPath = typeof(App).Assembly.Location;

            string tabName = "BIM-STARTER";
            application.CreateRibbonTab(tabName);

            //Панель excel
            RibbonPanel panelTest = application.CreateRibbonPanel(tabName, "Arch");

            PushButton btnAdskConvert = panelTest.AddItem(new PushButtonData(
                "ArchParametrisation",
                "АР Параметризация",
                assemblyPath,
                "ArchParametrisation.Cmd")
                ) as PushButton;

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
