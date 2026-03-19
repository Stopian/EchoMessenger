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
            if (txtUserInput.Text.Length > 50)
            {
                MessageBox.Show("메시지는 50자까지만 입력 가능합니다.", "알림"); // txtUserInput 에 입력한 텍스트가 50자 이상이면 메시지 박스를 띄워줌
                return;
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTextInput.SelectedIndex != -1)
            {
                lstTextInput.Items.RemoveAt(lstTextInput.SelectedIndex); // lstTextInput 에서 선택한 항목을 삭제해줌
                lblTextCount.Text = ($"현재 대화 : {lstTextInput.Items.Count} 개"); // 초기화 후 lblTextCount 라는 레이블에 txtUserInput 에 입력한 텍스트의 개수를 표시해줌
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택해주세요.");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (lstTextInput.SelectedIndex != -1)
            {
                lstTextInput.Items.Clear();
                lblTextCount.Text = ($"현재 대화 : {lstTextInput.Items.Count} 개"); // 초기화 후 lblTextCount 라는 레이블에 txtUserInput 에 입력한 텍스트의 개수를 표시해줌
            }
            else
            {
                MessageBox.Show("삭제할 내용이 없습니다.");
            }
        }

        
    }
}
