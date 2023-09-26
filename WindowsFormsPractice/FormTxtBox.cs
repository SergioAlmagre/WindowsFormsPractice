using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPractice
{
    public class FormTxtBox
    {
        private string music;
        private string name;
        private string secondName;
        private string password;

        public FormTxtBox(string music, string name, string secondName, string password)
        {
            this.music = music;
            this.name = name;
            this.secondName = secondName;
            this.password = password;
        }

        public FormTxtBox()
        {

        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Music
        {
            get { return music; }
            set { music = value; }
        }



    }
}
