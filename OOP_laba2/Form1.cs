namespace OOP_laba2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.Hide();
        using (Form2 form = new Form2())
        {
            form.ShowDialog();
        }
        this.Show();
            
    }
}