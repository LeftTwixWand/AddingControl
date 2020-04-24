namespace AddingControl
{
    partial class MyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelColumn1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelColumn4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelColumn3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelColumn2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.labelColumn1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 508);
            this.panel1.TabIndex = 0;
            // 
            // labelColumn1
            // 
            this.labelColumn1.BackColor = System.Drawing.Color.Moccasin;
            this.labelColumn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelColumn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumn1.Location = new System.Drawing.Point(0, 0);
            this.labelColumn1.Name = "labelColumn1";
            this.labelColumn1.Size = new System.Drawing.Size(180, 26);
            this.labelColumn1.TabIndex = 0;
            this.labelColumn1.Text = "Column name";
            this.labelColumn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SandyBrown;
            this.panelHeader.Controls.Add(this.buttonClose);
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(720, 30);
            this.panelHeader.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClose.Location = new System.Drawing.Point(690, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(115, 30);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Header text";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(720, 508);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.BurlyWood;
            this.panel4.Controls.Add(this.labelColumn4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(540, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 508);
            this.panel4.TabIndex = 3;
            // 
            // labelColumn4
            // 
            this.labelColumn4.BackColor = System.Drawing.Color.DarkSalmon;
            this.labelColumn4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelColumn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumn4.Location = new System.Drawing.Point(0, 0);
            this.labelColumn4.Name = "labelColumn4";
            this.labelColumn4.Size = new System.Drawing.Size(180, 26);
            this.labelColumn4.TabIndex = 1;
            this.labelColumn4.Text = "Column name";
            this.labelColumn4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel3.Controls.Add(this.labelColumn3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(360, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 508);
            this.panel3.TabIndex = 2;
            // 
            // labelColumn3
            // 
            this.labelColumn3.BackColor = System.Drawing.Color.Orange;
            this.labelColumn3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelColumn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumn3.Location = new System.Drawing.Point(0, 0);
            this.labelColumn3.Name = "labelColumn3";
            this.labelColumn3.Size = new System.Drawing.Size(180, 26);
            this.labelColumn3.TabIndex = 1;
            this.labelColumn3.Text = "Column name";
            this.labelColumn3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel2.Controls.Add(this.labelColumn2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 508);
            this.panel2.TabIndex = 1;
            // 
            // labelColumn2
            // 
            this.labelColumn2.BackColor = System.Drawing.Color.PeachPuff;
            this.labelColumn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelColumn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColumn2.Location = new System.Drawing.Point(0, 0);
            this.labelColumn2.Name = "labelColumn2";
            this.labelColumn2.Size = new System.Drawing.Size(180, 26);
            this.labelColumn2.TabIndex = 1;
            this.labelColumn2.Text = "Column name";
            this.labelColumn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panelHeader);
            this.Name = "MyControl";
            this.Size = new System.Drawing.Size(720, 538);
            this.panel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelColumn1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelColumn4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelColumn3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelColumn2;
    }
}
