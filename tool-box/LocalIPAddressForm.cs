using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.Net.NetworkInformation;


namespace tool_box
{
    public partial class LocalIPAddressForm : MaterialForm
    {
        public LocalIPAddressForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            InitializeComponent();
        }

        private void LocalIPAddressForm_Load(object sender, EventArgs e)
        {
            int x = 15;
            int y = 69;

            foreach (var item in IP.getLocalIp())
            {
                Label label = new MaterialLabel();
                label.Location = new Point(x, y);

                label.Text = item;

                this.Controls.Add(label);
                label.Click += LabelClick;

            }
        }

        private void LabelClick(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Clipboard.SetDataObject(label.Text);
            MaterialMessageBox.Show("复制成功", false);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PingButton_Click(object sender, EventArgs e)
        {
            var ipTextBox = this.Controls.Find("IpTextBox", false);

            foreach (var item in ipTextBox)
            {
                var process = new Process();
                process.StartInfo.FileName = "telnet";
                process.StartInfo.Arguments = "ping" + item.Text;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                process.BeginOutputReadLine();
            }
        }
    }
}
