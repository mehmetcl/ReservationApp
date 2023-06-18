namespace ReservationManagement
{
    partial class SysManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysManagement));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher3 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher4 = new System.IO.FileSystemWatcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClosedManagement = new System.Windows.Forms.Button();
            this.pnlTableSatate = new System.Windows.Forms.Panel();
            this.pbxTitle = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTableState = new System.Windows.Forms.Panel();
            this.btnTableState = new System.Windows.Forms.Button();
            this.pnlReservationList = new System.Windows.Forms.Panel();
            this.btnReservationList = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher4)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlTableState.SuspendLayout();
            this.pnlReservationList.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // fileSystemWatcher3
            // 
            this.fileSystemWatcher3.EnableRaisingEvents = true;
            this.fileSystemWatcher3.SynchronizingObject = this;
            // 
            // fileSystemWatcher4
            // 
            this.fileSystemWatcher4.EnableRaisingEvents = true;
            this.fileSystemWatcher4.SynchronizingObject = this;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(96)))), ((int)(((byte)(189)))));
            this.pnlTop.Controls.Add(this.btnClosedManagement);
            this.pnlTop.Controls.Add(this.pnlTableSatate);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(875, 45);
            this.pnlTop.TabIndex = 0;
            // 
            // btnClosedManagement
            // 
            this.btnClosedManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosedManagement.FlatAppearance.BorderSize = 0;
            this.btnClosedManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosedManagement.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClosedManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(65)))), ((int)(((byte)(14)))));
            this.btnClosedManagement.Location = new System.Drawing.Point(828, 0);
            this.btnClosedManagement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClosedManagement.Name = "btnClosedManagement";
            this.btnClosedManagement.Size = new System.Drawing.Size(47, 46);
            this.btnClosedManagement.TabIndex = 5;
            this.btnClosedManagement.Text = "X";
            this.btnClosedManagement.UseVisualStyleBackColor = true;
            this.btnClosedManagement.Click += new System.EventHandler(this.btnClosedManagement_Click);
            // 
            // pnlTableSatate
            // 
            this.pnlTableSatate.Location = new System.Drawing.Point(585, 45);
            this.pnlTableSatate.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTableSatate.Name = "pnlTableSatate";
            this.pnlTableSatate.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTableSatate.Size = new System.Drawing.Size(290, 100);
            this.pnlTableSatate.TabIndex = 6;
            // 
            // pbxTitle
            // 
            this.pbxTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.pbxTitle.Image = ((System.Drawing.Image)(resources.GetObject("pbxTitle.Image")));
            this.pbxTitle.Location = new System.Drawing.Point(0, 0);
            this.pbxTitle.Name = "pbxTitle";
            this.pbxTitle.Size = new System.Drawing.Size(54, 45);
            this.pbxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTitle.TabIndex = 4;
            this.pbxTitle.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pnlTableState, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlReservationList, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 100);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // pnlTableState
            // 
            this.pnlTableState.Controls.Add(this.btnTableState);
            this.pnlTableState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableState.Location = new System.Drawing.Point(442, 5);
            this.pnlTableState.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTableState.Name = "pnlTableState";
            this.pnlTableState.Size = new System.Drawing.Size(428, 90);
            this.pnlTableState.TabIndex = 11;
            // 
            // btnTableState
            // 
            this.btnTableState.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTableState.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTableState.FlatAppearance.BorderSize = 0;
            this.btnTableState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTableState.ForeColor = System.Drawing.Color.White;
            this.btnTableState.Image = ((System.Drawing.Image)(resources.GetObject("btnTableState.Image")));
            this.btnTableState.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTableState.Location = new System.Drawing.Point(0, 0);
            this.btnTableState.Margin = new System.Windows.Forms.Padding(0);
            this.btnTableState.Name = "btnTableState";
            this.btnTableState.Padding = new System.Windows.Forms.Padding(1);
            this.btnTableState.Size = new System.Drawing.Size(428, 79);
            this.btnTableState.TabIndex = 7;
            this.btnTableState.Text = "Table State";
            this.btnTableState.UseVisualStyleBackColor = false;
            this.btnTableState.Click += new System.EventHandler(this.Btn_Click);
            // 
            // pnlReservationList
            // 
            this.pnlReservationList.Controls.Add(this.btnReservationList);
            this.pnlReservationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReservationList.Location = new System.Drawing.Point(5, 5);
            this.pnlReservationList.Margin = new System.Windows.Forms.Padding(5);
            this.pnlReservationList.Name = "pnlReservationList";
            this.pnlReservationList.Size = new System.Drawing.Size(427, 90);
            this.pnlReservationList.TabIndex = 11;
            // 
            // btnReservationList
            // 
            this.btnReservationList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReservationList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservationList.FlatAppearance.BorderSize = 0;
            this.btnReservationList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReservationList.ForeColor = System.Drawing.Color.White;
            this.btnReservationList.Image = ((System.Drawing.Image)(resources.GetObject("btnReservationList.Image")));
            this.btnReservationList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservationList.Location = new System.Drawing.Point(0, 0);
            this.btnReservationList.Name = "btnReservationList";
            this.btnReservationList.Size = new System.Drawing.Size(427, 78);
            this.btnReservationList.TabIndex = 7;
            this.btnReservationList.Text = "Reservation List";
            this.btnReservationList.UseVisualStyleBackColor = false;
            this.btnReservationList.Click += new System.EventHandler(this.Btn_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 145);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(875, 467);
            this.pnlMain.TabIndex = 6;
          
            // 
            // SysManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 612);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pbxTitle);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SysManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysManagement";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher4)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlTableState.ResumeLayout(false);
            this.pnlReservationList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.IO.FileSystemWatcher fileSystemWatcher3;
        private System.IO.FileSystemWatcher fileSystemWatcher4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pbxTitle;
        private System.Windows.Forms.Button btnClosedManagement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTableState;
        private System.Windows.Forms.Panel pnlTableSatate;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnReservationList;
        private System.Windows.Forms.Panel pnlTableState;
        private System.Windows.Forms.Panel pnlReservationList;
    }
}