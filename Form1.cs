using LinQDemo.EFDbFirst;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LinQDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataService dataService = new DataService();
            // Linq sorgusunu çalıştır
            List<ResultViewModel> results = dataService.GetPivotedData();

            // Sonuçları DataGridView'e bastır
            dataGridView1.DataSource = PivotData(results);
        }
        private List<PivotViewModel> PivotData(List<ResultViewModel> data)
        {
            // "PIVOT" işlemini burada gerçekleştiriyoruz
            var pivotData = data
                .GroupBy(d => d.OrderYear)
                .Select(g => new PivotViewModel
                {
                    OrderYear = g.Key,
                    WaterBottle = g.FirstOrDefault(x => x.ProductName == "Water Bottle - 30 oz.")?.TotalOrders ?? 0,
                    PatchKit = g.FirstOrDefault(x => x.ProductName == "Patch Kit/8 Patches")?.TotalOrders ?? 0,
                    MountainTireTube = g.FirstOrDefault(x => x.ProductName == "Mountain Tire Tube")?.TotalOrders ?? 0,
                    RoadTireTube = g.FirstOrDefault(x => x.ProductName == "Road Tire Tube")?.TotalOrders ?? 0,
                    Sport100HelmetRed = g.FirstOrDefault(x => x.ProductName == "Sport-100 Helmet, Red")?.TotalOrders ?? 0
                })
                .ToList();

            return pivotData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new AdventureWorksDW2022Entities())
            {
                
            }
        }
    }

    // Enum for Product Names
    public enum ProductNameEnum
    {
        WaterBottle,
        PatchKit,
        MountainTireTube,
        RoadTireTube,
        Sport100HelmetRed
    }

    // ViewModel for Pivot Data
    public class PivotViewModel
    {
        public int OrderYear { get; set; }
        public int WaterBottle { get; set; }
        public int PatchKit { get; set; }
        public int MountainTireTube { get; set; }
        public int RoadTireTube { get; set; }
        public int Sport100HelmetRed { get; set; }
    }
}
