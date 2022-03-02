
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
            this.button1 = new System.Windows.Forms.Button();
            this.myCreateButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myOpenButton
            // 
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
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.myCreateButton);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.mySaveButton);
            this.splitContainer1.Panel1.Controls.Add(this.myOpenButton);
            this.splitContainer1.Panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.splitContainer1.Panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PropertyGrid);
            this.splitContainer1.Size = new System.Drawing.Size(697, 464);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.splitContainer1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "To String";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // myCreateButton
            // 
            this.myCreateButton.Location = new System.Drawing.Point(12, 99);
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
            this.PropertyGrid.AllowDrop = true;
            this.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.PropertyGrid.Name = "PropertyGrid";
            this.PropertyGrid.Size = new System.Drawing.Size(345, 464);
            this.PropertyGrid.TabIndex = 1;
            this.PropertyGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.PropertyGrid.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Hand Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.HandLoad_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 464);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "SharpGPX Test";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Panel_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel_DragEnter);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

