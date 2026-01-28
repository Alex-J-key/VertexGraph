namespace GraphPlotter
{
    partial class frmAddNewVertex
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
            btnInsert = new Button();
            btnCancel = new Button();
            cmbColour = new ComboBox();
            label1 = new Label();
            txtX = new TextBox();
            txtY = new TextBox();
            lblXPos = new Label();
            lblYPos = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Sitka Banner", 16F);
            btnInsert.Location = new Point(190, 187);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(126, 57);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Sitka Banner", 16F);
            btnCancel.Location = new Point(12, 187);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 57);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbColour
            // 
            cmbColour.FormattingEnabled = true;
            cmbColour.ImeMode = ImeMode.Disable;
            cmbColour.Items.AddRange(new object[] { "Black", "Red", "Blue", "Magenta", "Yellow", "Green" });
            cmbColour.Location = new Point(112, 108);
            cmbColour.Name = "cmbColour";
            cmbColour.Size = new Size(158, 27);
            cmbColour.TabIndex = 4;
            cmbColour.Text = "Select a colour";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 111);
            label1.Name = "label1";
            label1.Size = new Size(50, 19);
            label1.TabIndex = 5;
            label1.Text = "Colour";
            // 
            // txtX
            // 
            txtX.Location = new Point(112, 59);
            txtX.MaxLength = 4;
            txtX.Name = "txtX";
            txtX.Size = new Size(76, 26);
            txtX.TabIndex = 6;
            // 
            // txtY
            // 
            txtY.Location = new Point(194, 59);
            txtY.MaxLength = 4;
            txtY.Name = "txtY";
            txtY.Size = new Size(76, 26);
            txtY.TabIndex = 7;
            // 
            // lblXPos
            // 
            lblXPos.AutoSize = true;
            lblXPos.Location = new Point(112, 37);
            lblXPos.Name = "lblXPos";
            lblXPos.Size = new Size(42, 19);
            lblXPos.TabIndex = 8;
            lblXPos.Text = "X Pos";
            // 
            // lblYPos
            // 
            lblYPos.AutoSize = true;
            lblYPos.Location = new Point(194, 37);
            lblYPos.Name = "lblYPos";
            lblYPos.Size = new Size(42, 19);
            lblYPos.TabIndex = 9;
            lblYPos.Text = "Y Pos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 18);
            label2.Name = "label2";
            label2.Size = new Size(244, 19);
            label2.TabIndex = 10;
            label2.Text = "Must be integers between 10 and 600";
            // 
            // frmAddNewVertex
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 256);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(lblYPos);
            Controls.Add(lblXPos);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(label1);
            Controls.Add(cmbColour);
            Controls.Add(btnCancel);
            Controls.Add(btnInsert);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddNewVertex";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Insert New Vertex";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private Button btnCancel;
        private ComboBox cmbColour;
        private Label label1;
        private TextBox txtX;
        private TextBox txtY;
        private Label lblXPos;
        private Label lblYPos;
        private Label label2;
    }
}