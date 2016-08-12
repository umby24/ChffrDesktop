namespace Standalone_Dashboard {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblCommaPoints = new System.Windows.Forms.Label();
            this.lstRoutes = new System.Windows.Forms.ListBox();
            this.lblRoutes = new System.Windows.Forms.Label();
            this.panelHolder = new System.Windows.Forms.Panel();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCommaPoints
            // 
            this.lblCommaPoints.AutoSize = true;
            this.lblCommaPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommaPoints.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCommaPoints.Location = new System.Drawing.Point(12, 5);
            this.lblCommaPoints.Name = "lblCommaPoints";
            this.lblCommaPoints.Size = new System.Drawing.Size(157, 25);
            this.lblCommaPoints.TabIndex = 0;
            this.lblCommaPoints.Text = "Comma Points:";
            // 
            // lstRoutes
            // 
            this.lstRoutes.FormattingEnabled = true;
            this.lstRoutes.Location = new System.Drawing.Point(12, 47);
            this.lstRoutes.Name = "lstRoutes";
            this.lstRoutes.Size = new System.Drawing.Size(175, 303);
            this.lstRoutes.TabIndex = 1;
            this.lstRoutes.SelectedIndexChanged += new System.EventHandler(this.lstRoutes_SelectedIndexChanged);
            // 
            // lblRoutes
            // 
            this.lblRoutes.AutoSize = true;
            this.lblRoutes.Location = new System.Drawing.Point(12, 31);
            this.lblRoutes.Name = "lblRoutes";
            this.lblRoutes.Size = new System.Drawing.Size(44, 13);
            this.lblRoutes.TabIndex = 2;
            this.lblRoutes.Text = "Routes:";
            // 
            // panelHolder
            // 
            this.panelHolder.Controls.Add(this.lblLength);
            this.panelHolder.Location = new System.Drawing.Point(193, 47);
            this.panelHolder.Name = "panelHolder";
            this.panelHolder.Size = new System.Drawing.Size(400, 302);
            this.panelHolder.TabIndex = 3;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(15, 17);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(35, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "label1";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(294, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(55, 13);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome,";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(518, 9);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 361);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panelHolder);
            this.Controls.Add(this.lblRoutes);
            this.Controls.Add(this.lstRoutes);
            this.Controls.Add(this.lblCommaPoints);
            this.Name = "mainForm";
            this.Text = "Chffr Dashboard";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelHolder.ResumeLayout(false);
            this.panelHolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCommaPoints;
        private System.Windows.Forms.ListBox lstRoutes;
        private System.Windows.Forms.Label lblRoutes;
        private System.Windows.Forms.Panel panelHolder;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogOut;
    }
}

