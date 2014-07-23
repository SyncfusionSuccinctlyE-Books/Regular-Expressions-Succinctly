using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexTester
{
    public partial class MainForm : Form
    {
        Color BGColor = SystemColors.Info;
        Color FGColor = Color.Navy;
        Color BGHighlight = Color.Turquoise;
        Color FGHighlight = Color.Black;

        public MainForm()
        {
            InitializeComponent();
            rtb.BackColor = BGColor;
            rtb.ForeColor = FGColor;
        }

        private void ResetRichTextBox()
        {
            rtb.SelectAll();
            rtb.SelectionBackColor = BGColor;
            rtb.SelectionColor = FGColor;
        }

        private void BN_Click(object sender, EventArgs e)
        {
            SLAB.Text = "";
            // Reset all colors
            ResetRichTextBox();

            string pattern = TB.Text.Trim();
            string source = rtb.Text;

            RegexOptions theOpts = RegexOptions.None;

            if (MLCB.Checked) { theOpts = theOpts | RegexOptions.Multiline; }
            if (SLCB.Checked) { theOpts = theOpts | RegexOptions.Singleline; }
            if (ICCB.Checked) { theOpts = theOpts | RegexOptions.IgnoreCase; }

            // If global, then iterate the Matches collection
            if (GBCB.Checked)
            {
                try
                {
                    foreach (Match match in Regex.Matches(source, pattern, theOpts))
                    {
                        HighLightResult(match);
                    }
                }
                catch (Exception ex)
                {
                     SLAB.Text = ex.Message;
                }
            }
            else
            {
                try
                {
                    Match theMatch = Regex.Match(source, pattern, theOpts);
                    if (theMatch.Success)
                    {
                        HighLightResult(theMatch);
                    }
                    else
                    {
                        SLAB.Text = "Not found...";
                    }
                }
                catch (Exception ex)
                    {
                        SLAB.Text = ex.Message;
                    }

            }
        }

        private void HighLightResult(Match OneMatch)
        {
            int endindex = OneMatch.Length;
            rtb.Select(OneMatch.Index, endindex);
            rtb.SelectionBackColor = BGHighlight;
            rtb.SelectionColor = FGHighlight;

        }
    }
}
