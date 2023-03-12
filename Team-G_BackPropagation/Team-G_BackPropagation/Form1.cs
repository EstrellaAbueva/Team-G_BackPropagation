using Backprop;
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
        Quantify quan;

        public Form1()
        {
            InitializeComponent();
            nn = new NeuralNet(13, 10, 1);
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
            double ages, sexs, scholars, studies, nonscis, scis, attendances, mids1, mids2, note, listens, interests, grades;
            ages = Convert.ToDouble(age.Text);
            sexs = Convert.ToDouble(sex.Text);
            scholars = Convert.ToDouble(scholar.Text);
            studies = Convert.ToDouble(study.Text);
            nonscis = Convert.ToDouble(nonsci.Text);
            scis = Convert.ToDouble(sci.Text);
            attendances = Convert.ToDouble(attendance.Text);
            mids1 = Convert.ToDouble(mid1.Text);
            mids2 = Convert.ToDouble(mid2.Text);
            note = Convert.ToDouble(notes.Text);
            listens = Convert.ToDouble(listen.Text);
            interests = Convert.ToDouble(interest.Text);
            grades = Convert.ToDouble(grade.Text);

            quan = new Quantify();

            double[] array = new double[13];
            array = quan.Equivalent(ages, sexs, scholars, studies, nonscis, scis, attendances, mids1, mids2, note, listens, interests, grades);

            nn.setInputs(0, array[0]);
            nn.setInputs(1, array[1]);
            nn.setInputs(2, array[2]);
            nn.setInputs(3, array[3]);
            nn.setInputs(4, array[4]);
            nn.setInputs(5, array[5]);
            nn.setInputs(6, array[6]);
            nn.setInputs(7, array[7]);
            nn.setInputs(8, array[8]);
            nn.setInputs(9, array[9]);
            nn.setInputs(10, array[10]);
            nn.setInputs(11, array[11]);
            nn.setInputs(12, array[12]);
            nn.run();

            var value = nn.getOuputData(0);

            if (value < 0.33)
            {
                output.Text = "BAD!\n\n" + nn.getOuputData(0).ToString();
            }
            else if(value < 0.66)
            {
                output.Text = "GOOD!\n\n" + nn.getOuputData(0).ToString();
            }
            else if(value < 1)
            {
                output.Text = "VERY GOOD!\n\n" + nn.getOuputData(0).ToString();
            }
            else
            {
                output.Text = "EXCELLENT!\n\n" + nn.getOuputData(0).ToString();
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
