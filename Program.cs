using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphics_lab_1_1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Input filename");
      string filename = Console.ReadLine();
      string[] text = System.IO.File.ReadAllLines(filename);
      for (int i = 0 ; i < text.Length; i++) {
        Console.WriteLine(text[i]);
      }
    }
  }
}
