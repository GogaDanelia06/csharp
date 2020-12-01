namespace ConsoleApp3
{
    partial class Form2
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
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.First_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Minit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Last = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Jobid = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.NumericUpDown();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.pubid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Level)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(98, 8);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(216, 20);
            this.txtfirst.TabIndex = 0;
            // 
            // First_Name
            // 
            this.First_Name.AutoSize = true;
            this.First_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_Name.Location = new System.Drawing.Point(12, 9);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(80, 17);
            this.First_Name.TabIndex = 1;
            this.First_Name.Text = "First_Name";
            this.First_Name.Click += new System.EventHandler(this.First_Name_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minit";
            // 
            // Minit
            // 
            this.Minit.Location = new System.Drawing.Point(98, 43);
            this.Minit.Name = "Minit";
            this.Minit.Size = new System.Drawing.Size(216, 20);
            this.Minit.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last_Name";
            // 
            // Last
            // 
            this.Last.Location = new System.Drawing.Point(98, 79);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(216, 20);
            this.Last.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Job_Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Job_Level";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Jobid
            // 
            this.Jobid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Jobid.FormattingEnabled = true;
            this.Jobid.Location = new System.Drawing.Point(98, 117);
            this.Jobid.MaxDropDownItems = 15;
            this.Jobid.Name = "Jobid";
            this.Jobid.Size = new System.Drawing.Size(216, 21);
            this.Jobid.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pub_Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hire Date";
            // 
            // Level
            // 
            this.Level.Location = new System.Drawing.Point(98, 154);
            this.Level.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(216, 20);
            this.Level.TabIndex = 15;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(98, 232);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(216, 20);
            this.Date.TabIndex = 16;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(98, 272);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(216, 42);
            this.save.TabIndex = 17;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // pubid
            // 
            this.pubid.Location = new System.Drawing.Point(98, 194);
            this.pubid.Name = "pubid";
            this.pubid.Size = new System.Drawing.Size(216, 20);
            this.pubid.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 337);
            this.Controls.Add(this.pubid);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Jobid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Last);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minit);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.txtfirst);
            this.Name = "Form2";
            this.Text = "Add New Employee";
            ((System.ComponentModel.ISupportInitialize)(this.Level)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.Label First_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Minit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Last;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Jobid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Level;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox pubid;
    }
}