using MaterialSkin;
using MaterialSkin.Controls;

namespace tool_box
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void GetLocalIpAddreass_Click(object sender, EventArgs e)
        {
            Form localIpAddressForm = new LocalIPAddressForm();
            localIpAddressForm.ShowDialog();

        }
    }
}