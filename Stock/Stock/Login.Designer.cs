namespace Stock
{
     partial class Login
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
               this.UserName_TextBox = new System.Windows.Forms.TextBox();
               this.Password_TextBox = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.Clear_Button = new System.Windows.Forms.Button();
               this.Login_Button = new System.Windows.Forms.Button();
               this.linkLabel1 = new System.Windows.Forms.LinkLabel();
               this.Register_Button = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // UserName_TextBox
               // 
               this.UserName_TextBox.Location = new System.Drawing.Point(131, 53);
               this.UserName_TextBox.Name = "UserName_TextBox";
               this.UserName_TextBox.Size = new System.Drawing.Size(231, 20);
               this.UserName_TextBox.TabIndex = 0;
               // 
               // Password_TextBox
               // 
               this.Password_TextBox.Location = new System.Drawing.Point(131, 95);
               this.Password_TextBox.Name = "Password_TextBox";
               this.Password_TextBox.Size = new System.Drawing.Size(231, 20);
               this.Password_TextBox.TabIndex = 1;
               this.Password_TextBox.UseSystemPasswordChar = true;
               this.Password_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_TextBox_KeyDown);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(42, 60);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(66, 13);
               this.label1.TabIndex = 2;
               this.label1.Text = "User Name :";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(49, 102);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(59, 13);
               this.label2.TabIndex = 3;
               this.label2.Text = "Password :";
               // 
               // Clear_Button
               // 
               this.Clear_Button.Location = new System.Drawing.Point(45, 145);
               this.Clear_Button.Name = "Clear_Button";
               this.Clear_Button.Size = new System.Drawing.Size(96, 23);
               this.Clear_Button.TabIndex = 4;
               this.Clear_Button.Text = "Clear";
               this.Clear_Button.UseVisualStyleBackColor = true;
               this.Clear_Button.Click += new System.EventHandler(this.ClearButton_Click);
               // 
               // Login_Button
               // 
               this.Login_Button.Location = new System.Drawing.Point(180, 145);
               this.Login_Button.Name = "Login_Button";
               this.Login_Button.Size = new System.Drawing.Size(96, 23);
               this.Login_Button.TabIndex = 5;
               this.Login_Button.Text = "Login";
               this.Login_Button.UseVisualStyleBackColor = true;
               this.Login_Button.Click += new System.EventHandler(this.LoginButton_Click);
               // 
               // linkLabel1
               // 
               this.linkLabel1.AutoSize = true;
               this.linkLabel1.Location = new System.Drawing.Point(270, 118);
               this.linkLabel1.Name = "linkLabel1";
               this.linkLabel1.Size = new System.Drawing.Size(92, 13);
               this.linkLabel1.TabIndex = 6;
               this.linkLabel1.TabStop = true;
               this.linkLabel1.Text = "Forgot Password?";
               // 
               // Register_Button
               // 
               this.Register_Button.Location = new System.Drawing.Point(316, 145);
               this.Register_Button.Name = "Register_Button";
               this.Register_Button.Size = new System.Drawing.Size(75, 23);
               this.Register_Button.TabIndex = 7;
               this.Register_Button.Text = "Register";
               this.Register_Button.UseVisualStyleBackColor = true;
               this.Register_Button.Click += new System.EventHandler(this.Register_Button_Click);
               // 
               // Login
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(448, 198);
               this.Controls.Add(this.Register_Button);
               this.Controls.Add(this.linkLabel1);
               this.Controls.Add(this.Login_Button);
               this.Controls.Add(this.Clear_Button);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.Password_TextBox);
               this.Controls.Add(this.UserName_TextBox);
               this.MaximizeBox = false;
               this.Name = "Login";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Login";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox UserName_TextBox;
          private System.Windows.Forms.TextBox Password_TextBox;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Button Clear_Button;
          private System.Windows.Forms.Button Login_Button;
          private System.Windows.Forms.LinkLabel linkLabel1;
          private System.Windows.Forms.Button Register_Button;
     }
}