using System.Drawing;
using System.IO;

namespace TPR1
{
    //source: https://github.com/cerilewis/NGraphviz 
    public static class Examples
    {
        public static Image Run(string dot)
        {
            string executable = @"C:\Users\Ramil\source\repos\TPR1\packages\Graphviz.2.38.0.2\dot.exe";
            string output = @"C:\Users\Ramil\source\repos\TPR1\packages\Graphviz.2.38.0.2\tempgraph";
            File.WriteAllText(output, dot);

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            
            process.StartInfo.FileName = executable;
            process.StartInfo.Arguments = string.Format(@"{0} -Tpng -O", output);
            
            process.Start();
            process.WaitForExit();
            Image image;
            using (Stream bmpStream = System.IO.File.Open(output + ".png", System.IO.FileMode.Open))
            {
                image = Image.FromStream(bmpStream);

            }

            File.Delete(output);
            File.Delete(output + ".png");
            return image;
        }
    }
}
