using System;
using System.IO; //StreamReader
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;//Xml
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HRWatch.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalData : ContentPage
    {
        public PersonalData()
        {
            InitializeComponent();
        }
        public void readPersonXml(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            var file = ("content://com.android.providers.media.document/document/document%3A39");
            using (StreamReader rd = new StreamReader(file))
            {
                Person p = xs.Deserialize(rd) as Person;
                Button bouton = (Button)sender;
                bouton.Text = p.FirstName;
                //Console.WriteLine("Id : {0}", p.Id);
                //Console.WriteLine("Nom : {0} {1}", p.FirstName, p.LastName);

            }
        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}