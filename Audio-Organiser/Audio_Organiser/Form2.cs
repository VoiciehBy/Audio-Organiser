using System;
using System.Windows.Forms;

namespace Audio_Organiser
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void resolutionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                MainWindow mW = new MainWindow();
                if (resolutionsBox.SelectedItem == resolutionsBox.Items[0])
                {
                    Width = 1280;
                    Height = 768;
                    mW.moveButtonsEtc(0, 0);
                    mW.resizeColumns(0, 0, 272, 189, 164, 137, 59, 149);
                    this.Hide();
                    mW.Show();
            }
                else if (resolutionsBox.SelectedItem == resolutionsBox.Items[1])
                {
                    Width = 1024;
                    Height = 768;
                    mW.moveButtonsEtc(-250, 0);
                    mW.resizeColumns(0, 0, 150, 135, 145, 140, 60, 90);
                    this.Hide();
                    mW.Show();
            }
                else if (resolutionsBox.SelectedItem == resolutionsBox.Items[2])
                {
                    Width = 800;
                    Height = 768;
                    mW.moveButtonsEtc(-350, 0, -503, 29);
                    mW.resizeColumns(0, 0, 110, 85, 100, 80, 50, 60);
                    this.Hide();
                    mW.Show();
            }
            }
        }
    }
