

using SqlSugar;

namespace tool_box
{
    [SugarTable("GeneratorCodeTemplateEntity")]
    internal class GeneratorCodeTemplateEntity
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public int? SchoolId { get; set; }
        public string Name { get; set; }

        /*        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
                private long id;

                private string name;

                private string type;

                private string description;

                private string templateType;

                private string templatePackage;

                private string objectName;

                private string category;

                public int GeneratorCodeTemplateEntityProperties { get; set; }
                public long Id { get => id; set => id = value; }*/
    }
}
