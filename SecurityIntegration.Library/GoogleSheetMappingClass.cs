using System;
namespace SecurityIntegration.Library
{
    public class GoogleSheetMappingClass
    {
        

        public GoogleSheetMappingClass()
        {
        }

        public string SourceProjectName { get; set; }
        public string SourceUrlPattern { get; set; }
        public string DefectDojoProjectName { get; set; }
        public string Squad { get; set; }
        public string Gerencia { get; set; }
        public string Vertical { get; set; }
        public string Diretoria { get; set; }
        public DateTime DataCadastro { get; set; }


        public Test test { get; set; }
        public Product product { get; set; }
        public Engagement engagement { get; set; }
    }
}
