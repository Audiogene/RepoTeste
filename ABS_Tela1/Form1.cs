
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABS_Tela1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private String TreelastSelected;
      
      

        public Estrutura customerArray = new Estrutura();

        private ContextMenuStrip TreeDocMenu;
        public void updateStruturesTree()
        {
            //Cria no raiz
            //TreeAmbientes.BeginUpdate();
            //TreeAmbientes.Nodes.Clear();
            //TreeAmbientes.Nodes.Add("Home");
            //TreeAmbientes.Nodes[0].NodeFont = new Font(TreeAmbientes.Font, FontStyle.Bold);


            //TreeAmbientes.EndUpdate ();



            //Faz a Leitura da classe e carrega as estruturar e ambientes




            // Create the root node.
            TreeNode HomeNode = new TreeNode("home");

            // Aqui Atualiza as Estruturas.
            HomeNode.Nodes.Add("Estrutura 1");
            HomeNode.Nodes.Add("Estrutura 2");
            HomeNode.Nodes.Add("Estrutura 3");
            // Add the root nodes to the TreeView.
            TreeAmbientes.Nodes.Add(HomeNode);





            // Create the ContextMenuStrip.
            TreeDocMenu = new ContextMenuStrip();

            //Create some menu items.
            ToolStripMenuItem openLabel = new ToolStripMenuItem();
            openLabel.Text = "Open";
            ToolStripMenuItem deleteLabel = new ToolStripMenuItem();
            deleteLabel.Text = "Delete";
            ToolStripMenuItem renameLabel = new ToolStripMenuItem();
            renameLabel.Text = "Rename";

            //Add the menu items to the menu.
            TreeDocMenu.Items.AddRange(new ToolStripMenuItem[]{openLabel,
            deleteLabel, renameLabel});

            // Set the ContextMenuStrip property to the ContextMenuStrip.
            HomeNode.ContextMenuStrip = TreeDocMenu;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            updateStruturesTree();
        }

       
        private void TreeAmbientes_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right && treePatchSelected.Equals ("Home")) // botao direito
            {
                
                TreeDocMenu.Show();
            }
                
           
        }




        String treePatchSelected;
        private void TreeAmbientes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreelastSelected = TreeAmbientes.SelectedNode.Text;
                Console.WriteLine("SelectedNode = " + TreelastSelected);
                Console.WriteLine("Nodes = " + TreeAmbientes.Nodes);
                treePatchSelected = TreeAmbientes.SelectedNode.FullPath;
                Console.WriteLine("Nodes = " + TreeAmbientes.SelectedNode.FullPath);
            }
            catch (System.NullReferenceException) { }
        }
    }
}
