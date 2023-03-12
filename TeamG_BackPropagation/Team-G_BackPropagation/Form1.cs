﻿using Backprop;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_G_BackPropagation
{
    public partial class Form1 : Form
    {
        String fileName;
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void train_Click(object sender, EventArgs e)
        {

            var data = File.ReadAllLines(fileName)
                    .Skip(1) // Skip header row
                    .Select(row => row.Split(',')) // Split rows by comma
                    .Select(row => new
                    {
                        Inputs = row.Take(row.Length - 1).Select(float.Parse).ToArray(),
                        Output = float.Parse(row.Last())
                    })
                    .ToArray();

            // Create neural network
            var numInputs = data.First().Inputs.Length;
            var numOutputs = 1;
            var numHidden = 10; // Adjust as needed
            nn = new NeuralNet(numInputs, numHidden, numOutputs);

            for (int i = 0; i < Convert.ToInt32(epochs.Text); i++)
            {
                // Train neural network
                foreach (var row in data)
                {
                    nn.setInputs(0, row.Inputs[0]);
                    nn.setInputs(1, row.Inputs[1]);
                    nn.setInputs(2, row.Inputs[2]);
                    nn.setInputs(3, row.Inputs[3]);
                    nn.setInputs(4, row.Inputs[4]);
                    nn.setInputs(5, row.Inputs[5]);
                    nn.setInputs(6, row.Inputs[6]);
                    nn.setInputs(7, row.Inputs[7]);
                    nn.setInputs(8, row.Inputs[8]);
                    nn.setInputs(9, row.Inputs[9]);
                    nn.setInputs(10, row.Inputs[10]);
                    nn.setInputs(11, row.Inputs[11]);
                    nn.setInputs(12, row.Inputs[12]);
                    nn.setDesiredOutput(0, row.Output);
                    nn.learn();
                }
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(age.Text));
            nn.setInputs(1, Convert.ToDouble(sex.Text));
            nn.setInputs(2, Convert.ToDouble(scholar.Text));
            nn.setInputs(3, Convert.ToDouble(study.Text));
            nn.setInputs(4, Convert.ToDouble(nonsci.Text));
            nn.setInputs(5, Convert.ToDouble(sci.Text));
            nn.setInputs(6, Convert.ToDouble(attendance.Text));
            nn.setInputs(7, Convert.ToDouble(mid1.Text));
            nn.setInputs(8, Convert.ToDouble(mid2.Text));
            nn.setInputs(9, Convert.ToDouble(notes.Text));
            nn.setInputs(10, Convert.ToDouble(listen.Text));
            nn.setInputs(11, Convert.ToDouble(interest.Text));
            nn.setInputs(12, Convert.ToDouble(grade.Text));
            nn.run();

            output.Text = nn.getOuputData(0).ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            epochs.Text = "";
            age.Text = "";
            sex.Text = "";
            scholar.Text = "";
            study.Text = "";
            nonsci.Text = "";
            sci.Text = "";
            attendance.Text = "";
            mid1.Text = "";
            mid2.Text = "";
            notes.Text = "";
            listen.Text = "";
            interest.Text = "";
            grade.Text = "";
            output.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileName = openFileDialog1.FileName;
        }
    }
}
