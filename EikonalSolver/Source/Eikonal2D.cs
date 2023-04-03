using EikonalSolver;
using MathPrimitivesLibrary;
using MathPrimitivesLibrary.Types.Meshes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
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

    int NumberOfIterations { get; set; }
    double Epsilon { get; set; }

    // Функция точного решения T
    Func<double, double, double> ExactSolutionFunc { get; set; }

    Func<double, double, double> RecFunction { get; set; }

    private string ExactSolutionPath { get { return ".\\Results\\2D\\ExactSolution.dat"; }}
    private string ApproximatedSolutionPath { get { return ".\\Results\\2D\\ApproximatedSolution.dat"; } }
    private string ApproximatedDifferencePath { get { return ".\\Results\\2D\\ApproximatedDifference.dat"; } }

    // Сетка
    RegularMesh2D RegMesh { get; set; }

    Matrix ExactSolution { get; set; }

    Point OriginPoint { get; set; }

    Helper.MethodType CalculationType { get; set; }

    public Eikonal2D(RegularMesh2D regMesh, Func<double, double, double> recFunction, 
      Func<double, double, double> exactSolution, Helper.MethodType type, 
      int numberOfIterations, double epsilon)
    {
      RegMesh = regMesh;
      RecFunction = recFunction;
      ExactSolutionFunc = exactSolution;
      ExactSolution = new Matrix(RegMesh.NumberOfStepsX, RegMesh.NumberOfStepsY);
      CalculationType = type;
      NumberOfIterations = numberOfIterations; 
      Epsilon = epsilon;
      OriginPoint = new Point(RegMesh.NumberOfStepsX / 2, RegMesh.NumberOfStepsY / 2);
      Initialize();
    }

    public void Run()
    {
      switch (CalculationType)
      {
        case Helper.MethodType.FSM:
          {
            Console.WriteLine("\t\t\t--- Using FSM (Fast Sweeping Method) ---\t\t\t");
            FSM(NumberOfIterations);
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
      MessageBox.Show($"Данные точного решения были записаны в {ExactSolutionPath}\n" +
        $"Данные приближённого решения были записаны в {ApproximatedSolutionPath}\n" +
        $"Данные ошибки приближённого решения были записаны в {ApproximatedDifferencePath}");
      PlotGraphs();
    }

    private void PlotGraphs(bool UseHeatmap=false)
    {
      Console.WriteLine("Building plots...");
      GnuPlot.Set("title 'Solutions'");
      GnuPlot.Set("isosamples 30", "hidden3d");
      GnuPlot.Set("dgrid3d 100,100,2");
      GnuPlot.Set("terminal wxt size 2400,1200");
      GnuPlot.HoldOn();
      GnuPlot.SPlot($"{ExactSolutionPath}", "using 1:2:3 with points title " +
        "'Exact Solution'");
      GnuPlot.Replot();
      GnuPlot.SPlot($"{ApproximatedSolutionPath}", "using 1:2:3 with points " +
        "title 'Approximated Solution'");
      DialogResult result = MessageBox.Show("Show Difference?", "Plots", MessageBoxButtons.YesNo);
      if (result == DialogResult.No)
      {
        return;
      }
      GnuPlot.HoldOff();
      GnuPlot.Set("terminal wxt 3 size 2400,1200");
      GnuPlot.Set("title 'Difference'");
      GnuPlot.SPlot($"{ApproximatedDifferencePath}", "using 1:2:3 with points title 'Difference'");
    }

    private void Initialize()
    {
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
      RegMesh.Grid[(int)OriginPoint.X, (int)OriginPoint.Y] = 0;
    }

    private void WriteApproximationDifference(string path)
    {
      Helper.ClearFile(path);
      if (File.Exists(path) == false)
      {
        File.Create(path);
      }
      StreamWriter sw = new StreamWriter(path);
      for (int i = 0; i < RegMesh.Grid.Rows; i++)
      {
        for (int j = 0; j < RegMesh.Grid.Coloumns; j++)
        {
          sw.WriteLine(RegMesh.GridPoints[i, j].X + " " + RegMesh.GridPoints[i, j].Y + " "
            + Math.Abs(RegMesh.Grid[i, j] - ExactSolution[i, j]));
        }
      }
      sw.Close();
    }

    private void WriteResults(string path)
    {
      Helper.ClearFile(path);
      if (File.Exists(path) == false)
      {
        File.Create(path);
      }
      StreamWriter sw = new StreamWriter(path);
      for (int i = 0; i < RegMesh.Grid.Rows; i++)
      {
        for (int j = 0; j < RegMesh.Grid.Coloumns; j++)
        {
          sw.WriteLine(RegMesh.GridPoints[i,j].X + " " + RegMesh.GridPoints[i,j].Y + " " + RegMesh.Grid[i, j]);
        }
      }
      sw.Flush();
      sw.Close();
    }

    private void WriteResults(Matrix matrix, string path)
    {
      Helper.ClearFile(path);
      if (File.Exists(path) == false)
      {
        File.Create(path);
      }
      StreamWriter sw = new StreamWriter(path);
      for (int i = 0; i < RegMesh.Grid.Rows; i++)
      {
        for (int j = 0; j < RegMesh.Grid.Coloumns; j++)
        {
          sw.WriteLine(RegMesh.GridPoints[i, j].X + " " + RegMesh.GridPoints[i, j].Y + " " + matrix[i, j]);
          //Console.WriteLine(RegMesh.GridPoints[i, j].X + " " + RegMesh.GridPoints[i, j].Y + " " + matrix[i, j]);
        }
      }
      sw.Flush();
      sw.Close();
    }

    private void WriteResults(double[,] matrix, string path)
    {
      Helper.ClearFile(path);
      if (File.Exists(path) == false)
      {
        File.Create(path);
      }
      StreamWriter sw = new StreamWriter(path);
      for (int i = 0; i < RegMesh.Grid.Rows; i++)
      {
        for (int j = 0; j < RegMesh.Grid.Coloumns; j++)
        {
          sw.WriteLine(RegMesh.GridPoints[i, j].X + " " + RegMesh.GridPoints[i, j].Y + " " + matrix[i, j]);
        }
      }
      sw.Flush();
      sw.Close();
    }

    private void FiniteDifference()
    {
    }

    private void FMM()
    {
      /*
      Matrix farAwayPoint = new Matrix(RegMesh.NumberOfStepsX, RegMesh.NumberOfStepsY);
      for (int i = 0; i < farAwayPoint.Rows; i++)
      {
        for (int j =0; j < farAwayPoint.Coloumns; j++)
        {
          farAwayPoint[i, j] = 2
        }
      }

      for (int i = 0; i <   )


      for (int i = 0; i < origins.size(); i++)
      {
        vector<int> point = origins[i];
        space2d[(int)point[0] * N + (int)point[1]] = 0;
        far_away[(int)point[0] * N + (int)point[1]] = 0;
      }

      // Get Neighbors of Origins points
      vector<vector<int>> narrowBandIndexOfOrigins = getIndexesNarrowBand(origins);

      // Label Neighbors of Origins points as narrowBand
      for (int i = 0; i < narrowBandIndexOfOrigins.size(); i++)
      {
        vector<int> row = narrowBandIndexOfOrigins[i];
        far_away[row[0] * N + row[1]] = 1;

        // calculate eikonal for all narrowBand
        calculateEikonal2d(row[0], row[1]);
      }

      // Get all value of narrowBandIndexOfOrigins and save them to the heap

      int iter = 1;

      clock_t tstart = clock();

      while (true)
      {
        // Get all Indexes of narrowBand
        vector<vector<int>> indexesOnesNarrowBand = getIndexesNarrowBand(far_away);

        // When not finished all element inside narrowband
        if (!indexesOnesNarrowBand.empty())
        {
          // Get the minimum element index
          vector<int> minIndex = getIndexesMinNarrowBand(space2d, indexesOnesNarrowBand);
          // Add the minimum to the frozen elements
          far_away[minIndex[0] * N + minIndex[1]] = 0;

          // Get the neighbors of the minvalue
          vector<vector<int>> newNeighborsIndexes;
          for (int j = 0; j < neighbors.size(); j++)
          {
            vector<int> ind;
            ind.push_back(minIndex[0] + neighbors[j][0]);
            ind.push_back(minIndex[1] + neighbors[j][1]);
            newNeighborsIndexes.push_back(ind);
          }

          // Put 1 where 2 in far_away (label far away as narrowBand)
          for (int i = 0; i < newNeighborsIndexes.size(); i++)
          {
            vector<int> current = newNeighborsIndexes[i];
            if (far_away[current[0] * N + current[1]] == 2)
            {
              far_away[current[0] * N + current[1]] = 1;
            }
          }
          // We got new narrowBand... must get all indexes and recalculate distance field value for new added...

          // Calculate U tentative of that
          for (int i = 0; i < newNeighborsIndexes.size(); i++)
          {
            vector<int> currentIndex = newNeighborsIndexes[i];

            calculateEikonal2d(currentIndex[0], currentIndex[1]);
          }
        }

        if (iter == N * N)
        {
          break;
        }
        iter++;
      }

      delete[] far_away;
      clock_t tfinish = clock();
      std::cout << "Sequential FMM - Time: \tt = " << (tfinish - tstart) / (double)CLOCKS_PER_SEC << endl;
      std::cout << "  FMM - N: \tN = " << N << endl;
      std::cout << "  FMM solving" << endl;
      /*std::cout << "Writing file..." << endl;
      writeFile2d(fname);*/
    }

    private void FSM(int iters)
    {
      int iterations = iters;
      int count = 0;
      List<bool[]> sweepDirections = new List<bool[]> { 
        new bool[] { true, true },
        new bool[] { false, true },
        new bool[] { false, false },
        new bool[] { true, false }
      };

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
      WriteResults(ApproximatedSolutionPath);
      WriteApproximationDifference(ApproximatedDifferencePath);
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

        if (Math.Abs(txMin - tyMin) >= RegMesh.StepLengthX / RecFunction(RegMesh.GridPoints[i, j].X, RegMesh.GridPoints[i, j].Y))
        {
          t = Math.Min(txMin, tyMin) + RegMesh.StepLengthX / RecFunction(RegMesh.GridPoints[i, j].X, RegMesh.GridPoints[i, j].Y);
        }
        else
        {
          double sqrtP = 2.0 / Math.Pow(RecFunction(RegMesh.GridPoints[i, j].X, RegMesh.GridPoints[i, j].Y), 2) * RegMesh.StepLengthX * RegMesh.StepLengthX
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
          ExactSolution[i,j] = Math.Abs(ExactSolutionFunc(RegMesh.GridPoints[i, j].X, RegMesh.GridPoints[i, j].Y));
        }
      }
      WriteResults(ExactSolution, ExactSolutionPath);
    }
  }
}
