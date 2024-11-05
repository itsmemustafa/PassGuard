namespace PassGuard.User_control
{
    partial class Uc_passstrenght
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
            this.PS_txtbox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_Checkstrenght = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.strength_lbl = new System.Windows.Forms.Label();
            this.lbl_uppercase = new System.Windows.Forms.Label();
            this.lbl_Numbers = new System.Windows.Forms.Label();
            this.lbl_spicalchars = new System.Windows.Forms.Label();
            this.lbl_long = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PS_txtbox
            // 
            this.PS_txtbox.Location = new System.Drawing.Point(246, 396);
            this.PS_txtbox.Name = "PS_txtbox";
            this.PS_txtbox.Size = new System.Drawing.Size(689, 50);
            this.PS_txtbox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.PS_txtbox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PS_txtbox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PS_txtbox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PS_txtbox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PS_txtbox.StateCommon.Border.Rounding = 20;
            this.PS_txtbox.StateCommon.Border.Width = 1;
            this.PS_txtbox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.PS_txtbox.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.PS_txtbox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.PS_txtbox.TabIndex = 3;
            this.PS_txtbox.TextChanged += new System.EventHandler(this.PS_txtbox_TextChanged);
            this.PS_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PS_txtbox_KeyDown);
            // 
            // btn_Checkstrenght
            // 
            this.btn_Checkstrenght.Location = new System.Drawing.Point(478, 864);
            this.btn_Checkstrenght.Name = "btn_Checkstrenght";
            this.btn_Checkstrenght.Size = new System.Drawing.Size(257, 98);
            this.btn_Checkstrenght.TabIndex = 4;
            this.btn_Checkstrenght.Values.Text = "Check";
            this.btn_Checkstrenght.Click += new System.EventHandler(this.btn_Checkstrenght_Click);
            // 
            // strength_lbl
            // 
            this.strength_lbl.AutoSize = true;
            this.strength_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strength_lbl.Location = new System.Drawing.Point(953, 409);
            this.strength_lbl.Name = "strength_lbl";
            this.strength_lbl.Size = new System.Drawing.Size(0, 37);
            this.strength_lbl.TabIndex = 5;
            // 
            // lbl_uppercase
            // 
            this.lbl_uppercase.AutoSize = true;
            this.lbl_uppercase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uppercase.Location = new System.Drawing.Point(283, 631);
            this.lbl_uppercase.Name = "lbl_uppercase";
            this.lbl_uppercase.Size = new System.Drawing.Size(291, 31);
            this.lbl_uppercase.TabIndex = 6;
            this.lbl_uppercase.Text = "At least one uppercase";
            // 
            // lbl_Numbers
            // 
            this.lbl_Numbers.AutoSize = true;
            this.lbl_Numbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numbers.Location = new System.Drawing.Point(283, 679);
            this.lbl_Numbers.Name = "lbl_Numbers";
            this.lbl_Numbers.Size = new System.Drawing.Size(262, 31);
            this.lbl_Numbers.TabIndex = 7;
            this.lbl_Numbers.Text = "At least one number ";
            // 
            // lbl_spicalchars
            // 
            this.lbl_spicalchars.AutoSize = true;
            this.lbl_spicalchars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spicalchars.Location = new System.Drawing.Point(283, 728);
            this.lbl_spicalchars.Name = "lbl_spicalchars";
            this.lbl_spicalchars.Size = new System.Drawing.Size(364, 31);
            this.lbl_spicalchars.TabIndex = 8;
            this.lbl_spicalchars.Text = "At least one spical charracter";
            // 
            // lbl_long
            // 
            this.lbl_long.AutoSize = true;
            this.lbl_long.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_long.Location = new System.Drawing.Point(283, 584);
            this.lbl_long.Name = "lbl_long";
            this.lbl_long.Size = new System.Drawing.Size(228, 31);
            this.lbl_long.TabIndex = 9;
            this.lbl_long.Text = "(8 -20) characters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Suggestions :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 51);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter your Password Here";
            // 
            // Uc_passstrenght
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_long);
            this.Controls.Add(this.lbl_spicalchars);
            this.Controls.Add(this.lbl_Numbers);
            this.Controls.Add(this.lbl_uppercase);
            this.Controls.Add(this.strength_lbl);
            this.Controls.Add(this.btn_Checkstrenght);
            this.Controls.Add(this.PS_txtbox);
            this.Name = "Uc_passstrenght";
            this.Size = new System.Drawing.Size(1237, 1176);
            this.Load += new System.EventHandler(this.Uc_passstrenght_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox PS_txtbox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Checkstrenght;
        private System.Windows.Forms.Label strength_lbl;
        private System.Windows.Forms.Label lbl_uppercase;
        private System.Windows.Forms.Label lbl_Numbers;
        private System.Windows.Forms.Label lbl_spicalchars;
        private System.Windows.Forms.Label lbl_long;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
