using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Using Microcharts

//Using Microcharts
using Microcharts;
//Especificar que los entrys son los del nuget
using Entry = Microcharts.Entry;
//Using a SkiaSharp para los colores de los gráficos
using SkiaSharp;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microcharts.Forms;

namespace EasyWalletAdmin.View
{


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        List<Entry> entryList;
        List<Entry> entryListP;
        public HomePage()
        {
            InitializeComponent();
            entryList = new List<Entry>();

            entryListP = new List<Entry>();


            //Cargar nuesta lista de entries;
            LoadEntries();
           

          
            //Asignar los datos dentro de los entrys a los gráficos dentro de la vista XAML
            linesChart.Chart = new LineChart()
            {
                Entries = entryList
            };
            LoadEntriesP();
            linesChart.Chart = new LineChart()
            {
                Entries = entryList
            };


            

        }
        async void GoInv_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new InventarioPage());
        async void GoPe_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new PedidoPage());

        private void LoadEntries()
        {
            Entry e1 = new Entry(70)
            {
                Label = "A",
                ValueLabel = "70",
                Color = SKColor.Parse("#00bcd4")
            };
            Entry e2 = new Entry(300)
            {
                Label = "B",
                ValueLabel = "300",
                Color = SKColor.Parse("#F44336")
            };
            Entry e3 = new Entry(50)
            {
                Label = "C",
                ValueLabel = "50",
                Color = SKColor.Parse("#43A047")
            };
            Entry e4 = new Entry(500)
            {
                Label = "D",
                ValueLabel = "500",
                Color = SKColor.Parse("#F9A825")
            };
            entryList.Add(e1);
            entryList.Add(e2);
            entryList.Add(e3);
            entryList.Add(e4);
        }

        private void LoadEntriesP()
        {
            Entry e1 = new Entry(70)
            {
                Label = "A",
                ValueLabel = "70",
                Color = SKColor.Parse("#00bcd4")
            };
            Entry e2 = new Entry(300)
            {
                Label = "B",
                ValueLabel = "300",
                Color = SKColor.Parse("#F44336")
            };
            Entry e3 = new Entry(50)
            {
                Label = "C",
                ValueLabel = "50",
                Color = SKColor.Parse("#43A047")
            };
            Entry e4 = new Entry(500)
            {
                Label = "D",
                ValueLabel = "500",
                Color = SKColor.Parse("#F9A825")
            };
            entryListP.Add(e1);
            entryListP.Add(e2);
            entryListP.Add(e3);
            entryListP.Add(e4);
        }
    }
}