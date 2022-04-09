namespace Practical_9_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Add("Chiniese");
            //listView1.Items[0].Text = "Chiniese";
            //Manually By Code
            string[] x=new string[15];
            listView1.Items[0].Text=x[0];   
            x[7] = "Punjabi";
            x[8] = "Momos Chi";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int quantity;
            int price;
            //string item=listView1.SelectedItems[1].Text;
            quantity=int.Parse(numericUpDown1.Value.ToString());
            price=int.Parse(numericUpDown1.Value.ToString());   
            price=int.Parse(listView1.SelectedItems[0].SubItems.ToString());

            price = price * quantity;
            //label3.Text=price.ToString();
            listView1.Items.Add((string)label3.Text); 
            
            


            
            

        }
    }
}