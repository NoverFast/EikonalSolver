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
      leftUpperBound.Location = new System.Drawing.Point(6, 18);
      leftUpperBound.Name = "leftUpperBound";
      leftUpperBound.Size = new System.Drawing.Size(189, 16);
      leftUpperBound.TabIndex = 7;
      leftUpperBound.Text = "Левая верхняя граница (x, y)";
      // 
      // label4
      // 
      label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
      label4.AutoSize = true;
      label4.Location = new System.Drawing.Point(6, 62);
      label4.Name = "label4";
      label4.Size = new System.Drawing.Size(193, 16);
      label4.TabIndex = 10;
      label4.Text = "Правая нижняя граница (x, y)";
      // 
      // label1
      // 
      label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      label1.AutoSize = true;
      label1.Location = new System.Drawing.Point(3, 106);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(159, 16);
      label1.TabIndex = 13;
      label1.Text = "Число шагов сетки по X";
      // 
      // label5
      // 
      label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
      label5.AutoSize = true;
      label5.Location = new System.Drawing.Point(6, 150);
      label5.Name = "label5";
      label5.Size = new System.Drawing.Size(160, 16);
      label5.TabIndex = 14;
      label5.Text = "Число шагов сетки по Y";
      // 
      // label10
      // 
      label10.AutoSize = true;
      label10.Location = new System.Drawing.Point(225, 396);
      label10.Name = "label10";
      label10.Size = new System.Drawing.Size(10, 16);
      label10.TabIndex = 8;
      label10.Text = "|";
      // 
      // label12
      // 
      label12.AutoSize = true;
      label12.Location = new System.Drawing.Point(22, 378);
      label12.Name = "label12";
      label12.Size = new System.Drawing.Size(10, 16);
      label12.TabIndex = 9;
      label12.Text = "|";
      // 
      // label14
      // 
      label14.AutoSize = true;
      label14.Location = new System.Drawing.Point(22, 362);
      label14.Name = "label14";
      label14.Size = new System.Drawing.Size(10, 16);
      label14.TabIndex = 11;
      label14.Text = "|";
      // 
      // label15
      // 
      label15.AutoSize = true;
      label15.Location = new System.Drawing.Point(22, 396);
      label15.Name = "label15";
      label15.Size = new System.Drawing.Size(10, 16);
      label15.TabIndex = 12;
      label15.Text = "|";
      // 
      // label16
      // 
      label16.AutoSize = true;
      label16.Location = new System.Drawing.Point(22, 412);
      label16.Name = "label16";
      label16.Size = new System.Drawing.Size(10, 16);
      label16.TabIndex = 13;
      label16.Text = "|";
      // 
      // label17
      // 
      label17.AutoSize = true;
      label17.Location = new System.Drawing.Point(22, 428);
      label17.Name = "label17";
      label17.Size = new System.Drawing.Size(10, 16);
      label17.TabIndex = 14;
      label17.Text = "|";
      // 
      // label18
      // 
      label18.AutoSize = true;
      label18.Location = new System.Drawing.Point(225, 378);
      label18.Name = "label18";
      label18.Size = new System.Drawing.Size(10, 16);
      label18.TabIndex = 15;
      label18.Text = "|";
      // 
      // label19
      // 
      label19.AutoSize = true;
      label19.Location = new System.Drawing.Point(225, 362);
      label19.Name = "label19";
      label19.Size = new System.Drawing.Size(10, 16);
      label19.TabIndex = 16;
      label19.Text = "|";
      // 
      // label20
      // 
      label20.AutoSize = true;
      label20.Location = new System.Drawing.Point(225, 412);
      label20.Name = "label20";
      label20.Size = new System.Drawing.Size(10, 16);
      label20.TabIndex = 17;
      label20.Text = "|";
      // 
      // label21
      // 
      label21.AutoSize = true;
      label21.Location = new System.Drawing.Point(225, 428);
      label21.Name = "label21";
      label21.Size = new System.Drawing.Size(10, 16);
      label21.TabIndex = 18;
      label21.Text = "|";
      // 
      // label22
      // 
      label22.AutoSize = true;
      label22.Location = new System.Drawing.Point(87, 442);
      label22.Name = "label22";
      label22.Size = new System.Drawing.Size(79, 16);
      label22.TabIndex = 19;
      label22.Text = "-          -          -";
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new System.Drawing.Point(87, 346);
      label6.Name = "label6";
      label6.Size = new System.Drawing.Size(79, 16);
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
      this.methodTypes.Location = new System.Drawing.Point(3, 18);
      this.methodTypes.Name = "methodTypes";
      this.methodTypes.Size = new System.Drawing.Size(246, 24);
      this.methodTypes.TabIndex = 1;
      this.methodTypes.Tag = "";
      this.toolTip1.SetToolTip(this.methodTypes, "Доступные методы вычисления уравнения Эйконала");
      this.methodTypes.SelectedIndexChanged += new System.EventHandler(this.methodTypes_SelectedIndexChanged);
      // 
      // paramsGroupBox
      // 
      this.paramsGroupBox.BackColor = System.Drawing.SystemColors.ControlDark;
      this.paramsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.paramsGroupBox.Controls.Add(this.groupBox1);
      this.paramsGroupBox.Controls.Add(this.methodTypes);
      this.paramsGroupBox.Location = new System.Drawing.Point(12, 12);
      this.paramsGroupBox.Name = "paramsGroupBox";
      this.paramsGroupBox.Size = new System.Drawing.Size(252, 243);
      this.paramsGroupBox.TabIndex = 2;
      this.paramsGroupBox.TabStop = false;
      this.paramsGroupBox.Text = "Параметры";
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
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
      this.groupBox1.Location = new System.Drawing.Point(3, 42);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(246, 197);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Параметры Сетки";
      // 
      // leftUpperY
      // 
      this.leftUpperY.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.leftUpperY.AutoSize = true;
      this.leftUpperY.Location = new System.Drawing.Point(63, 37);
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
      this.leftUpperY.Size = new System.Drawing.Size(50, 22);
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
      this.rightLowerY.Location = new System.Drawing.Point(63, 81);
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
      this.rightLowerY.Size = new System.Drawing.Size(50, 22);
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
      this.stepsY.Location = new System.Drawing.Point(6, 169);
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
      this.stepsY.Size = new System.Drawing.Size(50, 22);
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
      this.stepsX.Location = new System.Drawing.Point(4, 125);
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
      this.stepsX.Size = new System.Drawing.Size(50, 22);
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
      this.rightLowerX.Location = new System.Drawing.Point(4, 81);
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
      this.rightLowerX.Size = new System.Drawing.Size(50, 22);
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
      this.leftUpperX.Location = new System.Drawing.Point(4, 37);
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
      this.leftUpperX.Size = new System.Drawing.Size(50, 22);
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
      this.LU.Location = new System.Drawing.Point(6, 346);
      this.LU.Name = "LU";
      this.LU.Size = new System.Drawing.Size(44, 16);
      this.LU.TabIndex = 4;
      this.LU.Text = "label6";
      // 
      // RU
      // 
      this.RU.AutoSize = true;
      this.RU.Location = new System.Drawing.Point(207, 346);
      this.RU.Name = "RU";
      this.RU.Size = new System.Drawing.Size(44, 16);
      this.RU.TabIndex = 5;
      this.RU.Text = "label7";
      // 
      // LL
      // 
      this.LL.AutoSize = true;
      this.LL.Location = new System.Drawing.Point(6, 442);
      this.LL.Name = "LL";
      this.LL.Size = new System.Drawing.Size(44, 16);
      this.LL.TabIndex = 6;
      this.LL.Text = "label8";
      // 
      // RL
      // 
      this.RL.AutoSize = true;
      this.RL.Location = new System.Drawing.Point(207, 442);
      this.RL.Name = "RL";
      this.RL.Size = new System.Drawing.Size(44, 16);
      this.RL.TabIndex = 7;
      this.RL.Text = "label9";
      // 
      // grid
      // 
      this.grid.AutoSize = true;
      this.grid.Location = new System.Drawing.Point(100, 396);
      this.grid.Name = "grid";
      this.grid.Size = new System.Drawing.Size(44, 16);
      this.grid.TabIndex = 21;
      this.grid.Text = "label8";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(12, 261);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(252, 44);
      this.button2.TabIndex = 3;
      this.button2.Text = "Запуск расчёта";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(9, 313);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 22;
      this.button1.Text = "graph";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // FSMboard
      // 
      this.FSMboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.FSMboard.Controls.Add(this.IterationsFSM);
      this.FSMboard.Location = new System.Drawing.Point(270, 13);
      this.FSMboard.Name = "FSMboard";
      this.FSMboard.Size = new System.Drawing.Size(127, 100);
      this.FSMboard.TabIndex = 23;
      this.FSMboard.Visible = false;
      // 
      // IterationsFSM
      // 
      this.IterationsFSM.Location = new System.Drawing.Point(2, 40);
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
      this.IterationsFSM.Size = new System.Drawing.Size(120, 22);
      this.IterationsFSM.TabIndex = 0;
      this.IterationsFSM.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.SystemColors.ControlDark;
      this.ClientSize = new System.Drawing.Size(576, 465);
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
  }
}

