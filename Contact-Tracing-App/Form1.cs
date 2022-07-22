using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
    public partial class ContactTracingForm : Form
    {
        private Form2 form2;
        


        public ContactTracingForm()
        {
            InitializeComponent();
        }

        private void qrcodeauto_fill(object? sender, QRCodeReadEventArgs e)
        {
            string json = e.Data;
            Contact_Tracing_Form_1.ContactTracingInfo? data = JsonSerializer.Deserialize<Contact_Tracing_Form_1.ContactTracingInfo>(json);
            if (data is not null)
            {
                Nametextbox.Text = data.FullName;
                AddressTextBox.Text = data.CompleteAddress;
                DateTextbox.Text = data.Date;
                ContactNumberTextbox.Text = data.PhoneNumber;
                TimeInTextbox.Text = data.Timein;
                TimeoutTextbox.Text = data.Timeout;
                EmergencyNameTextbox.Text = data.FullName2;
                EmergencyAddressTextbox.Text = data.CompleteAddress2;
                EmergencyNumberTextbox.Text = data.PhoneNumber2;


            }

        }


        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsentCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SexLabel_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void TimeInTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void ContactTracingForm_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void EmergencyNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmergencyNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmergencyAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmergencyNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmergencyAddressTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmergencyNumberTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VisitorInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void Namelabel_Click(object sender, EventArgs e)
        {

        }

        private void ContactNumberTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeoutTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeoutLabel_Click(object sender, EventArgs e)
        {

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information Saved");

            string Date = DateTextbox.Text;
            string filepath = @"C:\Users\rodfr\source\repos\Contact-Tracing-App\Contact-Tracing-App\bin\Debug\net6.0-windows\" + Date + ".txt";



            StreamWriter file = File.AppendText(@"C:\Users\rodfr\source\repos\Contact-Tracing-App\Contact-Tracing-App\bin\Debug\net6.0-windows\" + Date + ".txt");
            file.WriteLine("Visitor's Information");
            file.WriteLine("Name:" + Nametextbox.Text);
            file.WriteLine("Address:" + AddressTextBox.Text);
            file.WriteLine("Contact Number:" + ContactNumberTextbox.Text);
            file.WriteLine("Date:" + DateTextbox.Text);
            file.WriteLine("Time In:" + TimeInTextbox.Text);
            file.WriteLine("Time Out:" + TimeoutTextbox.Text);
            file.WriteLine("Emergency Contact's Information");
            file.WriteLine("Name:" + EmergencyNameTextbox.Text);
            file.WriteLine("Contact Number:" + EmergencyNumberTextbox.Text);
            file.WriteLine("Address:" + EmergencyAddressTextbox.Text);
            file.WriteLine("");
            file.WriteLine("");
            file.Close();

            Nametextbox.Clear();
            AddressTextBox.Clear();
            ContactNumberTextbox.Clear();
            DateTextbox.Clear();
            TimeInTextbox.Clear();
            TimeoutTextbox.Clear();
            EmergencyNameTextbox.Clear();
            EmergencyNumberTextbox.Clear();
            EmergencyAddressTextbox.Clear();

            StreamReader InfoSubmitted = File.OpenText(@"C:\Users\rodfr\source\repos\Contact-Tracing-App\Contact-Tracing-App\bin\Debug\net6.0-windows\" + Date + ".txt");
            string data = InfoSubmitted.ReadToEnd();
            InfoSubmitted.Close();

            string info = data;

            string[] splitter = new string[] { "\n" };
            string[] ListedData = info.Split(splitter, StringSplitOptions.None);

            string firstline = ListedData[0];
            string secondline = ListedData[1];
            string thirdline = ListedData[2];
            string fourthline = ListedData[3];
            string fifthline = ListedData[4];
            string sixthline = ListedData[5];
            string seventhline = ListedData[6];
            string eighthline = ListedData[7];
            string ninthline = ListedData[8];
            string tenthline = ListedData[9];
            string eleventhline = ListedData[10];

            DataListbox.Items.Add(firstline);
            DataListbox.Items.Add(secondline);
            DataListbox.Items.Add(thirdline);
            DataListbox.Items.Add(fourthline);
            DataListbox.Items.Add(fifthline);
            DataListbox.Items.Add(sixthline);
            DataListbox.Items.Add(seventhline);
            DataListbox.Items.Add(eighthline);
            DataListbox.Items.Add(ninthline);
            DataListbox.Items.Add(tenthline);
            DataListbox.Items.Add(eleventhline);



        }

        



        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void label1_Click_6(object sender, EventArgs e)
        {

        }

        private void DataSubmitted_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            StreamReader search = new StreamReader(Application.StartupPath + Searchtextbox.Text + ".txt");
            Resultsbox.Text = search.ReadToEnd();
            search.Close();
        }

        

        private void CameraBox_Click(object sender, EventArgs e)
        {

        }

        private void QRCodeResultsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_7(object sender, EventArgs e)
        {

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            













                }

        private void CodeButton_Click(object sender, EventArgs e)
        {
            var data = new Contact_Tracing_Form_1.ContactTracingInfo
            {
                FullName = Nametextbox.Text,
                CompleteAddress = AddressTextBox.Text,
                PhoneNumber = ContactNumberTextbox.Text,
                Date = DateTextbox.Text,
                Timein = TimeInTextbox.Text,
                Timeout = TimeoutTextbox.Text,
                FullName2 = EmergencyNameTextbox.Text,
                CompleteAddress2 = EmergencyAddressTextbox.Text,
                PhoneNumber2 = EmergencyNumberTextbox.Text,

            };
            var width = QRCODEPictureBox.Width;
            var height = QRCODEPictureBox.Height;
            IBarcodeWriter<PixelData> writer = new BarcodeWriterPixelData
            {

                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Height = QRCODEPictureBox.Height,
                    Width = QRCODEPictureBox.Width
                },
            };

            var pixelData = writer.Write(JsonSerializer.Serialize(data));
            var Bitmap = new Bitmap(width, height);
            foreach ((byte[] pixel, int index) in pixelData.Pixels.Chunk(4).Zip(Enumerable.Range(0, Width * Height)))
            {

                var color = Color.FromArgb(pixel[3], pixel[2], pixel[1], pixel[0]);
                var y = index / width;
                var x = index % width;

                Bitmap.SetPixel(x, y, color);

            }
            QRCODEPictureBox.Image = Bitmap;
        }

        private void QRcodereader_Click(object sender, EventArgs e)
        {
            
                if (form2 is null)
                {
                    form2 = new Form2();

                form2.QRCodeRead += qrcodeauto_fill;
                form2.FormClosed += (sender, e) =>
                    {
                        form2 = null;
                    };
                    form2.Show();
                }
            }

        private void qrlabel_Click(object sender, EventArgs e)
        {

        }

        private void QRCODEPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
    }


       


        
        

        

        
       
 
