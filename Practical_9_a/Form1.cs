namespace Practical_9_a
{
    public partial class Form1 : Form
    {
        int i = 0;
        int total =0;

        public Form1()
        {
            InitializeComponent();
        }

        private void add_items(string name, int p)
        {
            ListViewItem l = new ListViewItem(name);
            l.SubItems.Add(p.ToString());
            listView1.Items.Add(l);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //listView1.Items.Add("Chiniese");
            //listView1.Items[0].Text = "Chiniese";
            //Manually By Code
             string[] x=new string[15];
            //int[] pr=new int[15];
            // x[7] = "Punjabi";
            // x[8] = "Momos Chi";
            // x[9] = "Noodle";
            // pr[7] = 300;
            // pr[8] = 250;
            // pr[9] = 300;

            //for(int i = 0; i < 15; i++)
            //{
            //    add_items(x[i], pr[i]); 
            //}

            listView2.Columns.Add("Quantity");
            listView2.View = View.Details;
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
            int p;
            int q;

            //string item=listView1.SelectedItems[1].Text;

            //p=int.Parse(numericUpDown1.Value.ToString());
            //q = int.Parse(numericUpDown1.Value.ToString());
            //p =int.Parse(listView1.SelectedItems[0].SubItems.ToString());
            string iname;
           
                iname = listView1.SelectedItems[0].Text;
                p = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
                q = int.Parse(numericUpDown1.Text);

                listView2.Items.Add(iname);
                listView2.Items[i].SubItems.Add(p.ToString());
                listView2.Items[i].SubItems.Add(q.ToString());
                i++;
                p = p * q;
                total = total + p;
                label2.Text = total.ToString();
                label2.Visible = true;
                label1.Visible = true;
                label3.Visible = true;
                //price = price * quantity;
                //label3.Text=price.ToString();
                //listView1.Items.Add((string)label3.Text); 
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total = 0;
            int i = 0;
            
                int cost = Convert.ToInt32(listView2.SelectedItems[0].SubItems[1].Text);
                int q = Convert.ToInt32(listView2.SelectedItems[0].SubItems[2].Text);
                int cancelitem_total = cost * q;
                total = total - cancelitem_total;
                //total = total -
                Convert.ToInt32(listView2.SelectedItems[0].SubItems[1].Text);
                listView2.Items.Remove(listView2.SelectedItems[0]);
                label2.Text = total.ToString();
                i--;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            label2.Text = "";

        }
    }
}