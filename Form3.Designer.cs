namespace CRUD_Linq_To_Sql
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.INSERTbutton = new System.Windows.Forms.Button();
            this.GENDERtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AGEtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CLASStextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NAMEtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 298);
            this.dataGridView1.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(426, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 36);
            this.button2.TabIndex = 21;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // INSERTbutton
            // 
            this.INSERTbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSERTbutton.Location = new System.Drawing.Point(273, 176);
            this.INSERTbutton.Name = "INSERTbutton";
            this.INSERTbutton.Size = new System.Drawing.Size(118, 36);
            this.INSERTbutton.TabIndex = 18;
            this.INSERTbutton.Text = "INSERT";
            this.INSERTbutton.UseVisualStyleBackColor = true;
            this.INSERTbutton.Click += new System.EventHandler(this.INSERTbutton_Click);
            // 
            // GENDERtextBox
            // 
            this.GENDERtextBox.Location = new System.Drawing.Point(309, 76);
            this.GENDERtextBox.Name = "GENDERtextBox";
            this.GENDERtextBox.Size = new System.Drawing.Size(288, 22);
            this.GENDERtextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "GENDER";
            // 
            // AGEtextBox
            // 
            this.AGEtextBox.Location = new System.Drawing.Point(309, 110);
            this.AGEtextBox.Name = "AGEtextBox";
            this.AGEtextBox.Size = new System.Drawing.Size(288, 22);
            this.AGEtextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "AGE";
            // 
            // CLASStextBox
            // 
            this.CLASStextBox.Location = new System.Drawing.Point(309, 148);
            this.CLASStextBox.Name = "CLASStextBox";
            this.CLASStextBox.Size = new System.Drawing.Size(288, 22);
            this.CLASStextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "CLASS";
            // 
            // NAMEtextBox
            // 
            this.NAMEtextBox.Location = new System.Drawing.Point(309, 41);
            this.NAMEtextBox.Name = "NAMEtextBox";
            this.NAMEtextBox.Size = new System.Drawing.Size(288, 22);
            this.NAMEtextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 38);
            this.label1.TabIndex = 26;
            this.label1.Text = "STUDENT DETAILS";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 528);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.INSERTbutton);
            this.Controls.Add(this.GENDERtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AGEtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CLASStextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NAMEtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button INSERTbutton;
        private System.Windows.Forms.TextBox GENDERtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AGEtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CLASStextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NAMEtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}