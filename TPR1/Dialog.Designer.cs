namespace TPR1
{
    partial class Dialog
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
            this.data = new System.Windows.Forms.DataGridView();
            this.graphMaker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(0, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(439, 380);
            this.data.TabIndex = 0;
            // 
            // graphMaker
            // 
            this.graphMaker.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.graphMaker.Location = new System.Drawing.Point(250, 336);
            this.graphMaker.Name = "graphMaker";
            this.graphMaker.Size = new System.Drawing.Size(177, 23);
            this.graphMaker.TabIndex = 1;
            this.graphMaker.Text = "Результирующий граф";
            this.graphMaker.UseVisualStyleBackColor = true;
            this.graphMaker.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 380);
            this.Controls.Add(this.graphMaker);
            this.Controls.Add(this.data);
            this.Name = "Dialog";
            this.Text = "Результаты";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button graphMaker;
    }
}