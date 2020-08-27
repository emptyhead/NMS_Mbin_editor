using libMBIN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMS_Mbin_editor
{
    class Mbin
    {
        public string mbinPath; // path to MBIN
                                // used to load file, display relative path
        //public string fileName; // MBIN file name
                                // figure it's probably useful to have

        public NMSTemplate mbinStruct;  // the file as a struct in memory
                                        // contains all the info for the various fields in the EXML
        public Dictionary<TreeNode, FieldInfo> dict_nodeToField = new Dictionary<TreeNode, FieldInfo>();  // dictionary linking nodes to the fields in the struct
                                        // why? Use it to access the field when clicking on a node
                                        // don't think there's an easier way to do it
        public TreeNode rootNode;   // not sure why I want this anymore to be honest
                                    // it's handy I suppose
        

        public Mbin (string pathToMbin) // constructor with path to mbin
        {
            LoadMbin(pathToMbin);       // separate method to load it for some reason
        }

        public TreeNode GetRootNode()
        {
            return rootNode;
        }

        public FieldInfo GetAssociatedFieldFromNode(TreeNode treeNode)
        {
            FieldInfo fieldToReturn = dict_nodeToField[treeNode];
            return fieldToReturn;
        }

        public Type GetFieldType(FieldInfo fieldInfo)
        {
            Type typeToReturn = mbinStruct.GetType();
            if (fieldInfo != null)
            {
                typeToReturn = fieldInfo.GetValue(mbinStruct).GetType();
            }
            return typeToReturn;
        }

        public string GetFieldName (FieldInfo fieldInfo)
        {
            string fieldNameToReturn = "<NO FIELD INFO>";

            if (fieldInfo != null)
            {
                fieldNameToReturn = fieldInfo.Name;
            }
            else
            {
                fieldNameToReturn = rootNode.Name;
            }
            
            return fieldNameToReturn;
        }

        public string GetFieldValue (FieldInfo field)
        {
            string fieldValueToReturn = "<NO FIELD INFO>";
            if (field != null)
            {
                fieldValueToReturn = field.GetValue(mbinStruct).ToString();
            }
            return fieldValueToReturn;
        }

        public void SetFieldValue (FieldInfo fieldInfo, string value)
        {
            // cast the string to the type of field
            var valueToSet = Convert.ChangeType(value, GetFieldType(fieldInfo));
        }

        public void PutFieldsInTreeview (TreeView trv)
        {
            rootNode = new TreeNode(mbinPath);      // create the root node
                                                    // which is just the full path name
                                                    // should maybe be the relative path name
            dict_nodeToField.Add(rootNode, null); // null cos it doesn't point to a field
            trv.Nodes.Add(rootNode);                // add the node to the treeView passed in
            
            // run through all the entries
            foreach (FieldInfo entry in mbinStruct.GetType().GetFields())   // getType() then GetFields() from the type
                                                                            // don't get this at the moment really
            {
                TreeNode treeNode = trv.Nodes[trv.Nodes.Count - 1].Nodes.Add(entry.GetValue(mbinStruct).GetType() + ": "+ entry.Name);
                dict_nodeToField.Add(treeNode, entry);
            }
            // any entry that is of type *.xml has children that make up that xml
            // these should maybe just be displayed in the editing bit
        }

        public void LoadMbin (string path)
        {
            mbinStruct = FileIO.LoadMbin(path);
            mbinPath = path;
        }
    }
}
