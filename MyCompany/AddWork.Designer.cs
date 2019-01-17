namespace MyCompany
{
    partial class AddWork
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtGelme = new System.Windows.Forms.TextBox();
            this.txtCixma = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGelme = new System.Windows.Forms.Label();
            this.lblGetme = new System.Windows.Forms.Label();
            this.btnYaddaSaxla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(118, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(130, 69);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(118, 20);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtGelme
            // 
            this.txtGelme.Location = new System.Drawing.Point(130, 146);
            this.txtGelme.Name = "txtGelme";
            this.txtGelme.Size = new System.Drawing.Size(118, 20);
            this.txtGelme.TabIndex = 3;
            this.txtGelme.TextChanged += new System.EventHandler(this.txtGelme_TextChanged);
            // 
            // txtCixma
            // 
            this.txtCixma.Location = new System.Drawing.Point(129, 185);
            this.txtCixma.Name = "txtCixma";
            this.txtCixma.Size = new System.Drawing.Size(118, 20);
            this.txtCixma.TabIndex = 4;
            this.txtCixma.TextChanged += new System.EventHandler(this.txtGetme_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(62, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(20, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Ad";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(62, 72);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(37, 13);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Soyad";
            this.lblSurname.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(62, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblGelme
            // 
            this.lblGelme.AutoSize = true;
            this.lblGelme.Location = new System.Drawing.Point(62, 153);
            this.lblGelme.Name = "lblGelme";
            this.lblGelme.Size = new System.Drawing.Size(62, 13);
            this.lblGelme.TabIndex = 8;
            this.lblGelme.Text = "Gelme vaxti";
            // 
            // lblGetme
            // 
            this.lblGetme.AutoSize = true;
            this.lblGetme.Location = new System.Drawing.Point(62, 188);
            this.lblGetme.Name = "lblGetme";
            this.lblGetme.Size = new System.Drawing.Size(61, 13);
            this.lblGetme.TabIndex = 9;
            this.lblGetme.Text = "Getme vaxt";
            // 
            // btnYaddaSaxla
            // 
            this.btnYaddaSaxla.Location = new System.Drawing.Point(251, 234);
            this.btnYaddaSaxla.Name = "btnYaddaSaxla";
            this.btnYaddaSaxla.Size = new System.Drawing.Size(125, 23);
            this.btnYaddaSaxla.TabIndex = 10;
            this.btnYaddaSaxla.Text = "Yadda saxla";
            this.btnYaddaSaxla.UseVisualStyleBackColor = true;
            this.btnYaddaSaxla.Click += new System.EventHandler(this.btnYaddaSaxla_Click);
            // 
            // AddWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 314);
            this.Controls.Add(this.btnYaddaSaxla);
            this.Controls.Add(this.lblGetme);
            this.Controls.Add(this.lblGelme);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtCixma);
            this.Controls.Add(this.txtGelme);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Name = "AddWork";
            this.Text = "AddWork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtGelme;
        private System.Windows.Forms.TextBox txtCixma;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGelme;
        private System.Windows.Forms.Label lblGetme;
        private System.Windows.Forms.Button btnYaddaSaxla;
    }
}