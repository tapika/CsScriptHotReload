using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    // Must be here when using EnvDTE
    [STAThread]
    public static void Main()
    {
        ScriptHost.ConnectDebugger();
        Console.WriteLine("---------------------------------------------------------------------------");
        // Must be able to share any data with application itself.
        Class1.HelloClass1();
        if(Class1.dataList.Count < 2)
            Class1.dataList.Add("testScript::Main");

        Console.WriteLine(DateTime.Now.ToString());
        Console.WriteLine(__FILE__() + ": Hello ! world");
    }

    static string __FILE__([System.Runtime.CompilerServices.CallerFilePath] string fileName = "")
    {
        return fileName;
    }
}
