using MaterialSkin;
using MaterialSkin.Controls;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tool_box
{
    public partial class CodeGeneratorForm : MaterialForm
    {
        public CodeGeneratorForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            SqlSugarScope sqlClient = DBUtils.sqlClient;
            
            GeneratorCodeTemplateEntity generatorCodeTemplateEntity = new GeneratorCodeTemplateEntity();
            generatorCodeTemplateEntity.Id = 1;
            generatorCodeTemplateEntity.SchoolId = 1;
            generatorCodeTemplateEntity.Name = "lyra";


            DBUtils.CheckAndCreateTable<GeneratorCodeTemplateEntity>(sqlClient, "GeneratorCodeTemplateEntity");

            sqlClient.Insertable(generatorCodeTemplateEntity).ExecuteCommand();
        }
    }
}
