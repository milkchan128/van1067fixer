using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace van1067fixer
{
    public partial class van1067fixer : Form
    {
        public van1067fixer()
        {
            InitializeComponent();

            // 관리자 권한 체크
            if (!IsAdministrator())
            {
                MessageBox.Show("⚠️ 이 프로그램은 관리자 권한으로 실행되어야 합니다.\n\n관리자 권한으로 다시 실행해주세요.", "관리자 권한 필요", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0); // 프로그램 종료
            }
        }

        private bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void van1067fixer_Load(object sender, EventArgs e)
        {

        }

        private void fix_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "계속하시면 해결 완료 후 5초 후 자동으로 재부팅됩니다.\n계속하시겠습니까?",
                "Vanguard 설정 및 재부팅",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    RunCmdCommand("sc start \"vgc\"");
                    RunCmdCommand("sc config \"vgc\" start= delayed-auto");
                    RunCmdCommand("shutdown -r -t 5");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("작업이 취소되었습니다.");
            }
        }

        private void RunCmdCommand(string command)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c " + command;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;

            Process process = Process.Start(psi);
            process.WaitForExit();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = "/c \"shutdown -a\"";

                psi.UseShellExecute = true;
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.Verb = "runas"; // 관리자 권한 실행

                Process process = Process.Start(psi);
                process.WaitForExit();

                MessageBox.Show("재부팅이 취소되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }
    }
}
