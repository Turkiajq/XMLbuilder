using System;

namespace XMLBuilder
{
    class XMLBuilder
    {
        private string html;
        int count = 0;

        public XMLBuilder()
        {
            this.html = "";
        }

        public XMLBuilder beginTag(string value)
        {
            for (int i = 0; i < count; i++)
            {
                this.html += "\t";
            }
            this.html += "<" + value + ">" + "\n";
            count++;
            return this;
        }
        public XMLBuilder content(string value)
        {
            for (int i = 0; i < count - 1; i++)
            {
                this.html += "\t";
            }
            this.html += " " + value + " " + "\n";
            return this;
        }
        public XMLBuilder endTag(string value)
        {
            count--;
            for (int i = count; i > 0; i--)
            {
                this.html += "\t";
            }
            this.html += "</" + value + ">" + "\n";
            return this;
        }

        public string get()
        {

            return this.html;
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            XMLBuilder xmlBuilder = new XMLBuilder();
            xmlBuilder.beginTag("departements");
            xmlBuilder.beginTag("departement");
            xmlBuilder.beginTag("IT");
            xmlBuilder.content("software");
            xmlBuilder.endTag("IT");
            xmlBuilder.endTag("departement");
            xmlBuilder.endTag("departements");
            Console.WriteLine(xmlBuilder.get());
        }
    }
}
