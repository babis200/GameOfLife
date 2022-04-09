namespace GameOfLifeGUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorButton = new System.Windows.Forms.Button();
            this.emptyButton = new System.Windows.Forms.Button();
            this.gliderGunButton = new System.Windows.Forms.Button();
            this.rowButton = new System.Windows.Forms.Button();
            this.SpaceshipButton = new System.Windows.Forms.Button();
            this.gliderButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.runCheckBox = new System.Windows.Forms.CheckBox();
            this.gridCheckBox = new System.Windows.Forms.CheckBox();
            this.densityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.desityLabel = new System.Windows.Forms.Label();
            this.delayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.delayLabel = new System.Windows.Forms.Label();
            this.squareSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.squareSizeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.densityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1222, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.colorButton);
            this.panel1.Controls.Add(this.emptyButton);
            this.panel1.Controls.Add(this.gliderGunButton);
            this.panel1.Controls.Add(this.rowButton);
            this.panel1.Controls.Add(this.SpaceshipButton);
            this.panel1.Controls.Add(this.gliderButton);
            this.panel1.Controls.Add(this.randomButton);
            this.panel1.Controls.Add(this.runCheckBox);
            this.panel1.Controls.Add(this.gridCheckBox);
            this.panel1.Controls.Add(this.densityNumericUpDown);
            this.panel1.Controls.Add(this.desityLabel);
            this.panel1.Controls.Add(this.delayNumericUpDown);
            this.panel1.Controls.Add(this.delayLabel);
            this.panel1.Controls.Add(this.squareSizeNumericUpDown);
            this.panel1.Controls.Add(this.squareSizeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 59);
            this.panel1.TabIndex = 0;
            // 
            // colorButton
            // 
            this.colorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.colorButton.Location = new System.Drawing.Point(1048, 17);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 14;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // emptyButton
            // 
            this.emptyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emptyButton.Location = new System.Drawing.Point(967, 17);
            this.emptyButton.Name = "emptyButton";
            this.emptyButton.Size = new System.Drawing.Size(75, 23);
            this.emptyButton.TabIndex = 13;
            this.emptyButton.Text = "Empty";
            this.emptyButton.UseVisualStyleBackColor = true;
            this.emptyButton.Click += new System.EventHandler(this.emptyButton_Click);
            // 
            // gliderGunButton
            // 
            this.gliderGunButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gliderGunButton.Location = new System.Drawing.Point(886, 17);
            this.gliderGunButton.Name = "gliderGunButton";
            this.gliderGunButton.Size = new System.Drawing.Size(75, 23);
            this.gliderGunButton.TabIndex = 12;
            this.gliderGunButton.Text = "Glider Gun";
            this.gliderGunButton.UseVisualStyleBackColor = true;
            this.gliderGunButton.Click += new System.EventHandler(this.gliderGunButton_Click);
            // 
            // rowButton
            // 
            this.rowButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rowButton.Location = new System.Drawing.Point(805, 17);
            this.rowButton.Name = "rowButton";
            this.rowButton.Size = new System.Drawing.Size(75, 23);
            this.rowButton.TabIndex = 11;
            this.rowButton.Text = "Row";
            this.rowButton.UseVisualStyleBackColor = true;
            this.rowButton.Click += new System.EventHandler(this.rowButton_Click);
            // 
            // SpaceshipButton
            // 
            this.SpaceshipButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SpaceshipButton.Location = new System.Drawing.Point(724, 17);
            this.SpaceshipButton.Name = "SpaceshipButton";
            this.SpaceshipButton.Size = new System.Drawing.Size(75, 23);
            this.SpaceshipButton.TabIndex = 10;
            this.SpaceshipButton.Text = "Spaceship";
            this.SpaceshipButton.UseVisualStyleBackColor = true;
            this.SpaceshipButton.Click += new System.EventHandler(this.SpaceshipButton_Click);
            // 
            // gliderButton
            // 
            this.gliderButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gliderButton.Location = new System.Drawing.Point(643, 17);
            this.gliderButton.Name = "gliderButton";
            this.gliderButton.Size = new System.Drawing.Size(75, 23);
            this.gliderButton.TabIndex = 9;
            this.gliderButton.Text = "Glider";
            this.gliderButton.UseVisualStyleBackColor = true;
            this.gliderButton.Click += new System.EventHandler(this.gliderButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.randomButton.Location = new System.Drawing.Point(562, 17);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(75, 23);
            this.randomButton.TabIndex = 8;
            this.randomButton.Text = "Random";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // runCheckBox
            // 
            this.runCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.runCheckBox.AutoSize = true;
            this.runCheckBox.Location = new System.Drawing.Point(509, 23);
            this.runCheckBox.Name = "runCheckBox";
            this.runCheckBox.Size = new System.Drawing.Size(47, 19);
            this.runCheckBox.TabIndex = 7;
            this.runCheckBox.Text = "Run";
            this.runCheckBox.UseVisualStyleBackColor = true;
            this.runCheckBox.CheckedChanged += new System.EventHandler(this.runCheckBox_CheckedChanged);
            // 
            // gridCheckBox
            // 
            this.gridCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridCheckBox.AutoSize = true;
            this.gridCheckBox.Location = new System.Drawing.Point(455, 23);
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.Size = new System.Drawing.Size(48, 19);
            this.gridCheckBox.TabIndex = 6;
            this.gridCheckBox.Text = "Grid";
            this.gridCheckBox.UseVisualStyleBackColor = true;
            this.gridCheckBox.CheckedChanged += new System.EventHandler(this.gridCheckBox_CheckedChanged);
            // 
            // densityNumericUpDown
            // 
            this.densityNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.densityNumericUpDown.Location = new System.Drawing.Point(378, 19);
            this.densityNumericUpDown.Name = "densityNumericUpDown";
            this.densityNumericUpDown.Size = new System.Drawing.Size(59, 23);
            this.densityNumericUpDown.TabIndex = 5;
            this.densityNumericUpDown.ValueChanged += new System.EventHandler(this.densityNumericUpDown_ValueChanged);
            // 
            // desityLabel
            // 
            this.desityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.desityLabel.AutoSize = true;
            this.desityLabel.Location = new System.Drawing.Point(309, 21);
            this.desityLabel.Name = "desityLabel";
            this.desityLabel.Size = new System.Drawing.Size(63, 15);
            this.desityLabel.TabIndex = 4;
            this.desityLabel.Text = "Desity (%):";
            // 
            // delayNumericUpDown
            // 
            this.delayNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delayNumericUpDown.Location = new System.Drawing.Point(244, 19);
            this.delayNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delayNumericUpDown.Name = "delayNumericUpDown";
            this.delayNumericUpDown.Size = new System.Drawing.Size(59, 23);
            this.delayNumericUpDown.TabIndex = 3;
            this.delayNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delayNumericUpDown.ValueChanged += new System.EventHandler(this.delayNumericUpDown_ValueChanged);
            // 
            // delayLabel
            // 
            this.delayLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(172, 21);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(66, 15);
            this.delayLabel.TabIndex = 2;
            this.delayLabel.Text = "Delay (ms):";
            // 
            // squareSizeNumericUpDown
            // 
            this.squareSizeNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.squareSizeNumericUpDown.Location = new System.Drawing.Point(107, 19);
            this.squareSizeNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.squareSizeNumericUpDown.Name = "squareSizeNumericUpDown";
            this.squareSizeNumericUpDown.Size = new System.Drawing.Size(59, 23);
            this.squareSizeNumericUpDown.TabIndex = 1;
            this.squareSizeNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.squareSizeNumericUpDown.ValueChanged += new System.EventHandler(this.squareSizeNumericUpDown_ValueChanged);
            // 
            // squareSizeLabel
            // 
            this.squareSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.squareSizeLabel.AutoSize = true;
            this.squareSizeLabel.Location = new System.Drawing.Point(9, 21);
            this.squareSizeLabel.Name = "squareSizeLabel";
            this.squareSizeLabel.Size = new System.Drawing.Size(92, 15);
            this.squareSizeLabel.TabIndex = 0;
            this.squareSizeLabel.Text = "Square size (px):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(10, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1202, 365);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Game of Life";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.densityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label squareSizeLabel;
        private NumericUpDown squareSizeNumericUpDown;
        private NumericUpDown densityNumericUpDown;
        private Label desityLabel;
        private NumericUpDown delayNumericUpDown;
        private Label delayLabel;
        private CheckBox runCheckBox;
        private CheckBox gridCheckBox;
        private Button gliderGunButton;
        private Button rowButton;
        private Button SpaceshipButton;
        private Button gliderButton;
        private Button randomButton;
        private System.Windows.Forms.Timer timer1;
        private Button emptyButton;
        private ColorDialog colorDialog1;
        private Button colorButton;
    }
}