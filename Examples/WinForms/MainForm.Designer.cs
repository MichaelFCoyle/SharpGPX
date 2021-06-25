
namespace WinForms
{
    partial class MainForm
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
            this.myOpenButton = new System.Windows.Forms.Button();
            this.mySaveButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.myCreateButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myOpenButton
            // 
            this.myOpenButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.myOpenButton.Location = new System.Drawing.Point(12, 12);
            this.myOpenButton.Name = "myOpenButton";
            this.myOpenButton.Size = new System.Drawing.Size(75, 23);
            this.myOpenButton.TabIndex = 0;
            this.myOpenButton.Text = "Open";
            this.myOpenButton.UseVisualStyleBackColor = true;
            this.myOpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // mySaveButton
            // 
            this.mySaveButton.Location = new System.Drawing.Point(12, 41);
            this.mySaveButton.Name = "mySaveButton";
            this.mySaveButton.Size = new System.Drawing.Size(75, 23);
            this.mySaveButton.TabIndex = 1;
            this.mySaveButton.Text = "Save";
            this.mySaveButton.UseVisualStyleBackColor = true;
            this.mySaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.myCreateButton);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.mySaveButton);
            this.splitContainer1.Panel1.Controls.Add(this.myOpenButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PropertyGrid);
            this.splitContainer1.Size = new System.Drawing.Size(484, 341);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.TabIndex = 2;
            // 
            // myCreateButton
            // 
            this.myCreateButton.Location = new System.Drawing.Point(12, 70);
            this.myCreateButton.Name = "myCreateButton";
            this.myCreateButton.Size = new System.Drawing.Size(75, 23);
            this.myCreateButton.TabIndex = 3;
            this.myCreateButton.Text = "Create";
            this.myCreateButton.UseVisualStyleBackColor = true;
            this.myCreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(93, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 2;
            // 
            // PropertyGrid
            // 
            this.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.PropertyGrid.Name = "PropertyGrid";
            this.PropertyGrid.Size = new System.Drawing.Size(238, 341);
            this.PropertyGrid.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "SharpGPX Test";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button myOpenButton;
        private System.Windows.Forms.Button mySaveButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PropertyGrid PropertyGrid;
        private System.Windows.Forms.Button myCreateButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

