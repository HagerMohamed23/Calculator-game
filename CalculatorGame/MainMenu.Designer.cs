namespace CalculatorGame
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_bttn = new System.Windows.Forms.Button();
            this.Exit_bttn = new System.Windows.Forms.Button();
            this.names_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.names_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hall of fame";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(281, 281);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(234, 20);
            this.name_textbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Name";
            // 
            // name_bttn
            // 
            this.name_bttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_bttn.Location = new System.Drawing.Point(304, 320);
            this.name_bttn.Name = "name_bttn";
            this.name_bttn.Size = new System.Drawing.Size(133, 37);
            this.name_bttn.TabIndex = 4;
            this.name_bttn.Text = "Start";
            this.name_bttn.UseVisualStyleBackColor = true;
            this.name_bttn.Click += new System.EventHandler(this.name_bttn_Click);
            // 
            // Exit_bttn
            // 
            this.Exit_bttn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_bttn.Location = new System.Drawing.Point(304, 363);
            this.Exit_bttn.Name = "Exit_bttn";
            this.Exit_bttn.Size = new System.Drawing.Size(133, 37);
            this.Exit_bttn.TabIndex = 5;
            this.Exit_bttn.Text = "Exit";
            this.Exit_bttn.UseVisualStyleBackColor = true;
            this.Exit_bttn.Click += new System.EventHandler(this.Exit_bttn_Click);
            // 
            // names_dataGridView1
            // 
            this.names_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.names_dataGridView1.Location = new System.Drawing.Point(219, 83);
            this.names_dataGridView1.Name = "names_dataGridView1";
            this.names_dataGridView1.ReadOnly = true;
            this.names_dataGridView1.Size = new System.Drawing.Size(296, 165);
            this.names_dataGridView1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.Location = new System.Drawing.Point(290, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numbers Game";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.names_dataGridView1);
            this.Controls.Add(this.Exit_bttn);
            this.Controls.Add(this.name_bttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.names_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button name_bttn;
        private System.Windows.Forms.Button Exit_bttn;
        private System.Windows.Forms.DataGridView names_dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}