using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace CadastralPlan
{
    public partial class PreviewXmlForm : Form
    {
        public PreviewXmlForm(XmlNode node)
        {
            InitializeComponent();

            xmlPreviewBox.Text = System.Xml.Linq.XDocument.Parse(node.OuterXml).ToString();
        }
    }
}
