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
        public string fileName; // MBIN file name
                                // figure it's probably useful to have

        public NMSTemplate mbinStruct;  // the file as a struct in memory
                                        // contains all the info for the various fields in the EXML
        public Dictionary<TreeNode, FieldInfo> dict_fieldFromNode;  // dictionary linking nodes to the fields in the struct
                                        // why? Use it to access the field when clicking on a node
                                        // don't think there's an easier way to do it
        public TreeNode rootNode;   // not sure why I want this anymore to be honest
                                    // it's handy I suppose
        

        public Mbin (string pathToMbin)
        {
            LoadMbin(pathToMbin);
        }

        public TreeNode GetRootNode()
        {
            return rootNode;
        }

        public Type GetFieldType(FieldInfo field)
        {
            Type fieldType = field.GetType();
            return fieldType;
        }

        public string GetFieldName (FieldInfo field)
        {
            string fieldName = field.Name;
            return fieldName;
        }

        public string GetFieldValue (FieldInfo field)
        {
            string fieldValue = field.GetValue(mbinStruct).ToString();
            return fieldValue;
        }

        public void SetFieldValue (FieldInfo field, string value)
        {
            // cast the string to the type of field
            var valueToSet = Convert.ChangeType(value, GetFieldType(field));
        }

        public void MbinToTreeView (TreeView trv)
        {
            rootNode = new TreeNode(mbinPath);
            dict_fieldFromNode.Add(rootNode, null); // null cos it doesn't point to a field
            trv.Nodes.Add(rootNode);
            
            // run through all the entries
            foreach (FieldInfo entry in mbinStruct.GetType().GetFields())
            {
                TreeNode treeNode = trv.Nodes[trv.Nodes.Count - 1].Nodes.Add(entry.Name);
                dict_fieldFromNode.Add(treeNode, entry);
            }
            // any entry that is of type *.xml has children that make up that xml
            // these should maybe just be displayed in the editing bit
        }

        public void LoadMbin (string path)
        {
            mbinStruct = FileIO.LoadMbin(path);
        }
    }
}
