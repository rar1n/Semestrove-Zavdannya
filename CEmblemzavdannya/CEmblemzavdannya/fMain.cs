namespace CEmblemzavdannya
{
    public partial class fMain : Form
    {
        CEmblem[] emblems;
        int EmblemCount = 0;
        int CurrentEmblemIndex;
        public fMain()
        {
            InitializeComponent();
            emblems = new CEmblem[100];
        }
        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (EmblemCount >= 99)
            {
                MessageBox.Show("Досягнуто межі кількості емблем!");
                return;
            }
            Graphics graphics = pnMain.CreateGraphics();
            CurrentEmblemIndex = EmblemCount;
            emblems[CurrentEmblemIndex] = new CEmblem(graphics, pnMain.Width / 2, pnMain.Height / 2, 50);
            emblems[CurrentEmblemIndex].Show();
            EmblemCount++;
            cbCircles.Items.Add("Коло №" + (EmblemCount - 1).ToString());
            cbCircles.SelectedIndex = EmblemCount - 1;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Show();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Expand(5);
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Collapse(5);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Move(0, -10);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Move(0, 10);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Move(10, 0);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            emblems[CurrentEmblemIndex].Move(-10, 0);
        }

        private void btnRightFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnLeftFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }

        }

        private void btnUpFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void btnDownFar_Click(object sender, EventArgs e)
        {
            CurrentEmblemIndex = cbCircles.SelectedIndex;
            if ((CurrentEmblemIndex > EmblemCount) || (CurrentEmblemIndex < 0))
                return;
            for (int i = 0; i < 100; i++)
            {
                emblems[CurrentEmblemIndex].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
        }
    }
}
