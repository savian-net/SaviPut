using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace SaviPut
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class frmSaviPut : Form
    {
        private Button button1;
        private CheckBox cbDquote;
        private CheckBox cbSuppressTrailingBlanks;
        private CheckBox cbWebLiterals;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        private Label label1;
        private Label label2;
        private RichTextBox rtbEncasedCode;
        private RichTextBox rtbSasCode;
        private TableLayoutPanel tableLayoutPanel1;

        public frmSaviPut()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.Run(new frmSaviPut());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Read in literals so they can be handled separately

            //var literals = new ArrayList();
            //var rdr = new XmlTextReader("literals.xml");
            //while (rdr.Read())
            //{
            //    if (rdr.NodeType == XmlNodeType.Element && rdr.HasAttributes)
            //    {
            //        literals.Add(rdr.GetAttribute("value"));
            //    }
            //}

            rtbEncasedCode.Text = "put " + Environment.NewLine;

            int i = 0;

            foreach (string str in rtbSasCode.Lines)
            {
                if (str.Trim() != "")
                {
                    string quote = string.Empty;
                    if (i != 0)
                        quote = "\'";
                    else
                        quote = "'";
                    string new_str = str;

                    if (cbSuppressTrailingBlanks.Checked)
                        str.Trim();
                    if (cbDquote.Checked)
                        quote = "\"";

                    new_str = str.Replace(quote, quote + quote);

                    //if (cbWebLiterals.Checked)
                    //{
                    //    foreach (object obj in literals)
                    //    {
                    //        var literal = (string) obj;
                    //        if (literal != null)
                    //        {
                    //            new_str = str.ToLower().Replace(literal.Trim().ToLower(),
                    //                                            "\"\'" + literal.Trim().ToLower() + "\'\"");
                    //        }
                    //    }
                    //}
                    if (i != 0)
                        rtbEncasedCode.Text += "      / " + quote + new_str + quote + Environment.NewLine;
                    else
                        rtbEncasedCode.Text += "        " + quote + new_str + quote + Environment.NewLine;
                    i++;
                }
            }

            rtbEncasedCode.Text += "       ;  " + Environment.NewLine;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaviPut));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSuppressTrailingBlanks = new System.Windows.Forms.CheckBox();
            this.cbDquote = new System.Windows.Forms.CheckBox();
            this.cbWebLiterals = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbSasCode = new System.Windows.Forms.RichTextBox();
            this.rtbEncasedCode = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(715, 600);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Encase";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Code to be encased";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(403, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encased code";
            // 
            // cbSuppressTrailingBlanks
            // 
            this.cbSuppressTrailingBlanks.Checked = true;
            this.cbSuppressTrailingBlanks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSuppressTrailingBlanks.Location = new System.Drawing.Point(5, 632);
            this.cbSuppressTrailingBlanks.Margin = new System.Windows.Forms.Padding(5);
            this.cbSuppressTrailingBlanks.Name = "cbSuppressTrailingBlanks";
            this.cbSuppressTrailingBlanks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cbSuppressTrailingBlanks.Size = new System.Drawing.Size(152, 15);
            this.cbSuppressTrailingBlanks.TabIndex = 5;
            this.cbSuppressTrailingBlanks.Text = "Suppress trailing blanks";
            // 
            // cbDquote
            // 
            this.cbDquote.Location = new System.Drawing.Point(5, 605);
            this.cbDquote.Margin = new System.Windows.Forms.Padding(5);
            this.cbDquote.Name = "cbDquote";
            this.cbDquote.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cbDquote.Size = new System.Drawing.Size(208, 15);
            this.cbDquote.TabIndex = 6;
            this.cbDquote.Text = "Use double quotes to quote strings";
            // 
            // cbWebLiterals
            // 
            this.cbWebLiterals.Location = new System.Drawing.Point(5, 657);
            this.cbWebLiterals.Margin = new System.Windows.Forms.Padding(5);
            this.cbWebLiterals.Name = "cbWebLiterals";
            this.cbWebLiterals.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cbWebLiterals.Size = new System.Drawing.Size(216, 24);
            this.cbWebLiterals.TabIndex = 7;
            this.cbWebLiterals.Text = "Enclose web literals in single quotes";
            this.cbWebLiterals.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbWebLiterals, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbSuppressTrailingBlanks, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbDquote, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtbSasCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbEncasedCode, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 686);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // rtbSasCode
            // 
            this.rtbSasCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSasCode.Location = new System.Drawing.Point(3, 33);
            this.rtbSasCode.Name = "rtbSasCode";
            this.rtbSasCode.Size = new System.Drawing.Size(394, 564);
            this.rtbSasCode.TabIndex = 8;
            this.rtbSasCode.Text = "";
            // 
            // rtbEncasedCode
            // 
            this.rtbEncasedCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEncasedCode.Location = new System.Drawing.Point(403, 33);
            this.rtbEncasedCode.Name = "rtbEncasedCode";
            this.rtbEncasedCode.Size = new System.Drawing.Size(394, 564);
            this.rtbEncasedCode.TabIndex = 9;
            this.rtbEncasedCode.Text = "";
            // 
            // frmSaviPut
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(800, 686);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSaviPut";
            this.Text = "SaviPut";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}