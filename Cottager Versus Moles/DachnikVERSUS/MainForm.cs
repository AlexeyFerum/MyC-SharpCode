using System;
using System.Windows.Forms;
using LibraryForThird;

namespace DachnikVERSUS
{
    public partial class MainForm : Form
    {
        private Game _game;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void bttnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int)Width.Value < 2)
                    throw new Exception("Error, minimum size of the field - 2X2. Repeat an insert");
                if ((int)Height.Value < 2)
                    throw new Exception("Error, minimum size of the field - 2X2. Repeat an insert");
                if ((int)plantCount.Value < 1)
                    throw new Exception("Error, it is obligatory that on the field there are at least one mole and one plant. Repeat an insert");
                if ((int)moleCount.Value < 1)
                    throw new Exception("Error, it is obligatory that on the field there are at least one mole and one plant. Repeat an insert");

                _game = new Game((int)Width.Value, (int)Height.Value, (int)moleCount.Value, (int)plantCount.Value, this, Upd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Upd()
        {
            if (_game == null)
                return;

            var state = _game.GetState();
            dgv.ColumnCount = state.Inside.GetLength(0);
            dgv.RowCount = state.Inside.GetLength(1);

            for (var i = 0; i < dgv.ColumnCount; i++) {
                for (var j = 0; j < dgv.RowCount; j++) {
                    dgv[i, j].Value = state.Inside[i, j];
                }
            }

            tbPlantsInfo.Lines = state.Plants.ToArray();
            tbMolesInfo.Lines = state.Moles.ToArray();
        }

        private void bttnStop_Click(object sender, EventArgs e) {
            _game = null;
        }
    }
}
