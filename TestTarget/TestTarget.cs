using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTarget
{
    public partial class TestTarget : Form
    {
        public TestTarget()
        {
            InitializeComponent();
            statusChange(Status.Initializing);
        }

        private enum Status
        {
            Initializing,
            Ready,
            Executing
        }

        private void statusChange(Status status)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { statusChange(status); });
                return;
            }

            switch (status)
            {
                case Status.Initializing:
                    this.execute_button.Enabled = false;// 起動完了までボタン無効にする
                    this.result_textBox.Text = "起動中...";
                    break;
                case Status.Executing:
                    this.execute_button.Enabled = false;// 実行完了までボタン無効にする
                    this.result_textBox.Text = "実行中...";
                    break;
                case Status.Ready:
                    this.execute_button.Enabled = true;// 実行可能
                    this.result_textBox.Text = "実行可能";
                    break;
            }
        }

        private void TestTarget_Load(object sender, EventArgs e)
        {
            new Task(()=> 
            {
                Thread.Sleep(1000);// 1秒後に起動完了する
                statusChange(Status.Ready);
            }).Start();
        }

        private void Execute_button_Click(object sender, EventArgs e)
        {
            statusChange(Status.Executing);
            new Task(() =>
            {
                Thread.Sleep(1000);// 1秒後に実行完了する
                statusChange(Status.Ready);
            }).Start();
        }
    }
}
