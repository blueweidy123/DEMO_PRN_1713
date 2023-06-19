using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pt2
{
    public class Word
    {
        public string WID { get; set; }
        public string WordContent { get; set; }
        public string Meaning { get; set; }
        public string EDate { get; set; }
        public string TypeName { get; set; }

        public Word()
        {
            
        }

        public Word(string wID, string wordContent, string meaning, string eDate, string typeName)
        {
            WID = wID;
            WordContent = wordContent;
            Meaning = meaning;
            EDate = eDate;
            TypeName = typeName;
        }
    }
}
