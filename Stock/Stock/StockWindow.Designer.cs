namespace Stock
{
     partial class StockWindow
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
               this.components = new System.ComponentModel.Container();
               this.toolTip = new System.Windows.Forms.ToolTip(this.components);
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.Quantity_Button = new System.Windows.Forms.Button();
               this.Quantity_TextBox = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.ProductCode_TextBox = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.RefreshButton = new System.Windows.Forms.Button();
               this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.TransDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.SuspendLayout();
               // 
               // dataGridView1
               // 
               this.dataGridView1.AllowUserToAddRows = false;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductName,
            this.TransDate,
            this.Quantity});
               this.dataGridView1.Location = new System.Drawing.Point(13, 80);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dataGridView1.Size = new System.Drawing.Size(607, 361);
               this.dataGridView1.TabIndex = 4;
               this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
               // 
               // Quantity_Button
               // 
               this.Quantity_Button.Location = new System.Drawing.Point(523, 50);
               this.Quantity_Button.Name = "Quantity_Button";
               this.Quantity_Button.Size = new System.Drawing.Size(75, 21);
               this.Quantity_Button.TabIndex = 5;
               this.Quantity_Button.Text = "Update ";
               this.Quantity_Button.UseVisualStyleBackColor = true;
               this.Quantity_Button.Click += new System.EventHandler(this.Quantity_Button_Click);
               // 
               // Quantity_TextBox
               // 
               this.Quantity_TextBox.Location = new System.Drawing.Point(412, 50);
               this.Quantity_TextBox.Name = "Quantity_TextBox";
               this.Quantity_TextBox.Size = new System.Drawing.Size(105, 20);
               this.Quantity_TextBox.TabIndex = 6;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(414, 31);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(56, 16);
               this.label1.TabIndex = 7;
               this.label1.Text = "Quantity";
               // 
               // ProductCode_TextBox
               // 
               this.ProductCode_TextBox.Location = new System.Drawing.Point(293, 51);
               this.ProductCode_TextBox.Name = "ProductCode_TextBox";
               this.ProductCode_TextBox.Size = new System.Drawing.Size(105, 20);
               this.ProductCode_TextBox.TabIndex = 9;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(295, 32);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(90, 16);
               this.label2.TabIndex = 10;
               this.label2.Text = "Product Code";
               // 
               // RefreshButton
               // 
               this.RefreshButton.Location = new System.Drawing.Point(203, 51);
               this.RefreshButton.Name = "RefreshButton";
               this.RefreshButton.Size = new System.Drawing.Size(75, 20);
               this.RefreshButton.TabIndex = 12;
               this.RefreshButton.Text = "Refresh";
               this.RefreshButton.UseVisualStyleBackColor = true;
               this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
               // 
               // ProductCode
               // 
               this.ProductCode.HeaderText = "ProductCode";
               this.ProductCode.Name = "ProductCode";
               // 
               // ProductName
               // 
               this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.ProductName.HeaderText = "ProductName";
               this.ProductName.Name = "ProductName";
               // 
               // TransDate
               // 
               this.TransDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.TransDate.HeaderText = "TransDate";
               this.TransDate.Name = "TransDate";
               // 
               // Quantity
               // 
               this.Quantity.HeaderText = "Quantity";
               this.Quantity.Name = "Quantity";
               // 
               // StockWindow
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.Control;
               this.ClientSize = new System.Drawing.Size(632, 453);
               this.Controls.Add(this.RefreshButton);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.ProductCode_TextBox);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.Quantity_TextBox);
               this.Controls.Add(this.Quantity_Button);
               this.Controls.Add(this.dataGridView1);
               this.ForeColor = System.Drawing.SystemColors.ControlText;
               this.IsMdiContainer = true;
               this.Name = "StockWindow";
               this.Text = "StockWindow";
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }
          #endregion
          private System.Windows.Forms.ToolTip toolTip;
          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.Button Quantity_Button;
          private System.Windows.Forms.TextBox Quantity_TextBox;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox ProductCode_TextBox;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Button RefreshButton;
          private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
          private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
          private System.Windows.Forms.DataGridViewTextBoxColumn TransDate;
          private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
     }
}



