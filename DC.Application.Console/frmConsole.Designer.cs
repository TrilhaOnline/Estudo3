namespace DC.Application.Console
{
    partial class frmConsole
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtCodeIn = new System.Windows.Forms.TextBox();
            this.txtRepeatCodeIn = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreateToken = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMessageCreateUser = new System.Windows.Forms.Label();
            this.lblMessageToken = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgUserData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUserData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir Senha:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(91, 19);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(172, 20);
            this.txtMail.TabIndex = 3;
            // 
            // txtCodeIn
            // 
            this.txtCodeIn.Location = new System.Drawing.Point(91, 43);
            this.txtCodeIn.Name = "txtCodeIn";
            this.txtCodeIn.PasswordChar = '*';
            this.txtCodeIn.Size = new System.Drawing.Size(172, 20);
            this.txtCodeIn.TabIndex = 4;
            // 
            // txtRepeatCodeIn
            // 
            this.txtRepeatCodeIn.Location = new System.Drawing.Point(91, 67);
            this.txtRepeatCodeIn.Name = "txtRepeatCodeIn";
            this.txtRepeatCodeIn.PasswordChar = '*';
            this.txtRepeatCodeIn.Size = new System.Drawing.Size(172, 20);
            this.txtRepeatCodeIn.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.Location = new System.Drawing.Point(269, 19);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(81, 94);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(91, 93);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(172, 20);
            this.txtNickName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nickname:";
            // 
            // btnCreateToken
            // 
            this.btnCreateToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreateToken.Location = new System.Drawing.Point(329, 19);
            this.btnCreateToken.Name = "btnCreateToken";
            this.btnCreateToken.Size = new System.Drawing.Size(82, 94);
            this.btnCreateToken.TabIndex = 9;
            this.btnCreateToken.Text = "Gerar Token";
            this.btnCreateToken.UseVisualStyleBackColor = false;
            this.btnCreateToken.Click += new System.EventHandler(this.btnCreateToken_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(56, 19);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(267, 94);
            this.txtToken.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Token:";
            // 
            // lblMessageCreateUser
            // 
            this.lblMessageCreateUser.AutoSize = true;
            this.lblMessageCreateUser.ForeColor = System.Drawing.Color.Red;
            this.lblMessageCreateUser.Location = new System.Drawing.Point(88, 130);
            this.lblMessageCreateUser.Name = "lblMessageCreateUser";
            this.lblMessageCreateUser.Size = new System.Drawing.Size(0, 13);
            this.lblMessageCreateUser.TabIndex = 12;
            // 
            // lblMessageToken
            // 
            this.lblMessageToken.AutoSize = true;
            this.lblMessageToken.ForeColor = System.Drawing.Color.Red;
            this.lblMessageToken.Location = new System.Drawing.Point(53, 130);
            this.lblMessageToken.Name = "lblMessageToken";
            this.lblMessageToken.Size = new System.Drawing.Size(0, 13);
            this.lblMessageToken.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMessageCreateUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodeIn);
            this.groupBox1.Controls.Add(this.txtRepeatCodeIn);
            this.groupBox1.Controls.Add(this.txtNickName);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 163);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Api de Cadastro de Usuário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtToken);
            this.groupBox2.Controls.Add(this.lblMessageToken);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnCreateToken);
            this.groupBox2.Location = new System.Drawing.Point(384, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 163);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Api de Geração de Token";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgUserData);
            this.groupBox3.Location = new System.Drawing.Point(13, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(799, 151);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do Usuário para Recuperação do Token";
            // 
            // dtgUserData
            // 
            this.dtgUserData.AllowUserToAddRows = false;
            this.dtgUserData.AllowUserToDeleteRows = false;
            this.dtgUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUserData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgUserData.Location = new System.Drawing.Point(3, 16);
            this.dtgUserData.Name = "dtgUserData";
            this.dtgUserData.ReadOnly = true;
            this.dtgUserData.Size = new System.Drawing.Size(793, 132);
            this.dtgUserData.TabIndex = 0;
            // 
            // frmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 348);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Acesso | Geração de Token";
            this.Load += new System.EventHandler(this.frmConsole_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUserData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtCodeIn;
        private System.Windows.Forms.TextBox txtRepeatCodeIn;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreateToken;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMessageCreateUser;
        private System.Windows.Forms.Label lblMessageToken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgUserData;
    }
}