using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;



namespace 传文文件批量重命名
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          

        }
        string[] fileNames;//文件列表


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "选择一个文件";           
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 获取选择的文件路径
                fileNames = openFileDialog1.FileNames;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                foreach (string fileName in fileNames)
                {
                    

                    string fName = Path.GetFileNameWithoutExtension(fileName);
                    string extension = Path.GetExtension (fileName);

                    string fpatch = Path.GetDirectoryName(fileName);

                   // MessageBox.Show("你选择的文件ming: " + fName+"kuozhan"+extension);

                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = fpatch });
                    newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = fName });
                    newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = extension });
                    newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = fName });
                    newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = extension });
                    dataGridView1.Rows.Add(newRow);
                                                         
                }
               
             
            }

       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

        }

        private void btn_reExt_Click(object sender, EventArgs e)
        {
            if (tb_newExt.Text.Length == 0)
            {
                MessageBox.Show("未输入");
                return;
            }
            else if (dataGridView1.Rows.Count <= 1)
            {
                MessageBox.Show("未选择文件");
                return;

            }
            else
            {
                String newExt = tb_newExt.Text;
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    dataGridView1.Rows[row].Cells[4].Value ="."+ newExt;
                }               
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
              
            }

        }

        private void btn_fold_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog1.SelectedPath;
                // 列出文件夹中的所有文件
                try
                {
                    string[] files = Directory.GetFiles(selectedFolderPath);
                    foreach (string file in files)
                    {
                   
                       string fName = Path.GetFileNameWithoutExtension(file);
                        string extension = Path.GetExtension(file);
                        string fpatch = Path.GetDirectoryName(file);

                        // MessageBox.Show("你选择的文件ming: " + fName+"kuozhan"+extension);

                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = fpatch });
                        newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = fName });
                        newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = extension });
                        newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = fName });
                        newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = extension });
                        dataGridView1.Rows.Add(newRow);

                    }
                }
                catch (Exception ex)
                {
                    // 处理异常（例如，访问被拒绝）
                    MessageBox.Show("文件夹为空: " + ex.Message);
                }
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            int i = 0;
             for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                String oldname = dataGridView1.Rows[row].Cells[0].Value.ToString() +"\\"+ dataGridView1.Rows[row].Cells[1].Value.ToString() +  dataGridView1.Rows[row].Cells[2].Value.ToString();

               String newname = dataGridView1.Rows[row].Cells[0].Value.ToString()+"\\"+dataGridView1.Rows[row].Cells[3].Value.ToString()+ dataGridView1.Rows[row].Cells[4].Value.ToString();

               // 检查文件是否存在
               if (File.Exists(oldname))
               {
                   try { 
                       File.Move(oldname, newname);
                       dataGridView1.Rows[row].Cells[1].Value = newname;
                       i++;
                   }
                   catch { 
                    Console.WriteLine("文件重命名失败！"+newname);
                   }
                  
                       
               }
               else
               {
                   Console.WriteLine("文件不存在。");
               }


                }
            MessageBox.Show("完成"+i+"条任务操作");
             if (cb_readd.Checked == false) {
              dataGridView1.Rows.Clear();
             }
            
         

        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            if (tb_serch.Text.Length == 0) {

                MessageBox.Show("请输入查找值");
                return;
            }                           

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                string foldname = dataGridView1.Rows[row].Cells[1].Value.ToString();
                string substringToFind = tb_serch.Text;
                string replacementString =tb_replace.Text;

                // 使用Replace方法查找并替换子字符串
                string modifiedString = foldname.Replace(substringToFind, replacementString);

                dataGridView1.Rows[row].Cells[3].Value = modifiedString;
            }
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //删除字符
            if (rbtn_shanchu.Checked) {
                
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    string foldname = dataGridView1.Rows[row].Cells[1].Value.ToString();
                    string substringToFind = tb_deleteMode.Text;                   
                    string modifiedString = foldname.Replace(substringToFind, "");
                    dataGridView1.Rows[row].Cells[3].Value = modifiedString;
                }
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
              
                return;
            } 
            
               int number;
               bool isNumber = int.TryParse(tb_deleteMode.Text, out number);

               if (isNumber==false)
               {  // 输入不是数字
                   MessageBox.Show("输入的不是数字");}
               else
               {
                 //删除前N位   
                   if (rbtn_delnum.Checked)
                   {
                       for (int row = 0; row < dataGridView1.Rows.Count; row++)
                       {
                           string foldname = dataGridView1.Rows[row].Cells[1].Value.ToString();

                           if (foldname.Length > number)
                           {
                               string modifiedString = foldname.Remove(0, number);
                               dataGridView1.Rows[row].Cells[3].Value = modifiedString;

                           }
                       }
                       dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                   
               
                }
            //保留前N位
              if (rbtnz_saveN.Checked)
              {
                  for (int row = 0; row < dataGridView1.Rows.Count; row++)
                  {
                      string foldname = dataGridView1.Rows[row].Cells[1].Value.ToString();
                      if (foldname.Length > number)
                      {
                          string modifiedString = foldname.Substring(0, number);
                          dataGridView1.Rows[row].Cells[3].Value = modifiedString;
                      }
                  }
                  dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                  
             }



            }
           }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy; // 设置拖动效果为复制
            }
            else
            {
                e.Effect = DragDropEffects.None; // 如果不是文件，则不允许拖放
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            int aa = 0; 
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foreach (string file in files)
            {

                if (File.Exists(file))
                {
                    string fName = Path.GetFileNameWithoutExtension(file);
                    string extension = Path.GetExtension(file);

                    string fpatch = Path.GetDirectoryName(file);

                    // MessageBox.Show("你选择的文件ming: " + fName+"kuozhan"+extension);

                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = fpatch });
                    newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = fName });
                    newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = extension });
                    newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = fName });
                    newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = extension });
                    dataGridView1.Rows.Add(newRow);
                }
                else {
                    aa++;
                }

          }
            if (aa > 0) {
                MessageBox.Show("拖入了"+aa+"个文件夹，暂不支持拖入文件夹");

            }
           
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_addtxt.TextLength == 0) {
                MessageBox.Show("未输入");
                return;
            
            }   
            
             dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
             if (rb_addsart.Checked) {

                 for (int row = 0; row < dataGridView1.Rows.Count; row++)
                 {
                     string foldname = dataGridView1.Rows[row].Cells[1].Value.ToString();

                     string modifiedString = tb_addtxt.Text + foldname;
                     dataGridView1.Rows[row].Cells[3].Value = modifiedString;

                 }
             }
                

               if (rb_addend.Checked) {
                      for (int row = 0; row < dataGridView1.Rows.Count; row++)
                      {
                          string foldname = dataGridView1.Rows[row].Cells[1].Value.ToString();

                          string modifiedString = foldname + tb_addtxt.Text;
                          dataGridView1.Rows[row].Cells[3].Value = modifiedString;

                      }
                }
               if (rb_insert.Checked) {
                   if (tb_addnum.Text.Length == 0) {
                       MessageBox.Show("请输入N");
                       return;
                   }
                   int number;
                   bool isNumber = int.TryParse(tb_addnum.Text, out number);
                   if (number >= 0)
                   {

                       for (int row = 0; row < dataGridView1.Rows.Count; row++)
                       {
                           string foldname = dataGridView1.Rows[row].Cells[1].Value.ToString();

                           int splitIndex = number; // 想要分割的位置（第8个字符）

                           //
                           //
                           string string1, string2;
                           try { 
                            string1 = foldname.Substring(0, splitIndex);

                           // 
                            string2 = foldname.Substring(splitIndex);
                           }
                           catch (ArgumentOutOfRangeException ex)
                           {
                               Console.WriteLine("索引或长度超出范围: " + ex.Message);
                               string1 = foldname;
                               string2 = "";
                           }
                           
                           string modifiedString = string1 + tb_addtxt.Text + string2;

                           dataGridView1.Rows[row].Cells[3].Value = modifiedString;

                       }
                   }                   
               }
                   
               
         
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedRowId = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                //    MessageBox.Show(selectedRowId);

                if (!string.IsNullOrEmpty(selectedRowId))
                {
                    // 遍历 DataGridView.Rows，找到与 selectedRowId 相匹配的行，并删除它
                    // 注意：这种方法可能不是最高效的，特别是当 DataGridView 有很多行时
                    // 一个更好的方法是在数据绑定层处理删除操作，而不是直接操作 DataGridView.Rows
                    // 但为了简化示例，这里我们仍然使用 DataGridView.Rows

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[1].Value.ToString() == selectedRowId)
                        {
                            if (!row.IsNewRow)
                            {
                                dataGridView1.Rows.RemoveAt(row.Index);
                                // 如果你的数据源是绑定的，你可能还需要从数据源中删除该行
                            }
                            break; // 假设ID是唯一的，找到后就退出循环
                        }
                    }
                }


            }
            else {
                MessageBox.Show("未选中整行");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tb_addtxt.Text = "";
            tb_deleteMode.Text = "";
            tb_newExt.Text = "";
            tb_replace.Text = "";
            tb_serch.Text = "";
            checkBox1.Checked = false;
            rbtn_shanchu.Checked = true;
            rb_addsart.Checked = true;
            tb_addnum.Text = "";

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                string foldname = dataGridView1.Rows[row].Cells[1].Value.ToString();                
                string extname = dataGridView1.Rows[row].Cells[2].Value.ToString();

                dataGridView1.Rows[row].Cells[3].Value = foldname;
                dataGridView1.Rows[row].Cells[4].Value = extname;
            }
        }

        private void tb_addnum_KeyPress(object sender, KeyPressEventArgs e)
        {     
  
      // 仅允许数字
           if (!char.IsDigit(e.KeyChar))
          {
          e.Handled = true; // 阻止输入
           }
          }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                string foldname = dataGridView1.Rows[row].Cells[1].Value.ToString();
            
               
               string[] modifiedString = foldname.Split('-');
               string newstring="";
               if (modifiedString.Length == 2)
               {
                    newstring = modifiedString[1] + "-" + modifiedString[0];
               }

               dataGridView1.Rows[row].Cells[3].Value = newstring;
            }
        }

        private void btn_prnum_Click(object sender, EventArgs e)
        {
               int number;
               bool isNumber = int.TryParse(tb_beginnum.Text, out number);
               if (number<0)
               {  // 输入不是数字
                   MessageBox.Show("输入不能小于0");
                   return;
               }

               if (isNumber == false)
               {  // 输入不是数字
                   MessageBox.Show("输入的不是数字");
               }
               else
               { 
                   for(int i=0;i<dataGridView1.Rows.Count;i++){
                      // int b = number + 1;
                       String newstring = "";
                       if (cb_add0.Checked&&number<10)
                       {
                           newstring = tb_begintxt.Text + "0" + number + tb_numlasttxt.Text;
                       }
                       else {
                           newstring = tb_begintxt.Text + number + tb_numlasttxt.Text;
                       }
                       number++;
                       dataGridView1.Rows[i].Cells[3].Value = newstring;
                    
                    }
               }
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
          
         
     }
           
}
