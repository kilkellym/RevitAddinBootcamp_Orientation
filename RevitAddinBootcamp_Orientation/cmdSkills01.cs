namespace RevitAddinBootcamp_Orientation
{
    [Transaction(TransactionMode.Manual)]
    public class cmdSkills01 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Revit application and document variables
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            // Your Module 01 Skills code goes here
            // Delete the TaskDialog below and add your code
            TaskDialog.Show("Module 01 Skills", "Got Here to Skills 01!");
            TaskDialog.Show("Test", "Testing to see if this makes it to GitHub");
            TaskDialog.Show("Test2", "Testing to see if this makes it to VS");
            return Result.Succeeded;
        }
    }

}
