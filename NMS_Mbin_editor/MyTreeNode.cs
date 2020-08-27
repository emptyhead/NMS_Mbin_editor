using libMBIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMS_Mbin_editor
{
    class MyTreeNode: TreeNode
    {
        // so, basic treeNode functionality plus things I need.
        // what field does it point to 
        // what NMSTemplate is it part of

        public ExtendedNmsTemplate associatedTemplate;
        // what NMSTemplate this nodes contents are part of - eg. GcPlayerGlobals.Global.Mbin etc

        public FieldInfo fieldInfo;
        // this is the FieldInfo of the field the node is associated with
        // if root node then null

        public bool isRootNode = false;
        // flag if this is a root node or not
        
        public MyTreeNode rootNode;
        // easy access to the root node for this node ie. the NMSTemplate struct
        // if isRootNode then this is null

        public bool isParentNode = false;
        // flag if this is a parent of something else
        // Don't think this is actually needed but
        // useful functionality

        public int subLevel = 0;
        // sublevel 0 is the root node for template
        // Sublevel 1 is all the stats directly under the root node
        // other sublevels (2+) will be children of other parents

        public MyTreeNode parentNode;
        // if it is a parent node then hold that node here
        // if not root node and 

        public MyTreeNode (string nodeName, ExtendedNmsTemplate template)
        {
            this.associatedTemplate = template;
            this.Text = nodeName;
        }
    }
}
