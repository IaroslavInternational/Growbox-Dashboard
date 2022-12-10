using FontAwesome.Sharp;

namespace GrowboxDashboard
{
    public partial class MainForm : Form
    {
        private IconButton currentBtn;
        private Form   currentChildForm;
        private Panel  leftBorderBtn;

        public MainForm()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //OpenChildForm(new IntroForm());
        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            main_panel.Controls.Add(childForm);
            main_panel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ActiveButton(manageBtn, Color.FromArgb(235, 197, 28));
            OpenChildForm(new ManageForm());
        }

        private void manageBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(235, 197, 28));
            OpenChildForm(new ManageForm());
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(235, 197, 28));
            //OpenChildForm(new SettignsForm());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            currentChildForm.Close();
        }
    }
}