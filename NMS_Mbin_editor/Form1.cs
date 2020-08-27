using libMBIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMS_Mbin_editor
{
    public partial class Form1 : Form
    {
        // var to hold the current MBIN being worked on
        Mbin currentMbin;

        Dictionary<TreeNode, Mbin> dict_loadedMbins = new Dictionary<TreeNode, Mbin>();

        public Form1()
        {
            InitializeComponent();
        }

        private void trv_Mbins_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            // get all files dropped as strings to path into array

            currentMbin = new Mbin(droppedFiles[0]);
            // create a new instance of my MBIN object
            // it loads the correct mbin into itself

            currentMbin.PutFieldsInTreeview(trv_Mbins);
            dict_loadedMbins.Add(currentMbin.rootNode, currentMbin);
        }

        private void trv_Mbins_DragEnter(object sender, DragEventArgs e)
        {
            // need to check that the data being dragged is of a format we want
            // in this case it's dragging a file using the windows shell
            // this is the FileDrop DataFormat
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // don't really understand the effects thing
                // for now .All seems to work
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void trv_Mbins_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // compare if the selected node>>field is in the current mbin
            // if not then go through each loaded mbin
            // foreach loaded mbin: check if e.node>>field is in the loaded mbin
            // when we find the correct one - set it to the current mbin

            if (!currentMbin.dict_nodeToField.ContainsKey(e.Node))
            {
                foreach (TreeNode treeNode in dict_loadedMbins.Keys)
                {
                    if (dict_loadedMbins[treeNode].dict_nodeToField.ContainsKey(e.Node))
                    {
                        currentMbin = dict_loadedMbins[treeNode];
                        
                    }
                }
            }
            lbl_MbinRelativePath.Text = currentMbin.mbinPath;
            lbl_VarName.Text = currentMbin.GetFieldName(currentMbin.GetAssociatedFieldFromNode(e.Node));
            lbl_varType.Text = currentMbin.GetFieldType(currentMbin.GetAssociatedFieldFromNode(e.Node)).ToString();
        }
    }
}
