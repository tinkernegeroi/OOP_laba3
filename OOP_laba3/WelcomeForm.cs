namespace OOP_laba3;

public partial class WelcomeForm : Form
{
    public WelcomeForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.Hide();
        using (MainForm form = new MainForm())
        {
            form.ShowDialog();
        }
        this.Show();
            
    }
}