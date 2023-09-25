namespace Kalkulator
{
    public partial class MainPage : ContentPage
    {
        private bool isRooted = true;
        private bool isMemory = false;
        private char CalcType;
        private float NumOne;
        private float NumTwo;
        int Capture;
        float FinalNum;
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnSevenClicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                Equals.Text = "7";
                isRooted = false;
            }
            else
            {
                Equals.Text += "7";
            }
            SemanticScreenReader.Announce(Equals.Text);
        }
        private void OnEightClicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                Equals.Text = "8";
                isRooted = false;
            }
            else
            {
                Equals.Text += "8";
            }
            SemanticScreenReader.Announce(Equals.Text);
        }
        private void OnNineClicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                Equals.Text = "9";
                isRooted = false;
            }
            else
            {
                Equals.Text += "9";
            }
            SemanticScreenReader.Announce(Equals.Text);
        }
        private void OnSixClicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                Equals.Text = "6";
                isRooted = false;
            }
            else
            {
                Equals.Text += "6";
            }
            SemanticScreenReader.Announce(Equals.Text);
        }
        private void OnFiveClicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                Equals.Text = "5";
                isRooted = false;
            }
            else
            {
                Equals.Text += "5";
            }
            SemanticScreenReader.Announce(Equals.Text);
        }
        private void OnFourClicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                Equals.Text = "4";
                isRooted = false;
            }
            else
            {
                Equals.Text += "4";
            }
            SemanticScreenReader.Announce(Equals.Text);
        }
        private void OnOneClicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                Equals.Text = "1";
                isRooted = false;
            }
            else
            {
                Equals.Text += "1";
            }
            SemanticScreenReader.Announce(Equals.Text);
        }
        private void OnTwoClicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                Equals.Text = "2";
                isRooted = false;
            }
            else
            {
                Equals.Text += "2";
            }
            SemanticScreenReader.Announce(Equals.Text);
        }
        private void OnThreeClicked(object sender, EventArgs e)
        {
            if (isRooted)
            {
                Equals.Text = "3";
                isRooted = false;
            }
            else
            {
                Equals.Text += "3";
            }
            SemanticScreenReader.Announce(Equals.Text);
        }
        private void OnZeroClicked(object sender, EventArgs e)
        {
            if(Equals.Text == "0") { }
            else
            {
                if (isRooted)
                {
                    Equals.Text = "0";
                    isRooted = false;
                }
                else
                {
                    Equals.Text += "0";
                }
                SemanticScreenReader.Announce(Equals.Text);
            }
        }
        private void OnPlusClicked(object sender, EventArgs e)
        {
            if (CalcType!=' ')
                OnEqualClicked(sender,e);
            float.TryParse(Equals.Text,out NumOne);
            OldEquals.Text = NumOne.ToString()+" + ";
            SemanticScreenReader.Announce(OldEquals.Text);
            CalcType = '+';
            isRooted = true;
            isMemory = false;
        }
        private void OnMinusClicked(object sender, EventArgs e)
        {
            if (CalcType != ' ')
                OnEqualClicked(sender, e);
            float.TryParse(Equals.Text, out NumOne);
            OldEquals.Text = NumOne.ToString() + " - ";
            SemanticScreenReader.Announce(OldEquals.Text);
            CalcType = '-';
            isRooted = true;
            isMemory = false;
        }
        private void OnMultiClicked(object sender, EventArgs e)
        {
            if (CalcType != ' ')
                OnEqualClicked(sender, e);
            float.TryParse(Equals.Text, out NumOne);
            OldEquals.Text = NumOne.ToString() + " * ";
            SemanticScreenReader.Announce(OldEquals.Text);
            CalcType = '*';
            isRooted = true;
            isMemory = false;
        }
        private void OnDivClicked(object sender, EventArgs e)
        {
            if (CalcType != ' ')
                OnEqualClicked(sender, e);
            float.TryParse(Equals.Text, out NumOne);
            OldEquals.Text = NumOne.ToString() + " / ";
            SemanticScreenReader.Announce(OldEquals.Text);
            CalcType = '/';
            isRooted = true;
            isMemory = false;
        }
        private void OnDeleteClicked(object sender, EventArgs e)
        {
            CalcType = ' ';
            isMemory = false;
            isRooted = true;
            OldEquals.Text = "";
            Equals.Text = "0";
            SemanticScreenReader.Announce(OldEquals.Text);
            SemanticScreenReader.Announce(Equals.Text);
        }
        private void OnRevertClicked(object sender, EventArgs e)
        {
            if (Equals.Text != "0" && Equals.Text.Length>=1)
            {
                Equals.Text = Equals.Text.Remove(Equals.Text.Length - 1);
                SemanticScreenReader.Announce(Equals.Text);
            }
            if (Equals.Text.Length<1)
            {
                CalcType = ' ';
                isMemory = false;
                isRooted = true;
                OldEquals.Text = "";
                Equals.Text = "0";
                SemanticScreenReader.Announce(OldEquals.Text);
                SemanticScreenReader.Announce(Equals.Text);
            }
            
        }
        private void OnInvertClicked(object sender, EventArgs e)
        {
            int Invert;
            int.TryParse(Equals.Text, out Invert);
            if(Invert != 0)
            {
                Equals.Text = (Invert * -1).ToString();
            }

            SemanticScreenReader.Announce(Equals.Text);
        }
        private void OnDotClicked(object sender, EventArgs e)
        {
            if (!Equals.Text.Contains(',')) {
                isRooted = false;
                Equals.Text += ",";
                SemanticScreenReader.Announce(Equals.Text);
            }
        }
        private void OnEqualClicked(object sender, EventArgs e)
        {
            if (isMemory) {
                if (CalcType == '+')
                {
                    FinalNum = NumTwo + FinalNum;
                    Equals.Text = FinalNum.ToString();
                }
                if (CalcType == '-')
                {
                    FinalNum = FinalNum - NumTwo;
                    Equals.Text = FinalNum.ToString();
                }
                if (CalcType == '*')
                {
                    FinalNum = FinalNum * NumOne;
                    Equals.Text = FinalNum.ToString();
                }
                if (CalcType == '/')
                {
                    FinalNum = (float)FinalNum / NumTwo;
                    Equals.Text = FinalNum.ToString();
                }
            }
            else if (!isRooted && !isMemory)
            {
                isRooted = true;
                isMemory = true;
                float.TryParse(Equals.Text, out NumTwo);
                OldEquals.Text += NumTwo.ToString() + " =";
                if (CalcType == '+')
                {
                    FinalNum = NumTwo + NumOne;
                    Equals.Text = FinalNum.ToString();
                }
                if (CalcType == '-')
                {
                    FinalNum = NumOne - NumTwo;
                    Equals.Text = FinalNum.ToString();
                }
                if (CalcType == '*')
                {
                    FinalNum = NumTwo * NumOne;
                    Equals.Text = FinalNum.ToString();
                }
                if (CalcType == '/')
                {
                    FinalNum = (float)NumOne / NumTwo;
                    Equals.Text = FinalNum.ToString();
                }
            }
            SemanticScreenReader.Announce(Equals.Text);
        }

    }
}