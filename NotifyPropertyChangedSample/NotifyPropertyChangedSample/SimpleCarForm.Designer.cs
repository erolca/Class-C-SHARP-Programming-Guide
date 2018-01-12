namespace NotifyPropertyChangedSample
{
    partial class SimpleCarForm
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
            this.btnInitiateCars = new System.Windows.Forms.Button();
            this.grvCars = new System.Windows.Forms.DataGridView();
            this.timerUpdateCurrentSpeeds = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInitiateCars
            // 
            this.btnInitiateCars.Location = new System.Drawing.Point(12, 12);
            this.btnInitiateCars.Name = "btnInitiateCars";
            this.btnInitiateCars.Size = new System.Drawing.Size(99, 23);
            this.btnInitiateCars.TabIndex = 0;
            this.btnInitiateCars.Text = "Initiate Cars";
            this.btnInitiateCars.UseVisualStyleBackColor = true;
            this.btnInitiateCars.Click += new System.EventHandler(this.btnInitiateCars_Click);
            // 
            // grvCars
            // 
            this.grvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCars.Location = new System.Drawing.Point(12, 41);
            this.grvCars.Name = "grvCars";
            this.grvCars.Size = new System.Drawing.Size(557, 195);
            this.grvCars.TabIndex = 2;
            // 
            // timerUpdateCurrentSpeeds
            // 
            this.timerUpdateCurrentSpeeds.Enabled = true;
            this.timerUpdateCurrentSpeeds.Interval = 1000;
            this.timerUpdateCurrentSpeeds.Tick += new System.EventHandler(this.timerUpdateCurrentSpeeds_Tick);
            // 
            // SimpleCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 288);
            this.Controls.Add(this.grvCars);
            this.Controls.Add(this.btnInitiateCars);
            this.Name = "SimpleCarForm";
            this.Text = "SimpleCarForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInitiateCars;
        private System.Windows.Forms.DataGridView grvCars;
        private System.Windows.Forms.Timer timerUpdateCurrentSpeeds;
    }
}

