using System.Windows.Forms;

using GameOfLifeModels;

namespace GameOfLifeGUI
{
    public partial class MainForm : Form
    {
        Board board;

        Color _cellColor;

        public MainForm()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset(bool randomize = true)
        {
            board = new Board(pictureBox1.Width, pictureBox1.Height, (int)squareSizeNumericUpDown.Value);
            if (randomize)
                board.Randomize((double)densityNumericUpDown.Value / 100);
            Render();
        }

        private void Reset(string startingPattern)
        {
            string[] lines = startingPattern.Split('\n');
            int yOffset = (board.Rows - lines.Length) / 2;
            int xOffset = (board.Columns - lines[0].Length) / 2;

            Reset();
            for (int y = 0; y < lines.Length; y++)
                for (int x = 0; x < lines[y].Length; x++)
                    board.Cells[x + xOffset, y + yOffset].IsAlive = lines[y].Substring(x, 1) == "X";

            Render();
        }

        private void Render()
        {
            using (var bmp = new Bitmap(board.Width, board.Height))
            using (var gfx = Graphics.FromImage(bmp))
            using (var cellBrush = new SolidBrush(_cellColor))
            {
                gfx.Clear(Color.Black);

                var cellSize = (gridCheckBox.Checked && board.CellSize > 1) ?
                                new Size(board.CellSize - 1, board.CellSize - 1) :
                                new Size(board.CellSize, board.CellSize);

                for (int col = 0; col < board.Columns; col++)
                {
                    for (int row = 0; row < board.Rows; row++)
                    {
                        var cell = board.Cells[col, row];
                        if (cell.IsAlive)
                        {
                            var cellLocation = new Point(col * board.CellSize, row * board.CellSize);
                            var cellRect = new Rectangle(cellLocation, cellSize);
                            gfx.FillRectangle(cellBrush, cellRect);
                        }
                    }
                }

                pictureBox1.Image = (Bitmap)bmp.Clone();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            board.Advance();
            Render();
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            Reset(false);
        }

        private void gliderButton_Click(object sender, EventArgs e)
        {
            densityNumericUpDown.Value = 0;
            Reset(randomize: false);
            string startingPattern = "-X-\n" +
                                     "--X\n" +
                                     "XXX";
            Reset(startingPattern);
        }

        private void SpaceshipButton_Click(object sender, EventArgs e)
        {
            densityNumericUpDown.Value = 0;
            string spaceship =
                "--XX-\n" +
                "-XXXX\n" +
                "XX-XX\n" +
                "-XX--";
            Reset(spaceship);
        }

        private void rowButton_Click(object sender, EventArgs e)
        {
            densityNumericUpDown.Value = 0;
            string complexRow =
                "XXXXXXXX-XXXXX---XXX------XXXXXXX-XXXXX";
            Reset(complexRow);
        }

        private void gliderGunButton_Click(object sender, EventArgs e)
        {
            densityNumericUpDown.Value = 0;

            string gliderGun =
                "-------------------------X----------\n" +
                "----------------------XXXX----X-----\n" +
                "-------------X-------XXXX-----X-----\n" +
                "------------X-X------X--X---------XX\n" +
                "-----------X---XX----XXXX---------XX\n" +
                "XX---------X---XX-----XXXX----------\n" +
                "XX---------X---XX--------X----------\n" +
                "------------X-X---------------------\n" +
                "-------------X----------------------";
            //Initialize with glider gun
            Reset(gliderGun);
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e) => Reset();
        private void squareSizeNumericUpDown_ValueChanged(object sender, EventArgs e) => Reset();
        private void densityNumericUpDown_ValueChanged(object sender, EventArgs e) => Reset();

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            board.Advance();
            Render();
        }

        private void runCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = runCheckBox.Checked;
        }

        private void delayNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)delayNumericUpDown.Value;
        }

        private void gridCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Render();
        }

        private void emptyButton_Click(object sender, EventArgs e) => Reset();

        private void colorButton_Click(object sender, EventArgs e)
        {
            var  res = colorDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                _cellColor = colorDialog1.Color;
                Render();
            }
                
        }
    }
}