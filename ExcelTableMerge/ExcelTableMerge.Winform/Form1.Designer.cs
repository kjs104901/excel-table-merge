namespace ExcelTableMerge.Winform
{
    partial class Form1
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
            reoGridControl1 = new unvell.ReoGrid.ReoGridControl();
            button1 = new Button();
            SuspendLayout();
            // 
            // reoGridControl1
            // 
            reoGridControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reoGridControl1.BackColor = Color.FromArgb(255, 255, 255);
            reoGridControl1.ColumnHeaderContextMenuStrip = null;
            reoGridControl1.LeadHeaderContextMenuStrip = null;
            reoGridControl1.Location = new Point(12, 41);
            reoGridControl1.Name = "reoGridControl1";
            reoGridControl1.RowHeaderContextMenuStrip = null;
            reoGridControl1.Script = null;
            reoGridControl1.SheetTabContextMenuStrip = null;
            reoGridControl1.SheetTabNewButtonVisible = true;
            reoGridControl1.SheetTabVisible = true;
            reoGridControl1.SheetTabWidth = 60;
            reoGridControl1.ShowScrollEndSpacing = true;
            reoGridControl1.Size = new Size(776, 397);
            reoGridControl1.TabIndex = 0;
            reoGridControl1.Text = "reoGridControl1";
            // 
            // button1
            // 
            button1.Location = new Point(713, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(reoGridControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private unvell.ReoGrid.ReoGridControl reoGridControl1;
        private Button button1;
    }
}
