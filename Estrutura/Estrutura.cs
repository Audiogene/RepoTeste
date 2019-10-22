using System;

namespace ABS_Tela1
{
    public class Estrutura
    {
        public String TitleStructure { get; set; }
        public int IDstructure { get; set; }

        public override String ToString()
        {
            return "ID: " + IDstructure + ";" + "   Name: " + TitleStructure;
        }
    }
}
