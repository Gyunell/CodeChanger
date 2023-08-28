namespace project;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        button1.Click += button1_Click;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        listbox1.Items.Clear();
        if (comboBox1.Text == "Javascript")
        {
            listbox1.Items.Add("Console.log (Hello World)");
        }
        else if (comboBox1.Text == "Python")
        {
            listbox1.Items.Add("print('Hello World')");
        }
        else if (comboBox1.Text == "C#")
        {
            listbox1.Items.Add("System.Console.Writeline('Hello World')");
        }
        else if (comboBox1.Text == "C++")
        {
            listbox1.Items.Add("std::count << 'Hello World'");
        }
    }
}
