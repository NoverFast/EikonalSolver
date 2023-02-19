using ConsoleApp1;
using ConsoleApp1.EikanalSolver;
using EikonalSolver.Forms;
using MathPrimitivesLibrary.Types.Meshes;
using System;
using OxyPlot.Series;
using OxyPlot;
using System.Windows.Forms;

namespace EikonalSolver
{
  public partial class MainForm : Form
  {

    private RegularMesh2D Mesh2D { get; set; }
    private Eikonal2D Eik2D { get; set; }

    public MainForm()
    {
      InitializeComponent();
      InitializeGraph();
    }

    private void InitializeGraph()
    {
      var pm = new PlotModel
      { 
        PlotType = PlotType.Cartesian,
        Background = OxyColors.White
      };
      pm.Series.Add(new FunctionSeries(t => 5 * Math.Cos(t), t => 5 * Math.Sin(t), 0, 2 * Math.PI, 0.1));
      graph.Model = pm;
    }

    private void InitializeEikonal()
    {
      Func<double, double, double> FunctionF = (x, y) =>
      {
        //return 2 * Math.Exp(x * x + y * y) * Math.Sqrt(x * x + y * y);
        return 1;
      };
      Func<double, double, double> ExactSolution = (x, y) =>
      {
        //return Math.Exp(x * x + y * y) - 1;
        return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
      };
      Mesh2D = new RegularMesh2D(
        new double[] { (double)rightLowerX.Value, (double)rightLowerY.Value },
        new double[] { (double)leftUpperX.Value, (double)leftUpperY.Value },
        (int)stepsX.Value + 1, (int)stepsY.Value + 1);
      Eik2D = new Eikonal2D(Mesh2D, FunctionF, ExactSolution, GetSelectedMethod(), (int)IterationsFSM.Value, 1e-3);
      Eik2D.Run();
    }
    private void leftUpper_ValueChanged(object sender, EventArgs e)
    {
      if (leftUpperX.Value >= rightLowerX.Value || rightLowerX.Value <= leftUpperX.Value)
      {
        MessageBox.Show("Выход за границы сетки относительно Х!");
        return;
      }
      LU.Text = $"({leftUpperX.Value}, {leftUpperY.Value})";
      RU.Text = $"({rightLowerX.Value}, {leftUpperY.Value})";
      LL.Text = $"({leftUpperX.Value}, {rightLowerY.Value})";
    }
    private void rightLower_ValueChanged(object sender, EventArgs e)
    {
      if (leftUpperY.Value <= rightLowerY.Value || rightLowerY.Value >= leftUpperY.Value)
      {
        MessageBox.Show("Выход за границы сетки относительно Y!");
        return;
      }
      RL.Text = $"({rightLowerX.Value}, {rightLowerY.Value})";
      LL.Text = $"({leftUpperX.Value}, {rightLowerY.Value})";
      RU.Text = $"({rightLowerX.Value}, {leftUpperY.Value})";
    }
    private void grid_ValueChanged(object sender, EventArgs e)
    {
      grid.Text = $"({stepsX.Value} X {stepsX.Value})";
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      leftUpper_ValueChanged(sender, e);
      rightLower_ValueChanged(sender, e);
      grid_ValueChanged(sender, e);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Graph graph = new Graph();
      graph.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      InitializeEikonal();
    }

    private Helper.MethodType GetSelectedMethod()
    {
      switch (methodTypes.SelectedIndex)
      {
        case 0:
          return Helper.MethodType.FSM;
        case 1:
          return Helper.MethodType.FMM;
        case 2:
          return Helper.MethodType.Bicharacteristic;
        default:
          MessageBox.Show("Couldn't find suitable calculation method");
          return 0;
      }
    }

    private void methodTypes_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (methodTypes.SelectedIndex == 0)
      {
        FSMboard.Visible = true;
      }
      else FSMboard.Visible = false;
    }
  }
}
