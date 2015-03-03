using System;
using System.Linq;
using System.Windows.Forms;
using Delta.Commons.Thrift;
using Thrift.Protocol;
using Thrift.Transport;

namespace ThriftClient
{
    public partial class MainForm : Form
    {
        private const int port = 9090;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InvokeThen(Action<CityService.Client> then)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                using (var transport = new TSocket("localhost", port))
                {
                    var protocol = new TBinaryProtocol(transport);
                    var client = new CityService.Client(protocol);
                    transport.Timeout = 100;
                    transport.Open();

                    then(client);
                }
            }
            catch (Exception ex)
            {
                logbox.AppendText("Error while invoking service:\r\n" + ex.ToString() + "\r\n\r\n");
            }
            finally { Cursor = Cursors.Default; }
        }

        private void invokeButton_Click(object sender, EventArgs e)
        {
            InvokeThen(client =>
            {
                var allCities = client.GetAllCities();
                ShowCities(allCities);
            });
        }

        private void getByIdButton_Click(object sender, EventArgs e)
        {
            InvokeThen(client =>
            {
                long id = (long)idUpDown.Value;
                var found = client.GetCity(id);

                if (found == null)
                    logbox.AppendText(string.Format("City with Id {0}: NULL\r\n", id));
                else
                    logbox.AppendText(string.Format("City with Id {0}: {1}\r\n", id, found));

                logbox.AppendText("\r\n");
            });
        }

        private void ShowCities(CityCollection collection)
        {
            var sorted = collection.Items
                .OrderBy(c => c.__isset.displayOrder ? c.DisplayOrder : int.MaxValue)
                .ThenBy(c => c.Id);

            foreach (var city in sorted)
            {
                logbox.AppendText(city.ToString() + "\r\n");
            }

            logbox.AppendText("\r\n");
        }

        private void clearButton_Click(object sender, EventArgs e) { logbox.Clear(); }
    }
}
