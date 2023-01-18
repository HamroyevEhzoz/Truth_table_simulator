namespace RostlikJadvaliWinform
{
    public partial class TruthTableForm : Form
    {
        private readonly string picLocation = "C:\\Users\\User\\source\\repos\\RostlikJadvaliWF\\RostlikJadvaliWinform\\pictures\\default.jpg";
        public TruthTableForm()
        {
            InitializeComponent();
        }

        private void inkorButton_Click(object sender, EventArgs e)
        {
            var location = "C:\\Users\\User\\source\\repos\\RostlikJadvaliWF\\RostlikJadvaliWinform\\pictures\\mantiqiyInkor.jpg";
            resulTextBox.Clear();
            tablePictureBox.Image=Image.FromFile(location);
        }

        private void kupaytmaButton_Click(object sender, EventArgs e)
        {
           var location = "C:\\Users\\User\\source\\repos\\RostlikJadvaliWF\\RostlikJadvaliWinform\\pictures\\mantiqiyKopaytirish.jpg";
            resulTextBox.Clear();
            tablePictureBox.Image = Image.FromFile(location);

        }

        private void qushishButton_Click(object sender, EventArgs e)
        {
            var location = "C:\\Users\\User\\source\\repos\\RostlikJadvaliWF\\RostlikJadvaliWinform\\pictures\\mantiqiyQushish.jpg";
            resulTextBox.Clear();
            tablePictureBox.Image = Image.FromFile(location);
        }


        private void kupaytmaCButton_Click(object sender, EventArgs e)
        {
            tablePictureBox.Image = Image.FromFile(picLocation);

            var a = aTextBox.Text.ToLower();

            var b = bTextBox.Text.ToLower();
            if (a == "" || b == "")
            {
                resulTextBox.Text = "Mulohaza kiritayoganda (bo'sh)notog'ri format berildi!";
                aTextBox.Clear();
                bTextBox.Clear();
            }
            else if ((a == "rost" || a=="true" || a=="1") && (b == "rost" || b == "true" || b == "1"))
            {
                resulTextBox.Text = "rost";

                aTextBox.Clear();
                bTextBox.Clear();

            }
            else
            {
                resulTextBox.Text = "yolg'on";
                aTextBox.Clear();
                bTextBox.Clear();
            }
        }

        private void qoshishCbutton_Click(object sender, EventArgs e)
        {
            tablePictureBox.Image = Image.FromFile(picLocation);

            var a = aTextBox.Text.ToLower();

            var b = bTextBox.Text.ToLower();

            if(a== "" || b== "")
            {
                resulTextBox.Text = "Mulohaza kiritayoganda (bo'sh)notog'ri format berildi!";
                aTextBox.Clear();
                bTextBox.Clear();
            }
            else if ((a == "rost" || a == "true" || a == "1") || (b == "rost" || b == "true" || b == "1"))
            {
                resulTextBox.Text = "rost";
                aTextBox.Clear();
                bTextBox.Clear();
            }
            else
            {
                resulTextBox.Text = "yolg'on";
                aTextBox.Clear();
                bTextBox.Clear();
            }

        }

        private void inkorCbutton_Click(object sender, EventArgs e)
        {
            tablePictureBox.Image = Image.FromFile(picLocation);

            var a = aTextBox.Text.ToLower();

            if(bTextBox.Text!="")
            {
                resulTextBox.Text = "Bu commanda faqat A uchun ishlaydi B ga qiymat bermang!";
                aTextBox.Clear();
                bTextBox.Clear();
                return;
            }
            if ((a == "rost" || a == "true" || a == "1"))
            {
                resulTextBox.Text = "yolg'on";
                aTextBox.Clear();
                bTextBox.Clear();
            }
            else if (a == "yolg'on" || a=="false" || a=="0")
            {
                resulTextBox.Text = "rost";
                aTextBox.Clear();
                bTextBox.Clear();
            }
            else
            {
                resulTextBox.Text = "Mulohaza kiritayoganda (bo'sh)notog'ri format berildi!";
                aTextBox.Clear();
                bTextBox.Clear();
            }
        }
    }
}
