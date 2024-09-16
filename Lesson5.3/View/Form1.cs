using Lesson5._3.Model;

namespace Lesson5._3.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
           // person.Move();
            Human human = new Human("Василий");
           // MessageBox.Show(human.Name);
            human.Name = "Boris";
            MessageBox.Show(human.Name);
        }
        
    }
}
