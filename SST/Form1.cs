﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SST
{
    public partial class frm_main : Form
    {
        Boolean isCreating = true;
        int xGlobal, yGlobal;
        List<Node> nodes;
        public frm_main()
        {
            InitializeComponent();
            nodes = new List<Node>();
        }

        private void pnl_drawing_Paint(object sender, PaintEventArgs e)
        {
            drawNodes(e.Graphics);

        }
        private void drawNodes(Graphics g)
        {
            foreach (Node node in nodes)
            {
                node.draw(g);
            }
        }
        /** to add or edit a node*/
        private void btn_action_Click(object sender, EventArgs e)
        {

            object[] data = getData();
            if (data == null)
            {
                MessageBox.Show("Check the data and try again");
            }
            else
            {
                /**create node from the data*/
                Node node = new Node(data[0].ToString(), (Node)data[1], (double)data[2], xGlobal, yGlobal);

                if (isCreating)
                {
                    /** chek if the node do exist*/
                    if (nodes.Contains(node))
                    {
                        MessageBox.Show("This node already exist");
                        return;
                    }

                    /** add it to nodes list*/
                    nodes.Add(node);

                    /** if has parent add it under it*/
                    if (node.Parent != null)
                    {
                        node.Parent.Childs.Add(node);
                        addNodeToTree(node,treeView_nodes.Nodes);
                    }
                    /** add a seperate node for it*/
                    treeView_nodes.Nodes.Add(new TreeNode(node.Name));
                    combo_parent.Items.Add(node.Name);

                }
                else
                {
                    Node currentNode = nodes[nodes.IndexOf(node)];
                    /** we check if parent get changed , we will update the tree*/
                    if ((node.Parent != null && !node.Parent.Equals(currentNode.Parent)) || (currentNode.Parent != null && !currentNode.Parent.Equals(node.Parent)))
                    {
                        /** change the tree view*/
                        changeNodeParentOnTree(currentNode, currentNode.Parent, node.Parent);
                        /** we need to remove the node from its parent*/
                        if(currentNode.Parent !=null)
                        {
                            currentNode.Parent.Childs.Remove(currentNode);
                            
                        }
                        if(node.Parent != null)
                        {
                            node.Parent.Childs.Add(currentNode);

                        }
                        currentNode.Parent = node.Parent;


                    }
                    if (!currentNode.Distance.Equals(node.Distance))
                    {
                        currentNode.Distance = node.Distance;
                    }

                }

            }


            pnl_drawing.Refresh();

        }

        private void addNodeToTree(Node node , TreeNodeCollection srcTreeNodes)
        {
            foreach (TreeNode treeNode in srcTreeNodes)
            {
                if (treeNode.Text.Equals(node.Parent.Name))
                {
                    treeNode.Nodes.Add(node.Name);
                }
            }
        }
        private void addNodeToTree(Node node, TreeNode srcTreeNode)
        {
            srcTreeNode.Nodes.Add(node.Name);
        }
        private void changeNodeParentOnTree(Node node, Node oldParent, Node newParent)
        {

            foreach (TreeNode treeNode in treeView_nodes.Nodes)
            {
                if (oldParent!=null &&  treeNode.Text.Equals(oldParent.Name))
                {
                    removeNodeFromTree(node, treeNode);
                }
                if (newParent!= null && treeNode.Text.Equals(newParent.Name))
                {
                    addNodeToTree(node, treeNode);

                }
            }
        }

        private void removeNodeFromTree(Node node , TreeNode sourceTreeNode)
        {
            foreach (TreeNode treeNode in sourceTreeNode.Nodes)
            {
                if (treeNode != null && treeNode.Text.Equals(node.Name))
                {
                    sourceTreeNode.Nodes.Remove(treeNode);
                }
            }
        }
        private void setData(String name, Node parent, double distance)
        {
            txt_nodeName.Text = name;
            int parentIndex = nodes.IndexOf(parent);
            combo_parent.SelectedIndex = (parentIndex);
            txt_distance.Text = distance.ToString();
        }
        private object[] getData()
        {
            double distance = 0;
            if (txt_nodeName.TextLength == 0 || txt_distance.TextLength == 0 || !Double.TryParse(txt_distance.Text, out distance))
            {
                return null;
            }
            Object[] data = new object[3];
            data[0] = txt_nodeName.Text;
            if (combo_parent.SelectedIndex != -1)
            {
                data[1] = combo_parent.Items[combo_parent.SelectedIndex];
                foreach (Node node in nodes)
                {
                    if (node.Name.Equals(data[1].ToString()))
                    {
                        data[1] = node;
                        break;
                    }
                }
            }

            data[2] = distance;
            return data;

        }

        /** we get the mouse x, y in order to know where to add the node*/
        private void pnl_drawing_MouseClick(object sender, MouseEventArgs e)
        {
            lbl_xPosition.Text = (xGlobal = e.X).ToString();
            lbl_yPosition.Text = (yGlobal = e.Y).ToString();

            /** check if there node on this point*/
            Node node = getNodeOnGraph(xGlobal, yGlobal);
            /** if there is node , we want to load its data*/
            if (node != null)
            {
                setData(node.Name, node.Parent, node.Distance);
                isCreating = false;
                txt_nodeName.ReadOnly = true;
                btn_action.Text = " Update";
            }
            else
            {
                isCreating = true;
                txt_nodeName.ReadOnly = false;
                btn_action.Text = " Create";

            }

        }
        /** return the node that exist on the x,y*/
        private Node getNodeOnGraph(int x, int y)
        {
            foreach (Node node in nodes)
            {
                if (inNode(node, x, y))
                {
                    return node;
                }
            }
            return null;
        }
        /** checks if in this X,Y there is a node*/
        private Boolean inNode(Node node, int x, int y)
        {
            if (x >= node.X && x <= node.X + (2 * Node.RADIUS) && y >= node.Y && y <= node.Y + (2 * Node.RADIUS))
            {
                return true;
            }
            return false;
        }

        private void fillDataIntoFields(String name, Node parent, double distance)
        {
            txt_nodeName.Text = name;
            txt_distance.Text = distance.ToString();
            combo_parent.SelectedIndex = combo_parent.FindStringExact(parent.Name);

        }
    }
}
