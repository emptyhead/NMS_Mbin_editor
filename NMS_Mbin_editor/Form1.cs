using libMBIN;
using libMBIN.NMS.GameComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        /*
         * Deals with file being dropped into TreeView
         * gets the filepath as a string
         * sets the active MBIN to the dropped file
         * asks the current MBIN to populate the TreeView with it's data
         * adds itself to the list of loadedTemplates
         */
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

        /*
         * Set up dragEnter being allowed
         * Don't understand why this needs to specifically be set
         * but it does
         */
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

        /*
         * After selecting a Node
         * Check if it's in the currentTemplate, if not change currentTemplate to match correct MBIN
         * Display information about the node:
         *      it's path
         *      if it's a root node
         *      if it's an array
         *          if it is an array does it use an enum
         *              if it does get those values and display them
         *              
         * Yea, in all honesty this method should be broken down into
         * separate ones. It does too much.
         */
        private void trv_Mbins_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // just an easily named shortcut to the node from the event
            MyTreeNode selectedNode = (MyTreeNode)e.Node;

            // if selected node associated template isn't the current template
            // then set current template to be the selected one
            if (selectedNode.associatedTemplate != currentTemplate)
            {
                currentTemplate = selectedNode.associatedTemplate;
            }

            // Blank the information labels
            lbl_libMBINType.Text = "<NO INFO>";
            lbl_MbinRelativePath.Text = "<NO INFO>";
            lbl_VarName.Text = "<NO INFO>";
            lbl_varType.Text = "<NO INFO>";

            // MBIN RELATIVE PATH
            lbl_MbinRelativePath.Text = currentTemplate.GetRelativePath(currentTemplate.mbinPath);

            // WHAT STRUCT IS THIS FROM?
            lbl_libMBINType.Text = selectedNode.associatedTemplate.baseTemplate.GetType().Name;

            // If this isn't a root node
            // then we've got some other information to show and process
            if (!selectedNode.isRootNode)
            {
                // VAR NAME
                lbl_VarName.Text = selectedNode.fieldInfo.Name;
                // VAR TYPE (SINGLE, BOOL, LIBMBIN STRUCT, ARRAY)
                lbl_varType.Text = selectedNode.fieldInfo.GetValue(currentTemplate.baseTemplate).GetType().Name;

                // If the var is an array then we need to process and display it in different ways
                if (selectedNode.fieldInfo.GetValue(currentTemplate.baseTemplate).GetType().IsArray)
                {
                    string messageText = "";    // Do i need to use this??

                    // Firstly get the array
                    Array array = (Array)selectedNode.fieldInfo.GetValue(currentTemplate.baseTemplate);

                    // Was doing some crazy shit before when I was confused. Left it here to ponder my madness in future
                    //FieldInfo reflectedField = selectedNode.fieldInfo.ReflectedType.GetField(selectedNode.fieldInfo.Name);

                    // Shortcut to the field we're interested in. Just to not have to type the whole thing each time
                    FieldInfo field = selectedNode.fieldInfo;

                    // Testing/Debug info to find out how things work
                    Console.WriteLine("Value of node>>field is: " + field.GetValue(currentTemplate.baseTemplate));
                    Console.WriteLine("Name of fieldInfo is: " + field.Name);
                    Console.WriteLine("Reflected type is: " + field.ReflectedType);
                    Console.WriteLine("Just NMSAttribute[] i think: " + field.GetCustomAttributes(typeof(NMSAttribute), false));

                    // Get attributes from the field
                    // returns a zero length array if there is none
                    NMSAttribute[] nmsAttributes = (NMSAttribute[])field.GetCustomAttributes(typeof(NMSAttribute), false);

                    Console.WriteLine("Length of array: " + nmsAttributes.Length);

                    /*if (true)
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

                    }*/

                    // temp Array var to store values from an Enum
                    Array enumValues;

                    // Check if the attribute has an EnumType
                    // if it does then we want to use it for this field
                    if (nmsAttributes[0].EnumType != null)
                    {
                        // it has an associated enum type so let's add that
                        // to the Var Type info box
                        lbl_varType.Text += " using:\r\n" + nmsAttributes[0].EnumType.Name;

                        // Get the values used in the EnumType
                        // and store them in that array from before (enumValues)
                        enumValues = nmsAttributes[0].EnumType.GetEnumValues();

                        // Loop through each enum showing the name associated with the number
                        // and then the value from the array itself
                        for (int i = 0; i < enumValues.Length; i++)
                        {
                            messageText += enumValues.GetValue(i).ToString() + ": " + array.GetValue(i) + "\r\n";
                            //Console.WriteLine("Index " + i + ": " + enumValues.GetValue(i));
                        }
                    }
                    // if it doesn't have an EnumType
                    // then it's just a list of indices (0...n)
                    else
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            messageText += "Index [" + i.ToString() + "] : " + array.GetValue(i) + "\r\n";
                        }
                    }

                    txtB_values.Text = messageText;
                }
                // If it isn't an array then just display the value
                else
                {
                    txtB_values.Text = selectedNode.fieldInfo.GetValue(currentTemplate.baseTemplate).ToString();
                }
            }
        }
    }
}
