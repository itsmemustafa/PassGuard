namespace PassGuard.User_control
{
    partial class Uc_passwordgenerator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gpasswordtbox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.chbnumber = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.chbspecialChars = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.sizeTracker = new System.Windows.Forms.TrackBar();
            this.strengthvalue = new System.Windows.Forms.Label();
            this.btn_generate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTracker)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpasswordtbox
            // 
            this.Gpasswordtbox.Location = new System.Drawing.Point(264, 487);
            this.Gpasswordtbox.Multiline = true;
            this.Gpasswordtbox.Name = "Gpasswordtbox";
            this.Gpasswordtbox.ReadOnly = true;
            this.Gpasswordtbox.Size = new System.Drawing.Size(689, 54);
            this.Gpasswordtbox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Gpasswordtbox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Gpasswordtbox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Gpasswordtbox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Gpasswordtbox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Gpasswordtbox.StateCommon.Border.Rounding = 20;
            this.Gpasswordtbox.StateCommon.Border.Width = 1;
            this.Gpasswordtbox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Gpasswordtbox.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Gpasswordtbox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Gpasswordtbox.TabIndex = 2;
            // 
            // chbnumber
            // 
            this.chbnumber.Location = new System.Drawing.Point(264, 605);
            this.chbnumber.Name = "chbnumber";
            this.chbnumber.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.chbnumber.Size = new System.Drawing.Size(226, 39);
            this.chbnumber.TabIndex = 3;
            this.chbnumber.Values.Text = "include Numbers";
            // 
            // chbspecialChars
            // 
            this.chbspecialChars.Location = new System.Drawing.Point(264, 668);
            this.chbspecialChars.Name = "chbspecialChars";
            this.chbspecialChars.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.chbspecialChars.Size = new System.Drawing.Size(241, 39);
            this.chbspecialChars.TabIndex = 4;
            this.chbspecialChars.Values.Text = "includ Spical chars";
            // 
            // sizeTracker
            // 
            this.sizeTracker.Location = new System.Drawing.Point(644, 677);
            this.sizeTracker.Maximum = 25;
            this.sizeTracker.Minimum = 5;
            this.sizeTracker.Name = "sizeTracker";
            this.sizeTracker.Size = new System.Drawing.Size(370, 90);
            this.sizeTracker.TabIndex = 5;
            this.sizeTracker.Value = 5;
            this.sizeTracker.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // strengthvalue
            // 
            this.strengthvalue.AutoSize = true;
            this.strengthvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthvalue.Location = new System.Drawing.Point(1036, 688);
            this.strengthvalue.Name = "strengthvalue";
            this.strengthvalue.Size = new System.Drawing.Size(0, 42);
            this.strengthvalue.TabIndex = 6;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(397, 814);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(372, 100);
            this.btn_generate.TabIndex = 7;
            this.btn_generate.Values.Text = "Generate";
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 627);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password Length";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Uc_passwordgenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.strengthvalue);
            this.Controls.Add(this.sizeTracker);
            this.Controls.Add(this.chbspecialChars);
            this.Controls.Add(this.chbnumber);
            this.Controls.Add(this.Gpasswordtbox);
            this.Name = "Uc_passwordgenerator";
            this.Size = new System.Drawing.Size(1237, 1176);
            this.Load += new System.EventHandler(this.Uc_passwordgenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizeTracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Gpasswordtbox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chbnumber;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chbspecialChars;
        private System.Windows.Forms.TrackBar sizeTracker;
        private System.Windows.Forms.Label strengthvalue;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_generate;
        private System.Windows.Forms.Label label1;
    }
}
