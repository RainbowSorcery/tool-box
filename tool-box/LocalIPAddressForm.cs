using MaterialSkin;
using MaterialSkin.Controls;
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
            int x = 30;
            int y = 150;

            foreach (var item in IP.getLocalIp())
            {
                Label label = new Label();
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
    }
}
