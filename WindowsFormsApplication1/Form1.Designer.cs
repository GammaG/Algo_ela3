namespace WindowsFormsApplication1
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
            this.button1_Demo = new System.Windows.Forms.Button();
            this.dataGridViewMen = new System.Windows.Forms.DataGridView();
            this.dataGridViewWomen = new System.Windows.Forms.DataGridView();
            this.button_FindStable = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWomen)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_Demo
            // 
            this.button1_Demo.Location = new System.Drawing.Point(253, 428);
            this.button1_Demo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1_Demo.Name = "button1_Demo";
            this.button1_Demo.Size = new System.Drawing.Size(249, 57);
            this.button1_Demo.TabIndex = 0;
            this.button1_Demo.Text = "Load Demo";
            this.button1_Demo.UseVisualStyleBackColor = true;
            this.button1_Demo.Click += new System.EventHandler(this.button1_Demo_Click);
            // 
            // dataGridViewMen
            // 
            this.dataGridViewMen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMen.Location = new System.Drawing.Point(18, 20);
            this.dataGridViewMen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewMen.Name = "dataGridViewMen";
            this.dataGridViewMen.Size = new System.Drawing.Size(484, 258);
            this.dataGridViewMen.TabIndex = 3;
            // 
            // dataGridViewWomen
            // 
            this.dataGridViewWomen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewWomen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewWomen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWomen.Location = new System.Drawing.Point(510, 20);
            this.dataGridViewWomen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewWomen.Name = "dataGridViewWomen";
            this.dataGridViewWomen.Size = new System.Drawing.Size(480, 258);
            this.dataGridViewWomen.TabIndex = 4;
            // 
            // button_FindStable
            // 
            this.button_FindStable.Location = new System.Drawing.Point(510, 428);
            this.button_FindStable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_FindStable.Name = "button_FindStable";
            this.button_FindStable.Size = new System.Drawing.Size(480, 57);
            this.button_FindStable.TabIndex = 5;
            this.button_FindStable.Text = "Find Stable Matches";
            this.button_FindStable.UseVisualStyleBackColor = true;
            this.button_FindStable.Click += new System.EventHandler(this.button_FindStable_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(18, 428);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(227, 54);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // textBox_Output
            // 
            this.textBox_Output.Location = new System.Drawing.Point(18, 288);
            this.textBox_Output.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Output.Multiline = true;
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Output.Size = new System.Drawing.Size(972, 129);
            this.textBox_Output.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 505);
            this.Controls.Add(this.textBox_Output);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_FindStable);
            this.Controls.Add(this.dataGridViewWomen);
            this.Controls.Add(this.dataGridViewMen);
            this.Controls.Add(this.button1_Demo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Stable Matching";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWomen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Demo;
        private System.Windows.Forms.DataGridView dataGridViewMen;
        private System.Windows.Forms.DataGridView dataGridViewWomen;
        private System.Windows.Forms.Button button_FindStable;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.TextBox textBox_Output;
    }
}

