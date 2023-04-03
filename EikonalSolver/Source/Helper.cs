using System.IO;
using MathPrimitivesLibrary;

namespace ConsoleApp1
{
  public static class Helper
  {
    public enum MethodType : byte
    {
      FSM = 0,
      FMM = 1,
      Godunov = 2,
      Bicharacteristic = 3,
      FiniteDifference
    }
    public static void ClearFile(string path)
    {
      if (File.Exists(path))
      {
        File.WriteAllText(path, string.Empty);
      }
    }
    public static void WriteToFile(Matrix m, string path)
    {
      StreamWriter sw = new StreamWriter(path);
      for (int i =0; i < m.Rows; i++)
      {
        for (int j =0; j < m.Coloumns;j++)
        {
          sw.Write(m[i, j] + " ");
        }
        sw.WriteLine();
      }
    }

    public static void WriteToFile(Vector v, string path)
    {
      StreamWriter sw = new StreamWriter(path);
      for (int i =0; i < v.Size; i++)
      {
        sw.Write(v[i]);
      }
    }
  }
}
