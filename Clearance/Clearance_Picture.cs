﻿using AForge.Video;
using AForge.Video.DirectShow;
using plths.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plths.Clearance
{
    public partial class Clearance_Picture : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
     

        int roid, resid;
        string amount;
        private VideoCaptureDevice VideoCapture;
        private FilterInfoCollection FilterInfo;
        


        public Clearance_Picture()
        {
            InitializeComponent();
        }

        public Clearance_Picture(int rowid, int residentID, string amm) : this()
        {
            roid = rowid;
            resid = residentID;
            amount = amm;
        }

     

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

     

        private void printBtn_Click(object sender, EventArgs e)
        {
            var resident = _context.Residents.Where(r => r.ID == resid).FirstOrDefault();
            string toDate = DateTime.Today.ToString("dd");
            string myDate = DateTime.Today.ToString("MM/yy");
            string issued = resident.fullname;
            string r_gender = resident.Gender;
            string r_civil = resident.civil_status;
            int r_age = (int)resident.Age;
            string filedirect = resident.picture;


            Reports.frmClearanceReport clearanceReport = new Reports.frmClearanceReport();
            clearanceReport.residentClearanceData(issued, toDate, r_gender, r_age, r_civil,toDate, filedirect);
            clearanceReport.Show();

            var request = _context.requests.Where(re => re.request_id == roid).FirstOrDefault();
            request.printed = "true";
            request.datePrinted = DateTime.Today;
            _context.SaveChanges();


        }
      
        private void startCamera()
        {
            try
            {
                FilterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                VideoCapture = new VideoCaptureDevice(FilterInfo[0].MonikerString);
                VideoCapture.VideoResolution = VideoCapture.VideoCapabilities[4];
                VideoCapture.NewFrame += new NewFrameEventHandler(Camera_On);
                VideoCapture.Start();

            }
            catch (Exception e)
            {

            }
        }
        private void exitcamera()
        {

            VideoCapture.SignalToStop();
            // FinalVideo.WaitForStop();  << marking out that one solved it
            VideoCapture.NewFrame -= new NewFrameEventHandler(Camera_On); // as sugested
            VideoCapture = null;
        }


        private void Camera_On(object sender, NewFrameEventArgs eventArgs)
        {

            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void ltbPurpose_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddIndigency_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string filename = @"C:\testfolder\" + textBox1.Text.Trim() + ".jpg";
            var bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            pictureBox1.DrawToBitmap(bitmap, pictureBox1.ClientRectangle);

            System.Drawing.Imaging.ImageFormat imageFormat = null;

            imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;

            bitmap.Save(filename);


            byte[] b = File.ReadAllBytes(filename);


            var resident = _context.Residents.Where( r => r.ID == resid).FirstOrDefault();

            resident.picture = filename;
              
            _context.SaveChanges();

            MessageBox.Show("Image Captured");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            startCamera();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            exitcamera();
            this.Close();

           
        }

     
    }

}
