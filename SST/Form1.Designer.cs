namespace SST
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_drawing = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_childs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_yPosition = new System.Windows.Forms.Label();
            this.lbl_xPosition = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_action = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_distance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_parent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nodeName = new System.Windows.Forms.TextBox();
            this.treeView_nodes = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_step = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_drawing
            // 
            this.pnl_drawing.BackColor = System.Drawing.Color.Silver;
            this.pnl_drawing.Location = new System.Drawing.Point(393, 153);
            this.pnl_drawing.Name = "pnl_drawing";
            this.pnl_drawing.Size = new System.Drawing.Size(921, 411);
            this.pnl_drawing.TabIndex = 0;
            this.pnl_drawing.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_drawing_Paint);
            this.pnl_drawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_drawing_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_childs);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_yPosition);
            this.groupBox1.Controls.Add(this.lbl_xPosition);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_action);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_distance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combo_parent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nodeName);
            this.groupBox1.Location = new System.Drawing.Point(393, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Node";
            // 
            // txt_childs
            // 
            this.txt_childs.Location = new System.Drawing.Point(357, 58);
            this.txt_childs.Name = "txt_childs";
            this.txt_childs.Size = new System.Drawing.Size(155, 20);
            this.txt_childs.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(403, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Childs";
            // 
            // lbl_yPosition
            // 
            this.lbl_yPosition.AutoSize = true;
            this.lbl_yPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yPosition.Location = new System.Drawing.Point(709, 63);
            this.lbl_yPosition.Name = "lbl_yPosition";
            this.lbl_yPosition.Size = new System.Drawing.Size(15, 15);
            this.lbl_yPosition.TabIndex = 11;
            this.lbl_yPosition.Text = "0";
            // 
            // lbl_xPosition
            // 
            this.lbl_xPosition.AutoSize = true;
            this.lbl_xPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_xPosition.Location = new System.Drawing.Point(709, 34);
            this.lbl_xPosition.Name = "lbl_xPosition";
            this.lbl_xPosition.Size = new System.Drawing.Size(15, 15);
            this.lbl_xPosition.TabIndex = 10;
            this.lbl_xPosition.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(683, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Y :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(683, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "X :";
            // 
            // btn_action
            // 
            this.btn_action.Location = new System.Drawing.Point(785, 21);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(130, 63);
            this.btn_action.TabIndex = 6;
            this.btn_action.Text = "ADD/SAVE";
            this.btn_action.UseVisualStyleBackColor = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(566, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Distance";
            // 
            // txt_distance
            // 
            this.txt_distance.Location = new System.Drawing.Point(553, 61);
            this.txt_distance.Name = "txt_distance";
            this.txt_distance.Size = new System.Drawing.Size(110, 20);
            this.txt_distance.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parent";
            // 
            // combo_parent
            // 
            this.combo_parent.FormattingEnabled = true;
            this.combo_parent.Location = new System.Drawing.Point(215, 61);
            this.combo_parent.Name = "combo_parent";
            this.combo_parent.Size = new System.Drawing.Size(121, 21);
            this.combo_parent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txt_nodeName
            // 
            this.txt_nodeName.Location = new System.Drawing.Point(36, 61);
            this.txt_nodeName.Name = "txt_nodeName";
            this.txt_nodeName.Size = new System.Drawing.Size(155, 20);
            this.txt_nodeName.TabIndex = 0;
            // 
            // treeView_nodes
            // 
            this.treeView_nodes.Location = new System.Drawing.Point(12, 187);
            this.treeView_nodes.Name = "treeView_nodes";
            this.treeView_nodes.Size = new System.Drawing.Size(330, 377);
            this.treeView_nodes.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(829, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Graph";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_time);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_pause);
            this.groupBox2.Controls.Add(this.btn_step);
            this.groupBox2.Controls.Add(this.btn_stop);
            this.groupBox2.Controls.Add(this.btn_play);
            this.groupBox2.Location = new System.Drawing.Point(12, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 149);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(152, 119);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(49, 20);
            this.lbl_time.TabIndex = 13;
            this.lbl_time.Text = "0:0:0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Elapsed Time :";
            // 
            // btn_pause
            // 
            this.btn_pause.BackgroundImage = global::SST.Properties.Resources.pause;
            this.btn_pause.Location = new System.Drawing.Point(174, 40);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(64, 61);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.UseVisualStyleBackColor = true;
            // 
            // btn_step
            // 
            this.btn_step.BackgroundImage = global::SST.Properties.Resources.step;
            this.btn_step.Location = new System.Drawing.Point(94, 38);
            this.btn_step.Name = "btn_step";
            this.btn_step.Size = new System.Drawing.Size(64, 61);
            this.btn_step.TabIndex = 2;
            this.btn_step.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.btn_stop.BackgroundImage = global::SST.Properties.Resources.stop;
            this.btn_stop.Location = new System.Drawing.Point(254, 40);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(64, 61);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // btn_play
            // 
            this.btn_play.BackgroundImage = global::SST.Properties.Resources.play;
            this.btn_play.Location = new System.Drawing.Point(13, 38);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(64, 61);
            this.btn_play.TabIndex = 0;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 597);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1340, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(177, 17);
            this.toolStripStatusLabel1.Text = "Ihab Zhaika AND  Khalid khsaika";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1340, 619);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.treeView_nodes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_drawing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.Text = "SS Tree";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_drawing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_distance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_parent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nodeName;
        private System.Windows.Forms.TreeView treeView_nodes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_step;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_yPosition;
        private System.Windows.Forms.Label lbl_xPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_childs;
        private System.Windows.Forms.Label label8;
    }
}

