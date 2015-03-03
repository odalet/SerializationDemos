using System.Windows.Forms;
using Delta.Commons.Proto;

namespace ProtoSample
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
            idBox.Value = city.HasId ? (decimal)city.Id : 0M;
            nameBox.Text = city.Name;
            ccBox.Text = city.CountryCode;
            isEnabledBox.Checked = city.Enabled;
            displayOrderBox.Value = (decimal)city.DisplayOrder;
        }

        internal City Save()
        {
            var builder = City.CreateBuilder();

            if (idBox.Value <= 0M)
                builder.ClearId();
            else builder.Id = (long)idBox.Value;
            builder.Name = nameBox.Text ?? string.Empty;
            builder.CountryCode = ccBox.Text ?? string.Empty;
            builder.Enabled = isEnabledBox.Checked;
            builder.DisplayOrder = (int)displayOrderBox.Value;

            return builder.Build();
        }
    }
}
