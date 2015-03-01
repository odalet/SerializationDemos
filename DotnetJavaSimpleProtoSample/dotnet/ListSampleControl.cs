using System;
using System.Windows.Forms;
using Delta.Commons.Proto;

namespace ProtoSample
{
    public partial class ListSampleControl : UserControl
    {
        private CityCollection collection = null;

        public ListSampleControl()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            var builder = CityCollection.CreateBuilder();
            builder.ItemsList.Add(MakeCity(1, "Paris", "FRA", true, 0));
            builder.ItemsList.Add(MakeCity(2, "Lyon", "FRA", true, 0));
            builder.ItemsList.Add(MakeCity(null, "Marseille", "FRA", true, 0));

            collection = builder.Build();
            logbox.AppendText(string.Format("Collection Size: {0}\r\n", collection.ItemsCount));
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            logbox.Clear();
        }

        private City MakeCity(long? id, string name, string ccode, bool enabled, int display)
        {
            var builder = City.CreateBuilder();

            if (!id.HasValue)
                builder.ClearId();
            else builder.Id = id.Value;

            builder.SetName(name).SetCountryCode(ccode).SetEnabled(enabled).SetDisplayOrder(display);
            
            return builder.Build();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (collection == null)
            {
                logbox.AppendText("Collection is null!\r\n");
                return;
            }

            foreach (var item in collection.ItemsList)
                logbox.AppendText(item.ToString() + "\r\n");
        }
    }
}

