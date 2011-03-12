using System.Windows.Forms;

namespace QQTClient
{
    /// <summary>
    /// 主窗口类
    /// </summary>
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录菜单按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog(this);
        }
    }
}
