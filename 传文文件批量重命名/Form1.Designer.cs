namespace 传文文件批量重命名
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_reExt = new System.Windows.Forms.Button();
            this.tb_newExt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_replace = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_replace = new System.Windows.Forms.TextBox();
            this.tb_serch = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rbtnz_saveN = new System.Windows.Forms.RadioButton();
            this.rbtn_delnum = new System.Windows.Forms.RadioButton();
            this.rbtn_shanchu = new System.Windows.Forms.RadioButton();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_deleteMode = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tb_addnum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rb_insert = new System.Windows.Forms.RadioButton();
            this.btn_add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_addtxt = new System.Windows.Forms.TextBox();
            this.rb_addend = new System.Windows.Forms.RadioButton();
            this.rb_addsart = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldfilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldfileEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newfilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newfileEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteline = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_fold = new System.Windows.Forms.Button();
            this.cb_readd = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_beginnum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_begintxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_numlasttxt = new System.Windows.Forms.TextBox();
            this.btn_prnum = new System.Windows.Forms.Button();
            this.cb_add0 = new System.Windows.Forms.CheckBox();
            this.上移1行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下移1行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.deleteline.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 633);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cb_add0);
            this.tabPage1.Controls.Add(this.btn_prnum);
            this.tabPage1.Controls.Add(this.tb_numlasttxt);
            this.tabPage1.Controls.Add(this.tb_begintxt);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tb_beginnum);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btn_reExt);
            this.tabPage1.Controls.Add(this.tb_newExt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "修改扩展名";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "音乐-修改歌手歌曲位置";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_reExt
            // 
            this.btn_reExt.Location = new System.Drawing.Point(86, 169);
            this.btn_reExt.Name = "btn_reExt";
            this.btn_reExt.Size = new System.Drawing.Size(75, 23);
            this.btn_reExt.TabIndex = 2;
            this.btn_reExt.Text = "预览";
            this.btn_reExt.UseVisualStyleBackColor = true;
            this.btn_reExt.Click += new System.EventHandler(this.btn_reExt_Click);
            // 
            // tb_newExt
            // 
            this.tb_newExt.Location = new System.Drawing.Point(71, 109);
            this.tb_newExt.Name = "tb_newExt";
            this.tb_newExt.Size = new System.Drawing.Size(100, 21);
            this.tb_newExt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(49, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "请输入新扩展名";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_replace);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tb_replace);
            this.tabPage2.Controls.Add(this.tb_serch);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "替换模式";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_replace
            // 
            this.btn_replace.Location = new System.Drawing.Point(63, 233);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(75, 23);
            this.btn_replace.TabIndex = 3;
            this.btn_replace.Text = "预览";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "替换内容";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "查找内容";
            // 
            // tb_replace
            // 
            this.tb_replace.Location = new System.Drawing.Point(32, 184);
            this.tb_replace.Name = "tb_replace";
            this.tb_replace.Size = new System.Drawing.Size(181, 21);
            this.tb_replace.TabIndex = 1;
            // 
            // tb_serch
            // 
            this.tb_serch.Location = new System.Drawing.Point(32, 113);
            this.tb_serch.Name = "tb_serch";
            this.tb_serch.Size = new System.Drawing.Size(181, 21);
            this.tb_serch.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(63, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "包含扩展名";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rbtnz_saveN);
            this.tabPage3.Controls.Add(this.rbtn_delnum);
            this.tabPage3.Controls.Add(this.rbtn_shanchu);
            this.tabPage3.Controls.Add(this.btn_delete);
            this.tabPage3.Controls.Add(this.tb_deleteMode);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(352, 607);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "删除模式";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rbtnz_saveN
            // 
            this.rbtnz_saveN.AutoSize = true;
            this.rbtnz_saveN.Location = new System.Drawing.Point(76, 140);
            this.rbtnz_saveN.Name = "rbtnz_saveN";
            this.rbtnz_saveN.Size = new System.Drawing.Size(77, 16);
            this.rbtnz_saveN.TabIndex = 3;
            this.rbtnz_saveN.Text = "保留前N位";
            this.rbtnz_saveN.UseVisualStyleBackColor = true;
            // 
            // rbtn_delnum
            // 
            this.rbtn_delnum.AutoSize = true;
            this.rbtn_delnum.Location = new System.Drawing.Point(76, 118);
            this.rbtn_delnum.Name = "rbtn_delnum";
            this.rbtn_delnum.Size = new System.Drawing.Size(77, 16);
            this.rbtn_delnum.TabIndex = 3;
            this.rbtn_delnum.Text = "删除前N位";
            this.rbtn_delnum.UseVisualStyleBackColor = true;
            // 
            // rbtn_shanchu
            // 
            this.rbtn_shanchu.AutoSize = true;
            this.rbtn_shanchu.Checked = true;
            this.rbtn_shanchu.Location = new System.Drawing.Point(76, 96);
            this.rbtn_shanchu.Name = "rbtn_shanchu";
            this.rbtn_shanchu.Size = new System.Drawing.Size(95, 16);
            this.rbtn_shanchu.TabIndex = 3;
            this.rbtn_shanchu.TabStop = true;
            this.rbtn_shanchu.Text = "删除指定字符";
            this.rbtn_shanchu.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(76, 276);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "预览";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_deleteMode
            // 
            this.tb_deleteMode.Location = new System.Drawing.Point(58, 210);
            this.tb_deleteMode.Name = "tb_deleteMode";
            this.tb_deleteMode.Size = new System.Drawing.Size(124, 21);
            this.tb_deleteMode.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tb_addnum);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.rb_insert);
            this.tabPage4.Controls.Add(this.btn_add);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.tb_addtxt);
            this.tabPage4.Controls.Add(this.rb_addend);
            this.tabPage4.Controls.Add(this.rb_addsart);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(352, 607);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "添加内容";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tb_addnum
            // 
            this.tb_addnum.Location = new System.Drawing.Point(61, 108);
            this.tb_addnum.Name = "tb_addnum";
            this.tb_addnum.Size = new System.Drawing.Size(69, 21);
            this.tb_addnum.TabIndex = 6;
            this.tb_addnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_addnum_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "添加到第N字符后";
            // 
            // rb_insert
            // 
            this.rb_insert.AutoSize = true;
            this.rb_insert.Location = new System.Drawing.Point(205, 47);
            this.rb_insert.Name = "rb_insert";
            this.rb_insert.Size = new System.Drawing.Size(83, 16);
            this.rb_insert.TabIndex = 4;
            this.rb_insert.TabStop = true;
            this.rb_insert.Text = "到指定位置";
            this.rb_insert.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(96, 234);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "预览";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "添加内容";
            // 
            // tb_addtxt
            // 
            this.tb_addtxt.Location = new System.Drawing.Point(49, 180);
            this.tb_addtxt.Name = "tb_addtxt";
            this.tb_addtxt.Size = new System.Drawing.Size(193, 21);
            this.tb_addtxt.TabIndex = 1;
            // 
            // rb_addend
            // 
            this.rb_addend.AutoSize = true;
            this.rb_addend.Location = new System.Drawing.Point(116, 47);
            this.rb_addend.Name = "rb_addend";
            this.rb_addend.Size = new System.Drawing.Size(83, 16);
            this.rb_addend.TabIndex = 0;
            this.rb_addend.Text = "添加到结尾";
            this.rb_addend.UseVisualStyleBackColor = true;
            // 
            // rb_addsart
            // 
            this.rb_addsart.AutoSize = true;
            this.rb_addsart.Checked = true;
            this.rb_addsart.Location = new System.Drawing.Point(27, 47);
            this.rb_addsart.Name = "rb_addsart";
            this.rb_addsart.Size = new System.Drawing.Size(83, 16);
            this.rb_addsart.TabIndex = 0;
            this.rb_addsart.TabStop = true;
            this.rb_addsart.Text = "添加到开头";
            this.rb_addsart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(595, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "清空列表";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_start.Location = new System.Drawing.Point(862, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(93, 48);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择工作模式";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(182, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "重置设置";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.oldfilename,
            this.oldfileEX,
            this.newfilename,
            this.newfileEX});
            this.dataGridView1.ContextMenuStrip = this.deleteline;
            this.dataGridView1.Location = new System.Drawing.Point(305, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(753, 611);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "文件路径";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // oldfilename
            // 
            this.oldfilename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.oldfilename.HeaderText = "源文件文件名";
            this.oldfilename.MinimumWidth = 30;
            this.oldfilename.Name = "oldfilename";
            this.oldfilename.Width = 72;
            // 
            // oldfileEX
            // 
            this.oldfileEX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.oldfileEX.HeaderText = "源文件扩展名";
            this.oldfileEX.Name = "oldfileEX";
            this.oldfileEX.Width = 72;
            // 
            // newfilename
            // 
            this.newfilename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.newfilename.HeaderText = "新文件文件名";
            this.newfilename.MinimumWidth = 30;
            this.newfilename.Name = "newfilename";
            this.newfilename.Width = 72;
            // 
            // newfileEX
            // 
            this.newfileEX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.newfileEX.HeaderText = "新文件扩展名";
            this.newfileEX.Name = "newfileEX";
            this.newfileEX.Width = 72;
            // 
            // deleteline
            // 
            this.deleteline.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.上移1行ToolStripMenuItem,
            this.下移1行ToolStripMenuItem});
            this.deleteline.Name = "deleteline";
            this.deleteline.Size = new System.Drawing.Size(125, 70);
            this.deleteline.Text = "删除本行";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "删除本行";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btn_fold
            // 
            this.btn_fold.Location = new System.Drawing.Point(450, 15);
            this.btn_fold.Name = "btn_fold";
            this.btn_fold.Size = new System.Drawing.Size(82, 28);
            this.btn_fold.TabIndex = 6;
            this.btn_fold.Text = "选择文件夹";
            this.btn_fold.UseVisualStyleBackColor = true;
            this.btn_fold.Click += new System.EventHandler(this.btn_fold_Click);
            // 
            // cb_readd
            // 
            this.cb_readd.AutoSize = true;
            this.cb_readd.Location = new System.Drawing.Point(723, 44);
            this.cb_readd.Name = "cb_readd";
            this.cb_readd.Size = new System.Drawing.Size(120, 16);
            this.cb_readd.TabIndex = 7;
            this.cb_readd.Text = "修改后添加到任务";
            this.cb_readd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(94, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "自编号";
            // 
            // tb_beginnum
            // 
            this.tb_beginnum.Location = new System.Drawing.Point(107, 363);
            this.tb_beginnum.Name = "tb_beginnum";
            this.tb_beginnum.Size = new System.Drawing.Size(100, 21);
            this.tb_beginnum.TabIndex = 5;
            this.tb_beginnum.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "开始数字";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "前置内容";
            // 
            // tb_begintxt
            // 
            this.tb_begintxt.Location = new System.Drawing.Point(107, 408);
            this.tb_begintxt.Name = "tb_begintxt";
            this.tb_begintxt.Size = new System.Drawing.Size(100, 21);
            this.tb_begintxt.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 455);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "后置内容";
            // 
            // tb_numlasttxt
            // 
            this.tb_numlasttxt.Location = new System.Drawing.Point(107, 452);
            this.tb_numlasttxt.Name = "tb_numlasttxt";
            this.tb_numlasttxt.Size = new System.Drawing.Size(100, 21);
            this.tb_numlasttxt.TabIndex = 5;
            // 
            // btn_prnum
            // 
            this.btn_prnum.Location = new System.Drawing.Point(96, 497);
            this.btn_prnum.Name = "btn_prnum";
            this.btn_prnum.Size = new System.Drawing.Size(75, 23);
            this.btn_prnum.TabIndex = 6;
            this.btn_prnum.Text = "预览编号";
            this.btn_prnum.UseVisualStyleBackColor = true;
            this.btn_prnum.Click += new System.EventHandler(this.btn_prnum_Click);
            // 
            // cb_add0
            // 
            this.cb_add0.AutoSize = true;
            this.cb_add0.Checked = true;
            this.cb_add0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_add0.Location = new System.Drawing.Point(86, 332);
            this.cb_add0.Name = "cb_add0";
            this.cb_add0.Size = new System.Drawing.Size(108, 16);
            this.cb_add0.TabIndex = 7;
            this.cb_add0.Text = "10以下添加1个0";
            this.cb_add0.UseVisualStyleBackColor = true;
            // 
            // 上移1行ToolStripMenuItem
            // 
            this.上移1行ToolStripMenuItem.Name = "上移1行ToolStripMenuItem";
            this.上移1行ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.上移1行ToolStripMenuItem.Text = "上移1行";
            // 
            // 下移1行ToolStripMenuItem
            // 
            this.下移1行ToolStripMenuItem.Name = "下移1行ToolStripMenuItem";
            this.下移1行ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.下移1行ToolStripMenuItem.Text = "下移1行";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 689);
            this.Controls.Add(this.cb_readd);
            this.Controls.Add(this.btn_fold);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "传文文件批量重命名";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.deleteline.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_reExt;
        private System.Windows.Forms.TextBox tb_newExt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_replace;
        private System.Windows.Forms.TextBox tb_serch;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_addtxt;
        private System.Windows.Forms.RadioButton rb_addend;
        private System.Windows.Forms.RadioButton rb_addsart;
        private System.Windows.Forms.TextBox tb_deleteMode;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_fold;
        private System.Windows.Forms.RadioButton rbtnz_saveN;
        private System.Windows.Forms.RadioButton rbtn_delnum;
        private System.Windows.Forms.RadioButton rbtn_shanchu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldfilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldfileEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn newfilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn newfileEX;
        private System.Windows.Forms.ContextMenuStrip deleteline;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox tb_addnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_insert;
        private System.Windows.Forms.CheckBox cb_readd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cb_add0;
        private System.Windows.Forms.Button btn_prnum;
        private System.Windows.Forms.TextBox tb_numlasttxt;
        private System.Windows.Forms.TextBox tb_begintxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_beginnum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem 上移1行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下移1行ToolStripMenuItem;
    }
}

