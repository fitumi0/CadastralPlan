using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace CadastralPlan
{
    public partial class MainForm : Form
    {
        private XDocument _xmlDoc = new XDocument();
        private Dictionary<string, string> _rootElements = new Dictionary<string, string>
        {
            {"land_records", "Parcels"},
            {"build_records", "ObjectReality"},
            {"construction_record", "ObjectReality" },
            {"spatial_data", "SpatialData"},
            {"municipal_boundaries", "Bounds"},
            {"zones_and_territories_record", "Zones"}
        };
        private Dictionary<string, string> _ids = new Dictionary<string, string>
        {
            {"Parcels", "cad_number" },
            {"ObjectReality", "cad_number" },
            {"SpatialData", "sk_id" },
            {"Bounds", "reg_numb_border" },
            {"Zones", "reg_numb_border" },
        };
        private Dictionary<string, List<string>> _nodesToDisplay = new Dictionary<string, List<string>>
        {
            {"Parcels", new List<string>() { "land_record" } },
            {"ObjectReality", new List<string>() {"build_record", "construction_record" } },
            {"SpatialData",  new List<string>() {"entity_spatial" } },
            {"Bounds",  new List<string>() { "municipal_boundary_record"} },
            {"Zones" , new List < string >() { "b_object_zones_and_territories" } }
        };

        private Dictionary<string, XElement> _childNodesDictionary = new Dictionary<string, XElement>();

        public MainForm()
        {
            InitializeComponent();
        }

        public TreeNode FindNodeByName(TreeNodeCollection nodes, string name)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text == name)
                    return node;

                var found = FindNodeByName(node.Nodes, name);

                if (found != null)
                    return found;
            }

            return null;
        }

        public XmlNode ToXmlNode(XElement element)
        {
            using (var xmlReader = element.CreateReader())
            {
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlReader);
                return xmlDoc;
            }
        }

        private void TraverseNodes(TreeNodeCollection nodes, List<TreeNode> expandedNodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.IsExpanded)
                {
                    expandedNodes.Add(node);
                }

                if (node.Nodes.Count > 0)
                {
                    TraverseNodes(node.Nodes, expandedNodes);
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "xml files (*.xml)|*.xml";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    var fileStream = openFileDialog.OpenFile();

                    using (var reader = new StreamReader(fileStream))
                    {
                        _xmlDoc = XDocument.Load(reader);
                    }
                }
            }

            mainTree.Nodes.Clear();

            // Проход по корневым элементам
            foreach (var root in _rootElements)
            {
                // Поиск значений, являющихся ключами dict _rootElements
                foreach (var element in _xmlDoc.Descendants(root.Key))
                {         
                    var search = FindNodeByName(mainTree.Nodes, root.Value);
                    var node = search ?? new TreeNode(root.Value);

                    if (!mainTree.Nodes.Contains(node)) mainTree.Nodes.Add(node);

                    _nodesToDisplay[root.Value].ForEach(v =>
                    {
                        foreach (var item in element.Descendants(v))
                        {
                            var key = item.Descendants(_ids[root.Value]).First().Value;
                            var elementNode = new TreeNode(key);

                            if (!_childNodesDictionary.ContainsKey(key))
                            {
                                _childNodesDictionary.Add(key, item);
                            }

                            node.Nodes.Add(elementNode);
                        };
                    });
                }
            }
        }

        private void mainTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (mainTree.SelectedNode != null && mainTree.SelectedNode.Parent != null)
            {
                var previewForm =
                    new PreviewXmlForm(
                        ToXmlNode(_childNodesDictionary[mainTree.SelectedNode.Text])
                    );
                previewForm.ShowDialog();
            }

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var expandedNodes = new List<TreeNode>();
            TraverseNodes(mainTree.Nodes, expandedNodes);

            using (var saveFileDialog = new SaveFileDialog()) 
            {
                saveFileDialog.Filter = "xml files (*.xml)|*.xml";
                saveFileDialog.FileName = "Untitled";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XDocument xdoc = new XDocument();
                    XElement root = new XElement("SavedExpandedNodes");
                    xdoc.Add(root);
                    foreach (var node in expandedNodes)
                    {
                        foreach (TreeNode item in node.Nodes)
                        {
                            XElement temp;
                            _childNodesDictionary.TryGetValue(item.Text, out temp);
                            root.Add(temp);
                        }
                    }

                    xdoc.Save(saveFileDialog.FileName);
                }
            }
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
