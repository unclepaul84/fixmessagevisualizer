using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Diagnostics;
using FixMessageVisualizer.VsDebugger;
using FixMessageVisualizer.WinForms;
using System.Reflection;
using System.IO;


[assembly: DebuggerVisualizer(typeof(FixMessageDebugVisualizer), typeof(FixMessageObjectSource), Target = typeof(QuickFix.Message), Description = "Fix Message Visualizer")]

[assembly: DebuggerVisualizer(typeof(FixMessageDebugVisualizer), typeof(FixMessageObjectSource), Target = typeof(string), Description = "Fix Message Visualizer")]

namespace FixMessageVisualizer.VsDebugger
{
    public class FixMessageDebugVisualizer : DialogDebuggerVisualizer
    {

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            var fixMessageString = objectProvider.GetObject().ToString();

            var directoryPath = Path.GetDirectoryName(Uri.UnescapeDataString(new System.Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath));

            FixMessageVisualizerDialog.Show(fixMessageString, new ConventionBasedFixDictionarySource(directoryPath), null);

        }


        public static void TestShowVisualizer(object objectToVisualize) { var visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(FixMessageDebugVisualizer), typeof(FixMessageObjectSource), false); visualizerHost.ShowVisualizer(); }
    }


    public class FixMessageObjectSource : VisualizerObjectSource
    {
        public override void GetData(object target, System.IO.Stream outgoingData)
        {
            base.GetData(target.ToString(), outgoingData);
        }

    }

}
