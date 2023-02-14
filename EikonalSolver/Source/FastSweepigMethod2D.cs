using MathPrimitivesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.EikonalSolver
{
  public class FastSweepigMethod2D
  {
    public Matrix SweepDirections { get; set; }
    public double Precision { get; set; }
    public int AmountOfIterations { get; set; }
    public Matrix Grid { get; set; }
    public FastSweepigMethod2D(double precision, int amountOfIterations, Matrix Grid)
    {
      SweepDirections = new Matrix(new double[,] { { 1, 1 }, { 0, 1 }, { 0, 0 }, { 1, 0 } });
      Precision = precision;
      AmountOfIterations = amountOfIterations;
      this.Grid= Grid;
    }

    public void Sweep()
    {

    }
  }
}
