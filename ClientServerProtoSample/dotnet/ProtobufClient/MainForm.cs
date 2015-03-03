using System;
using System.Linq;
using System.Windows.Forms;
using Delta.Commons.Proto;
using ProtobufClient.ApiServiceReference;

namespace ProtobufClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void invokeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                using (var client = new ApiClient())
                {
                    var response = client.searchCities(new byte[0]);
                    DecodeResponse(response);
                }
            }
            catch (Exception ex)
            {
                logbox.AppendText("Error while invoking service:\r\n" + ex.ToString() + "\r\n");
            }
            finally { Cursor = Cursors.Default; }
        }

        private void DecodeResponse(byte[] data)
        {
            CityCollection collection = null;
            try
            {
                collection = CityCollection.ParseFrom(data);
            }
            catch (Exception ex)
            {
                logbox.AppendText("Error while deserializing service response:\r\n" + ex.ToString() + "\r\n");
                return;
            }

            var sorted = collection.ItemsList
                .OrderBy(c => c.HasDisplayOrder ? c.DisplayOrder : int.MaxValue)
                .ThenBy(c => c.Id);

            foreach (var city in sorted)
            {
                logbox.AppendText(city.ToString());
            }

            logbox.AppendText("\r\n");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            logbox.Clear();
        }
    }
}
