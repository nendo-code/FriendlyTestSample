using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows;
using System.Diagnostics;
using System.Windows.Forms;

namespace TestProject
{
    class TestHelper
    {
        // Formへの参照。
        // このクラス内でのFormへはdynamic型経由でアクセスしているため、
        // コントロール名やメソッド名が変わったらここでアクセスする名前も変更しなければいけないことに注意
        private dynamic targetForm;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TestHelper()
        {
            // テスト対象のプロセスを起動、アタッチして、フォームへの参照を取得
            var path = System.IO.Path.GetFullPath("TestTarget.exe");
            var app = new WindowsAppFriend(Process.Start(path));
            targetForm = app.Type(typeof(Application)).OpenForms[0];
        }

        public bool IsExecute_button_Enable()
        {
            return (bool)targetForm.execute_button.Enabled; 
        }

        public string StatusText()
        {
            return (string)targetForm.result_textBox.Text;
        }

        public void PushExecute()
        {
            targetForm.Execute_button_Click(null, null);
        }

        public void CloseForm()
        {
            targetForm.Close();
        }
    }
}
