
namespace CameraView
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.DrawPaint = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPaint)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewBox
            // 
            this.PreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewBox.Location = new System.Drawing.Point(0, 0);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(1006, 559);
            this.PreviewBox.TabIndex = 1;
            this.PreviewBox.TabStop = false;
            this.PreviewBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDrawPainting);
            this.PreviewBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPaint);
            this.PreviewBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FinishDrawPainting);
            // 
            // DrawPaint
            // 
            this.DrawPaint.BackColor = System.Drawing.Color.Transparent;
            this.DrawPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawPaint.Location = new System.Drawing.Point(0, 0);
            this.DrawPaint.Name = "DrawPaint";
            this.DrawPaint.Size = new System.Drawing.Size(1006, 559);
            this.DrawPaint.TabIndex = 1;
            this.DrawPaint.TabStop = false;
            this.DrawPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDrawPainting);
            this.DrawPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPaint);
            this.DrawPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FinishDrawPainting);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 559);
            this.Controls.Add(this.DrawPaint);
            this.Controls.Add(this.PreviewBox);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "CameraView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingForm);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.FormSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPaint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.PictureBox DrawPaint;
    }
}

