using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraView
{
    public partial class ManageForm : Form
    {
        Color selectedColor;
        int fontsize;
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        private readonly Action<NewFrameEventArgs> render;
        private readonly Action drawClear;

        public ManageForm(Action<NewFrameEventArgs> render, Action drawClear)
        {
            InitializeComponent();
            this.render = render;
            this.drawClear = drawClear;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            drawClear();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            FetchCamera();
            StartRendering();
            FontSize.SelectedIndex = 3;
            fontsize = 4;
            selectedColor = Color.Black;
        }

        void FetchCamera()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            SelectDeviceBox.Items.Clear();

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("カメラデバイスが存在しないため、終了します。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            foreach (FilterInfo device in videoDevices)
            {
                SelectDeviceBox.Items.Add(device.Name);
            }
            SelectDeviceBox.SelectedIndex = 0;
        }

        private void DeviceSelected(object sender, EventArgs e)
        {
            StartRendering();
        }

        void StartRendering()
        {
            if (videoSource != null)
            {
                videoSource.SignalToStop();
                videoSource.Stop();
            }

            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            videoSource = new VideoCaptureDevice(videoDevices[SelectDeviceBox.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoRendering);
            videoSource.VideoSourceError += VideoSourceError;
            videoSource.PlayingFinished += VideoPlayingFinished;

            videoSource.Start();
        }

        private void VideoSourceError(object sender, VideoSourceErrorEventArgs eventArgs)
        {
            Console.WriteLine("VideoSourceError: " + eventArgs.Description);
        }

        private void VideoPlayingFinished(object sender, ReasonToFinishPlaying reason)
        {
            MessageBox.Show("カメラが切断されました。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void VideoRendering(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action<NewFrameEventArgs>(render), eventArgs);
                }
                else
                {
                    render(eventArgs);
                }
            }
            catch (ObjectDisposedException) { }
        }

        private void ColorBlack_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Black;
        }

        private void ColorRed_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Red;
        }

        private void ColorOrange_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Orange;
        }

        private void ColorYellow_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Yellow;
        }

        private void ColorLime_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Lime;
        }

        private void ColorAqua_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Aqua;
        }

        private void ColorBlue_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Blue;
        }

        private void ColorPurple_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Purple;
        }

        private void ColorMagenta_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Magenta;
        }

        private void OtherColors_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = selectedColor;
            dialog.FullOpen = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = dialog.Color;
            }
        }

        private void FontSizeChanged(object sender, EventArgs e)
        {
            try
            {
                fontsize = int.Parse(FontSize.Text, NumberStyles.Integer);
                if (fontsize <= 0)
                {
                    MessageBox.Show("文字サイズには1以上を指定してください。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FontSize.SelectedIndex = 0;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("文字サイズには数値を指定してください。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FontSize.SelectedIndex = 3;
            }
        }

        public Color GetColor()
        {
            return selectedColor;
        }
        public int GetFontSize()
        {
            return fontsize;
        }

        public void ResetVideoSource()
        {
            if (videoSource != null)
            {
                videoSource.SignalToStop();
                videoSource.Stop();
            }
        }
    }
}
