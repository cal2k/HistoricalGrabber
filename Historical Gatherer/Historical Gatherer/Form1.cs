using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Historical_Gatherer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path, pathTL, temp, trickname, lasttrick;
        List<string> trick = new List<string>();
        List<string> rotatsion = new List<string>();
        List<string> start = new List<string>();
        List<string> end = new List<string>();
        List<string> grind = new List<string>();
        List<string> grindStart = new List<string>();
        List<string> grindEnd = new List<string>();
        //Select Buttons
        private void btnSelect_Click(object sender, EventArgs e)
        {
            openbrowser();
            lblPath.Text = path;
            btnGenFlip.Enabled = true;
        }
        private void btnSelectTrickLine_Click(object sender, EventArgs e)
        {
            openbrowser();
            pathTL = path;
        }
        private void openbrowser()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                path = selectedFileName;
            }
        }

        

        private void FormatTrick()
        {
            temp = temp.Remove(0, 15);
            temp = temp.Substring(0, temp.Length - 2);
            temp = temp.Replace("_", " ");
        }
        private void CheckStance()
        {
            switch (temp)
            {
                case "RGS":
                    temp = "Regular";
                    trickname = trickname.Remove(0, 3);
                    trickname = temp + trickname;
                    break;
                case "SWS":
                    temp = "Switch";
                    trickname = trickname.Remove(0, 3);
                    trickname = temp + trickname;
                    break;
                case "NLS":
                    temp = "Nollie";
                    trickname = trickname.Remove(0, 3);
                    trickname = temp + trickname;
                    break;
                case "FKS":
                    temp = "Fakie";
                    trickname = trickname.Remove(0, 3);
                    trickname = temp + trickname;
                    break;
                default:
                    break;
            }
        }
        //Generate List Buttons
        private void btnGen_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var line in File.ReadAllLines(path))
                {
                    if (line.Contains("\"trickName\":"))
                    {
                        lasttrick = "flip";
                        temp = line;
                        FormatTrick();
                        trickname = temp;
                        temp = trickname.Substring(0, 3);
                        CheckStance();

                        trick.Add(trickname);
                    }
                    if (line.Contains("\"grindName\":"))
                    {
                        lasttrick = "grind";
                        temp = line;
                        FormatTrick();
                        trickname = temp;
                        grind.Add(trickname);
                    }
                    if (line.Contains("\"trickRotation\":"))
                    {
                        temp = line;
                        temp = temp.Remove(0, 19);
                        temp = temp.Substring(0, temp.Length - 2);
                        temp = temp.Replace("ELTRT_", "");
                        rotatsion.Add(temp);
                    }
                    if (line.Contains("\"startLocationName\":"))
                    {
                        if (lasttrick == "flip")
                        {
                            temp = line;
                            temp = temp.Remove(0, 25);
                            temp = temp.Substring(0, temp.Length - 2);
                            start.Add(temp);
                        }
                        if (lasttrick == "grind")
                        {
                            temp = line;
                            temp = temp.Remove(0, 25);
                            temp = temp.Substring(0, temp.Length - 2);
                            grindStart.Add(temp);
                        }
                    }
                    if (line.Contains("\"endLocationName\":"))
                    {
                        if (lasttrick == "flip")
                        {
                            temp = line;
                            temp = temp.Remove(0, 23);
                            temp = temp.Substring(0, temp.Length - 1);
                            end.Add(temp);
                        }
                        if (lasttrick == "grind")
                        {
                            temp = line;
                            temp = temp.Remove(0, 23);
                            temp = temp.Substring(0, temp.Length - 1);
                            grindEnd.Add(temp);
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            write();
        }
        private void write()
        {
            DateTime time = new DateTime();
            time = DateTime.Now;
            string newpath = path.Substring(0, path.Length - 4) + "new.txt";

            if (!File.Exists(newpath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(newpath))
                {
                    // Loop over trick and rotation and write with
                    for (int i = 0; i < trick.Count(); i++)
                    {
                        temp = "Trick - " + trick[i] + "    Rotation - " + rotatsion[i] + "    Location - " + start[i] + "  -  " + end[i];
                        sw.WriteLine(temp);
                    }
                    for (int i = 0; i < grind.Count(); i++)
                    {
                        temp = "Trick - " + grind[i] + "    Location - " + start[i] + "  -  " + end[i];
                        sw.WriteLine(temp);
                    }

                    MessageBox.Show("Historical list complete");
                }

            }
        }
    }
}