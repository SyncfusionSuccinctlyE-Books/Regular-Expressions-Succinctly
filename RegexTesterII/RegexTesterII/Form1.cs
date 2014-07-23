using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Text;

namespace RegexTesterII
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


        private void RunBtn_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();  // Create a high resolution time

            SLAB.Text = "";
            TV.Nodes.Clear();

            // Reset all colors
            rtb.SelectAll();
            rtb.SelectionBackColor = BGColor;
            rtb.SelectionColor = FGColor;

            string pattern = TB.Text.Trim();
            string source = rtb.Text;
            Boolean isGlobal = false;

            if (clearCache.Checked)
            {
                Regex.CacheSize=0;
                clearCache.Checked = false;
            }

            RegexOptions theOpts = RegexOptions.None;

            foreach (var item in CB.CheckedItems)
            {
                if (item.ToString().ToLower() == "global") { isGlobal = true; }
                if (item.ToString().ToLower() == "multiline") { theOpts = theOpts | RegexOptions.Multiline; }
                if (item.ToString().ToLower() == "ignore case") { theOpts = theOpts | RegexOptions.IgnoreCase; }
                if (item.ToString().ToLower() == "singleline") { theOpts = theOpts | RegexOptions.Singleline; }
                if (item.ToString().ToLower() == "compiled") { theOpts = theOpts | RegexOptions.Compiled; }
                if (item.ToString().ToLower() == "ignorepatternwhitespace") { theOpts = theOpts | RegexOptions.IgnorePatternWhitespace; }
                if (item.ToString().ToLower() == "righttoleft") { theOpts = theOpts | RegexOptions.RightToLeft;}
                if (item.ToString().ToLower() == "emcascript") { theOpts = theOpts | RegexOptions.ECMAScript; }
                if (item.ToString().ToLower() == "cultureinvariant") { theOpts = theOpts | RegexOptions.CultureInvariant; }
            }



            // Start the timer
            stopWatch.Start();

            List<TreeNode> rootNode = new List<TreeNode>();
            int TreeIndex = -1;

            // If global, then iterate the Matches collection
            if (isGlobal)
            {
                try
                {
                    Regex theExpr = new Regex(pattern,theOpts);

                    foreach (Match match in theExpr.Matches(source))
                    {
                        int endindex = match.Length;
                        rtb.Select(match.Index, endindex);
                        rtb.SelectionBackColor = BGHighlight;
                        rtb.SelectionColor = FGHighlight;

                        rootNode.Add(TV.Nodes.Add("[ " + match.Value + " ]"));
                        TreeIndex++;


                        foreach (string groupName in theExpr.GetGroupNames())
                        {
                            Group theGroup = match.Groups[groupName];
                            if (groupName != "0")
                            {
                                TreeNode ChildNode = rootNode[TreeIndex].Nodes.Add("<" + groupName + "> (" + theGroup + ")");
                                foreach (Capture theCapture in theGroup.Captures)
                                {
                                    ChildNode.Nodes.Add(theCapture.Value);
                                }
                            }
                        }
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

                    Regex theExpr = new Regex(pattern, theOpts);
                    Match theMatch = theExpr.Match(source);
                    if (theMatch.Success)
                    {
                        int endindex = theMatch.Length;
                        rtb.Select(theMatch.Index, endindex);
                        rtb.SelectionBackColor = BGHighlight;
                        rtb.SelectionColor = FGHighlight;

                        string theDay = theMatch.Groups["Digit"].Value;
                        string theLetters = theMatch.Groups[2].Value;

                        CultureInfo defaultCulture = Thread.CurrentThread.CurrentCulture;
                        Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");

                        // Process the regex, using tr-FR (French) casing rules

                        Thread.CurrentThread.CurrentCulture = defaultCulture;


                        rootNode.Add(TV.Nodes.Add("[ " + theMatch.Value + " ]"));
                        TreeIndex++;

                        foreach (string groupName in theExpr.GetGroupNames())
                        {
                            Group theGroup = theMatch.Groups[groupName];
                            if (groupName != "0")
                            {
                                TreeNode ChildNode = rootNode[TreeIndex].Nodes.Add("<" + groupName + "> (" + theGroup + ")");
                                foreach (Capture theCapture in theGroup.Captures)
                                {
                                    ChildNode.Nodes.Add(theCapture.Value);
                                }
                            }
                        }
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
            TV.ExpandAll();

            // Record how long the processing took
            stopWatch.Stop();
            TimeSpan HowLong = stopWatch.Elapsed;
            Double TotalTicks = HowLong.TotalMilliseconds;
            TimeLabel.Text = TotalTicks.ToString("F3") + " ms";
        }
    }
}
