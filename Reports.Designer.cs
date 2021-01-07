
namespace Test
{
    partial class Reports
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
            this.btnTrainingNeeded = new System.Windows.Forms.Button();
            this.btnTrainingCompleted = new System.Windows.Forms.Button();
            this.btnTrainingHours = new System.Windows.Forms.Button();
            this.btnTrainingCodes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrainingNeeded
            // 
            this.btnTrainingNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainingNeeded.Location = new System.Drawing.Point(160, 56);
            this.btnTrainingNeeded.Name = "btnTrainingNeeded";
            this.btnTrainingNeeded.Size = new System.Drawing.Size(192, 56);
            this.btnTrainingNeeded.TabIndex = 0;
            this.btnTrainingNeeded.Text = "Training Needed";
            this.btnTrainingNeeded.UseVisualStyleBackColor = true;
            // 
            // btnTrainingCompleted
            // 
            this.btnTrainingCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainingCompleted.Location = new System.Drawing.Point(160, 128);
            this.btnTrainingCompleted.Name = "btnTrainingCompleted";
            this.btnTrainingCompleted.Size = new System.Drawing.Size(192, 56);
            this.btnTrainingCompleted.TabIndex = 1;
            this.btnTrainingCompleted.Text = "Training Completed";
            this.btnTrainingCompleted.UseVisualStyleBackColor = true;
            // 
            // btnTrainingHours
            // 
            this.btnTrainingHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainingHours.Location = new System.Drawing.Point(160, 200);
            this.btnTrainingHours.Name = "btnTrainingHours";
            this.btnTrainingHours.Size = new System.Drawing.Size(192, 56);
            this.btnTrainingHours.TabIndex = 2;
            this.btnTrainingHours.Text = "Training Hours";
            this.btnTrainingHours.UseVisualStyleBackColor = true;
            // 
            // btnTrainingCodes
            // 
            this.btnTrainingCodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainingCodes.Location = new System.Drawing.Point(160, 272);
            this.btnTrainingCodes.Name = "btnTrainingCodes";
            this.btnTrainingCodes.Size = new System.Drawing.Size(192, 56);
            this.btnTrainingCodes.TabIndex = 3;
            this.btnTrainingCodes.Text = "Training Codes";
            this.btnTrainingCodes.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 387);
            this.Controls.Add(this.btnTrainingCodes);
            this.Controls.Add(this.btnTrainingHours);
            this.Controls.Add(this.btnTrainingCompleted);
            this.Controls.Add(this.btnTrainingNeeded);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrainingNeeded;
        private System.Windows.Forms.Button btnTrainingCompleted;
        private System.Windows.Forms.Button btnTrainingHours;
        private System.Windows.Forms.Button btnTrainingCodes;
    }
}