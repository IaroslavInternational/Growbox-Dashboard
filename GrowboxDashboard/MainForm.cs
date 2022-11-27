namespace GrowboxDashboard
{
    public partial class MainForm : Form
    {
        private Button currentBtn;
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

                currentBtn = (Button)senderBtn;
                currentBtn.ForeColor = color;

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
            ActiveButton(manage_btn, Color.FromArgb(235, 197, 28));
            OpenChildForm(new ManageForm());
        }

        private void manage_btn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(235, 197, 28));
            OpenChildForm(new ManageForm());
        }

        private void connection_settings_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.FromArgb(235, 197, 28));
            //OpenChildForm(new SettignsForm());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //currentChildForm.Close();
        }
    }
}