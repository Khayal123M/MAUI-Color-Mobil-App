using System.Diagnostics;

namespace Net_MAUI_Color_Mobil_App
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var red = sldRed.Value;  
            var green = sldGreen.Value;
            var blue = sldBlue.Value;

            Color color = Color.FromRgb(red, green, blue);        

            SetColor(color);  
        }

        private void SetColor(Color color)
        {
            Debug.WriteLine(color.ToString());
            btnRandom.Background = color; 
            Container.BackgroundColor = color; 
            lblHex1.Text = color.ToHex(); 
        }

        private void btn_Random_Clicked(object sender, EventArgs e)  
        {
            var random = new Random(); 
            var color = Color.FromRgb(  
                random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0, 256));

            SetColor(color);     

            sldRed.Value = color.Red;      
            sldGreen.Value = color.Green;
            sldBlue.Value = color.Blue;
        }







    }
}