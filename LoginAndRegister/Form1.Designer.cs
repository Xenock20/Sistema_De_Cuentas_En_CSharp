namespace LoginAndRegister
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.homePanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.regisPanel = new System.Windows.Forms.Panel();
            this.inicioPanel = new System.Windows.Forms.Panel();
            this.loginButtom = new System.Windows.Forms.Button();
            this.regisButtom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassLogin = new System.Windows.Forms.TextBox();
            this.loginButtomTwo = new System.Windows.Forms.Button();
            this.returnOne = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUserRegis = new System.Windows.Forms.TextBox();
            this.textBoxPassRegis = new System.Windows.Forms.TextBox();
            this.textBoxPassRegisTwo = new System.Windows.Forms.TextBox();
            this.singUpButtom = new System.Windows.Forms.Button();
            this.returnTwo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mensajeLogin = new System.Windows.Forms.Label();
            this.mensajeRegis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.homePanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.regisPanel.SuspendLayout();
            this.inicioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Controls.Add(this.regisButtom);
            this.homePanel.Controls.Add(this.loginButtom);
            this.homePanel.Location = new System.Drawing.Point(13, 13);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(291, 216);
            this.homePanel.TabIndex = 0;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.label9);
            this.loginPanel.Controls.Add(this.label8);
            this.loginPanel.Controls.Add(this.mensajeLogin);
            this.loginPanel.Controls.Add(this.returnOne);
            this.loginPanel.Controls.Add(this.loginButtomTwo);
            this.loginPanel.Controls.Add(this.textBoxPassLogin);
            this.loginPanel.Controls.Add(this.textBoxUserLogin);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Location = new System.Drawing.Point(10, 10);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(291, 216);
            this.loginPanel.TabIndex = 1;
            this.loginPanel.Visible = false;
            // 
            // regisPanel
            // 
            this.regisPanel.Controls.Add(this.mensajeRegis);
            this.regisPanel.Controls.Add(this.label6);
            this.regisPanel.Controls.Add(this.label5);
            this.regisPanel.Controls.Add(this.label4);
            this.regisPanel.Controls.Add(this.returnTwo);
            this.regisPanel.Controls.Add(this.singUpButtom);
            this.regisPanel.Controls.Add(this.textBoxPassRegisTwo);
            this.regisPanel.Controls.Add(this.textBoxPassRegis);
            this.regisPanel.Controls.Add(this.textBoxUserRegis);
            this.regisPanel.Controls.Add(this.label3);
            this.regisPanel.Location = new System.Drawing.Point(10, 7);
            this.regisPanel.Name = "regisPanel";
            this.regisPanel.Size = new System.Drawing.Size(291, 216);
            this.regisPanel.TabIndex = 1;
            this.regisPanel.Visible = false;
            // 
            // inicioPanel
            // 
            this.inicioPanel.Controls.Add(this.button1);
            this.inicioPanel.Controls.Add(this.label7);
            this.inicioPanel.Location = new System.Drawing.Point(7, 10);
            this.inicioPanel.Name = "inicioPanel";
            this.inicioPanel.Size = new System.Drawing.Size(291, 216);
            this.inicioPanel.TabIndex = 1;
            this.inicioPanel.Visible = false;
            // 
            // loginButtom
            // 
            this.loginButtom.Location = new System.Drawing.Point(72, 84);
            this.loginButtom.Name = "loginButtom";
            this.loginButtom.Size = new System.Drawing.Size(150, 23);
            this.loginButtom.TabIndex = 0;
            this.loginButtom.Text = "Login";
            this.loginButtom.UseVisualStyleBackColor = true;
            this.loginButtom.Click += new System.EventHandler(this.loginButtom_Click);
            // 
            // regisButtom
            // 
            this.regisButtom.Location = new System.Drawing.Point(72, 124);
            this.regisButtom.Name = "regisButtom";
            this.regisButtom.Size = new System.Drawing.Size(150, 23);
            this.regisButtom.TabIndex = 1;
            this.regisButtom.Text = "Sign up";
            this.regisButtom.UseVisualStyleBackColor = true;
            this.regisButtom.Click += new System.EventHandler(this.regisButtom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Log in";
            // 
            // textBoxUserLogin
            // 
            this.textBoxUserLogin.Location = new System.Drawing.Point(39, 87);
            this.textBoxUserLogin.Name = "textBoxUserLogin";
            this.textBoxUserLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserLogin.TabIndex = 4;
            // 
            // textBoxPassLogin
            // 
            this.textBoxPassLogin.Location = new System.Drawing.Point(39, 127);
            this.textBoxPassLogin.Name = "textBoxPassLogin";
            this.textBoxPassLogin.PasswordChar = '*';
            this.textBoxPassLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassLogin.TabIndex = 5;
            // 
            // loginButtomTwo
            // 
            this.loginButtomTwo.Location = new System.Drawing.Point(175, 84);
            this.loginButtomTwo.Name = "loginButtomTwo";
            this.loginButtomTwo.Size = new System.Drawing.Size(75, 23);
            this.loginButtomTwo.TabIndex = 6;
            this.loginButtomTwo.Text = "Login";
            this.loginButtomTwo.UseVisualStyleBackColor = true;
            this.loginButtomTwo.Click += new System.EventHandler(this.loginButtomTwo_Click);
            // 
            // returnOne
            // 
            this.returnOne.Location = new System.Drawing.Point(175, 124);
            this.returnOne.Name = "returnOne";
            this.returnOne.Size = new System.Drawing.Size(75, 23);
            this.returnOne.TabIndex = 7;
            this.returnOne.Text = "Return";
            this.returnOne.UseVisualStyleBackColor = true;
            this.returnOne.Click += new System.EventHandler(this.returnOne_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sing up";
            // 
            // textBoxUserRegis
            // 
            this.textBoxUserRegis.Location = new System.Drawing.Point(19, 62);
            this.textBoxUserRegis.Name = "textBoxUserRegis";
            this.textBoxUserRegis.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserRegis.TabIndex = 5;
            // 
            // textBoxPassRegis
            // 
            this.textBoxPassRegis.Location = new System.Drawing.Point(19, 110);
            this.textBoxPassRegis.Name = "textBoxPassRegis";
            this.textBoxPassRegis.PasswordChar = '*';
            this.textBoxPassRegis.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassRegis.TabIndex = 6;
            // 
            // textBoxPassRegisTwo
            // 
            this.textBoxPassRegisTwo.Location = new System.Drawing.Point(19, 159);
            this.textBoxPassRegisTwo.Name = "textBoxPassRegisTwo";
            this.textBoxPassRegisTwo.PasswordChar = '*';
            this.textBoxPassRegisTwo.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassRegisTwo.TabIndex = 7;
            // 
            // singUpButtom
            // 
            this.singUpButtom.Location = new System.Drawing.Point(176, 86);
            this.singUpButtom.Name = "singUpButtom";
            this.singUpButtom.Size = new System.Drawing.Size(75, 23);
            this.singUpButtom.TabIndex = 8;
            this.singUpButtom.Text = "Sing up";
            this.singUpButtom.UseVisualStyleBackColor = true;
            this.singUpButtom.Click += new System.EventHandler(this.singUpButtom_Click);
            // 
            // returnTwo
            // 
            this.returnTwo.Location = new System.Drawing.Point(176, 136);
            this.returnTwo.Name = "returnTwo";
            this.returnTwo.Size = new System.Drawing.Size(75, 23);
            this.returnTwo.TabIndex = 8;
            this.returnTwo.Text = "Return";
            this.returnTwo.UseVisualStyleBackColor = true;
            this.returnTwo.Click += new System.EventHandler(this.returnTwo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "The same password";
            // 
            // mensajeLogin
            // 
            this.mensajeLogin.AutoSize = true;
            this.mensajeLogin.Location = new System.Drawing.Point(68, 179);
            this.mensajeLogin.Name = "mensajeLogin";
            this.mensajeLogin.Size = new System.Drawing.Size(0, 13);
            this.mensajeLogin.TabIndex = 8;
            // 
            // mensajeRegis
            // 
            this.mensajeRegis.AutoSize = true;
            this.mensajeRegis.Location = new System.Drawing.Point(44, 191);
            this.mensajeRegis.Name = "mensajeRegis";
            this.mensajeRegis.Size = new System.Drawing.Size(0, 13);
            this.mensajeRegis.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Iniciaste correctamente!!!!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "User";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sign off";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 235);
            this.Controls.Add(this.inicioPanel);
            this.Controls.Add(this.regisPanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.homePanel);
            this.Name = "Form1";
            this.Text = "Sistema de Cuentas";
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.regisPanel.ResumeLayout(false);
            this.regisPanel.PerformLayout();
            this.inicioPanel.ResumeLayout(false);
            this.inicioPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regisButtom;
        private System.Windows.Forms.Button loginButtom;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label mensajeLogin;
        private System.Windows.Forms.Button returnOne;
        private System.Windows.Forms.Button loginButtomTwo;
        private System.Windows.Forms.TextBox textBoxPassLogin;
        private System.Windows.Forms.TextBox textBoxUserLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel regisPanel;
        private System.Windows.Forms.Label mensajeRegis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button returnTwo;
        private System.Windows.Forms.Button singUpButtom;
        private System.Windows.Forms.TextBox textBoxPassRegisTwo;
        private System.Windows.Forms.TextBox textBoxPassRegis;
        private System.Windows.Forms.TextBox textBoxUserRegis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel inicioPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

