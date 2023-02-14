using MathPrimitivesLibrary;
using MathPrimitivesLibrary.Types.Meshes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace ConsoleApp1.EikanalSolver
{
  struct Point
  {
    public double X;
    public double Y;
    public Point(double x, double y)
    {
      X = x;
      Y = y;
    }

    public void Show()
    {
      Console.Write($"\t({X},{Y}) ");
    }
  }
  internal class Eikonal2D
  {
    // Коэффициенты для двумерного случая
    double a { get; set; }
    double b { get; set; }
    double c { get; set; }

    // Функция точного решения T
    Func<double, double, double> ExactSolutionFunc { get; set; }

    Func<double, double, double> RecFunction { get; set; }

    private string ExactSolutionPath { get { return "Results/2D/ExactSolution.txt"; }}
    private string ApproximatedSolutionPath { get { return "Results/2D/ApproximatedSolution.txt"; } }
    private string ApproximatedDifferencePath { get { return "Results/2D/ApproximatedDifference.txt"; } }

    // Сетка
    RegularMesh2D RegMesh { get; set; }

    Matrix ExactSolution { get; set; }

    // TODO: Переписать под свой кастомный тип матрицы. 
    Point[,] MeshPoints { get; set; }

    public Eikonal2D(RegularMesh2D regMesh, Func<double, double, double> recFunction, 
      Func<double, double, double> exactSolution, Helper.MethodType type)
    {
      RegMesh = regMesh;
      RecFunction = recFunction;
      ExactSolutionFunc = exactSolution;
      ExactSolution = new Matrix(RegMesh.NumberOfStepsX, RegMesh.NumberOfStepsY);
      MeshPoints = new Point[RegMesh.NumberOfStepsX, RegMesh.NumberOfStepsY];
      Initialize();
    }

    public void Run(Helper.MethodType type)
    {
      switch (type)
      {
        case Helper.MethodType.FSM:
          {
            Console.WriteLine("\t\t\t--- Using FSM (Fast Sweeping Method) ---\t\t\t");
            FSM();
            break;
          }
        case Helper.MethodType.FMM:
          {
            Console.WriteLine("\t\t\t--- Using FMM (Fast Marching Method) ---\t\t\t");
            //FMM();
            break;
          }
        case Helper.MethodType.Godunov:
          {
            Console.WriteLine("\t\t\t--- Using Godunov's Method ---\t\t\t");
            break;
          }
        case Helper.MethodType.Bicharacteristic:
          {
            Console.WriteLine("\t\t\t--- Using Bicharacteristics Method ---\t\t\t");
            break;
          }
        case Helper.MethodType.FiniteDifference:
          {
            Console.WriteLine("\t\t\t--- Using Finite Difference Method ---\t\t\t");
            FiniteDifference();
            break;
          }
        default:
          Console.WriteLine("Could not find the method.");
          break;
      }
      MessageBox.Show("Расчёт окончен");
    }

    private void Initialize()
    {
      FillMeshPoints();
      CalculateExactSolution();
      SetInitialConditions();
    }

    private void SetInitialConditions()
    {
      for (int i =0; i < RegMesh.NumberOfStepsX; i++)
      {
        for (int j =0; j < RegMesh.NumberOfStepsY; j++)
        {
          RegMesh.Grid[i, j] = Double.MaxValue;
        }
      }
      RegMesh.Grid[RegMesh.NumberOfStepsX / 2, RegMesh.NumberOfStepsY / 2] = 0;
    }

    private void WriteApproximationDifference(string path)
    {
      Helper.ClearFile(path);
      StreamWriter sw = new StreamWriter(path);
      for (int i = 0; i < RegMesh.Grid.Rows; i++)
      {
        for (int j = 0; j < RegMesh.Grid.Coloumns; j++)
        {
          sw.WriteLine(MeshPoints[i, j].X + " " + MeshPoints[i, j].Y + " "
            + Math.Abs(RegMesh.Grid[i, j] - ExactSolution[i, j]));
        }
      }
      sw.Close();
    }

    private void WriteResults(string path)
    {
      Helper.ClearFile(path);
      StreamWriter sw = new StreamWriter(path);
      for (int i = 0; i < RegMesh.Grid.Rows; i++)
      {
        for (int j = 0; j < RegMesh.Grid.Coloumns; j++)
        {
          sw.WriteLine(MeshPoints[i,j].X + " " + MeshPoints[i,j].Y + " " + RegMesh.Grid[i, j]);
        }
      }
      sw.Close();
    }

    private void WriteResults(Matrix matrix, string path)
    {
      Helper.ClearFile(path);
      StreamWriter sw = new StreamWriter(path);
      for (int i = 0; i < RegMesh.Grid.Rows; i++)
      {
        for (int j = 0; j < RegMesh.Grid.Coloumns; j++)
        {
          sw.WriteLine(MeshPoints[i, j].X + " " + MeshPoints[i, j].Y + " " + matrix[i, j]);
          Console.WriteLine(MeshPoints[i, j].X + " " + MeshPoints[i, j].Y + " " + matrix[i, j]);
        }
      }
      sw.Close();
    }

    private void WriteResults(double[,] matrix, string path)
    {
      Helper.ClearFile(path);
      StreamWriter sw = new StreamWriter(path);
      for (int i = 0; i < RegMesh.Grid.Rows; i++)
      {
        for (int j = 0; j < RegMesh.Grid.Coloumns; j++)
        {
          sw.WriteLine(MeshPoints[i, j].X + " " + MeshPoints[i, j].Y + " " + matrix[i, j]);
        }
      }
      sw.Close();
    }

    private void FillMeshPoints()
    {
      double tmpX = -1;
      double tmpY = -1;
      for (int i =0; i < RegMesh.NumberOfStepsX; i++)
      {
        for (int j =0; j < RegMesh.NumberOfStepsY; j++)
        {
          MeshPoints[i, j] = new Point(tmpY , tmpX);
          tmpY += RegMesh.StepLengthY;
        }
        tmpX += RegMesh.StepLengthX;
        tmpY = -1;
      }
    }

    public void ShowMeshPoints()
    {
      for (int i = 0; i < RegMesh.NumberOfStepsX; i++)
      {
        for (int j = 0; j < RegMesh.NumberOfStepsY; j++)
        {
          MeshPoints[i, j].Show();
        }
        Console.WriteLine();
      }
    }

    private void FiniteDifference()
    {
      for (int i = 0; i >= 0; i++)
      {
        for (int j = 0; j < RegMesh.NumberOfStepsY - 1; j++)
        {
          RegMesh.Grid[i, j + 1] = Math.Sqrt(Math.Pow(RegMesh.StepLengthY, 2) * RecFunction(MeshPoints[i, j].X, MeshPoints[i, j].Y) +
            +2 * RegMesh.Grid[i, j]);
        }
      }
    }

    private void FMM()
    {
      Matrix farAwayPoint = new Matrix(RegMesh.NumberOfStepsX, RegMesh.NumberOfStepsY);
      for (int i = 0; i < farAwayPoint.Rows; i++)
      {

      }
    }

    private void FSM()
    {
      int iterations = 5;
      int count = 0;
      List<bool[]> sweepDirections = new List<bool[]> { 
        new bool[] { true, true },
        new bool[] { false, true },
        new bool[] { false, false },
        new bool[] { true, false }
      };

      //RegMesh.Grid.Show();

      do
      {
        for (int sweep = 0; sweep < sweepDirections.Count; sweep++)
        {
          int iStart = sweepDirections[sweep][0] ? 0 : RegMesh.Grid.Rows - 1;
          int iEnd = sweepDirections[sweep][0] ? RegMesh.Grid.Rows : 0;

          int jStart = sweepDirections[sweep][1] ? 0 : RegMesh.Grid.Rows - 1;
          int jEnd = sweepDirections[sweep][1] ? RegMesh.Grid.Rows : 0;

          //Console.WriteLine($"iStart: {iStart}, iEnd: {iEnd}");
          //Console.WriteLine($"jStart: {jStart}, jEnd: {jEnd}");

          for (int i = iStart; i != iEnd; i = (sweepDirections[sweep][0]) ? i +1 : i-1)
          {
            for (int j = jStart; j != jEnd; j = (sweepDirections[sweep][1]) ? j + 1 : j - 1)
            {
              Sweep2D(i, j);
            }
          }
        }
        count++;
        Console.WriteLine($"Current iteration: {count}\n");
        Console.WriteLine((RegMesh.Grid - ExactSolution).Norm());
      } while (count != iterations);
      WriteApproximationDifference(ApproximatedDifferencePath);
      //WriteResultsTmp(ApproximatedSolutionPath);
      //WriteResults(ApproximatedSolutionPath);
    }

    private void Sweep2D(int i, int j)
    {
      double txMin, tyMin, t, eps = 0;
      if (!Double.IsInfinity(RegMesh.Grid[i, j]))
      {
        if (i == 0)
        {
          tyMin = RegMesh.Grid[i + 1, j];
        }
        else if (i == RegMesh.Grid.Rows - 1)
        {
          tyMin = RegMesh.Grid[i - 1, j];
        }
        else
        {
          tyMin = Math.Min(RegMesh.Grid[i - 1, j], RegMesh.Grid[i + 1, j]);
        }

        if (j == 0)
        {
          txMin = RegMesh.Grid[i,j + 1];
        }
        else if (j == RegMesh.Grid.Rows - 1)
        {
          txMin = RegMesh.Grid[i,j - 1];
        }
        else
        {
          txMin = Math.Min(RegMesh.Grid[i,j - 1], RegMesh.Grid[i,j + 1]);
        }

        if (Math.Abs(txMin - tyMin) >= RegMesh.StepLengthX / RecFunction(MeshPoints[i, j].X, MeshPoints[i, j].Y))
        {
          t = Math.Min(txMin, tyMin) + RegMesh.StepLengthX / RecFunction(MeshPoints[i, j].X, MeshPoints[i, j].Y);
        }
        else
        {
          double sqrtP = 2.0 / Math.Pow(RecFunction(MeshPoints[i, j].X, MeshPoints[i, j].Y), 2) * RegMesh.StepLengthX * RegMesh.StepLengthX
            - Math.Pow(txMin - tyMin, 2);
          t = (txMin + tyMin + Math.Sqrt(sqrtP)) / 2.0;
        }
        // set space data
        RegMesh.Grid[i, j] = Math.Min(RegMesh.Grid[i, j], t);
      }
    }

    private void CalculateApproximatedSolution()
    {
      RegMesh.ClearMeshData();
      Helper.WriteToFile(RegMesh.Grid, ApproximatedSolutionPath);
    }

    private void CalculateExactSolution()
    {
      for (int i = 0; i < RegMesh.NumberOfStepsX; i++)
      {
        for (int j = 0; j < RegMesh.NumberOfStepsY; j++)
        {
          //RegMesh.Grid[i, j] = ExactSolution(RegMesh.GridPointsX[i, 0], RegMesh.GridPointsY[0, j]);
          ExactSolution[i,j] = Math.Abs(ExactSolutionFunc(MeshPoints[i, j].X, MeshPoints[i, j].Y));
        }
      }
      WriteResults(ExactSolution, ExactSolutionPath);
    }
  }
}
