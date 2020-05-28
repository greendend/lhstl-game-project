using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lhstl_game_project
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            //pictureMap.Parent = this;
        }
    }
}
