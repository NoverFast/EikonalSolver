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
      foreach (string s in methodTypes.Items)
      {
        Console.WriteLine(s);
      }
      //InitializeEikonal();
    }

    private void InitializeEikonal()
    { 
      Mesh2D = new RegularMesh2D();
      Eik2D = new Eikonal2D(Mesh2D,
        (x, y) => { return x * 2 + y; },
        (x, y) => { return x * x + y; }, ConsoleApp1.Helper.MethodType.FSM);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Console.Write("Test");
      Graph graph = new Graph();
      graph.Show();
    }
  }
}
