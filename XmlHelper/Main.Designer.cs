namespace XmlHelper
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.countDownTextBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.scrollerTextBox = new System.Windows.Forms.TextBox();
            this.upTimeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // countDownTextBox
            // 
            this.countDownTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countDownTextBox.Enabled = false;
            this.countDownTextBox.Location = new System.Drawing.Point(12, 117);
            this.countDownTextBox.Name = "countDownTextBox";
            this.countDownTextBox.Size = new System.Drawing.Size(238, 20);
            this.countDownTextBox.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startTimeTextBox.Enabled = false;
            this.startTimeTextBox.Location = new System.Drawing.Point(12, 10);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(116, 20);
            this.startTimeTextBox.TabIndex = 3;
            // 
            // scrollerTextBox
            // 
            this.scrollerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scrollerTextBox.Location = new System.Drawing.Point(12, 36);
            this.scrollerTextBox.Multiline = true;
            this.scrollerTextBox.Name = "scrollerTextBox";
            this.scrollerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.scrollerTextBox.Size = new System.Drawing.Size(238, 75);
            this.scrollerTextBox.TabIndex = 4;
            this.scrollerTextBox.Text = resources.GetString("scrollerTextBox.Text");
            // 
            // upTimeTextBox
            // 
            this.upTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upTimeTextBox.Enabled = false;
            this.upTimeTextBox.Location = new System.Drawing.Point(134, 10);
            this.upTimeTextBox.Name = "upTimeTextBox";
            this.upTimeTextBox.Size = new System.Drawing.Size(116, 20);
            this.upTimeTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 149);
            this.Controls.Add(this.upTimeTextBox);
            this.Controls.Add(this.scrollerTextBox);
            this.Controls.Add(this.startTimeTextBox);
            this.Controls.Add(this.countDownTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "In Progress";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox countDownTextBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox scrollerTextBox;
        private System.Windows.Forms.TextBox upTimeTextBox;
    }
}

