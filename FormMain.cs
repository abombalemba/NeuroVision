using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using IronOcr;

namespace NeuroVision {
    public partial class FormMain : Form {
        public const string title = "NeuroVision";
        private const string fileUnnamed = "Режим рисования";
        private string fileName = fileUnnamed;
        private string fileExt = string.Empty;

        private OpenFileDialog ofd = new OpenFileDialog();

        public const string pathIcon = "Resources/csharp_blue.ico";

        private bool mouseDown = false;

        private ArrayPoints arrayPoints = new ArrayPoints(2);

        private List<object> allObjects = new List<object>();

        private int windowSizeX = Screen.PrimaryScreen.Bounds.Width;
        private int windowSizeY = Screen.PrimaryScreen.Bounds.Height;

        private Bitmap map;
        private Graphics graphics;
        private Pen pen;

        private bool drawing = true;

        public FormMain() {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.Icon = new Icon(pathIcon);

            ofd.Filter = "Bitmap file|*.bmp|PNG file|*.png|JPG file|*.jpg|TIFF file|*.tiff|PDF file|*.pdf|Any format|*.*";

            pen = new Pen(Color.Black, 3);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            License.LicenseKey = "IRONSUITE.VLAD.4002FG.MAIL.RU.1201-7DC19FB39E-HF3SLJP5REJ3KU-XVNQPOD5ZTDJ-Q2J77WZYBPWK-Z2OQYSYGZMKR-UDN2XOVNWW3L-D7K7ZNFH6YH3-Q4HRKS-TD3L52LRAY6MEA-DEPLOYMENT.TRIAL-4XBJI5.TRIAL.EXPIRES.04.MAY.2024";

            setSize();
            resizeForm();
            changeTitle();
        }

        private void FormMain_Resize(object sender, EventArgs e) {
            resizeForm();
        }

        private void formMainMenuStripFileDraw_Click(object sender, EventArgs e) {
            newFile();
            drawing = true;

            fileName = fileUnnamed;
            formMainPictureBox.Image = map;
            changeTitle();
        }

        private void formMainMenuStripFileOpen_Click(object sender, EventArgs e) {
            newFile();

            if (ofd.ShowDialog() == DialogResult.OK) {
                fileName = Path.GetFileName(ofd.FileName);
                fileExt = Path.GetExtension(ofd.FileName);

                if (fileExt != ".pdf") {
                    formMainPictureBox.Image = new Bitmap(ofd.FileName);
                } else {
                    formMainPictureBox.Image = new Bitmap(this.Width, this.Height);
                }
            } else {
                return;
            }
            drawing = false;

            changeTitle();
        }

        private void formMainMenuStripFileExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void formMainMenuStripReferenceAbout_Click(object sender, EventArgs e) {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void formMainPictureBox_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;

            if (drawing == false) {
                return;
            }

            changeTitle();
        }

        private void formMainPictureBox_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown == false) {
                return;
            }

            if (drawing == false) {
                return;
            }

            arrayPoints.setPoint(e.X, e.Y);

            if (arrayPoints.getCountPoints() >= 2) {
                graphics.DrawLines(pen, arrayPoints.getPoints());
                Point[] array = arrayPoints.getPoints();
                allObjects.Add(array);
                formMainPictureBox.Image = map;
                arrayPoints.setPoint(e.X, e.Y);
            }

            changeTitle();
        }

        private void formMainPictureBox_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;

            if (drawing == false) {
                return;
            }

            arrayPoints.resetPoints();

            changeTitle();
        }

        private void formMainRecognize_Click(object sender, EventArgs e) {
            IronTesseract OCR = new IronTesseract();
            OcrResult OCR_Result;

            if (drawing == true) {
                map.Save(@"Resources/temp.png");
                OcrInput OCR_Input = new OcrInput(@"Resources/temp.png");
                OCR_Result = OCR.Read(OCR_Input);
                File.Delete(@"Resources/temp.png");
            } else {
                string ext = Path.GetExtension(ofd.FileName);

                if (ext == ".pdf") {
                    OcrInput OCR_Input = new OcrInput();
                    OCR_Input.LoadPdf(ofd.FileName);
                    OCR_Result = OCR.Read(OCR_Input);
                } else {
                    OcrImageInput OCR_Image = new OcrImageInput(ofd.FileName);
                    OCR_Result = OCR.Read(OCR_Image);
                }
            }
            formMainResult.Text = OCR_Result.Text;
        }

        private void formMainCopy_Click(object sender, EventArgs e) {
            if (formMainResult.Text.Length == 0) {
                return;
            }

            Clipboard.SetText(formMainResult.Text);
        }

        private void resizeForm() {
            windowSizeX = this.Width;
            windowSizeY = this.Height;

            formMainPictureBox.Location = new Point(Convert.ToInt32(windowSizeX * 0.01), Convert.ToInt32(windowSizeY * 0.05));
            formMainPictureBox.Size = new Size(Convert.ToInt32(windowSizeX * 0.8), Convert.ToInt32(windowSizeY * 0.85));

            formMainRecognize.Location = new Point(Convert.ToInt32(windowSizeX * 0.825), Convert.ToInt32(windowSizeY * 0.05));
            formMainRecognize.Size = new Size(Convert.ToInt32(windowSizeX * 0.15), Convert.ToInt32(windowSizeY * 0.05));

            formMainCopy.Location = new Point(Convert.ToInt32(windowSizeX * 0.825), Convert.ToInt32(windowSizeY * 0.11));
            formMainCopy.Size = new Size(Convert.ToInt32(windowSizeX * 0.15), Convert.ToInt32(windowSizeY * 0.05));

            formMainLabel.Location = new Point(Convert.ToInt32(windowSizeX * 0.825), Convert.ToInt32(windowSizeY * 0.17));
            formMainLabel.Size = new Size(Convert.ToInt32(windowSizeX * 0.15), Convert.ToInt32(windowSizeY * 0.05));

            formMainResult.Location = new Point(Convert.ToInt32(windowSizeX * 0.825), Convert.ToInt32(windowSizeY * 0.23));
            formMainResult.Size = new Size(Convert.ToInt32(windowSizeX * 0.15), Convert.ToInt32(windowSizeY * 0.67));

            changeTitle();
        }

        private void setSize() {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);
        }

        private void changeTitle() {
            this.Text = title + " - " + fileName;
        }

        private void newFile() {
            fileName = fileUnnamed;

            graphics.Clear(Color.White);

            changeTitle();
        }
    }
}
