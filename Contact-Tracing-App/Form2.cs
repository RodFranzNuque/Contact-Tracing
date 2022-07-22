using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using ZXing.QrCode;
using System.Diagnostics;
using AForge;
using ZXing.Aztec;
using QRCoder;
using System.Drawing.Imaging;
using System.Text.Json;

namespace Contact_Tracing_App
{
    public partial class Form2 : Form
    {
        private BarcodeReaderGeneric barcodeReader = new BarcodeReaderGeneric(new QRCodeReader(), null, null);

        
        public event EventHandler<QRCodeReadEventArgs> QRCodeRead;

        public Form2()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CameraBox.Image != null)
            {

                Bitmap bmp = (Bitmap)CameraBox.Image;
                var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

                BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadOnly, bmp.PixelFormat);
                IntPtr ptr = bmpData.Scan0;

                int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
                byte[] rgbValues = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

                bmp.UnlockBits(bmpData);
                var bitmapFormat = bmp.PixelFormat switch
                {
                    PixelFormat.Format24bppRgb => RGBLuminanceSource.BitmapFormat.RGB24,
                    PixelFormat.Format32bppRgb => RGBLuminanceSource.BitmapFormat.RGB32,
                    PixelFormat.Format32bppArgb => RGBLuminanceSource.BitmapFormat.ARGB32,
                    PixelFormat.Format16bppRgb565 => RGBLuminanceSource.BitmapFormat.RGB565,
                    PixelFormat.Format16bppGrayScale => RGBLuminanceSource.BitmapFormat.Gray16,
                    _ => RGBLuminanceSource.BitmapFormat.Unknown,
                };

                Result result = barcodeReader.Decode(rgbValues, bmp.Width, bmp.Height, bitmapFormat);
                if (result?.Text is not null)
                {
                    if (QRCodeRead is not null)
                    {
                        QRCodeRead(this, new QRCodeReadEventArgs { Data = result.Text });
                    }

                    timer1.Stop();
                    stopCapture();
                    QRCodeRead(this, new QRCodeReadEventArgs { Data = result.Text });
                    this.Close();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                CamComboBox.Items.Add(filterInfo.Name);
            CamComboBox.SelectedIndex = 0;
        }
        private void OpenCameraButton_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[CamComboBox.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }



        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            CameraBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void stopCapture()
        {
            if (captureDevice is not null)
            {
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
                captureDevice = null;
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopCapture();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            startcapture();
            
        }
        private void startcapture()
        {
            if (captureDevice is null)
            {
                captureDevice = new VideoCaptureDevice(filterInfoCollection[CamComboBox.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.PlayingFinished += videocaptureerror;
                captureDevice.Start();
                timer1.Start();
            }

        }
        private void videocaptureerror(object sender, ReasonToFinishPlaying e)
        {
            Debug.WriteLine(e.ToString());

        }
        

        private void CamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stopCapture();
            startcapture();
        }

        private void CamLabel_Click(object sender, EventArgs e)
        {

        }
    }
    public class QRCodeReadEventArgs
    {
        public string Data { get; set; }
    }
}