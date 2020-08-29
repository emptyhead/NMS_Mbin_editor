using libMBIN;
using libMBIN.NMS.GameComponents;
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
        ExtendedNmsTemplate currentTemplate;

        // Need a list of all the Templates loaded into the form
        List<ExtendedNmsTemplate> loadedTemplates = new List<ExtendedNmsTemplate>();

        public static string unpackedNMSFilePath = @"D:\nmsModding\unpacked";

        //Dictionary<TreeNode, Mbin> dict_loadedMbins = new Dictionary<TreeNode, Mbin>();

        public Form1()
        {
            InitializeComponent();
        }

        private void trv_Mbins_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            // get all files dropped as strings to path into array

            currentTemplate = new ExtendedNmsTemplate(droppedFiles[0]);
            // create a new instance of my MBIN object
            // it loads the correct mbin into itself

            currentTemplate.PopulateTreeView(trv_Mbins);
            loadedTemplates.Add(currentTemplate);
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

            MyTreeNode selectedNode = (MyTreeNode)e.Node;

            string messageString = "";

            if (selectedNode.isRootNode)
            {
                messageString += "This is an NMSTemplate of type: " + selectedNode.associatedTemplate.baseTemplate.GetType() +
                    "\nIt's path is: " + selectedNode.associatedTemplate.mbinPath;
            }
            else if (!selectedNode.isRootNode)
            {
                messageString += "This node is just a field which points to: " + selectedNode.fieldInfo +
                    "\nIt is part of the NMSTemplate: " + selectedNode.associatedTemplate.baseTemplate.GetType() +
                    "\nWhich is on your PC here: " + selectedNode.associatedTemplate.mbinPath;
            }

            //MessageBox.Show(messageString);

            // if selected node associated template isn't the current template
            // then set current template to be the selected one
            if (selectedNode.associatedTemplate != currentTemplate)
            {
                currentTemplate = selectedNode.associatedTemplate;
            }

            // update the information labels
            lbl_libMBINType.Text = "<NO INFO>";
            lbl_MbinRelativePath.Text = "<NO INFO>";
            lbl_VarName.Text = "<NO INFO>";
            lbl_varType.Text = "<NO INFO>";

            lbl_MbinRelativePath.Text = currentTemplate.GetRelativePath(currentTemplate.mbinPath);

            if(selectedNode.isRootNode)
            {
                lbl_libMBINType.Text = selectedNode.associatedTemplate.baseTemplate.GetType().ToString();
            }
            else
            {
                lbl_libMBINType.Text = selectedNode.associatedTemplate.baseTemplate.GetType().ToString();
                lbl_VarName.Text = selectedNode.fieldInfo.Name;
                lbl_varType.Text = selectedNode.fieldInfo.GetValue(currentTemplate.baseTemplate).GetType().ToString();
                
                // the following branch works to display values, but...
                // some arrays have names and values and using this method just shows a bunch of numbers
                // they're arrays because they don't declare themselves as internal xml structs such as colours.xml
                if(selectedNode.fieldInfo.GetValue(currentTemplate.baseTemplate).GetType().IsArray)
                {
                    string messageText = "";
                    Array array = (Array)selectedNode.fieldInfo.GetValue(currentTemplate.baseTemplate); // getting the values from the array

                    // try to use getAttribute
                    // get property info
                    

                    Console.WriteLine("Value of node>>field is: "+selectedNode.fieldInfo.GetValue(currentTemplate.baseTemplate));
                    Console.WriteLine("Name of fieldInfo is: "+ selectedNode.fieldInfo.Name);
                    Console.WriteLine("Reflected type is: "+selectedNode.fieldInfo.ReflectedType);
                    
                    Console.WriteLine("Just NMSAttribute[] i think: " + selectedNode.fieldInfo.ReflectedType.GetField(selectedNode.fieldInfo.Name).GetCustomAttributes(typeof(NMSAttribute), false));
                    NMSAttribute[] nmsAttributes = (NMSAttribute[])selectedNode.fieldInfo.ReflectedType.GetField(selectedNode.fieldInfo.Name).GetCustomAttributes(typeof(NMSAttribute),false);

                    Console.WriteLine("Length of array: "+nmsAttributes.Length);
                    
                    
                    if (nmsAttributes.Length>0)
                    {
                        Console.WriteLine("NMSAttributes.Size: " + nmsAttributes[0].Size);
                        Console.WriteLine("NMSAttributes.Alignment: " + nmsAttributes[0].Alignment);
                        Console.WriteLine("NMSAttributes.Broken: " + nmsAttributes[0].Broken);
                        Console.WriteLine("NMSAttributes.DefaultValue: " + nmsAttributes[0].DefaultValue);
                        Console.WriteLine("NMSAttributes.EnumType: " + nmsAttributes[0].EnumType);
                        //Console.WriteLine(nmsAttributes[0].EnumValue);
                        Console.WriteLine("NMSAttributes.GUID: " + nmsAttributes[0].GUID);
                        Console.WriteLine("NMSAttributes.IDFIeld: " + nmsAttributes[0].IDField);
                        Console.WriteLine("NMSAttributes.Ignore: " + nmsAttributes[0].Ignore);
                        Console.WriteLine("NMSAttributes.NAmeHash: " + nmsAttributes[0].NameHash);
                        Console.WriteLine("NMSAttributes.Padding: " + nmsAttributes[0].Padding);
                        Console.WriteLine("NMSAttributes.TypeID: " + nmsAttributes[0].TypeId);

                    }
                    

                    foreach (var arrayItem in array)
                    {
                        messageText += array.Length + " " + arrayItem + "\r\n";
                    }

                    txtB_values.Text = messageText;
                }
                else
                {
                    txtB_values.Text = selectedNode.fieldInfo.GetValue(currentTemplate.baseTemplate).ToString();
                }
                
            }

            /*
            if (!currentTemplate.dict_nodeToField.ContainsKey(e.Node))
            {
                foreach (TreeNode treeNode in dict_loadedMbins.Keys)
                {
                    if (dict_loadedMbins[treeNode].dict_nodeToField.ContainsKey(e.Node))
                    {
                        currentTemplate = dict_loadedMbins[treeNode];
                        
                    }
                }
            }
            lbl_MbinRelativePath.Text = currentTemplate.mbinPath;
            lbl_VarName.Text = currentTemplate.GetFieldName(currentTemplate.GetAssociatedFieldFromNode(e.Node));
            lbl_varType.Text = currentTemplate.GetFieldType(currentTemplate.GetAssociatedFieldFromNode(e.Node)).ToString();
            */
        }
    }
}
