namespace CarsDataBase
{
    partial class frmAdd
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.frmVecRegLabel = new System.Windows.Forms.Label();
            this.frmMakeLabel = new System.Windows.Forms.Label();
            this.frmEngSizeLabel = new System.Windows.Forms.Label();
            this.frmDateLabel = new System.Windows.Forms.Label();
            this.frmRentalLabel = new System.Windows.Forms.Label();
            this.frmAvailLabel = new System.Windows.Forms.Label();
            this.frmVehicleReg = new System.Windows.Forms.TextBox();
            this.frmMake = new System.Windows.Forms.TextBox();
            this.frmEngine = new System.Windows.Forms.TextBox();
            this.frmDate = new System.Windows.Forms.TextBox();
            this.frmRental = new System.Windows.Forms.NumericUpDown();
            this.frmAvailable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.frmRental)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(96, 358);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 45);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(301, 358);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(486, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmVecRegLabel
            // 
            this.frmVecRegLabel.AutoSize = true;
            this.frmVecRegLabel.Location = new System.Drawing.Point(43, 29);
            this.frmVecRegLabel.Name = "frmVecRegLabel";
            this.frmVecRegLabel.Size = new System.Drawing.Size(211, 20);
            this.frmVecRegLabel.TabIndex = 3;
            this.frmVecRegLabel.Text = "Vehicle Registration Number";
            // 
            // frmMakeLabel
            // 
            this.frmMakeLabel.AutoSize = true;
            this.frmMakeLabel.Location = new System.Drawing.Point(43, 91);
            this.frmMakeLabel.Name = "frmMakeLabel";
            this.frmMakeLabel.Size = new System.Drawing.Size(48, 20);
            this.frmMakeLabel.TabIndex = 4;
            this.frmMakeLabel.Text = "Make";
            // 
            // frmEngSizeLabel
            // 
            this.frmEngSizeLabel.AutoSize = true;
            this.frmEngSizeLabel.Location = new System.Drawing.Point(47, 153);
            this.frmEngSizeLabel.Name = "frmEngSizeLabel";
            this.frmEngSizeLabel.Size = new System.Drawing.Size(94, 20);
            this.frmEngSizeLabel.TabIndex = 5;
            this.frmEngSizeLabel.Text = "Engine Size";
            // 
            // frmDateLabel
            // 
            this.frmDateLabel.AutoSize = true;
            this.frmDateLabel.Location = new System.Drawing.Point(43, 202);
            this.frmDateLabel.Name = "frmDateLabel";
            this.frmDateLabel.Size = new System.Drawing.Size(126, 20);
            this.frmDateLabel.TabIndex = 6;
            this.frmDateLabel.Text = "Date Registered";
            // 
            // frmRentalLabel
            // 
            this.frmRentalLabel.AutoSize = true;
            this.frmRentalLabel.Location = new System.Drawing.Point(43, 254);
            this.frmRentalLabel.Name = "frmRentalLabel";
            this.frmRentalLabel.Size = new System.Drawing.Size(116, 20);
            this.frmRentalLabel.TabIndex = 7;
            this.frmRentalLabel.Text = "Rental Per Day";
            // 
            // frmAvailLabel
            // 
            this.frmAvailLabel.AutoSize = true;
            this.frmAvailLabel.Location = new System.Drawing.Point(43, 309);
            this.frmAvailLabel.Name = "frmAvailLabel";
            this.frmAvailLabel.Size = new System.Drawing.Size(72, 20);
            this.frmAvailLabel.TabIndex = 8;
            this.frmAvailLabel.Text = "Available";
            // 
            // frmVehicleReg
            // 
            this.frmVehicleReg.Location = new System.Drawing.Point(319, 22);
            this.frmVehicleReg.Name = "frmVehicleReg";
            this.frmVehicleReg.Size = new System.Drawing.Size(100, 26);
            this.frmVehicleReg.TabIndex = 9;
            this.frmVehicleReg.TextChanged += new System.EventHandler(this.frmVehicleReg_TextChanged);
            // 
            // frmMake
            // 
            this.frmMake.Location = new System.Drawing.Point(319, 84);
            this.frmMake.Name = "frmMake";
            this.frmMake.Size = new System.Drawing.Size(100, 26);
            this.frmMake.TabIndex = 10;
            this.frmMake.TextChanged += new System.EventHandler(this.frmMake_TextChanged);
            // 
            // frmEngine
            // 
            this.frmEngine.Location = new System.Drawing.Point(319, 146);
            this.frmEngine.Name = "frmEngine";
            this.frmEngine.Size = new System.Drawing.Size(100, 26);
            this.frmEngine.TabIndex = 11;
            this.frmEngine.TextChanged += new System.EventHandler(this.frmEngine_TextChanged);
            // 
            // frmDate
            // 
            this.frmDate.Location = new System.Drawing.Point(319, 202);
            this.frmDate.Name = "frmDate";
            this.frmDate.Size = new System.Drawing.Size(100, 26);
            this.frmDate.TabIndex = 12;
            this.frmDate.TextChanged += new System.EventHandler(this.frmDate_TextChanged);
            // 
            // frmRental
            // 
            this.frmRental.Location = new System.Drawing.Point(319, 247);
            this.frmRental.Name = "frmRental";
            this.frmRental.Size = new System.Drawing.Size(120, 26);
            this.frmRental.TabIndex = 13;
            this.frmRental.ValueChanged += new System.EventHandler(this.frmRental_ValueChanged);
            // 
            // frmAvailable
            // 
            this.frmAvailable.AutoSize = true;
            this.frmAvailable.Location = new System.Drawing.Point(319, 295);
            this.frmAvailable.Name = "frmAvailable";
            this.frmAvailable.Size = new System.Drawing.Size(22, 21);
            this.frmAvailable.TabIndex = 14;
            this.frmAvailable.UseVisualStyleBackColor = true;
            this.frmAvailable.CheckedChanged += new System.EventHandler(this.frmAvailable_CheckedChanged);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmAvailable);
            this.Controls.Add(this.frmRental);
            this.Controls.Add(this.frmDate);
            this.Controls.Add(this.frmEngine);
            this.Controls.Add(this.frmMake);
            this.Controls.Add(this.frmVehicleReg);
            this.Controls.Add(this.frmAvailLabel);
            this.Controls.Add(this.frmRentalLabel);
            this.Controls.Add(this.frmDateLabel);
            this.Controls.Add(this.frmEngSizeLabel);
            this.Controls.Add(this.frmMakeLabel);
            this.Controls.Add(this.frmVecRegLabel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Name = "frmAdd";
            this.Text = "Task A Add Breda Cooney";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label frmVecRegLabel;
        private System.Windows.Forms.Label frmMakeLabel;
        private System.Windows.Forms.Label frmEngSizeLabel;
        private System.Windows.Forms.Label frmDateLabel;
        private System.Windows.Forms.Label frmRentalLabel;
        private System.Windows.Forms.Label frmAvailLabel;
        private System.Windows.Forms.TextBox frmVehicleReg;
        private System.Windows.Forms.TextBox frmMake;
        private System.Windows.Forms.TextBox frmEngine;
        private System.Windows.Forms.TextBox frmDate;
        private System.Windows.Forms.NumericUpDown frmRental;
        private System.Windows.Forms.CheckBox frmAvailable;
    }
}