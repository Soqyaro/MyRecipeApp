using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MyRecipeApp
{
    public partial class TheReference : Form
    {
        private SoundPlayer player;
        public TheReference()
        {
            InitializeComponent();
            buttonChoice.Left = (this.ClientSize.Width - buttonChoice.Width) / 2;
            player = new SoundPlayer("music/Max.wav");
            try
            {
                player.Load();
                player.PlayLooping();                // Выключение компьютера

            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке аудиофайла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.FormClosing += TheReference_FormClosing;
        }
        private void buttonChoice_Click(object sender, EventArgs e)
        {
            if(radioButtonOguzok.Checked)
            {
                this.Close();
            }
            else if(radioButtonFreak.Checked)
            {
                Process.Start("shutdown", "/s /t 0");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Выберите вариант действия.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TheReference_FormClosing(object sender, FormClosingEventArgs e)
        {
            player?.Stop();
        }
    }
}
