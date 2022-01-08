namespace VLC_BluRay_Installer_WFA
{
    public partial class Form1 : Form
    {
        private string keydbPath = @"C:\ProgramData\aacs";
        private string libaacsPath = @"C:\Program Files (x86)\VideoLAN\VLC";
        public Form1()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            InitializeComponent();
            VlcInstallationPathBox.Text = libaacsPath;
            outputBox.ReadOnly = true;
            var s = new Statics();

            if (!s.IsElevated(outputBox))
            {
                MessageBox.Show("You have to run the program as Administrator.");
                Environment.Exit(0);
            }
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void VlcInstallationPathBox_TextChanged(object sender, EventArgs e)
        {
            UpdateLibaacsPath(VlcInstallationPathBox.Text);
        }

        private void UpdateLibaacsPath(string input)
        {
            libaacsPath = input;
            VlcInstallationPathBox.Text = libaacsPath;
        }
        

        private void SelectDirectory_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderBrowserDialog1.InitialDirectory = libaacsPath;
                UpdateLibaacsPath(folderBrowserDialog1.SelectedPath);
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var s = new Statics();
            try
            {
                s.Run(outputBox, libaacsPath);
                ButtonStart.Enabled = false;
                ButtonFinish.Enabled = true;
            }
            catch (Exception exception)
            {
                outputBox.Text += exception.Message + "\n";
                outputBox.Text += "------------------------------------------------------------\n";
            }
        }
    }
}