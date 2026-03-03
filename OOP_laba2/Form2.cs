using OOP_laba2.services;

namespace OOP_laba2;

public partial class Form2 : Form
{
    
    public Form2()
    {
        InitializeComponent();
        listView1.View = View.Details;
    }
    private void button_Back_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button_Exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private async void button3_Click(object sender, EventArgs e)
    {
        button_Measure.Enabled = false;
        button_Measure.Text = "Загрузка...";
        listView1.Items.Clear();
        
        var (listResults, arrayResults) = await Task.Run(() =>
        {
            var listResults = new
            {
                Insert = PerformanceMeter.InsertIntoList().ToString(),
                Seq = PerformanceMeter.MeasureListSequentialRead().ToString(),
                Rand = PerformanceMeter.MeasureListRandomRead().ToString()
            };

            var arrayResults = new
            {
                Insert = PerformanceMeter.InsertIntoArray().ToString(),
                Seq = PerformanceMeter.MeasureArraySequentialRead().ToString(),
                Rand = PerformanceMeter.MeasureArrayRandomRead().ToString()
            };

            return (listResults, arrayResults);
        });
        
        ListViewItem itemHash = new ListViewItem("List");
        itemHash.SubItems.AddRange(new[] { listResults.Insert, listResults.Seq, listResults.Rand });
        listView1.Items.Add(itemHash);

        ListViewItem itemArray = new ListViewItem("Array");
        itemArray.SubItems.AddRange(new[] { arrayResults.Insert, arrayResults.Seq, arrayResults.Rand });
        listView1.Items.Add(itemArray);

        button_Measure.Text = "Измерить";
        button_Measure.Enabled = true;
    }
}