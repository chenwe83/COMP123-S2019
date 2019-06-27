namespace COMP123_S2019
{
    partial class Lab8
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
            this.namelable = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.agelable = new System.Windows.Forms.Label();
            this.agetextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.Outputlable = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lab8";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // namelable
            // 
            this.namelable.AutoSize = true;
            this.namelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelable.Location = new System.Drawing.Point(21, 29);
            this.namelable.Name = "namelable";
            this.namelable.Size = new System.Drawing.Size(168, 31);
            this.namelable.TabIndex = 0;
            this.namelable.Text = "Your Name:";
            this.namelable.Click += new System.EventHandler(this.label1_Click);
            // 
            // nametextbox
            // 
            this.nametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextbox.Location = new System.Drawing.Point(195, 29);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(279, 38);
            this.nametextbox.TabIndex = 1;
            // 
            // agelable
            // 
            this.agelable.AutoSize = true;
            this.agelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agelable.Location = new System.Drawing.Point(46, 81);
            this.agelable.Name = "agelable";
            this.agelable.Size = new System.Drawing.Size(143, 31);
            this.agelable.TabIndex = 0;
            this.agelable.Text = "Your Age:";
            this.agelable.Click += new System.EventHandler(this.label1_Click);
            // 
            // agetextbox
            // 
            this.agetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agetextbox.Location = new System.Drawing.Point(195, 81);
            this.agetextbox.Name = "agetextbox";
            this.agetextbox.Size = new System.Drawing.Size(279, 38);
            this.agetextbox.TabIndex = 1;
            this.agetextbox.TextChanged += new System.EventHandler(this.agetextbox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.namelable);
            this.groupBox1.Controls.Add(this.agetextbox);
            this.groupBox1.Controls.Add(this.agelable);
            this.groupBox1.Controls.Add(this.nametextbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(488, 353);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(124, 50);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Outputlable
            // 
            this.Outputlable.AutoSize = true;
            this.Outputlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outputlable.Location = new System.Drawing.Point(39, 363);
            this.Outputlable.Name = "Outputlable";
            this.Outputlable.Size = new System.Drawing.Size(0, 31);
            this.Outputlable.TabIndex = 0;
            this.Outputlable.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lab8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Outputlable);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Lab8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab8";
            this.Load += new System.EventHandler(this.Lab8_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namelable;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label agelable;
        private System.Windows.Forms.TextBox agetextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label Outputlable;
    }
}

