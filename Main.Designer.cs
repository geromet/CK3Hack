namespace CK3Hack
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectGameFolderButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddNewFileButton = new System.Windows.Forms.Button();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.searchStringTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectGameFolderButton
            // 
            this.SelectGameFolderButton.AutoSize = true;
            this.SelectGameFolderButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.SelectGameFolderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelectGameFolderButton.FlatAppearance.BorderSize = 0;
            this.SelectGameFolderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.SelectGameFolderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.SelectGameFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectGameFolderButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectGameFolderButton.Location = new System.Drawing.Point(0, 0);
            this.SelectGameFolderButton.Name = "SelectGameFolderButton";
            this.SelectGameFolderButton.Size = new System.Drawing.Size(573, 30);
            this.SelectGameFolderButton.TabIndex = 1;
            this.SelectGameFolderButton.Text = "Select game folder";
            this.SelectGameFolderButton.UseVisualStyleBackColor = false;
            this.SelectGameFolderButton.Click += new System.EventHandler(this.SelectGameFolderButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.AutoSize = true;
            this.RunButton.BackColor = System.Drawing.Color.DeepPink;
            this.RunButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RunButton.FlatAppearance.BorderSize = 0;
            this.RunButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.RunButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.RunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RunButton.Location = new System.Drawing.Point(0, 30);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(573, 30);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.OutputBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 248);
            this.panel1.TabIndex = 3;
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.MediumPurple;
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputBox.Location = new System.Drawing.Point(0, 0);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(573, 174);
            this.OutputBox.TabIndex = 1;
            this.OutputBox.Text = "";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel2.Controls.Add(this.AddNewFileButton);
            this.panel2.Controls.Add(this.LocationTextBox);
            this.panel2.Controls.Add(this.searchStringTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 74);
            this.panel2.TabIndex = 0;
            // 
            // AddNewFileButton
            // 
            this.AddNewFileButton.AutoSize = true;
            this.AddNewFileButton.BackColor = System.Drawing.Color.DeepPink;
            this.AddNewFileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddNewFileButton.FlatAppearance.BorderSize = 0;
            this.AddNewFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.AddNewFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddNewFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewFileButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewFileButton.Location = new System.Drawing.Point(0, 44);
            this.AddNewFileButton.Name = "AddNewFileButton";
            this.AddNewFileButton.Size = new System.Drawing.Size(573, 30);
            this.AddNewFileButton.TabIndex = 3;
            this.AddNewFileButton.Text = "Add new file";
            this.AddNewFileButton.UseVisualStyleBackColor = false;
            this.AddNewFileButton.Click += new System.EventHandler(this.AddNewFileButton_Click);
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.BackColor = System.Drawing.Color.Thistle;
            this.LocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LocationTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocationTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LocationTextBox.ForeColor = System.Drawing.Color.Black;
            this.LocationTextBox.Location = new System.Drawing.Point(0, 22);
            this.LocationTextBox.MaxLength = 100;
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.PlaceholderText = "Location";
            this.LocationTextBox.Size = new System.Drawing.Size(573, 22);
            this.LocationTextBox.TabIndex = 1;
            // 
            // searchStringTextBox
            // 
            this.searchStringTextBox.BackColor = System.Drawing.Color.Thistle;
            this.searchStringTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchStringTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchStringTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchStringTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchStringTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchStringTextBox.Location = new System.Drawing.Point(0, 0);
            this.searchStringTextBox.MaxLength = 100;
            this.searchStringTextBox.Name = "searchStringTextBox";
            this.searchStringTextBox.PlaceholderText = "SearchString";
            this.searchStringTextBox.Size = new System.Drawing.Size(573, 22);
            this.searchStringTextBox.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(573, 308);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.SelectGameFolderButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CK3Hack";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button SelectGameFolderButton;
        private Button RunButton;
        private FolderBrowserDialog folderBrowserDialog;
        private Panel panel1;
        private Panel panel2;
        private Button AddNewFileButton;
        private TextBox LocationTextBox;
        private TextBox searchStringTextBox;
        private RichTextBox OutputBox;
    }
}