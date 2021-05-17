
namespace CameraView
{
    partial class ManageForm
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
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FontSize = new System.Windows.Forms.ComboBox();
            this.SelectDeviceBox = new System.Windows.Forms.ComboBox();
            this.ColorYellow = new System.Windows.Forms.Button();
            this.ColorOrange = new System.Windows.Forms.Button();
            this.ColorRed = new System.Windows.Forms.Button();
            this.ColorBlue = new System.Windows.Forms.Button();
            this.ColorAqua = new System.Windows.Forms.Button();
            this.ColorLime = new System.Windows.Forms.Button();
            this.ColorPurple = new System.Windows.Forms.Button();
            this.ColorMagenta = new System.Windows.Forms.Button();
            this.OtherColors = new System.Windows.Forms.Button();
            this.ColorBlack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(12, 128);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(301, 48);
            this.ClearBtn.TabIndex = 10;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(62, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "px";
            // 
            // FontSize
            // 
            this.FontSize.FormattingEnabled = true;
            this.FontSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "125",
            "150",
            "175",
            "200",
            "225",
            "250",
            "275",
            "300",
            "325",
            "350",
            "375",
            "400",
            "425",
            "450",
            "475",
            "500",
            "550",
            "600",
            "650",
            "700",
            "750",
            "800",
            "850",
            "900",
            "950",
            "1000"});
            this.FontSize.Location = new System.Drawing.Point(12, 54);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(44, 20);
            this.FontSize.TabIndex = 7;
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.FontSizeChanged);
            this.FontSize.TextChanged += new System.EventHandler(this.FontSizeChanged);
            // 
            // SelectDeviceBox
            // 
            this.SelectDeviceBox.FormattingEnabled = true;
            this.SelectDeviceBox.Location = new System.Drawing.Point(12, 12);
            this.SelectDeviceBox.Name = "SelectDeviceBox";
            this.SelectDeviceBox.Size = new System.Drawing.Size(301, 20);
            this.SelectDeviceBox.TabIndex = 6;
            this.SelectDeviceBox.SelectedIndexChanged += new System.EventHandler(this.DeviceSelected);
            // 
            // ColorYellow
            // 
            this.ColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.ColorYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorYellow.Location = new System.Drawing.Point(168, 53);
            this.ColorYellow.Margin = new System.Windows.Forms.Padding(0);
            this.ColorYellow.Name = "ColorYellow";
            this.ColorYellow.Size = new System.Drawing.Size(20, 20);
            this.ColorYellow.TabIndex = 11;
            this.ColorYellow.UseVisualStyleBackColor = false;
            this.ColorYellow.Click += new System.EventHandler(this.ColorYellow_Click);
            // 
            // ColorOrange
            // 
            this.ColorOrange.BackColor = System.Drawing.Color.Orange;
            this.ColorOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorOrange.Location = new System.Drawing.Point(143, 53);
            this.ColorOrange.Margin = new System.Windows.Forms.Padding(0);
            this.ColorOrange.Name = "ColorOrange";
            this.ColorOrange.Size = new System.Drawing.Size(20, 20);
            this.ColorOrange.TabIndex = 11;
            this.ColorOrange.UseVisualStyleBackColor = false;
            this.ColorOrange.Click += new System.EventHandler(this.ColorOrange_Click);
            // 
            // ColorRed
            // 
            this.ColorRed.BackColor = System.Drawing.Color.Red;
            this.ColorRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorRed.Location = new System.Drawing.Point(118, 53);
            this.ColorRed.Margin = new System.Windows.Forms.Padding(0);
            this.ColorRed.Name = "ColorRed";
            this.ColorRed.Size = new System.Drawing.Size(20, 20);
            this.ColorRed.TabIndex = 11;
            this.ColorRed.UseVisualStyleBackColor = false;
            this.ColorRed.Click += new System.EventHandler(this.ColorRed_Click);
            // 
            // ColorBlue
            // 
            this.ColorBlue.BackColor = System.Drawing.Color.Blue;
            this.ColorBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorBlue.Location = new System.Drawing.Point(243, 53);
            this.ColorBlue.Margin = new System.Windows.Forms.Padding(0);
            this.ColorBlue.Name = "ColorBlue";
            this.ColorBlue.Size = new System.Drawing.Size(20, 20);
            this.ColorBlue.TabIndex = 11;
            this.ColorBlue.UseVisualStyleBackColor = false;
            this.ColorBlue.Click += new System.EventHandler(this.ColorBlue_Click);
            // 
            // ColorAqua
            // 
            this.ColorAqua.BackColor = System.Drawing.Color.Aqua;
            this.ColorAqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorAqua.Location = new System.Drawing.Point(218, 53);
            this.ColorAqua.Margin = new System.Windows.Forms.Padding(0);
            this.ColorAqua.Name = "ColorAqua";
            this.ColorAqua.Size = new System.Drawing.Size(20, 20);
            this.ColorAqua.TabIndex = 11;
            this.ColorAqua.UseVisualStyleBackColor = false;
            this.ColorAqua.Click += new System.EventHandler(this.ColorAqua_Click);
            // 
            // ColorLime
            // 
            this.ColorLime.BackColor = System.Drawing.Color.Lime;
            this.ColorLime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorLime.Location = new System.Drawing.Point(193, 53);
            this.ColorLime.Margin = new System.Windows.Forms.Padding(0);
            this.ColorLime.Name = "ColorLime";
            this.ColorLime.Size = new System.Drawing.Size(20, 20);
            this.ColorLime.TabIndex = 11;
            this.ColorLime.UseVisualStyleBackColor = false;
            this.ColorLime.Click += new System.EventHandler(this.ColorLime_Click);
            // 
            // ColorPurple
            // 
            this.ColorPurple.BackColor = System.Drawing.Color.Purple;
            this.ColorPurple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorPurple.Location = new System.Drawing.Point(268, 53);
            this.ColorPurple.Margin = new System.Windows.Forms.Padding(0);
            this.ColorPurple.Name = "ColorPurple";
            this.ColorPurple.Size = new System.Drawing.Size(20, 20);
            this.ColorPurple.TabIndex = 11;
            this.ColorPurple.UseVisualStyleBackColor = false;
            this.ColorPurple.Click += new System.EventHandler(this.ColorPurple_Click);
            // 
            // ColorMagenta
            // 
            this.ColorMagenta.BackColor = System.Drawing.Color.Magenta;
            this.ColorMagenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorMagenta.Location = new System.Drawing.Point(293, 53);
            this.ColorMagenta.Margin = new System.Windows.Forms.Padding(0);
            this.ColorMagenta.Name = "ColorMagenta";
            this.ColorMagenta.Size = new System.Drawing.Size(20, 20);
            this.ColorMagenta.TabIndex = 11;
            this.ColorMagenta.UseVisualStyleBackColor = false;
            this.ColorMagenta.Click += new System.EventHandler(this.ColorMagenta_Click);
            // 
            // OtherColors
            // 
            this.OtherColors.Location = new System.Drawing.Point(12, 80);
            this.OtherColors.Name = "OtherColors";
            this.OtherColors.Size = new System.Drawing.Size(301, 34);
            this.OtherColors.TabIndex = 10;
            this.OtherColors.Text = "その他の色";
            this.OtherColors.UseVisualStyleBackColor = true;
            this.OtherColors.Click += new System.EventHandler(this.OtherColors_Click);
            // 
            // ColorBlack
            // 
            this.ColorBlack.BackColor = System.Drawing.Color.Black;
            this.ColorBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorBlack.Location = new System.Drawing.Point(93, 53);
            this.ColorBlack.Margin = new System.Windows.Forms.Padding(0);
            this.ColorBlack.Name = "ColorBlack";
            this.ColorBlack.Size = new System.Drawing.Size(20, 20);
            this.ColorBlack.TabIndex = 11;
            this.ColorBlack.UseVisualStyleBackColor = false;
            this.ColorBlack.Click += new System.EventHandler(this.ColorBlack_Click);
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 183);
            this.ControlBox = false;
            this.Controls.Add(this.ColorLime);
            this.Controls.Add(this.ColorAqua);
            this.Controls.Add(this.ColorBlack);
            this.Controls.Add(this.ColorRed);
            this.Controls.Add(this.ColorMagenta);
            this.Controls.Add(this.ColorPurple);
            this.Controls.Add(this.ColorBlue);
            this.Controls.Add(this.ColorOrange);
            this.Controls.Add(this.ColorYellow);
            this.Controls.Add(this.OtherColors);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FontSize);
            this.Controls.Add(this.SelectDeviceBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ManageForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FontSize;
        private System.Windows.Forms.ComboBox SelectDeviceBox;
        private System.Windows.Forms.Button ColorYellow;
        private System.Windows.Forms.Button ColorOrange;
        private System.Windows.Forms.Button ColorRed;
        private System.Windows.Forms.Button ColorBlue;
        private System.Windows.Forms.Button ColorAqua;
        private System.Windows.Forms.Button ColorLime;
        private System.Windows.Forms.Button ColorPurple;
        private System.Windows.Forms.Button ColorMagenta;
        private System.Windows.Forms.Button OtherColors;
        private System.Windows.Forms.Button ColorBlack;
    }
}