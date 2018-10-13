using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

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
            process.StartInfo.Arguments = string.Format(@"{0} -Tjpg -O", output);
            
            process.Start();
            process.WaitForExit();
            Image image;
            using (Stream bmpStream = System.IO.File.Open(output + ".jpg", System.IO.FileMode.Open))
            {
                image = Image.FromStream(bmpStream);

            }

            File.Delete(output);
            File.Delete(output + ".jpg");
            return image;
        }
        
        public static class Graphviz
        {
            public const string LIB_GVC = @"C:\Users\Ramil\source\repos\TPR1\packages\Graphviz.2.38.0.2\gvc.dll";
            public const string LIB_GRAPH = @"C:\Users\Ramil\source\repos\TPR1\packages\Graphviz.2.38.0.2\cgraph.dll";
            public const int SUCCESS = 0;
            

            [DllImport(LIB_GVC, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr gvContext();
            
            [DllImport(LIB_GVC, CallingConvention = CallingConvention.Cdecl)]
            public static extern int gvFreeContext(IntPtr gvc);
            
            [DllImport(LIB_GRAPH, CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr agmemread(string data);

            
            [DllImport(LIB_GRAPH, CallingConvention = CallingConvention.Cdecl)]
            public static extern void agclose(IntPtr g);
            
            [DllImport(LIB_GVC, CallingConvention = CallingConvention.Cdecl)]
            public static extern int gvLayout(IntPtr gvc, IntPtr g, string engine);

            
            [DllImport(LIB_GVC, CallingConvention = CallingConvention.Cdecl)]
            public static extern int gvFreeLayout(IntPtr gvc, IntPtr g);
            
            [DllImport(LIB_GVC, CallingConvention = CallingConvention.Cdecl)]
            public static extern int gvRenderFilename(IntPtr gvc, IntPtr g,
                string format, string fileName);
            
            [DllImport(LIB_GVC, CallingConvention = CallingConvention.Cdecl)]
            public static extern int gvRenderData(IntPtr gvc, IntPtr g,
                string format, out IntPtr result, out int length);
            
            [DllImport(LIB_GVC, CallingConvention = CallingConvention.Cdecl)]
            public static extern int gvFreeRenderData(IntPtr result);


            public static Image RenderImage(string source, string format)
            {
                IntPtr gvc = gvContext();
                if (gvc == IntPtr.Zero)
                    throw new Exception("Failed to create Graphviz context.");
                
                IntPtr g = agmemread(source);
                if (g == IntPtr.Zero)
                    throw new Exception("Failed to create graph from source. Check for syntax errors.");
                
                if (gvLayout(gvc, g, "dot") != SUCCESS)
                    throw new Exception("Layout failed.");

                IntPtr result;
                int length;
                
                if (gvRenderData(gvc, g, format, out result, out length) != SUCCESS)
                    throw new Exception("Render failed.");
                
                byte[] bytes = new byte[length];
                
                Marshal.Copy(result, bytes, 0, length);
                
                gvFreeRenderData(result);
                gvFreeLayout(gvc, g);
                agclose(g);
                gvFreeContext(gvc);
                using (MemoryStream stream = new MemoryStream(bytes))
                {
                    return Image.FromStream(stream);
                }
            }
        }
    }
}
