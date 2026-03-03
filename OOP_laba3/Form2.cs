using OOP_laba3.classes;
using OOP_laba3.services;
using OOP_laba3.utils;

namespace OOP_laba3;

public partial class Form2 : Form
{
    private AirportCollection _list;
    
    private ListEventListener _listener;
    public Form2()
    {
        InitializeComponent();
        _list = new AirportCollection();
        _listener = new ListEventListener(_list, textBox_Actions);
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
    
    private void RefreshObjectGrid()
    {
        dataGridView1.Rows.Clear();

        foreach ( Airport airport in _list.List)
        {
            int index = _list.List.IndexOf(airport);
            
            dataGridView1.Rows.Add(
                index,
                airport.Name,
                airport.Location,
                airport.FlightsPerDay,
                airport.TicketsSold,
                airport.Balance,
                airport.Rating,
                airport.EmployeesCount
            );
        }
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

    private void button_CreateObj_Click(object sender, EventArgs e)
    {
        try
        {
            _list.AddRandomItem();
            RefreshObjectGrid();
        }
        catch (Exception exception)
        {
            NativeMessageBox.MessageBox(
                0,
                exception.Message,
                "Ошибка",
                NativeMessageBox.MB_OK | NativeMessageBox.MB_ICONERROR
            );
        }
    }

    private void button_DeleteObj_Click(object sender, EventArgs e)
    {
        try
        {
            int index = (int)numericUpDown_Obj.Value;
            _list.Remove(index);
            RefreshObjectGrid();
        }
        catch (Exception exception)
        {
            NativeMessageBox.MessageBox(
                0,
                exception.Message,
                "Ошибка",
                NativeMessageBox.MB_OK | NativeMessageBox.MB_ICONERROR
            );
        }
    }
}