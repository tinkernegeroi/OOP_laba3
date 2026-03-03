namespace OOP_laba2;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
    }
    private void button_Back_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button_Exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}