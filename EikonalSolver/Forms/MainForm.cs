using ConsoleApp1;
using ConsoleApp1.EikanalSolver;
using EikonalSolver.Forms;
using MathPrimitivesLibrary.Types.Meshes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
      Mesh2D = new RegularMesh2D(-1, 0, -1, 1, (int)stepsX.Value + 1, (int)stepsY.Value + 1);
      Eik2D = new Eikonal2D(Mesh2D,
        FunctionF, ExactSolution, ConsoleApp1.Helper.MethodType.FSM);
      Eik2D.Run(ConsoleApp1.Helper.MethodType.FSM);
    }
    private void leftUpper_ValueChanged(object sender, EventArgs e)
    {
      LU.Text = $"({leftUpperX.Value}, {leftUpperY.Value})";
    }
    private void rightUpper_ValueChanged(object sender, EventArgs e)
    {
      RU.Text = $"({rightUpperX.Value}, {rightUpperY.Value})";
    }
    private void leftLower_ValueChanged(object sender, EventArgs e)
    {
      LL.Text = $"({leftLowerX.Value}, {leftLowerY.Value})";
    }
    private void rightLower_ValueChanged(object sender, EventArgs e)
    {
      RL.Text = $"({rightLowerX.Value}, {rightLowerY.Value})";
    }
    private void grid_ValueChanged(object sender, EventArgs e)
    {
      grid.Text = $"({stepsX.Value} X {stepsX.Value})";
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      leftLower_ValueChanged(sender, e);
      rightUpper_ValueChanged(sender, e);
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
  }
}
