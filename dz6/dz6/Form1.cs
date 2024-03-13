using System.Windows.Forms;

namespace dz6
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();

        private int interval = 1;

        private double curVerVelocity = 3;
        private double curHorVelocity = 3;

        private int dirVerVelocity = -1;
        private int dirHorVelocity = 1;

        DateTime start = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
            PictureBox pic1 = pictureBox1;
            PictureBox pic2 = pictureBoxBox;
            label6.Text = IsTopIntersectsWithBottom(pictureBox1, pictureBoxBox).ToString() + " " + IsBottomIntersectsWithTop(pictureBox1, pictureBoxBox) + " " + IsLeftIntersectsWithRight(pictureBox1, pictureBoxBox) + " " + IsRightIntersectsWithLeft(pictureBox1, pictureBoxBox);
            label5.Text = (pic1.Bounds.Left < pic2.Bounds.Left) + " " + ((pic1.Bounds.Left + pic1.Bounds.Width) > pic2.Bounds.Left) + " " +
                   (pic1.Bounds.Top + pic1.Bounds.Width > pic2.Bounds.Top) + " " + ((pic1.Bounds.Bottom + pic1.Bounds.Width) > pic2.Bounds.Bottom);
        }

        private void move()
        {
            pictureBox1.Top += (int)curVerVelocity * dirVerVelocity;
            pictureBox1.Left += (int)curHorVelocity * dirHorVelocity;

            labelTime.Text = (DateTime.Now - start).TotalSeconds.ToString();
        }
        private bool IsTopIntersectsWithBottom(PictureBox pic1, PictureBox pic2)
        {
            return pic1.Bounds.Top < pic2.Bounds.Top && (pic1.Bounds.Top + pic1.Bounds.Width) > pic2.Bounds.Top &&
                   (pic1.Bounds.Left + pic1.Bounds.Width > pic2.Bounds.Left && (pic1.Bounds.Right + pic1.Bounds.Width) > pic2.Bounds.Right);
        }

        private bool IsBottomIntersectsWithTop(PictureBox pic1, PictureBox pic2)
        {
            return pic1.Bounds.Bottom < pic2.Bounds.Bottom && (pic1.Bounds.Bottom + pic1.Bounds.Width) > pic2.Bounds.Bottom &&
                   (pic1.Bounds.Left + pic1.Bounds.Width > pic2.Bounds.Left && (pic1.Bounds.Right + pic1.Bounds.Width) > pic2.Bounds.Right);
        }

        private bool IsLeftIntersectsWithRight(PictureBox pic1, PictureBox pic2)
        {
            return pic1.Bounds.Left < pic2.Bounds.Left && (pic1.Bounds.Left + pic1.Bounds.Width) > pic2.Bounds.Left &&
                   (pic1.Bounds.Top + pic1.Bounds.Width > pic2.Bounds.Top && (pic1.Bounds.Bottom + pic1.Bounds.Width) > pic2.Bounds.Bottom);
        }

        private bool IsRightIntersectsWithLeft(PictureBox pic1, PictureBox pic2)
        {
            return pic1.Bounds.Right < pic2.Bounds.Right && (pic1.Bounds.Right + pic1.Bounds.Width) > pic2.Bounds.Right &&
                   (pic1.Bounds.Top + pic1.Bounds.Width > pic2.Bounds.Top && (pic1.Bounds.Bottom + pic1.Bounds.Width) > pic2.Bounds.Bottom);
        }

        private void modeVertical()
        {
            if (pictureBox1.Top <= panel2.Top)
            {
                dirVerVelocity = 1;
            }
            else if (pictureBox1.Bottom >= panel2.Bottom)
            {
                dirVerVelocity = -1;
            }

            if (pictureBox1.Bounds.IntersectsWith(pictureBoxBox.Bounds))
            {
                if (IsBottomIntersectsWithTop(pictureBox1, pictureBoxBox))
                {
                    dirVerVelocity *= -1;
                }
                if (IsTopIntersectsWithBottom(pictureBox1, pictureBoxBox))
                {
                    dirVerVelocity *= -1;
                }
            }
        }

        private void modeHorizontal()
        {
            if (pictureBox1.Left <= panel2.Left)
            {
                dirHorVelocity = 1;
            }
            else if (pictureBox1.Right >= panel2.Right)
            {
                dirHorVelocity = -1;
            }

            if (pictureBox1.Bounds.IntersectsWith(pictureBoxBox.Bounds))
            {
                if (IsLeftIntersectsWithRight(pictureBox1, pictureBoxBox))
                {
                    dirHorVelocity *= -1;
                }
                if (IsRightIntersectsWithLeft(pictureBox1, pictureBoxBox))
                {
                    dirHorVelocity *= -1;
                }
            }
        }


        private void ChooseMode(object sender, EventArgs e)
        {
            if (radioButtonVertical.Checked)
            {
                curVerVelocity = trackBarVer.Value;
                curHorVelocity = 0;

                modeVertical();
            }
            else if (radioButtonHorizontal.Checked)
            {
                curHorVelocity = trackBarHor.Value;
                curVerVelocity = 0;

                modeHorizontal();
            }
            else if (radioButtonDiagonal.Checked)
            {
                curHorVelocity = trackBarHor.Value;
                curVerVelocity = trackBarVer.Value;
                modeVertical();
                modeHorizontal();
            }
            else if (radioButtonChaos.Checked)
            {
                //modeChaos();
            }
            else
            {
                timerNow.Stop();
                buttonStart.Text = "Start";

                MessageBox.Show("Вначале нужно выбрать режим", "Ошибка запуска движения",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            move();
            label5.Text = IsTopIntersectsWithBottom(pictureBox1, pictureBoxBox).ToString() + " " + IsBottomIntersectsWithTop(pictureBox1, pictureBoxBox).ToString() + " " + IsLeftIntersectsWithRight(pictureBox1, pictureBoxBox).ToString() + " " + IsRightIntersectsWithLeft(pictureBox1, pictureBoxBox).ToString();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (timerNow.Enabled)
            {
                timerNow.Stop();
                buttonStart.Text = "Start";
            }
            else
            {
                start = DateTime.Now;
                buttonStart.Text = "Stop";
                timerNow.Interval = interval;
                timerNow.Start();
            }

        }

        private void trackBarTimeActivities_Scroll(object sender, EventArgs e)
        {
            if (timerNow.Enabled)
            {
                interval = trackBarTimeActivities.Value;
                timerNow.Stop();
                timerNow.Interval = interval;
                timerNow.Start();
            }
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            ChooseMode(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
