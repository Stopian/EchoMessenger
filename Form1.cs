using System.Transactions;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Echo_Messenger
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void btrupload_Click(object sender, EventArgs e)
        {

            string UserInput = txtUserInput.Text; // txtUserInput 에 입력한 텍스트를 UserIntut 라는 변수에 저장해줌
            lstTextInput.Items.Add(UserInput); // lstTextInput 에 UserInput 텍스트를 입력
            txtUserInput.Text = ""; // txtUserInput 에 입력한 텍스트를 지워줌

        }

    }
}
