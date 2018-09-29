using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingList_Demo
{
    public partial class MainForm : Form
    {
        private readonly BindingList<Person> _people;
        public MainForm()
        {
            InitializeComponent();
            _people = new BindingList<Person>(DataSource.GetPeople().ToList());
            
            NameComboBox.DataSource = _people;
            _people.AddingNew += _people_AddingNew;
        }

        private void _people_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = CreatePerson();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //_people.Add(CreatePerson());

            var person = _people.AddNew();

            if (person.FirstName.Contains("7"))
            {
                _people.CancelNew(_people.IndexOf(person));
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var item = (Person)NameComboBox.SelectedItem;

            _people.Remove(item);
        }

        private Person CreatePerson()
        {
            var count = NameComboBox.Items.Count;

            return new Person
            {
                FirstName = $"John{count}",
                LastName = $"Doe{count}"
            };
        }
    }
}
