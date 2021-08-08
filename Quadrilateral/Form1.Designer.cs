namespace Quadrilateral
{
    partial class lblCalculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblCalculate));
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnNextSide = new System.Windows.Forms.Button();
            this.lblSide = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblKey1 = new System.Windows.Forms.Label();
            this.lblKey2 = new System.Windows.Forms.Label();
            this.lblkey3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtValue.Location = new System.Drawing.Point(58, 171);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(159, 26);
            this.txtValue.TabIndex = 0;
            // 
            // btnNextSide
            // 
            this.btnNextSide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNextSide.Location = new System.Drawing.Point(58, 292);
            this.btnNextSide.Name = "btnNextSide";
            this.btnNextSide.Size = new System.Drawing.Size(159, 59);
            this.btnNextSide.TabIndex = 2;
            this.btnNextSide.Text = "Next";
            this.btnNextSide.UseVisualStyleBackColor = true;
            this.btnNextSide.Click += new System.EventHandler(this.NextSide_Click);
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.BackColor = System.Drawing.Color.Red;
            this.lblSide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSide.Location = new System.Drawing.Point(79, 79);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(78, 20);
            this.lblSide.TabIndex = 3;
            this.lblSide.Text = "Click Next";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(468, 292);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(170, 59);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Visible = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.BackColor = System.Drawing.Color.Red;
            this.lblNext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNext.Location = new System.Drawing.Point(54, 383);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(216, 20);
            this.lblNext.TabIndex = 6;
            this.lblNext.Text = "Click to enter next Side/Angle";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Red;
            this.lblResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResult.Location = new System.Drawing.Point(500, 79);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 20);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result:";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtResult.Location = new System.Drawing.Point(457, 171);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(181, 26);
            this.txtResult.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Red;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(77, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(587, 32);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Welcome to Samir\'s Quadrilateral Recognizer";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(273, 292);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 59);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.BackColor = System.Drawing.Color.Red;
            this.lblTip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTip.Location = new System.Drawing.Point(241, 115);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(204, 20);
            this.lblTip.TabIndex = 11;
            this.lblTip.Text = "Tip: Side1 is opposite Side3";
            // 
            // lblKey1
            // 
            this.lblKey1.AutoSize = true;
            this.lblKey1.BackColor = System.Drawing.Color.Red;
            this.lblKey1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKey1.Location = new System.Drawing.Point(109, 264);
            this.lblKey1.Name = "lblKey1";
            this.lblKey1.Size = new System.Drawing.Size(48, 20);
            this.lblKey1.TabIndex = 12;
            this.lblKey1.Text = "Enter";
            // 
            // lblKey2
            // 
            this.lblKey2.AutoSize = true;
            this.lblKey2.BackColor = System.Drawing.Color.Red;
            this.lblKey2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKey2.Location = new System.Drawing.Point(309, 264);
            this.lblKey2.Name = "lblKey2";
            this.lblKey2.Size = new System.Drawing.Size(50, 20);
            this.lblKey2.TabIndex = 13;
            this.lblKey2.Text = "B Key";
            // 
            // lblkey3
            // 
            this.lblkey3.AutoSize = true;
            this.lblkey3.BackColor = System.Drawing.Color.Red;
            this.lblkey3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblkey3.Location = new System.Drawing.Point(526, 264);
            this.lblkey3.Name = "lblkey3";
            this.lblkey3.Size = new System.Drawing.Size(42, 20);
            this.lblkey3.TabIndex = 14;
            this.lblkey3.Text = "Shift";
            // 
            // lblCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 420);
            this.Controls.Add(this.lblkey3);
            this.Controls.Add(this.lblKey2);
            this.Controls.Add(this.lblKey1);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.btnNextSide);
            this.Controls.Add(this.txtValue);
            this.KeyPreview = true;
            this.Name = "lblCalculate";
            this.Text = "Quadrilateral";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblCalculate_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnNextSide;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblKey1;
        private System.Windows.Forms.Label lblKey2;
        private System.Windows.Forms.Label lblkey3;
    }
}

