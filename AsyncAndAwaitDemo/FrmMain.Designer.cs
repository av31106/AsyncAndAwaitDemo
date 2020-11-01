namespace AsyncAndAwaitDemo
{
    partial class FrmMain
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
            this.rboxText1 = new System.Windows.Forms.RichTextBox();
            this.btnSyncStart = new System.Windows.Forms.Button();
            this.btnAsyncStart = new System.Windows.Forms.Button();
            this.btnPellAsyncStart = new System.Windows.Forms.Button();
            this.btnParallel1AsyncStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rboxText1
            // 
            this.rboxText1.Location = new System.Drawing.Point(12, 12);
            this.rboxText1.Name = "rboxText1";
            this.rboxText1.Size = new System.Drawing.Size(523, 406);
            this.rboxText1.TabIndex = 0;
            this.rboxText1.Text = "";
            // 
            // btnSyncStart
            // 
            this.btnSyncStart.Location = new System.Drawing.Point(542, 13);
            this.btnSyncStart.Name = "btnSyncStart";
            this.btnSyncStart.Size = new System.Drawing.Size(100, 23);
            this.btnSyncStart.TabIndex = 1;
            this.btnSyncStart.Text = "Sync Start";
            this.btnSyncStart.UseVisualStyleBackColor = true;
            this.btnSyncStart.Click += new System.EventHandler(this.btnSyncStart_Click);
            // 
            // btnAsyncStart
            // 
            this.btnAsyncStart.Location = new System.Drawing.Point(542, 52);
            this.btnAsyncStart.Name = "btnAsyncStart";
            this.btnAsyncStart.Size = new System.Drawing.Size(100, 23);
            this.btnAsyncStart.TabIndex = 1;
            this.btnAsyncStart.Text = "Async Start";
            this.btnAsyncStart.UseVisualStyleBackColor = true;
            this.btnAsyncStart.Click += new System.EventHandler(this.btnAsyncStart_Click);
            // 
            // btnPellAsyncStart
            // 
            this.btnPellAsyncStart.Location = new System.Drawing.Point(542, 92);
            this.btnPellAsyncStart.Name = "btnPellAsyncStart";
            this.btnPellAsyncStart.Size = new System.Drawing.Size(100, 35);
            this.btnPellAsyncStart.TabIndex = 2;
            this.btnPellAsyncStart.Text = "Parallel Async Start";
            this.btnPellAsyncStart.UseVisualStyleBackColor = true;
            this.btnPellAsyncStart.Click += new System.EventHandler(this.btnPellAsyncStart_Click);
            // 
            // btnParallel1AsyncStart
            // 
            this.btnParallel1AsyncStart.Location = new System.Drawing.Point(542, 143);
            this.btnParallel1AsyncStart.Name = "btnParallel1AsyncStart";
            this.btnParallel1AsyncStart.Size = new System.Drawing.Size(100, 35);
            this.btnParallel1AsyncStart.TabIndex = 3;
            this.btnParallel1AsyncStart.Text = "Parallel 1 Async Start";
            this.btnParallel1AsyncStart.UseVisualStyleBackColor = true;
            this.btnParallel1AsyncStart.Click += new System.EventHandler(this.btnParallel1AsyncStart_Click);
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(654, 430);
            this.Controls.Add(this.btnParallel1AsyncStart);
            this.Controls.Add(this.btnPellAsyncStart);
            this.Controls.Add(this.btnAsyncStart);
            this.Controls.Add(this.btnSyncStart);
            this.Controls.Add(this.rboxText1);
            this.Name = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rboxText;
        private System.Windows.Forms.Button btnNormalStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rboxText1;
        private System.Windows.Forms.Button btnSyncStart;
        private System.Windows.Forms.Button btnAsyncStart;
        private System.Windows.Forms.Button btnPellAsyncStart;
        private System.Windows.Forms.Button btnParallel1AsyncStart;
    }
}

