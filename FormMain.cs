using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using IronOcr;

namespace NeuroVision {
    public partial class FormMain : Form {
        public const string title = "NeuroVision";
        private const string fileUnnamed = "Безымянный";
        private string fileName = fileUnnamed;

        private OpenFileDialog ofd = new OpenFileDialog();

        public const string pathIcon = "Resources/csharp_blue.ico";

        private bool mouseDown = false;
        private Point mouseDownPoint = Point.Empty;
        private Point mousePoint = Point.Empty;

        private ArrayPoints arrayPoints = new ArrayPoints(2);

        private List<object> allObjects = new List<object>();

        private int windowSizeX = Screen.PrimaryScreen.Bounds.Width;
        private int windowSizeY = Screen.PrimaryScreen.Bounds.Height;

        private Bitmap map;
        private Graphics graphics;
        private Pen pen;

        private IronTesseract OCR = new IronTesseract();
        private OcrInput OCR_Input = new OcrInput();

        public FormMain() {
            InitializeComponent();

            this.Icon = new Icon(pathIcon);

            formMainResult.Text = "Распознано: ничего";

            ofd.Filter = "Bitmap file|*.bmp|PNG file|.png|JPG file|.jpg|TIFF file|.tiff|GIF file|.gif|Any format|*.*";

            map = new Bitmap(windowSizeX, windowSizeY);
            pen = createTool("Карандаш");

            OCR.Language = OcrLanguage.Russian;
            License.LicenseKey = "IRONSUITE.VLAD.4002FG.MAIL.RU.1201-7DC19FB39E-HF3SLJP5REJ3KU-XVNQPOD5ZTDJ-Q2J77WZYBPWK-Z2OQYSYGZMKR-UDN2XOVNWW3L-D7K7ZNFH6YH3-Q4HRKS-TD3L52LRAY6MEA-DEPLOYMENT.TRIAL-4XBJI5.TRIAL.EXPIRES.04.MAY.2024";

            setSize();
            resizeForm();
        }

        private void resizeForm() {
            //formMainPictureBox.Width = this.Width - 30;
            //formMainPictureBox.Height = this.Height - 120;

            changeTitle();
        }

        private Pen createTool(string what) {
            Pen p = new Pen(Color.White, 1);
            p.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;

            switch (what) {
                case "Карандаш":
                p.Color = Color.Black;
                p.Width = 3;
                break;

                case "Маркер":
                p.Color = Color.DarkCyan;
                p.Width = 3;
                break;

                case "Фломастер":
                p.Color = Color.Gainsboro;
                p.Width = 3;
                break;

                case "Кисточка":
                p.Color = Color.Yellow;
                p.Width = 3;
                break;

                case "Ластик":
                p.Color = Color.White;
                p.Width = 3;
                break;
            }

            return p;
        }

        private void setSize() {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void formMainMenuStripReferenceAbout_Click(object sender, EventArgs e) {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void formMainMenuStripFileOpen_Click(object sender, EventArgs e) {
            newFile();

            if (ofd.ShowDialog() == DialogResult.OK) {
                fileName = ofd.FileName;

                formMainPictureBox.Image = new Bitmap(ofd.FileName);
            } else {
                return;
            }

            changeTitle();
        }

        private void formMainMenuStripFileExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void changeTitle() {
            string new_title = title;

            new_title += " - " + title;

            this.Text = new_title;
        }

        private void newFile() {
            fileName = fileUnnamed;

            graphics.Clear(Color.White);

            changeTitle();
        }

        private void formMainPictureBox_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            mousePoint = mouseDownPoint = e.Location;

            changeTitle();
        }

        private void formMainPictureBox_MouseMove(object sender, MouseEventArgs e) {
            mousePoint = e.Location;

            if (mouseDown == false) {
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
            arrayPoints.resetPoints();

            changeTitle();
        }

        private void formMainRecognize_Click(object sender, EventArgs e) {
            /*OCR_Input.Load(formMainPictureBox.Image);

            OcrResult result = OCR.Read(OCR_Input);
            */
            /*
            IronTesseract it = new IronTesseract();
            var result = it.Read();
            */
            //formMainResult.Text = string.Format("Распознано: {0}", result.Text);
        }
    }
}
