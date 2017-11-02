namespace Stock
{
     partial class Products
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
               this.ProductCode_TextBox = new System.Windows.Forms.TextBox();
               this.ProductName_TextBox = new System.Windows.Forms.TextBox();
               this.Status_ComboBox = new System.Windows.Forms.ComboBox();
               this.Delete_Button = new System.Windows.Forms.Button();
               this.Add_Button = new System.Windows.Forms.Button();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.UpdateButton = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(60, 29);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(72, 13);
               this.label1.TabIndex = 0;
               this.label1.Text = "Product Code";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(177, 29);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(75, 13);
               this.label2.TabIndex = 1;
               this.label2.Text = "Product Name";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(298, 29);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(37, 13);
               this.label3.TabIndex = 2;
               this.label3.Text = "Status";
               // 
               // ProductCode_TextBox
               // 
               this.ProductCode_TextBox.Location = new System.Drawing.Point(63, 55);
               this.ProductCode_TextBox.Name = "ProductCode_TextBox";
               this.ProductCode_TextBox.Size = new System.Drawing.Size(100, 20);
               this.ProductCode_TextBox.TabIndex = 3;
               // 
               // ProductName_TextBox
               // 
               this.ProductName_TextBox.Location = new System.Drawing.Point(180, 55);
               this.ProductName_TextBox.Name = "ProductName_TextBox";
               this.ProductName_TextBox.Size = new System.Drawing.Size(100, 20);
               this.ProductName_TextBox.TabIndex = 4;
               // 
               // Status_ComboBox
               // 
               this.Status_ComboBox.FormattingEnabled = true;
               this.Status_ComboBox.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
               this.Status_ComboBox.Location = new System.Drawing.Point(301, 53);
               this.Status_ComboBox.Name = "Status_ComboBox";
               this.Status_ComboBox.Size = new System.Drawing.Size(121, 21);
               this.Status_ComboBox.TabIndex = 5;
               // 
               // Delete_Button
               // 
               this.Delete_Button.Location = new System.Drawing.Point(455, 55);
               this.Delete_Button.Name = "Delete_Button";
               this.Delete_Button.Size = new System.Drawing.Size(75, 23);
               this.Delete_Button.TabIndex = 6;
               this.Delete_Button.Text = "Delete";
               this.Delete_Button.UseVisualStyleBackColor = true;
               this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
               // 
               // Add_Button
               // 
               this.Add_Button.Location = new System.Drawing.Point(563, 55);
               this.Add_Button.Name = "Add_Button";
               this.Add_Button.Size = new System.Drawing.Size(75, 23);
               this.Add_Button.TabIndex = 7;
               this.Add_Button.Text = "Add";
               this.Add_Button.UseVisualStyleBackColor = true;
               this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
               // 
               // dataGridView1
               // 
               this.dataGridView1.AllowUserToAddRows = false;
               this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
               this.dataGridView1.Location = new System.Drawing.Point(12, 84);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dataGridView1.Size = new System.Drawing.Size(838, 361);
               this.dataGridView1.TabIndex = 8;
               this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
               // 
               // Column1
               // 
               this.Column1.HeaderText = "Product Code";
               this.Column1.Name = "Column1";
               // 
               // Column2
               // 
               this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.Column2.HeaderText = "Product Name";
               this.Column2.Name = "Column2";
               // 
               // Column3
               // 
               this.Column3.HeaderText = "Status";
               this.Column3.Name = "Column3";
               // 
               // UpdateButton
               // 
               this.UpdateButton.Location = new System.Drawing.Point(662, 54);
               this.UpdateButton.Name = "UpdateButton";
               this.UpdateButton.Size = new System.Drawing.Size(75, 23);
               this.UpdateButton.TabIndex = 9;
               this.UpdateButton.Text = "Update";
               this.UpdateButton.UseVisualStyleBackColor = true;
               this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
               // 
               // Products
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(862, 445);
               this.Controls.Add(this.UpdateButton);
               this.Controls.Add(this.dataGridView1);
               this.Controls.Add(this.Add_Button);
               this.Controls.Add(this.Delete_Button);
               this.Controls.Add(this.Status_ComboBox);
               this.Controls.Add(this.ProductName_TextBox);
               this.Controls.Add(this.ProductCode_TextBox);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Name = "Products";
               this.Text = "Products";
               this.Load += new System.EventHandler(this.Products_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox ProductCode_TextBox;
          private System.Windows.Forms.TextBox ProductName_TextBox;
          private System.Windows.Forms.ComboBox Status_ComboBox;
          private System.Windows.Forms.Button Delete_Button;
          private System.Windows.Forms.Button Add_Button;
          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
          private System.Windows.Forms.Button UpdateButton;
     }
}