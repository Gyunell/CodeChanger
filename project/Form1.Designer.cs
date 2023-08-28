namespace project;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 500);
        this.Text = "Form1";
        
        label1=new Label();
        label1.Location=new Point(145,40);
        label1.Name="label1";
        label1.ForeColor=Color.Black;
        label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Width = 570;
        label1.Height = 30;
        label1.Text="(Hello world) code in four programming languages";
        this.Controls.Add(label1);


        comboBox1=new ComboBox();
        comboBox1.Location=new Point(150,100);
        comboBox1.Name="comboBox1";
        comboBox1.Items.Add("Javascript");
        comboBox1.Items.Add("Python");
        comboBox1.Items.Add("C#");
        comboBox1.Items.Add("C++");
        comboBox1.Width=350;
        comboBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.Controls.Add(comboBox1);

        button1 = new Button();
        button1.Location = new Point(550,95);
        button1.Name = "button1";
        button1.Width = 130;
        button1.Height = 47;
        button1.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        button1.BackColor = Color.Blue;
        button1.Text = "Search code";
        this.Controls.Add(button1);

        listbox1 = new ListBox();
        listbox1.Location = new Point(150,165);
        listbox1.Name = "listbox1";
        listbox1.Width = 350;
        listbox1.Height = 270;
        listbox1.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.Controls.Add(listbox1);
    }
    private Label label1;
    private ComboBox comboBox1;
    private Button button1;
    private ListBox listbox1;
    #endregion
}
