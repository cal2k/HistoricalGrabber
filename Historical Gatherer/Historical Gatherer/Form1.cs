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
        string path, pathF, pathG, pathTL, temp, trickname;
        List<string> trick = new List<string>();
        List<string> rotatsion = new List<string>();
        List<string> start = new List<string>();
        List<string> end = new List<string>();

        List<string> grind = new List<string>();
        List<string> gstart = new List<string>();
        List<string> gend = new List<string>();
        
        //Select Buttons
        private void btnSelect_Click(object sender, EventArgs e)
        {
            openbrowser();
            pathF = path;
            lblPath.Text = pathF;
            btnGenFlip.Enabled = true;
        }
        private void btnSelectGrindList_Click(object sender, EventArgs e)
        {
            openbrowser();
            pathG = path;
            lblPathGrind.Text = pathG;
            btnGenGrind.Enabled = true;
        }
        private void btnSelectTrickLine_Click(object sender, EventArgs e)
        {
            openbrowser();
            pathTL = path;
            lblPathTrickLine.Text = pathTL;
            btnGenTrickLine.Enabled = true;
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
        
        
        //Short Cut Buttons
        private void button1_Click_1(object sender, EventArgs e)
        {
            pathF = "C:\\Users\\Cal\\Desktop\\Historical Flips.txt";
            lblPath.Text = pathF;
            btnGenFlip.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pathG = "C:\\Users\\Cal\\Desktop\\Historical Grinds.txt";
            lblPathGrind.Text = pathG;
            btnGenGrind.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pathTL = "C:\\Users\\Cal\\Desktop\\Historical Trickline.txt";
            lblPathTrickLine.Text = pathTL;
            btnGenGrind.Enabled = true;
        }



        //Generate List Buttons
        private void btnGen_Click(object sender, EventArgs e)
        {
            foreach (var line in File.ReadAllLines(pathF))
            {
                if (line.Contains("\"trickName\":"))
                {
                    temp = line;
                    temp = temp.Remove(0, 15);
                    temp = temp.Substring(0, temp.Length - 2);
                    temp = temp.Replace("_", " ");

                    trickname = temp;
                    temp = trickname.Substring(0, 3);
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
                    trick.Add(trickname);
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
                    temp = line;
                    temp = temp.Remove(0, 25);
                    temp = temp.Substring(0, temp.Length - 2);
                    start.Add(temp);
                }
                if (line.Contains("\"endLocationName\":"))
                {
                    temp = line;
                    temp = temp.Remove(0, 23);
                    temp = temp.Substring(0, temp.Length - 1);
                    end.Add(temp);
                }
            }

            string newpath = pathF.Substring(0, pathF.Length - 4) + " New.txt";

            if (!File.Exists(newpath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(newpath))
                {
                    // Loop over trick and rotation and write with
                    for (int i = 0; i < trick.Count(); i++)
                    {
                        temp = "Trick - " + trick[i] + " Rotation - " + rotatsion[i] + "    Location - " + start[i] + "  -  " + end[i];
                        sw.WriteLine(temp);
                    }

                    MessageBox.Show("Fliptrick Historical list complete");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var line in File.ReadAllLines(pathG))
            {
                if (line.Contains("\"grindName\":"))
                {
                    temp = line;
                    temp = temp.Remove(0, 14);
                    temp = temp.Substring(0, temp.Length - 2);
                    temp = temp.Replace("_", " ");

                    string grindname = temp;
                    temp = grindname.Substring(0, 3);
                    grind.Add(grindname);
                }
                if (line.Contains("\"startLocationName\":"))
                {
                    temp = line;
                    temp = temp.Remove(0, 25);
                    temp = temp.Substring(0, temp.Length - 2);
                    gstart.Add(temp);
                }
                if (line.Contains("\"endLocationName\":"))
                {
                    temp = line;
                    temp = temp.Remove(0, 23);
                    temp = temp.Substring(0, temp.Length - 2);
                    gend.Add(temp);
                }
            }
            string newpath = pathG.Substring(0, pathG.Length - 4) + " New.txt";

            if (!File.Exists(newpath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(newpath))
                {
                    // Loop over trick and rotation and write with
                    for (int iii = 0; iii < grind.Count(); iii++)
                    {
                        temp = "Grind - " + grind[iii] + "    Location - " + gstart[iii] + "   -   " + gend[iii];
                        sw.WriteLine(temp);
                    }

                    MessageBox.Show("Grind Historical list complete");
                }

            }

        }
    }
}
