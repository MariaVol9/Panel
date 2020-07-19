using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbApp.Entities;
using dbApp.API;

namespace WindowsFormsApp4
{
    public partial class AddPerson : UserControl
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void SavePerson_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.id = int.Parse(Id.Text);
            person.name =fname.Text;
            person.family =lname.Text;
            person.age = DateTime.Parse(age.Text);
            person.city = city.Text;




            CustomerAPI customerAPI = new CustomerAPI();
            customerAPI.SaveCustomer(person);
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {

        }

        private void Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
