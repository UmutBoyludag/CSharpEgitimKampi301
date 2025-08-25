using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAverageCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
            lblAvarageLocationPrice.Text = db.Location.Average(x => x.Price).ToString() + "₺";
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();
            lblCappadociaTourCapacity.Text = db.Location.Where(x => x.LocationId == 1).Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTurkeyCapatiyAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();
            var RomeGuideId = db.Location.Where(x => x.City == "Roma Turistlik").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == RomeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();
            var maxPrice = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();
            var GuideIdByAyse=db.Guide.Where(x => x.GuideName == "Ayşegül").Select(y => y.GuideId).FirstOrDefault();
            lblAyseTourCount.Text = db.Location.Where(x => x.GuideId == GuideIdByAyse).Count().ToString();
        }
    }
}
