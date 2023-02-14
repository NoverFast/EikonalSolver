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
      System.Windows.Forms.Label label2;
      System.Windows.Forms.Label label3;
      System.Windows.Forms.Label label4;
      this.button1 = new System.Windows.Forms.Button();
      this.methodTypes = new System.Windows.Forms.ComboBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.paramsGroupBox = new System.Windows.Forms.GroupBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
      leftUpperBound = new System.Windows.Forms.Label();
      label2 = new System.Windows.Forms.Label();
      label3 = new System.Windows.Forms.Label();
      label4 = new System.Windows.Forms.Label();
      this.paramsGroupBox.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.AutoEllipsis = true;
      this.button1.BackColor = System.Drawing.SystemColors.Control;
      this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.button1.Location = new System.Drawing.Point(12, 244);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Тест";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
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
      this.toolTip1.SetToolTip(this.methodTypes, "Доступные методы вычисления уравнения Эйконала");
      // 
      // paramsGroupBox
      // 
      this.paramsGroupBox.BackColor = System.Drawing.SystemColors.ControlDark;
      this.paramsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.paramsGroupBox.Controls.Add(this.groupBox1);
      this.paramsGroupBox.Controls.Add(this.methodTypes);
      this.paramsGroupBox.Location = new System.Drawing.Point(12, 12);
      this.paramsGroupBox.Name = "paramsGroupBox";
      this.paramsGroupBox.Size = new System.Drawing.Size(252, 226);
      this.paramsGroupBox.TabIndex = 2;
      this.paramsGroupBox.TabStop = false;
      this.paramsGroupBox.Text = "Параметры";
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
      this.groupBox1.Controls.Add(label4);
      this.groupBox1.Controls.Add(label3);
      this.groupBox1.Controls.Add(label2);
      this.groupBox1.Controls.Add(leftUpperBound);
      this.groupBox1.Controls.Add(this.numericUpDown4);
      this.groupBox1.Controls.Add(this.numericUpDown3);
      this.groupBox1.Controls.Add(this.numericUpDown2);
      this.groupBox1.Controls.Add(this.numericUpDown1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(3, 42);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(246, 178);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Параметры Сетки";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.numericUpDown1.AutoSize = true;
      this.numericUpDown1.Location = new System.Drawing.Point(6, 21);
      this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.numericUpDown1.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(50, 22);
      this.numericUpDown1.TabIndex = 3;
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.numericUpDown2.AutoSize = true;
      this.numericUpDown2.Location = new System.Drawing.Point(6, 49);
      this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.numericUpDown2.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(50, 22);
      this.numericUpDown2.TabIndex = 4;
      // 
      // numericUpDown3
      // 
      this.numericUpDown3.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.numericUpDown3.AutoSize = true;
      this.numericUpDown3.Location = new System.Drawing.Point(6, 77);
      this.numericUpDown3.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.numericUpDown3.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
      this.numericUpDown3.Name = "numericUpDown3";
      this.numericUpDown3.Size = new System.Drawing.Size(50, 22);
      this.numericUpDown3.TabIndex = 5;
      // 
      // numericUpDown4
      // 
      this.numericUpDown4.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.numericUpDown4.AutoSize = true;
      this.numericUpDown4.Location = new System.Drawing.Point(6, 108);
      this.numericUpDown4.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.numericUpDown4.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
      this.numericUpDown4.Name = "numericUpDown4";
      this.numericUpDown4.Size = new System.Drawing.Size(50, 22);
      this.numericUpDown4.TabIndex = 6;
      // 
      // leftUpperBound
      // 
      leftUpperBound.Anchor = System.Windows.Forms.AnchorStyles.Top;
      leftUpperBound.AutoSize = true;
      leftUpperBound.Location = new System.Drawing.Point(62, 23);
      leftUpperBound.Name = "leftUpperBound";
      leftUpperBound.Size = new System.Drawing.Size(159, 16);
      leftUpperBound.TabIndex = 7;
      leftUpperBound.Text = "Левая верхняя граница";
      // 
      // label2
      // 
      label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
      label2.AutoSize = true;
      label2.Location = new System.Drawing.Point(62, 51);
      label2.Name = "label2";
      label2.Size = new System.Drawing.Size(168, 16);
      label2.TabIndex = 8;
      label2.Text = "Правая верхняя граница";
      // 
      // label3
      // 
      label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
      label3.AutoSize = true;
      label3.Location = new System.Drawing.Point(62, 79);
      label3.Name = "label3";
      label3.Size = new System.Drawing.Size(154, 16);
      label3.TabIndex = 9;
      label3.Text = "Левая нижняя граница";
      // 
      // label4
      // 
      label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
      label4.AutoSize = true;
      label4.Location = new System.Drawing.Point(62, 110);
      label4.Name = "label4";
      label4.Size = new System.Drawing.Size(163, 16);
      label4.TabIndex = 10;
      label4.Text = "Правая нижняя граница";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.SystemColors.ControlDark;
      this.ClientSize = new System.Drawing.Size(282, 465);
      this.Controls.Add(this.paramsGroupBox);
      this.Controls.Add(this.button1);
      this.Name = "MainForm";
      this.Text = "Уравнение эйконала";
      this.paramsGroupBox.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ComboBox methodTypes;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.GroupBox paramsGroupBox;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.NumericUpDown numericUpDown4;
    private System.Windows.Forms.NumericUpDown numericUpDown3;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
  }
}

