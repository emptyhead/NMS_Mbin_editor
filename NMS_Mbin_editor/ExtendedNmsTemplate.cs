using libMBIN;
using libMBIN.NMS.Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMS_Mbin_editor
{
    class ExtendedNmsTemplate
    {
        // no way for me to actually extend the template
        // as the templates for each mbin inherit from the base NMSTemplate
        // so wouldn't have any extensions I create

        // just creating a new class that contains the base template
        // and adds the stuff i need.
        // Hopefully this is manageable.

        public NMSTemplate baseTemplate;
        // the basic nmsTemplate holding the mbin info
        // all the vars plus any NMSTemplate funcitonality

        public string mbinPath;
        // full path to MBIN
        // could also do with either a var to hold the NMS internal path
        // or a method to get this from this var

        // in order to have a generic Type to hold all the different kinds of
        // NMSTemplate we dont' have IDE access to each var in the specific templates
        // ie. NMSTemplate just has methods for that class no matter what is loaded into it.
        //  NMSTemplate.playerPos isn't available has to be
        //  GcPlayerGlobal.playerPos
        // instead we can store all fieldInfos in an array

        public FieldInfo[] templateVars;
        // hold all the vars for the specific template
        
        public ExtendedNmsTemplate (string path)
        {
            mbinPath = path;
            baseTemplate = FileIO.LoadFile(path);
            templateVars = baseTemplate.GetType().GetFields();
        }

        public string GetRelativePath(string fullPath)
        {
            string returnString = fullPath.Remove(0, Form1.unpackedNMSFilePath.Length);
            return returnString;
        }

        public void PopulateTreeView (TreeView trv)
        {
            // get the name of the template (eg. GcPlayerGlobals) and use it as rootNode
            // get all the fields and use them as child nodes

            // create root node
            MyTreeNode rootNode = new MyTreeNode(mbinPath, this);
            rootNode.isRootNode = true;
            rootNode.rootNode = rootNode;

            // add to treeView
            trv.Nodes.Add(rootNode);

            // go through all fieldInfos and add them to treeview
            foreach(FieldInfo fi in templateVars)
            {
                MyTreeNode fieldNode = new MyTreeNode(fi.ToString(), this);
                fieldNode.subLevel = 1;
                fieldNode.rootNode = rootNode;
                fieldNode.fieldInfo = fi;
                // create new myTreeNode with fieldName associated with this mbin
                trv.Nodes[trv.Nodes.Count - 1].Nodes.Add(fieldNode);
            }
        }
    }
}
