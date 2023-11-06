using System.Diagnostics;
using System.Net.Http;

namespace Concurrency
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();
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
        
            int colMatA = 1080;
            int rowMatA = 1000;
            int colMatB = 750;

            var matA = MatrixUtilities.InitializeMatrix(rowMatA, colMatA);
            var matB = MatrixUtilities.InitializeMatrix(colMatA, colMatB);
            sw.Start();
            await Task.Run(() =>
            {
                MatrixUtilities.MultiplyMatricesSequentally(matA, matB);
            });



            sw.Stop();
            loadingGIF.Visible = false;
            var message = $"The program took {sw.ElapsedMilliseconds / 1000.0} seconds to finish.";
            await Console.Out.WriteLineAsync(message);
            sw.Reset();
            sw.Start();
            await Task.Run(() =>
            {
                MatrixUtilities.MultiplyMatricesInParallel(matA, matB);
            });
            sw.Stop();
            var message2 = $"The program took {sw.ElapsedMilliseconds / 1000.0} seconds to finish.";
            await Console.Out.WriteLineAsync(message2);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        static List<CustomImage> GetImages()
        {
            var images = new List<CustomImage>();
            for (int i = 0; i < 7; i++)
            {
                images.Add( new() { Title = $"skyline_{i}.jpg", URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/71/Nakanoshima_Skyscrapers_in_201504_001.jpg/800px-Nakanoshima_Skyscrapers_in_201504_001.jpg" });
                images.Add(new() { Title = $"Gate_{i}.jpg", URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Itsukushima_Shrine_Torii_Gate_%2813890465459%29.jpg/800px-Itsukushima_Shrine_Torii_Gate_%2813890465459%29.jpg" });
                images.Add(new() { Title = $"Shop_{i}.jpg", URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/150504_Ritsurin_Park_Takamatsu_Kagawa_pref_Japan01s3.jpg/800px-150504_Ritsurin_Park_Takamatsu_Kagawa_pref_Japan01s3.jpg" });
            }
            return images;
        }
        private async Task ProcessImage(string directory, CustomImage image)
        {
            var response = await client.GetAsync(image.URL);
            var content = await response.Content.ReadAsByteArrayAsync();

            Bitmap bitmap;
            using (var ms = new MemoryStream(content))
            {
                bitmap = new Bitmap(ms);
            }

            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            var destination = Path.Combine(directory, image.Title);
            bitmap.Save(destination);
        }
        private void PrepareExecution(string destinationInParallel,string destinationInSequence)
        {
            if (!Directory.Exists(destinationInParallel))
            {
                Directory.CreateDirectory(destinationInParallel);
            }

            if (!Directory.Exists(destinationInSequence))
            {
                Directory.CreateDirectory(destinationInSequence);
            }

            DeleteFiles(destinationInSequence);
            DeleteFiles(destinationInParallel);
        }

        void DeleteFiles(string dictoryName)
        {
            var file = Directory.EnumerateFiles(dictoryName);
            foreach (var image in file)
            {
                File.Delete(image);
            }
        }
    }

}

//private async void beginBtn_Click(object sender, EventArgs e)
//{
//    loadingGIF.Visible = true;
//    var sw = new Stopwatch();

//    sw.Start();
//    var tasks = new List<Task>()
//            {
//                DoSomeLongProcessingA(),
//                DoSomeLongProcessingB(),
//                DoSomeLongProcessingC()
//            };
//    await Task.WhenAll(tasks);
//    sw.Stop();
//    loadingGIF.Visible = false;
//    var message = $"The program took {sw.ElapsedMilliseconds / 1000.0} seconds to finish.";
//    await Console.Out.WriteLineAsync(message);

//}
//async Task DoSomeLongProcessingA()
//{
//    await Task.Delay(1000);
//    await Console.Out.WriteLineAsync("Process A finished");
//}
//async Task DoSomeLongProcessingB()
//{
//    await Task.Delay(1000);
//    await Console.Out.WriteLineAsync("Process B finished");

//}
//async Task DoSomeLongProcessingC()
//{
//    await Task.Delay(1000);
//    await Console.Out.WriteLineAsync("Process C finished");
//}

//async Task<string> GetName()
//{
//    await Task.Delay(1000);
//    return "Uli";
//}

//================================
//private async void beginBtn_Click(object sender, EventArgs e)
//{
//    loadingGIF.Visible = true;
//    var sw = new Stopwatch();
//    var currentDic = AppDomain.CurrentDomain.BaseDirectory;
//    var destSeq = Path.Combine(currentDic, @"images\seq");
//    var destParallel = Path.Combine(currentDic, @"images\par");

//    PrepareExecution(destParallel, destSeq);
//    var images = GetImages();
//    sw.Start();

//    //sequential 
//    foreach (var image in images)
//    {
//        await ProcessImage(destSeq, image);
//    }
//    await Console.Out.WriteLineAsync($"Seq took {sw.ElapsedMilliseconds / 1000.0} seconds to finish.");
//    sw.Reset();
//    sw.Start();

//    var tasks = images.Select(async image =>
//    {
//        await ProcessImage(destParallel, image);
//    });

//    await Task.WhenAll(tasks);
//    await Console.Out.WriteLineAsync($"Parallel took {sw.ElapsedMilliseconds / 1000.0} seconds to finish.");


//    sw.Stop();
//    loadingGIF.Visible = false;
//    //var message = $"The program took {sw.ElapsedMilliseconds / 1000.0} seconds to finish.";
//    //await Console.Out.WriteLineAsync(message);

//}