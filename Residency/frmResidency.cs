using AForge.Video;
using AForge.Video.DirectShow;
using plths.Reports;
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

namespace plths.Residency
{
    public partial class frmResidency : Form
    {
        plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();

        int resrowID, r_age, resid;
        private VideoCaptureDevice VideoCapture;
        private FilterInfoCollection FilterInfo;


        public frmResidency()
        {
            InitializeComponent();
        }

        public frmResidency(int rowID, int residentID): this()
        {
            resrowID = rowID;
            resid = residentID;
        }


        private void printBtn_Click(object sender, EventArgs e)
        {
            if (ltbPurpose.Text.Trim() != "")
            {
                var resident = _context.Residents.Where(r => r.ID == resid).FirstOrDefault();
                string toDate = DateTime.Today.ToString("dd");
                string myDate = DateTime.Today.ToString("MM/yyyy");
                string name = resident.fullname;
                int age = (int)resident.Age;
                string gender = resident.Gender;
                string civil = resident.civil_status;
                string purpose = ltbPurpose.Text.Trim();
                string filedirect = resident.picture;

                ResidencyReport residencyReport = new ResidencyReport();
                residencyReport.residentResidenceData(name, purpose, toDate, gender, age, civil, myDate,filedirect);
                residencyReport.Show();

                var request = _context.requests.Where(re => re.request_id == resrowID).FirstOrDefault();
                request.printed = "true";
                request.datePrinted = DateTime.Today;
                _context.SaveChanges();
            }
        }

        private void exitcamera()
        {

            VideoCapture.SignalToStop();
            // FinalVideo.WaitForStop();  << marking out that one solved it
            VideoCapture.NewFrame -= new NewFrameEventHandler(Camera_on); // as sugested
            VideoCapture = null;
        }

        private void Camera_on(object sender,NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void startCamera()
        {
            try
            {
                FilterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                VideoCapture = new VideoCaptureDevice(FilterInfo[0].MonikerString);
                VideoCapture.VideoResolution = VideoCapture.VideoCapabilities[4];
                VideoCapture.NewFrame += new NewFrameEventHandler(Camera_on);
                VideoCapture.Start();

            }
            catch (Exception e)
            {

            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            startCamera();
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


            var resident = _context.Residents.Where(r => r.ID == resid).FirstOrDefault();

            resident.picture = filename;

            _context.SaveChanges();

            MessageBox.Show("Image Captured");
        }

        private void frmResidency_Load(object sender, EventArgs e)
        {
           
        }

        

        private void btnResidencyCancel_Click(object sender, EventArgs e)
        {
            exitcamera();
            this.Close();
        }


    }
}
