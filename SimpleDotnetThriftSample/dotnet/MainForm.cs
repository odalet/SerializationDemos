using System;
using System.IO;
using System.Windows.Forms;
using Delta.Commons.Thrift;
using Thrift.Protocol;
using Thrift.Transport;

namespace ThriftSample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            editor.Clear();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ofd = new OpenFileDialog() { Filter="Thrift serialized files (*.bin)|*.bin|All files|*.*"})
                {
                    if (ofd.ShowDialog(this) == DialogResult.OK)
                    {
                        var bytes = File.ReadAllBytes(ofd.FileName);
                        var city = TMemoryBuffer.DeSerialize<City>(bytes);
                        editor.Load(city);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var city = editor.Save();
                using (var sfd = new SaveFileDialog() { Filter = "Thrift serialized files (*.bin)|*.bin|All files|*.*" })
                {
                    if (sfd.ShowDialog(this) == DialogResult.OK)
                    {
                        var bytes = TMemoryBuffer.Serialize(city);                 
                        File.WriteAllBytes(sfd.FileName, bytes);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
