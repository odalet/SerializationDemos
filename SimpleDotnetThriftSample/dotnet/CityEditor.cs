using System.Windows.Forms;
using Delta.Commons.Thrift;

namespace ThriftSample
{
    public partial class CityEditor : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CityEditor"/> class.
        /// </summary>
        public CityEditor()
        {
            InitializeComponent();
        }

        internal void Clear() 
        {
            idBox.Value = 0M;
            nameBox.Text = string.Empty;
            ccBox.Text = string.Empty;
            isEnabledBox.Checked = false;
            displayOrderBox.Value = 0M;
        }

        internal void Load(City city)
        {
            idBox.Value = city.__isset.id ? (decimal)city.Id : 0M;
            nameBox.Text = city.Name;
            ccBox.Text = city.CountryCode;
            isEnabledBox.Checked = city.Enabled;
            displayOrderBox.Value = (decimal)city.DisplayOrder;
        }

        internal City Save()
        {
            var city = new City();

            if (idBox.Value > 0M)
                city.Id = (long)idBox.Value;
            city.Name = nameBox.Text ?? string.Empty;
            city.CountryCode = ccBox.Text ?? string.Empty;
            city.Enabled = isEnabledBox.Checked;
            city.DisplayOrder = (int)displayOrderBox.Value;

            return city;
        }
    }
}
