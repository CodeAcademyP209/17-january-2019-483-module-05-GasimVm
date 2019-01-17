namespace MyCompany
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
            this.data = new System.Windows.Forms.DataGridView();
            this.btnMaawOrta = new System.Windows.Forms.Button();
            this.btnEnCoxIwci = new System.Windows.Forms.Button();
            this.btnMaasOrtaBoyuk = new System.Windows.Forms.Button();
            this.btnSaatCox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIsciElave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(12, 12);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(600, 263);
            this.data.TabIndex = 0;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.data.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellValueChanged);
            // 
            // btnMaawOrta
            // 
            this.btnMaawOrta.Location = new System.Drawing.Point(778, 63);
            this.btnMaawOrta.Name = "btnMaawOrta";
            this.btnMaawOrta.Size = new System.Drawing.Size(167, 44);
            this.btnMaawOrta.TabIndex = 1;
            this.btnMaawOrta.Text = "maaw ortalamasini goster";
            this.btnMaawOrta.UseVisualStyleBackColor = true;
            this.btnMaawOrta.Click += new System.EventHandler(this.btnMaawOrta_Click);
            // 
            // btnEnCoxIwci
            // 
            this.btnEnCoxIwci.Location = new System.Drawing.Point(778, 113);
            this.btnEnCoxIwci.Name = "btnEnCoxIwci";
            this.btnEnCoxIwci.Size = new System.Drawing.Size(167, 44);
            this.btnEnCoxIwci.TabIndex = 2;
            this.btnEnCoxIwci.Text = "en cox isliyen isci";
            this.btnEnCoxIwci.UseVisualStyleBackColor = true;
            this.btnEnCoxIwci.Click += new System.EventHandler(this.btnEnCoxIwci_Click);
            // 
            // btnMaasOrtaBoyuk
            // 
            this.btnMaasOrtaBoyuk.Location = new System.Drawing.Point(778, 163);
            this.btnMaasOrtaBoyuk.Name = "btnMaasOrtaBoyuk";
            this.btnMaasOrtaBoyuk.Size = new System.Drawing.Size(167, 39);
            this.btnMaasOrtaBoyuk.TabIndex = 3;
            this.btnMaasOrtaBoyuk.Text = "Maasi ortalama maasdan boyuk olan isciler";
            this.btnMaasOrtaBoyuk.UseVisualStyleBackColor = true;
            this.btnMaasOrtaBoyuk.Click += new System.EventHandler(this.btnMaasOrtaBoyuk_Click);
            // 
            // btnSaatCox
            // 
            this.btnSaatCox.Location = new System.Drawing.Point(778, 208);
            this.btnSaatCox.Name = "btnSaatCox";
            this.btnSaatCox.Size = new System.Drawing.Size(167, 37);
            this.btnSaatCox.TabIndex = 4;
            this.btnSaatCox.Text = "heftelik iwleme saati 30 dan cox olanlar";
            this.btnSaatCox.UseVisualStyleBackColor = true;
            this.btnSaatCox.Click += new System.EventHandler(this.btnSaatCox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Iscilerin siyahisini goster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIsciElave
            // 
            this.btnIsciElave.Location = new System.Drawing.Point(619, 12);
            this.btnIsciElave.Name = "btnIsciElave";
            this.btnIsciElave.Size = new System.Drawing.Size(139, 45);
            this.btnIsciElave.TabIndex = 6;
            this.btnIsciElave.Text = "Add";
            this.btnIsciElave.UseVisualStyleBackColor = true;
            this.btnIsciElave.Click += new System.EventHandler(this.btnIsciElave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 410);
            this.Controls.Add(this.btnIsciElave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaatCox);
            this.Controls.Add(this.btnMaasOrtaBoyuk);
            this.Controls.Add(this.btnEnCoxIwci);
            this.Controls.Add(this.btnMaawOrta);
            this.Controls.Add(this.data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btnMaawOrta;
        private System.Windows.Forms.Button btnEnCoxIwci;
        private System.Windows.Forms.Button btnMaasOrtaBoyuk;
        private System.Windows.Forms.Button btnSaatCox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIsciElave;
    }
}

