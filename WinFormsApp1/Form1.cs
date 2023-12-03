namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        int arrayIndex = 0;
        string[] arrID = new string[1000];
        string[] arrName = new string[1000];
        int[] arrScore = new int[10];

        string inputID;
        string inputNAME;
        string inputScore;

        int max_score, max_index, min_score, min_index;

        int GRAD_A = 0;
        int GRAD_B = 0;
        int GRAD_B2 = 0;
        int GRAD_C = 0;
        int GRAD_C2 = 0;
        int GRAD_D = 0;
        int GRAD_D2 = 0;
        int GRAD_F = 0;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //get input data from textbox
            inputID = tbinputID.Text;
            inputNAME = tbinputNAME.Text;
            inputScore = tbinputScore.Text;
            //create array สร้างเพื่อเก็บข้อมูลไว้

            //add data to array
            arrID[arrayIndex] = inputID;
            arrName[arrayIndex] = inputNAME;
            arrScore[arrayIndex] = int.Parse(inputScore);
            //add data to array
            arrayIndex++;

            // array = [1 ,2 ,3 , 4 ]
            //การหาค่ามากสุด
            max_score = arrScore.Max();
            max_index = arrScore.ToList().IndexOf(max_score);

            tbSCORE1.Text = arrScore[max_index].ToString();
            tbIDScore1.Text = arrID[max_index];
            tbNameScore1.Text = arrName[max_index];


            min_score = max_score;
            for (int i = 0; i < arrayIndex; i++)
            {

                if (arrScore[i] < min_score)
                {

                    min_score = arrScore[i];
                }

            }

            min_index = arrScore.ToList().IndexOf(min_score);


            tbSCORE2.Text = arrScore[min_index].ToString();
            tbIDScore2.Text = arrID[min_index].ToString();
            tbNameScore2.Text = arrName[min_index].ToString();

            int sum = 0;
            for (int i = 0; i < arrayIndex; i++)
            {

                sum += arrScore[i];

            }

            tbAVER.Text = (sum / arrayIndex).ToString();


            int SCORE = int.Parse(tbinputScore.Text);
            if ( SCORE >= 80 && SCORE <= 100)
            {
                GRAD_A += 1;
                tbGA.Text = GRAD_A.ToString();


            }
            
            else if ( SCORE >=75 && SCORE <= 79)
            {
                GRAD_B += 1;
                tbGB.Text = GRAD_B.ToString();

            }

            else if( SCORE >=70 && SCORE <= 74)
            {
                GRAD_B2 += 1;
                tbGB2.Text = GRAD_B2.ToString();

            }

            else if( SCORE >= 65 && SCORE <= 69)
            {
                GRAD_C  += 1;
                tbGC.Text = GRAD_C.ToString();  


            }

            else if( SCORE >=60 && SCORE <= 64)
            {
                GRAD_C2 += 1;
                tbGC2.Text = GRAD_C2.ToString();

            }

            else if (SCORE <=59 && SCORE >= 55)
            {
                GRAD_D += 1;
                tbGD.Text = GRAD_D.ToString();

            }

            else if (SCORE <=54 && SCORE >= 50)
            {
                GRAD_D2 += 1;
                tbGD2.Text = GRAD_D2.ToString();

            }

            else
            {
                GRAD_F  += 1;
                tbGF.Text = GRAD_F.ToString();
            }
        
            double GRA = ((GRAD_A * 4.00)+(GRAD_B *3.50)+(GRAD_B2*3.00)+(GRAD_C *2.50)+(GRAD_C2*2.00)+(GRAD_D*1.50)+(GRAD_D2*1.00))/
                ((GRAD_A)+(GRAD_B)+(GRAD_B2)+(GRAD_C)+(GRAD_C2)+(GRAD_D)+(GRAD_D2));
            gradEVG.Text = String.Format("{0:F2}", GRA);


        }









        private void tbIDScore1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNameScore1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tbNameScore2_TextChanged(object sender, EventArgs e)
        {
            tbNameScore2.Text = inputNAME;
        }

        private void tbSCORE2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSCORE1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tbIDScore2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
