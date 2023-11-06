using System.Diagnostics;

namespace Concurrency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void beginBtn_Click(object sender, EventArgs e)
        {
            loadingGIF.Visible = true;
            var sw = new Stopwatch();

            sw.Start();
            var tasks = new List<Task>()
            {
                DoSomeLongProcessingA(),
                DoSomeLongProcessingB(),
                DoSomeLongProcessingC()
            };
             await Task.WhenAll(tasks); 
            sw.Stop();
            loadingGIF.Visible = false;
            var message = $"The program took {sw.ElapsedMilliseconds / 1000.0} seconds to finish.";
            await Console.Out.WriteLineAsync(message);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        async Task DoSomeLongProcessingA()
        {
            await Task.Delay(1000);
            await Console.Out.WriteLineAsync("Process A finished");
        }
        async Task DoSomeLongProcessingB()
        {
            await Task.Delay(1000);
            await Console.Out.WriteLineAsync("Process B finished");

        }
        async Task DoSomeLongProcessingC()
        {
            await Task.Delay(1000);
            await Console.Out.WriteLineAsync("Process C finished");
        }

        async Task<string> GetName()
        {
            await Task.Delay(1000);
            return "Uli";
        }
    }
}