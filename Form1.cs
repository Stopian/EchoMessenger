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
            UserInput = UserInput.Trim(); // txtUserInput 에 입력한 텍스트의 앞뒤 공백을 제거해줌
            string time = DateTime.Now.ToString("HH:mm:ss");

            if (string.IsNullOrEmpty(txtUserInput.Text))
            {
                return; // txtUserInput 에 입력한 텍스트가 없으면 재호출
            }
            else
            {
                lstTextInput.Items.Add($"[{time}] {UserInput}"); // lstTextInput 에 UserInput 텍스트를 입력
            }
            txtUserInput.Text = ""; // txtUserInput 에 입력한 텍스트를 지워줌

            txtUserInput.Focus(); // txtUserInput 에 입력한 텍스트를 지운 후에도 txtUserInput 에 커서가 위치하도록 해줌

            lblTextCount.Text = ($"현재 대화 : {lstTextInput.Items.Count} 개"); // lblTextCount 라는 레이블에 txtUserInput 에 입력한 텍스트의 개수를 표시해줌

        }

        private void txtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btrupload_Click(sender, e);
            }
        }
    }
}
