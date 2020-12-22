using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void accountingTemplateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountingTemplateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.configDbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'configDbDataSet.AccountEntry' table. You can move, or remove it, as needed.
            this.accountEntryTableAdapter.Fill(this.configDbDataSet.AccountEntry);
            // TODO: This line of code loads data into the 'configDbDataSet.AccountingTemplate' table. You can move, or remove it, as needed.
            this.accountingTemplateTableAdapter.Fill(this.configDbDataSet.AccountingTemplate);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            accountEntryBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountEntryBindingSource.EndEdit();
            this.accountEntryTableAdapter.Update(configDbDataSet);
        }
    }
}
