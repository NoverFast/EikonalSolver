namespace EikonalSolver
{
  partial class MainForm
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label leftUpperBound;
      System.Windows.Forms.Label label4;
      System.Windows.Forms.Label label1;
      System.Windows.Forms.Label label5;
      System.Windows.Forms.Label label10;
      System.Windows.Forms.Label label12;
      System.Windows.Forms.Label label14;
      System.Windows.Forms.Label label15;
      System.Windows.Forms.Label label16;
      System.Windows.Forms.Label label17;
      System.Windows.Forms.Label label18;
      System.Windows.Forms.Label label19;
      System.Windows.Forms.Label label20;
      System.Windows.Forms.Label label21;
      System.Windows.Forms.Label label22;
      System.Windows.Forms.Label label6;
      System.Windows.Forms.Label label2;
      this.methodTypes = new System.Windows.Forms.ComboBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.paramsGroupBox = new System.Windows.Forms.GroupBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.leftUpperY = new System.Windows.Forms.NumericUpDown();
      this.rightLowerY = new System.Windows.Forms.NumericUpDown();
      this.stepsY = new System.Windows.Forms.NumericUpDown();
      this.stepsX = new System.Windows.Forms.NumericUpDown();
      this.rightLowerX = new System.Windows.Forms.NumericUpDown();
      this.leftUpperX = new System.Windows.Forms.NumericUpDown();
      this.LU = new System.Windows.Forms.Label();
      this.RU = new System.Windows.Forms.Label();
      this.LL = new System.Windows.Forms.Label();
      this.RL = new System.Windows.Forms.Label();
      this.grid = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.FSMboard = new System.Windows.Forms.Panel();
      this.IterationsFSM = new System.Windows.Forms.NumericUpDown();
      this.graph = new OxyPlot.WindowsForms.PlotView();
      leftUpperBound = new System.Windows.Forms.Label();
      label4 = new System.Windows.Forms.Label();
      label1 = new System.Windows.Forms.Label();
      label5 = new System.Windows.Forms.Label();
      label10 = new System.Windows.Forms.Label();
      label12 = new System.Windows.Forms.Label();
      label14 = new System.Windows.Forms.Label();
      label15 = new System.Windows.Forms.Label();
      label16 = new System.Windows.Forms.Label();
      label17 = new System.Windows.Forms.Label();
      label18 = new System.Windows.Forms.Label();
      label19 = new System.Windows.Forms.Label();
      label20 = new System.Windows.Forms.Label();
      label21 = new System.Windows.Forms.Label();
      label22 = new System.Windows.Forms.Label();
      label6 = new System.Windows.Forms.Label();
      label2 = new System.Windows.Forms.Label();
      this.paramsGroupBox.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.leftUpperY)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rightLowerY)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stepsY)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stepsX)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rightLowerX)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.leftUpperX)).BeginInit();
      this.FSMboard.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.IterationsFSM)).BeginInit();
      this.SuspendLayout();
      // 
      // leftUpperBound
      // 
      leftUpperBound.Anchor = System.Windows.Forms.AnchorStyles.Top;
      leftUpperBound.AutoSize = true;
      leftUpperBound.Location = new System.Drawing.Point(4, 15);
      leftUpperBound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      leftUpperBound.Name = "leftUpperBound";
      leftUpperBound.Size = new System.Drawing.Size(152, 13);
      leftUpperBound.TabIndex = 7;
      leftUpperBound.Text = "Левая верхняя граница (x, y)";
      // 
      // label4
      // 
      label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
      label4.AutoSize = true;
      label4.Location = new System.Drawing.Point(4, 50);
      label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label4.Name = "label4";
      label4.Size = new System.Drawing.Size(155, 13);
      label4.TabIndex = 10;
      label4.Text = "Правая нижняя граница (x, y)";
      // 
      // label1
      // 
      label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      label1.AutoSize = true;
      label1.Location = new System.Drawing.Point(2, 86);
      label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(130, 13);
      label1.TabIndex = 13;
      label1.Text = "Число шагов сетки по X";
      // 
      // label5
      // 
      label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
      label5.AutoSize = true;
      label5.Location = new System.Drawing.Point(4, 122);
      label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label5.Name = "label5";
      label5.Size = new System.Drawing.Size(130, 13);
      label5.TabIndex = 14;
      label5.Text = "Число шагов сетки по Y";
      // 
      // label10
      // 
      label10.AutoSize = true;
      label10.Location = new System.Drawing.Point(169, 322);
      label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label10.Name = "label10";
      label10.Size = new System.Drawing.Size(9, 13);
      label10.TabIndex = 8;
      label10.Text = "|";
      // 
      // label12
      // 
      label12.AutoSize = true;
      label12.Location = new System.Drawing.Point(16, 307);
      label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label12.Name = "label12";
      label12.Size = new System.Drawing.Size(9, 13);
      label12.TabIndex = 9;
      label12.Text = "|";
      // 
      // label14
      // 
      label14.AutoSize = true;
      label14.Location = new System.Drawing.Point(16, 294);
      label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label14.Name = "label14";
      label14.Size = new System.Drawing.Size(9, 13);
      label14.TabIndex = 11;
      label14.Text = "|";
      // 
      // label15
      // 
      label15.AutoSize = true;
      label15.Location = new System.Drawing.Point(16, 322);
      label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label15.Name = "label15";
      label15.Size = new System.Drawing.Size(9, 13);
      label15.TabIndex = 12;
      label15.Text = "|";
      // 
      // label16
      // 
      label16.AutoSize = true;
      label16.Location = new System.Drawing.Point(16, 335);
      label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label16.Name = "label16";
      label16.Size = new System.Drawing.Size(9, 13);
      label16.TabIndex = 13;
      label16.Text = "|";
      // 
      // label17
      // 
      label17.AutoSize = true;
      label17.Location = new System.Drawing.Point(16, 348);
      label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label17.Name = "label17";
      label17.Size = new System.Drawing.Size(9, 13);
      label17.TabIndex = 14;
      label17.Text = "|";
      // 
      // label18
      // 
      label18.AutoSize = true;
      label18.Location = new System.Drawing.Point(169, 307);
      label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label18.Name = "label18";
      label18.Size = new System.Drawing.Size(9, 13);
      label18.TabIndex = 15;
      label18.Text = "|";
      // 
      // label19
      // 
      label19.AutoSize = true;
      label19.Location = new System.Drawing.Point(169, 294);
      label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label19.Name = "label19";
      label19.Size = new System.Drawing.Size(9, 13);
      label19.TabIndex = 16;
      label19.Text = "|";
      // 
      // label20
      // 
      label20.AutoSize = true;
      label20.Location = new System.Drawing.Point(169, 335);
      label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label20.Name = "label20";
      label20.Size = new System.Drawing.Size(9, 13);
      label20.TabIndex = 17;
      label20.Text = "|";
      // 
      // label21
      // 
      label21.AutoSize = true;
      label21.Location = new System.Drawing.Point(169, 348);
      label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label21.Name = "label21";
      label21.Size = new System.Drawing.Size(9, 13);
      label21.TabIndex = 18;
      label21.Text = "|";
      // 
      // label22
      // 
      label22.AutoSize = true;
      label22.Location = new System.Drawing.Point(65, 359);
      label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label22.Name = "label22";
      label22.Size = new System.Drawing.Size(76, 13);
      label22.TabIndex = 19;
      label22.Text = "-          -          -";
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new System.Drawing.Point(65, 281);
      label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label6.Name = "label6";
      label6.Size = new System.Drawing.Size(76, 13);
      label6.TabIndex = 20;
      label6.Text = "-          -          -";
      // 
      // methodTypes
      // 
      this.methodTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.methodTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.methodTypes.Dock = System.Windows.Forms.DockStyle.Top;
      this.methodTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.methodTypes.Items.AddRange(new object[] {
            "FSM",
            "FMM",
            "Bicharacteristics"});
      this.methodTypes.Location = new System.Drawing.Point(2, 15);
      this.methodTypes.Margin = new System.Windows.Forms.Padding(2);
      this.methodTypes.Name = "methodTypes";
      this.methodTypes.Size = new System.Drawing.Size(185, 21);
      this.methodTypes.TabIndex = 1;
      this.methodTypes.Tag = "";
      this.toolTip1.SetToolTip(this.methodTypes, "Доступные методы вычисления уравнения Эйконала");
      this.methodTypes.SelectedIndexChanged += new System.EventHandler(this.methodTypes_SelectedIndexChanged);
      // 
      // paramsGroupBox
      // 
      this.paramsGroupBox.BackColor = System.Drawing.SystemColors.Control;
      this.paramsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.paramsGroupBox.Controls.Add(this.groupBox1);
      this.paramsGroupBox.Controls.Add(this.methodTypes);
      this.paramsGroupBox.Location = new System.Drawing.Point(9, 10);
      this.paramsGroupBox.Margin = new System.Windows.Forms.Padding(2);
      this.paramsGroupBox.Name = "paramsGroupBox";
      this.paramsGroupBox.Padding = new System.Windows.Forms.Padding(2);
      this.paramsGroupBox.Size = new System.Drawing.Size(189, 197);
      this.paramsGroupBox.TabIndex = 2;
      this.paramsGroupBox.TabStop = false;
      this.paramsGroupBox.Text = "Параметры";
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
      this.groupBox1.Controls.Add(this.leftUpperY);
      this.groupBox1.Controls.Add(this.rightLowerY);
      this.groupBox1.Controls.Add(label5);
      this.groupBox1.Controls.Add(label1);
      this.groupBox1.Controls.Add(this.stepsY);
      this.groupBox1.Controls.Add(this.stepsX);
      this.groupBox1.Controls.Add(label4);
      this.groupBox1.Controls.Add(leftUpperBound);
      this.groupBox1.Controls.Add(this.rightLowerX);
      this.groupBox1.Controls.Add(this.leftUpperX);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(2, 36);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
      this.groupBox1.Size = new System.Drawing.Size(185, 160);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Параметры Сетки";
      // 
      // leftUpperY
      // 
      this.leftUpperY.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.leftUpperY.AutoSize = true;
      this.leftUpperY.Location = new System.Drawing.Point(47, 30);
      this.leftUpperY.Margin = new System.Windows.Forms.Padding(2);
      this.leftUpperY.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.leftUpperY.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
      this.leftUpperY.Name = "leftUpperY";
      this.leftUpperY.Size = new System.Drawing.Size(38, 20);
      this.leftUpperY.TabIndex = 18;
      this.leftUpperY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.leftUpperY.ValueChanged += new System.EventHandler(this.leftUpper_ValueChanged);
      // 
      // rightLowerY
      // 
      this.rightLowerY.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.rightLowerY.AutoSize = true;
      this.rightLowerY.Location = new System.Drawing.Point(47, 66);
      this.rightLowerY.Margin = new System.Windows.Forms.Padding(2);
      this.rightLowerY.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.rightLowerY.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
      this.rightLowerY.Name = "rightLowerY";
      this.rightLowerY.Size = new System.Drawing.Size(38, 20);
      this.rightLowerY.TabIndex = 15;
      this.rightLowerY.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.rightLowerY.ValueChanged += new System.EventHandler(this.rightLower_ValueChanged);
      // 
      // stepsY
      // 
      this.stepsY.Location = new System.Drawing.Point(4, 137);
      this.stepsY.Margin = new System.Windows.Forms.Padding(2);
      this.stepsY.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
      this.stepsY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.stepsY.Name = "stepsY";
      this.stepsY.Size = new System.Drawing.Size(38, 20);
      this.stepsY.TabIndex = 12;
      this.stepsY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.stepsY.ValueChanged += new System.EventHandler(this.grid_ValueChanged);
      // 
      // stepsX
      // 
      this.stepsX.Location = new System.Drawing.Point(3, 102);
      this.stepsX.Margin = new System.Windows.Forms.Padding(2);
      this.stepsX.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
      this.stepsX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.stepsX.Name = "stepsX";
      this.stepsX.Size = new System.Drawing.Size(38, 20);
      this.stepsX.TabIndex = 11;
      this.stepsX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.stepsX.ValueChanged += new System.EventHandler(this.grid_ValueChanged);
      // 
      // rightLowerX
      // 
      this.rightLowerX.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.rightLowerX.AutoSize = true;
      this.rightLowerX.Location = new System.Drawing.Point(3, 66);
      this.rightLowerX.Margin = new System.Windows.Forms.Padding(2);
      this.rightLowerX.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.rightLowerX.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
      this.rightLowerX.Name = "rightLowerX";
      this.rightLowerX.Size = new System.Drawing.Size(38, 20);
      this.rightLowerX.TabIndex = 6;
      this.rightLowerX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.rightLowerX.ValueChanged += new System.EventHandler(this.rightLower_ValueChanged);
      // 
      // leftUpperX
      // 
      this.leftUpperX.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.leftUpperX.AutoSize = true;
      this.leftUpperX.Location = new System.Drawing.Point(3, 30);
      this.leftUpperX.Margin = new System.Windows.Forms.Padding(2);
      this.leftUpperX.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.leftUpperX.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
      this.leftUpperX.Name = "leftUpperX";
      this.leftUpperX.Size = new System.Drawing.Size(38, 20);
      this.leftUpperX.TabIndex = 3;
      this.leftUpperX.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.leftUpperX.ValueChanged += new System.EventHandler(this.leftUpper_ValueChanged);
      // 
      // LU
      // 
      this.LU.AutoSize = true;
      this.LU.Location = new System.Drawing.Point(4, 281);
      this.LU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.LU.Name = "LU";
      this.LU.Size = new System.Drawing.Size(35, 13);
      this.LU.TabIndex = 4;
      this.LU.Text = "label6";
      // 
      // RU
      // 
      this.RU.AutoSize = true;
      this.RU.Location = new System.Drawing.Point(155, 281);
      this.RU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.RU.Name = "RU";
      this.RU.Size = new System.Drawing.Size(35, 13);
      this.RU.TabIndex = 5;
      this.RU.Text = "label7";
      // 
      // LL
      // 
      this.LL.AutoSize = true;
      this.LL.Location = new System.Drawing.Point(4, 359);
      this.LL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.LL.Name = "LL";
      this.LL.Size = new System.Drawing.Size(35, 13);
      this.LL.TabIndex = 6;
      this.LL.Text = "label8";
      // 
      // RL
      // 
      this.RL.AutoSize = true;
      this.RL.Location = new System.Drawing.Point(155, 359);
      this.RL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.RL.Name = "RL";
      this.RL.Size = new System.Drawing.Size(35, 13);
      this.RL.TabIndex = 7;
      this.RL.Text = "label9";
      // 
      // grid
      // 
      this.grid.AutoSize = true;
      this.grid.Location = new System.Drawing.Point(75, 322);
      this.grid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.grid.Name = "grid";
      this.grid.Size = new System.Drawing.Size(35, 13);
      this.grid.TabIndex = 21;
      this.grid.Text = "label8";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(9, 212);
      this.button2.Margin = new System.Windows.Forms.Padding(2);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(189, 36);
      this.button2.TabIndex = 3;
      this.button2.Text = "Запуск расчёта";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(7, 254);
      this.button1.Margin = new System.Windows.Forms.Padding(2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(56, 19);
      this.button1.TabIndex = 22;
      this.button1.Text = "graph";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // FSMboard
      // 
      this.FSMboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.FSMboard.Controls.Add(label2);
      this.FSMboard.Controls.Add(this.IterationsFSM);
      this.FSMboard.Location = new System.Drawing.Point(698, 10);
      this.FSMboard.Margin = new System.Windows.Forms.Padding(2);
      this.FSMboard.Name = "FSMboard";
      this.FSMboard.Size = new System.Drawing.Size(156, 36);
      this.FSMboard.TabIndex = 23;
      this.FSMboard.Visible = false;
      // 
      // IterationsFSM
      // 
      this.IterationsFSM.Location = new System.Drawing.Point(5, 17);
      this.IterationsFSM.Margin = new System.Windows.Forms.Padding(2);
      this.IterationsFSM.Maximum = new decimal(new int[] {
            125,
            0,
            0,
            0});
      this.IterationsFSM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.IterationsFSM.Name = "IterationsFSM";
      this.IterationsFSM.Size = new System.Drawing.Size(90, 20);
      this.IterationsFSM.TabIndex = 0;
      this.IterationsFSM.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
      // 
      // graph
      // 
      this.graph.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.graph.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.graph.Location = new System.Drawing.Point(202, 13);
      this.graph.Margin = new System.Windows.Forms.Padding(2);
      this.graph.Name = "graph";
      this.graph.PanCursor = System.Windows.Forms.Cursors.Hand;
      this.graph.Size = new System.Drawing.Size(492, 346);
      this.graph.TabIndex = 24;
      this.graph.Text = "plotView1";
      this.graph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
      this.graph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
      this.graph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
      // 
      // label2
      // 
      label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
      label2.AutoSize = true;
      label2.Location = new System.Drawing.Point(2, 2);
      label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      label2.Name = "label2";
      label2.Size = new System.Drawing.Size(119, 13);
      label2.TabIndex = 19;
      label2.Text = "FSM: Кол-во итераций";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(865, 378);
      this.Controls.Add(this.graph);
      this.Controls.Add(this.FSMboard);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.grid);
      this.Controls.Add(label6);
      this.Controls.Add(label22);
      this.Controls.Add(label21);
      this.Controls.Add(label20);
      this.Controls.Add(label19);
      this.Controls.Add(label18);
      this.Controls.Add(label17);
      this.Controls.Add(label16);
      this.Controls.Add(label15);
      this.Controls.Add(label14);
      this.Controls.Add(label12);
      this.Controls.Add(label10);
      this.Controls.Add(this.RL);
      this.Controls.Add(this.LL);
      this.Controls.Add(this.RU);
      this.Controls.Add(this.LU);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.paramsGroupBox);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "MainForm";
      this.Text = "Уравнение эйконала";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.paramsGroupBox.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.leftUpperY)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rightLowerY)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stepsY)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stepsX)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rightLowerX)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.leftUpperX)).EndInit();
      this.FSMboard.ResumeLayout(false);
      this.FSMboard.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.IterationsFSM)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ComboBox methodTypes;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.GroupBox paramsGroupBox;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.NumericUpDown leftUpperX;
    private System.Windows.Forms.NumericUpDown rightLowerX;
    private System.Windows.Forms.NumericUpDown stepsY;
    private System.Windows.Forms.NumericUpDown stepsX;
    private System.Windows.Forms.NumericUpDown leftUpperY;
    private System.Windows.Forms.NumericUpDown rightLowerY;
    private System.Windows.Forms.Label LU;
    private System.Windows.Forms.Label RU;
    private System.Windows.Forms.Label LL;
    private System.Windows.Forms.Label RL;
    private System.Windows.Forms.Label grid;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel FSMboard;
    private System.Windows.Forms.NumericUpDown IterationsFSM;
    private OxyPlot.WindowsForms.PlotView graph;
  }
}

