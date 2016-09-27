namespace onequestionquiz
{
    partial class frmOneQuestionQuiz
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.grbRadioBottons = new System.Windows.Forms.GroupBox();
            this.rdoDemiLovato = new System.Windows.Forms.RadioButton();
            this.rdoTaylorSwift = new System.Windows.Forms.RadioButton();
            this.rdoSelenaQomez = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.grbRadioBottons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(128, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "who is my favorite singer?";
            // 
            // grbRadioBottons
            // 
            this.grbRadioBottons.Controls.Add(this.rdoDemiLovato);
            this.grbRadioBottons.Controls.Add(this.rdoTaylorSwift);
            this.grbRadioBottons.Controls.Add(this.rdoSelenaQomez);
            this.grbRadioBottons.Location = new System.Drawing.Point(60, 146);
            this.grbRadioBottons.Name = "grbRadioBottons";
            this.grbRadioBottons.Size = new System.Drawing.Size(200, 100);
            this.grbRadioBottons.TabIndex = 1;
            this.grbRadioBottons.TabStop = false;
            // 
            // rdoDemiLovato
            // 
            this.rdoDemiLovato.AutoSize = true;
            this.rdoDemiLovato.Location = new System.Drawing.Point(6, 66);
            this.rdoDemiLovato.Name = "rdoDemiLovato";
            this.rdoDemiLovato.Size = new System.Drawing.Size(85, 17);
            this.rdoDemiLovato.TabIndex = 2;
            this.rdoDemiLovato.TabStop = true;
            this.rdoDemiLovato.Text = "Demi Lovato";
            this.rdoDemiLovato.UseVisualStyleBackColor = true;
            this.rdoDemiLovato.CheckedChanged += new System.EventHandler(this.rdoDemi_CheckedChanged);
            // 
            // rdoTaylorSwift
            // 
            this.rdoTaylorSwift.AutoSize = true;
            this.rdoTaylorSwift.Location = new System.Drawing.Point(6, 43);
            this.rdoTaylorSwift.Name = "rdoTaylorSwift";
            this.rdoTaylorSwift.Size = new System.Drawing.Size(80, 17);
            this.rdoTaylorSwift.TabIndex = 1;
            this.rdoTaylorSwift.TabStop = true;
            this.rdoTaylorSwift.Text = "Taylor Swift";
            this.rdoTaylorSwift.UseVisualStyleBackColor = true;
            this.rdoTaylorSwift.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoSelenaQomez
            // 
            this.rdoSelenaQomez.AutoSize = true;
            this.rdoSelenaQomez.Location = new System.Drawing.Point(6, 19);
            this.rdoSelenaQomez.Name = "rdoSelenaQomez";
            this.rdoSelenaQomez.Size = new System.Drawing.Size(94, 17);
            this.rdoSelenaQomez.TabIndex = 0;
            this.rdoSelenaQomez.TabStop = true;
            this.rdoSelenaQomez.Text = "Selena Gomez";
            this.rdoSelenaQomez.UseVisualStyleBackColor = true;
            this.rdoSelenaQomez.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(60, 266);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // frmOneQuestionQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 376);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.grbRadioBottons);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmOneQuestionQuiz";
            this.Text = "One Question Quiz";
            this.grbRadioBottons.ResumeLayout(false);
            this.grbRadioBottons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox grbRadioBottons;
        private System.Windows.Forms.RadioButton rdoDemiLovato;
        private System.Windows.Forms.RadioButton rdoTaylorSwift;
        private System.Windows.Forms.RadioButton rdoSelenaQomez;
        private System.Windows.Forms.Label lblResult;
    }
}

