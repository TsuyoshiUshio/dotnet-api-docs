using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

public class Form1: Form
{
 protected TextBox textBox1;
// <Snippet1>
// Class-level declaration.
 // Create a TraceSwitch.
 static TraceSwitch generalSwitch = new TraceSwitch("General", "Entire Application");

 static public void MyErrorMethod(Object myObject, string category) {
    // Write the message if the TraceSwitch level is set to Error or higher.
    if(generalSwitch.TraceError)
       Debug.Write("Invalid object for category. ");

    // Write a second message if the TraceSwitch level is set to Verbose.
    if(generalSwitch.TraceVerbose)
       Debug.WriteLine(myObject, category);
 }

// </Snippet1>
}
