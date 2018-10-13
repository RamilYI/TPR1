namespace TPR1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.propabilityMatrix = new System.Windows.Forms.TabControl();
            this.valueMatrix = new System.Windows.Forms.TabControl();
            this.strategyCount = new System.Windows.Forms.NumericUpDown();
            this.stateCount = new System.Windows.Forms.NumericUpDown();
            this.stepCount = new System.Windows.Forms.NumericUpDown();
            this.calc = new System.Windows.Forms.Button();
            this.updatetable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.graphImageLtd = new System.Windows.Forms.PictureBox();
            this.changeStrategy = new System.Windows.Forms.ComboBox();
            this.saveTable = new System.Windows.Forms.Button();
            this.loadTable = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.strategyCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphImageLtd)).BeginInit();
            this.SuspendLayout();
            // 
            // propabilityMatrix
            // 
            this.propabilityMatrix.Location = new System.Drawing.Point(194, 53);
            this.propabilityMatrix.Name = "propabilityMatrix";
            this.propabilityMatrix.SelectedIndex = 0;
            this.propabilityMatrix.Size = new System.Drawing.Size(269, 178);
            this.propabilityMatrix.TabIndex = 0;
            // 
            // valueMatrix
            // 
            this.valueMatrix.Location = new System.Drawing.Point(194, 264);
            this.valueMatrix.Name = "valueMatrix";
            this.valueMatrix.SelectedIndex = 0;
            this.valueMatrix.Size = new System.Drawing.Size(269, 172);
            this.valueMatrix.TabIndex = 1;
            // 
            // strategyCount
            // 
            this.strategyCount.Location = new System.Drawing.Point(12, 98);
            this.strategyCount.Name = "strategyCount";
            this.strategyCount.Size = new System.Drawing.Size(120, 20);
            this.strategyCount.TabIndex = 2;
            // 
            // stateCount
            // 
            this.stateCount.Location = new System.Drawing.Point(12, 170);
            this.stateCount.Name = "stateCount";
            this.stateCount.Size = new System.Drawing.Size(120, 20);
            this.stateCount.TabIndex = 3;
            // 
            // stepCount
            // 
            this.stepCount.Location = new System.Drawing.Point(12, 33);
            this.stepCount.Name = "stepCount";
            this.stepCount.Size = new System.Drawing.Size(120, 20);
            this.stepCount.TabIndex = 4;
            this.stepCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calc
            // 
            this.calc.Enabled = false;
            this.calc.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.calc.Location = new System.Drawing.Point(12, 211);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(133, 79);
            this.calc.TabIndex = 5;
            this.calc.Text = "рассчитать ожидаемые доходности";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // updatetable
            // 
            this.updatetable.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.updatetable.Location = new System.Drawing.Point(12, 296);
            this.updatetable.Name = "updatetable";
            this.updatetable.Size = new System.Drawing.Size(133, 53);
            this.updatetable.TabIndex = 6;
            this.updatetable.Text = "создать новую таблицу";
            this.updatetable.UseVisualStyleBackColor = true;
            this.updatetable.Click += new System.EventHandler(this.updatetable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Количество шагов моделирования:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(-1, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Количество стратегий:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(-1, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество состояний:";
            // 
            // graphImageLtd
            // 
            this.graphImageLtd.BackColor = System.Drawing.Color.White;
            this.graphImageLtd.Dock = System.Windows.Forms.DockStyle.Right;
            this.graphImageLtd.Location = new System.Drawing.Point(563, 0);
            this.graphImageLtd.Name = "graphImageLtd";
            this.graphImageLtd.Size = new System.Drawing.Size(496, 476);
            this.graphImageLtd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.graphImageLtd.TabIndex = 12;
            this.graphImageLtd.TabStop = false;
            // 
            // changeStrategy
            // 
            this.changeStrategy.FormattingEnabled = true;
            this.changeStrategy.Location = new System.Drawing.Point(519, 31);
            this.changeStrategy.Name = "changeStrategy";
            this.changeStrategy.Size = new System.Drawing.Size(121, 21);
            this.changeStrategy.TabIndex = 13;
            this.changeStrategy.TextChanged += new System.EventHandler(this.changeStrategy_SelectedIndexChanged);
            // 
            // saveTable
            // 
            this.saveTable.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.saveTable.Location = new System.Drawing.Point(12, 355);
            this.saveTable.Name = "saveTable";
            this.saveTable.Size = new System.Drawing.Size(133, 53);
            this.saveTable.TabIndex = 14;
            this.saveTable.Text = "Cохранить таблицу";
            this.saveTable.UseVisualStyleBackColor = true;
            this.saveTable.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadTable
            // 
            this.loadTable.Enabled = false;
            this.loadTable.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.loadTable.Location = new System.Drawing.Point(12, 414);
            this.loadTable.Name = "loadTable";
            this.loadTable.Size = new System.Drawing.Size(133, 50);
            this.loadTable.TabIndex = 15;
            this.loadTable.Text = "Загрузить таблицу";
            this.loadTable.UseVisualStyleBackColor = true;
            this.loadTable.Click += new System.EventHandler(this.button2_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.exit.Location = new System.Drawing.Point(966, 433);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 31);
            this.exit.TabIndex = 16;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(190, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Матрица переходных вероятностей:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(235, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Матрица доходностей:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(449, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Выбор стратегии графа состояния:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(802, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Граф состояний:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 476);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.loadTable);
            this.Controls.Add(this.saveTable);
            this.Controls.Add(this.changeStrategy);
            this.Controls.Add(this.graphImageLtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updatetable);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.stepCount);
            this.Controls.Add(this.stateCount);
            this.Controls.Add(this.strategyCount);
            this.Controls.Add(this.valueMatrix);
            this.Controls.Add(this.propabilityMatrix);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.strategyCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphImageLtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl propabilityMatrix;
        private System.Windows.Forms.TabControl valueMatrix;
        private System.Windows.Forms.NumericUpDown strategyCount;
        private System.Windows.Forms.NumericUpDown stateCount;
        private System.Windows.Forms.NumericUpDown stepCount;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button updatetable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox graphImageLtd;
        private System.Windows.Forms.ComboBox changeStrategy;
        private System.Windows.Forms.Button saveTable;
        private System.Windows.Forms.Button loadTable;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

