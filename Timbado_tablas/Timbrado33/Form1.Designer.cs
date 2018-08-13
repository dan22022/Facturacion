namespace Timbrado33
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.txtFechaTimbrado = new System.Windows.Forms.TextBox();
            this.txtPDF = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "UUID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha Timbrado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(484, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "URL PDF:";
            // 
            // txtUUID
            // 
            this.txtUUID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUUID.Location = new System.Drawing.Point(528, 505);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.Size = new System.Drawing.Size(374, 20);
            this.txtUUID.TabIndex = 12;
            // 
            // txtFechaTimbrado
            // 
            this.txtFechaTimbrado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFechaTimbrado.Location = new System.Drawing.Point(587, 542);
            this.txtFechaTimbrado.Name = "txtFechaTimbrado";
            this.txtFechaTimbrado.Size = new System.Drawing.Size(315, 20);
            this.txtFechaTimbrado.TabIndex = 13;
            // 
            // txtPDF
            // 
            this.txtPDF.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPDF.Location = new System.Drawing.Point(543, 580);
            this.txtPDF.Name = "txtPDF";
            this.txtPDF.Size = new System.Drawing.Size(359, 20);
            this.txtPDF.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(321, 196);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPDF);
            this.Controls.Add(this.txtFechaTimbrado);
            this.Controls.Add(this.txtUUID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Timbrado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUUID;
        private System.Windows.Forms.TextBox txtFechaTimbrado;
        private System.Windows.Forms.TextBox txtPDF;
        private System.Windows.Forms.Button button1;
    }
}

