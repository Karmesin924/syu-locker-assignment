namespace syu_locker_assignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ReservationFormButton = new System.Windows.Forms.Button();
            this.ReturnFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReservationFormButton
            // 
            this.ReservationFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ReservationFormButton.Font = new System.Drawing.Font("나눔바른고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReservationFormButton.Location = new System.Drawing.Point(260, 663);
            this.ReservationFormButton.Name = "ReservationFormButton";
            this.ReservationFormButton.Size = new System.Drawing.Size(321, 93);
            this.ReservationFormButton.TabIndex = 0;
            this.ReservationFormButton.Text = "예약하기";
            this.ReservationFormButton.UseVisualStyleBackColor = false;
            // 
            // ReturnFormButton
            // 
            this.ReturnFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ReturnFormButton.Font = new System.Drawing.Font("나눔바른고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReturnFormButton.Location = new System.Drawing.Point(625, 663);
            this.ReturnFormButton.Name = "ReturnFormButton";
            this.ReturnFormButton.Size = new System.Drawing.Size(330, 93);
            this.ReturnFormButton.TabIndex = 1;
            this.ReturnFormButton.Text = "반납하기";
            this.ReturnFormButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1201, 901);
            this.Controls.Add(this.ReturnFormButton);
            this.Controls.Add(this.ReservationFormButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Locker Assignment";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ReservationFormButton;
        private Button ReturnFormButton;
    }
}