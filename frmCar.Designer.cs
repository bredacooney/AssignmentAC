namespace CarsDataBase
{
    partial class frmCar
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.frmCarHeading = new System.Windows.Forms.Label();
            this.frmVecRegLabel = new System.Windows.Forms.Label();
            this.frmMakeLabel = new System.Windows.Forms.Label();
            this.frmEngSizeLabel = new System.Windows.Forms.Label();
            this.frmRentalLabel = new System.Windows.Forms.Label();
            this.frmAvailLabel = new System.Windows.Forms.Label();
            this.frmDateLable = new System.Windows.Forms.Label();
            this.frmVehicleReg = new System.Windows.Forms.TextBox();
            this.frmMake = new System.Windows.Forms.TextBox();
            this.frmEngine = new System.Windows.Forms.TextBox();
            this.frmDate = new System.Windows.Forms.TextBox();
            this.frmRental = new System.Windows.Forms.NumericUpDown();
            this.frmAvailable = new System.Windows.Forms.CheckBox();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.recordCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.frmRental)).BeginInit();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(787, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 53);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.Black;
            this.btnLast.Location = new System.Drawing.Point(674, 440);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(123, 53);
            this.btnLast.TabIndex = 1;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(495, 440);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(123, 53);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious.Location = new System.Drawing.Point(157, 440);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(123, 53);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.Black;
            this.btnFirst.Location = new System.Drawing.Point(12, 440);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(123, 53);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(787, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 53);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(787, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 53);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(787, 211);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 53);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(787, 151);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 53);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(787, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 53);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmCarHeading
            // 
            this.frmCarHeading.AutoSize = true;
            this.frmCarHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmCarHeading.Location = new System.Drawing.Point(58, 1);
            this.frmCarHeading.Name = "frmCarHeading";
            this.frmCarHeading.Size = new System.Drawing.Size(617, 82);
            this.frmCarHeading.TabIndex = 10;
            this.frmCarHeading.Text = "Bowman Car Hire";
            // 
            // frmVecRegLabel
            // 
            this.frmVecRegLabel.AutoSize = true;
            this.frmVecRegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmVecRegLabel.Location = new System.Drawing.Point(19, 44);
            this.frmVecRegLabel.Name = "frmVecRegLabel";
            this.frmVecRegLabel.Size = new System.Drawing.Size(258, 25);
            this.frmVecRegLabel.TabIndex = 11;
            this.frmVecRegLabel.Text = "Vehicle Registration Number";
            // 
            // frmMakeLabel
            // 
            this.frmMakeLabel.AutoSize = true;
            this.frmMakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmMakeLabel.Location = new System.Drawing.Point(30, 166);
            this.frmMakeLabel.Name = "frmMakeLabel";
            this.frmMakeLabel.Size = new System.Drawing.Size(61, 25);
            this.frmMakeLabel.TabIndex = 12;
            this.frmMakeLabel.Text = "Make";
            // 
            // frmEngSizeLabel
            // 
            this.frmEngSizeLabel.AutoSize = true;
            this.frmEngSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.frmEngSizeLabel.Location = new System.Drawing.Point(31, 200);
            this.frmEngSizeLabel.Name = "frmEngSizeLabel";
            this.frmEngSizeLabel.Size = new System.Drawing.Size(117, 25);
            this.frmEngSizeLabel.TabIndex = 13;
            this.frmEngSizeLabel.Text = "Engine Size";
            // 
            // frmRentalLabel
            // 
            this.frmRentalLabel.AutoSize = true;
            this.frmRentalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmRentalLabel.Location = new System.Drawing.Point(34, 285);
            this.frmRentalLabel.Name = "frmRentalLabel";
            this.frmRentalLabel.Size = new System.Drawing.Size(142, 25);
            this.frmRentalLabel.TabIndex = 14;
            this.frmRentalLabel.Text = "Rental Per Day";
            // 
            // frmAvailLabel
            // 
            this.frmAvailLabel.AutoSize = true;
            this.frmAvailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmAvailLabel.Location = new System.Drawing.Point(34, 329);
            this.frmAvailLabel.Name = "frmAvailLabel";
            this.frmAvailLabel.Size = new System.Drawing.Size(92, 25);
            this.frmAvailLabel.TabIndex = 15;
            this.frmAvailLabel.Text = "Available";
            // 
            // frmDateLable
            // 
            this.frmDateLable.AutoSize = true;
            this.frmDateLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmDateLable.Location = new System.Drawing.Point(35, 244);
            this.frmDateLable.Name = "frmDateLable";
            this.frmDateLable.Size = new System.Drawing.Size(151, 25);
            this.frmDateLable.TabIndex = 16;
            this.frmDateLable.Text = "Date Registered";
            // 
            // frmVehicleReg
            // 
            this.frmVehicleReg.Location = new System.Drawing.Point(345, 131);
            this.frmVehicleReg.Name = "frmVehicleReg";
            this.frmVehicleReg.Size = new System.Drawing.Size(145, 26);
            this.frmVehicleReg.TabIndex = 17;
            this.frmVehicleReg.TextChanged += new System.EventHandler(this.frmVehicleReg_TextChanged);
            // 
            // frmMake
            // 
            this.frmMake.Location = new System.Drawing.Point(345, 167);
            this.frmMake.Name = "frmMake";
            this.frmMake.Size = new System.Drawing.Size(262, 26);
            this.frmMake.TabIndex = 18;
            this.frmMake.TextChanged += new System.EventHandler(this.frmMake_TextChanged);
            // 
            // frmEngine
            // 
            this.frmEngine.Location = new System.Drawing.Point(345, 200);
            this.frmEngine.Name = "frmEngine";
            this.frmEngine.Size = new System.Drawing.Size(145, 26);
            this.frmEngine.TabIndex = 19;
            this.frmEngine.TextChanged += new System.EventHandler(this.frmEngine_TextChanged);
            // 
            // frmDate
            // 
            this.frmDate.Location = new System.Drawing.Point(345, 243);
            this.frmDate.Name = "frmDate";
            this.frmDate.Size = new System.Drawing.Size(100, 26);
            this.frmDate.TabIndex = 20;
            this.frmDate.TextChanged += new System.EventHandler(this.frmDate_TextChanged);
            // 
            // frmRental
            // 
            this.frmRental.Location = new System.Drawing.Point(345, 285);
            this.frmRental.Name = "frmRental";
            this.frmRental.Size = new System.Drawing.Size(120, 26);
            this.frmRental.TabIndex = 21;
            this.frmRental.ValueChanged += new System.EventHandler(this.frmRental_ValueChanged);
            // 
            // frmAvailable
            // 
            this.frmAvailable.AutoSize = true;
            this.frmAvailable.Location = new System.Drawing.Point(333, 243);
            this.frmAvailable.Name = "frmAvailable";
            this.frmAvailable.Size = new System.Drawing.Size(22, 21);
            this.frmAvailable.TabIndex = 22;
            this.frmAvailable.UseVisualStyleBackColor = true;
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.Color.Transparent;
            this.updatePanel.Controls.Add(this.frmVecRegLabel);
            this.updatePanel.Controls.Add(this.frmAvailable);
            this.updatePanel.Location = new System.Drawing.Point(12, 86);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(739, 310);
            this.updatePanel.TabIndex = 23;
            // 
            // recordCount
            // 
            this.recordCount.Location = new System.Drawing.Point(311, 456);
            this.recordCount.Name = "recordCount";
            this.recordCount.Size = new System.Drawing.Size(154, 26);
            this.recordCount.TabIndex = 24;
            this.recordCount.TextChanged += new System.EventHandler(this.recordCount_TextChanged);
            // 
            // frmCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 535);
            this.Controls.Add(this.recordCount);
            this.Controls.Add(this.frmRental);
            this.Controls.Add(this.frmDate);
            this.Controls.Add(this.frmEngine);
            this.Controls.Add(this.frmMake);
            this.Controls.Add(this.frmVehicleReg);
            this.Controls.Add(this.frmDateLable);
            this.Controls.Add(this.frmAvailLabel);
            this.Controls.Add(this.frmRentalLabel);
            this.Controls.Add(this.frmEngSizeLabel);
            this.Controls.Add(this.frmMakeLabel);
            this.Controls.Add(this.frmCarHeading);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.updatePanel);
            this.Name = "frmCar";
            this.Text = "Task A Breda Cooney";
            this.Load += new System.EventHandler(this.frmCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmRental)).EndInit();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label frmCarHeading;
        private System.Windows.Forms.Label frmVecRegLabel;
        private System.Windows.Forms.Label frmMakeLabel;
        private System.Windows.Forms.Label frmEngSizeLabel;
        private System.Windows.Forms.Label frmRentalLabel;
        private System.Windows.Forms.Label frmAvailLabel;
        private System.Windows.Forms.Label frmDateLable;
        private System.Windows.Forms.TextBox frmVehicleReg;
        private System.Windows.Forms.TextBox frmMake;
        private System.Windows.Forms.TextBox frmEngine;
        private System.Windows.Forms.TextBox frmDate;
        private System.Windows.Forms.NumericUpDown frmRental;
        private System.Windows.Forms.CheckBox frmAvailable;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.TextBox recordCount;
    }
}

