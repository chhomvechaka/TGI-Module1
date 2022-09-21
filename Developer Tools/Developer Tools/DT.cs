using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Developer_Tools
{
    public partial class DT : Form
    {
        public DT()
        {
            InitializeComponent();
        }

        private void btnvscode_Click(object sender, EventArgs e)
        {
            var vscode = new ProcessStartInfo("Firefox.exe");
            vscode.Arguments = "https://code.visualstudio.com/sha/download?build=stable&os=win32-x64-user";
            Process.Start(vscode);
        }

        private void btnnode_Click(object sender, EventArgs e)
        {
            var nodeJS = new ProcessStartInfo("Chrome.exe");
            nodeJS.Arguments = "https://nodejs.org/dist/v16.15.0/node-v16.15.0-x64.msi";
            Process.Start(nodeJS);
        }

        private void btnsqlserver_Click(object sender, EventArgs e)
        {
            var sqlServerDeveloperEdition = new ProcessStartInfo("Chrome.exe");
            sqlServerDeveloperEdition.Arguments = "https://go.microsoft.com/fwlink/p/?linkid=866662";
            Process.Start(sqlServerDeveloperEdition);
        }

        private void btnintellij_Click(object sender, EventArgs e)
        {
            var intellijIDE = new ProcessStartInfo("Chrome.exe");
            intellijIDE.Arguments = "https://download.jetbrains.com/idea/ideaIC-2022.1.1.exe";
            Process.Start(intellijIDE);
        }

        private void btnpycharm_Click(object sender, EventArgs e)
        {
            var pycharmIDE = new ProcessStartInfo("Chrome.exe");
            pycharmIDE.Arguments = "https://download.jetbrains.com/python/pycharm-community-2022.1.1.exe";
            Process.Start(pycharmIDE);
        }

        private void btneclipse_Click(object sender, EventArgs e)
        {
            var eclipseIDE = new ProcessStartInfo("Chrome.exe");
            eclipseIDE.Arguments = "https://www.eclipse.org/downloads/download.php?file=/oomph/epp/2022-03/R/eclipse-inst-jre-win64.exe&mirror_id=1273";
            Process.Start(eclipseIDE);
        }

        private void btnvs2022community_Click(object sender, EventArgs e)
        {
            var vs2022community = new ProcessStartInfo("Chrome.exe");
            vs2022community.Arguments = "https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&passive=false&cid=2030";
            Process.Start(vs2022community);
        }

        private void btnsublimetext_Click(object sender, EventArgs e)
        {
            var sublimeText = new ProcessStartInfo("Chrome.exe");
            sublimeText.Arguments = "https://download.sublimetext.com/sublime_text_build_4126_x64_setup.exe";
            Process.Start(sublimeText);
        }

        private void btnapachenetbeans13_Click(object sender, EventArgs e)
        {
            var NetBeans13 = new ProcessStartInfo("Chrome.exe");
            NetBeans13.Arguments = "https://dlcdn.apache.org/netbeans/netbeans-installers/13/Apache-NetBeans-13-bin-windows-x64.exe";
            Process.Start(NetBeans13);
        }

        private void btnatom_Click(object sender, EventArgs e)
        {
            var atom = new ProcessStartInfo("Chrome.exe");
            atom.Arguments = "https://atom.io/download/windows_x64";
            Process.Start(atom);
        }

        private void btnpostgresql_Click(object sender, EventArgs e)
        {
            var postgreSQL = new ProcessStartInfo("Chrome.exe");
            postgreSQL.Arguments = "https://www.enterprisedb.com/postgresql-tutorial-resources-training?uuid=db55e32d-e9f0-4d7c-9aef-b17d01210704&campaignId=7012J000001NhszQAC";
            Process.Start(postgreSQL);
        }

        private void btnmysql_Click(object sender, EventArgs e)
        {
            var mySQL = new ProcessStartInfo("Chrome.exe");
            mySQL.Arguments = "https://dev.mysql.com/get/Downloads/MySQLInstaller/mysql-installer-community-8.0.29.0.msi";
            Process.Start(mySQL);
        }

        private void btnmongodb_Click(object sender, EventArgs e)
        {
            var mongoDB = new ProcessStartInfo("Chrome.exe");
            mongoDB.Arguments = "https://fastdl.mongodb.org/windows/mongodb-windows-x86_64-5.0.8-signed.msi";
            Process.Start(mongoDB);
        }

        private void btnredis_Click(object sender, EventArgs e)
        {
            var redis = new ProcessStartInfo("Chrome.exe");
            redis.Arguments = "https://github.com/redis/redis/archive/7.0.0.tar.gz";
            Process.Start(redis);
        }

        public void btnoracle_Click(object sender, EventArgs e)
        {
            var oracle = new ProcessStartInfo("Chrome.exe");
            oracle.Arguments = "https://www.oracle.com/webapps/redirect/signon?nexturl=https://download.oracle.com/otn/nt/oracle21c/213000/WINDOWS.X64_213000_db_home.zip";
            Process.Start(oracle);
        }

        private void btnjava_Click(object sender, EventArgs e)
        {
            var java = new ProcessStartInfo("Chrome.exe");
            java.Arguments = "https://compress-pdf.obar.info/download/compresspdf";
            Process.Start(java);
        }

        private void btnjavascript_Click(object sender, EventArgs e)
        {
            var javascript = new ProcessStartInfo("Chrome.exe");
            javascript.Arguments = "https://www.pdfdrive.com/download.pdf?id=158409266&h=e0165acb1767639826cf43eb5fab00e9&u=cache&ext=pdf";
            Process.Start(javascript);
        }

        private void btncsharp_Click(object sender, EventArgs e)
        {
            var csharp = new ProcessStartInfo("Chrome.exe");
            csharp.Arguments = "https://www.pdfdrive.com/download.pdf?id=19398012&h=47c9c0be31981fceeeee80addf595dde&u=cache&ext=pdf";
            Process.Start(csharp);
        }

        private void btncpp_Click(object sender, EventArgs e)
        {
            var cpp = new ProcessStartInfo("Chrome.exe");
            cpp.Arguments = "https://www.pdfdrive.com/download.pdf?id=158526740&h=964d3bbccec3e9d5a845b0bb8ba56eb8&u=cache&ext=pdf";
            Process.Start(cpp);
        }

        private void btnpython_Click(object sender, EventArgs e)
        {
            var python = new ProcessStartInfo("Chrome.exe");
            python.Arguments = "https://www.pdfdrive.com/download.pdf?id=158003322&h=e9b3f0ac6df37a2b5c7eb8b1c7836771&u=cache&ext=pdf";
            Process.Start(python);
        }

        private void btnphp_Click(object sender, EventArgs e)
        {
            var php = new ProcessStartInfo("Chrome.exe");
            php.Arguments = "https://b-ok.asia/dl/490781/4b9612?dsource=recommend";
            Process.Start(php);
        }

        private void btnspring_Click(object sender, EventArgs e)
        {
            var spring = new ProcessStartInfo("Chrome.exe");
            spring.Arguments = "https://b-ok.asia/dl/3603790/f6327a";
            Process.Start(spring);
        }

        private void btnreact_Click(object sender, EventArgs e)
        {
            var react = new ProcessStartInfo("Chrome.exe");
            react.Arguments = "https://b-ok.asia/dl/3559153/7943a4";
            Process.Start(react);
        }

        private void btnw3schools_Click(object sender, EventArgs e)
        {
            var w3 = new ProcessStartInfo("Chrome.exe");
            w3.Arguments = "https://www.w3schools.com";
            Process.Start(w3);
        }

        private void btncodecademy_Click(object sender, EventArgs e)
        {
            var codecademy = new ProcessStartInfo("Chrome.exe");
            codecademy.Arguments = "https://www.codecademy.com";
            Process.Start(codecademy);
        }

        private void btncodedamn_Click(object sender, EventArgs e)
        {
            var codedamn = new ProcessStartInfo("Chrome.exe");
            codedamn.Arguments = "https://www.codedamn.com";
            Process.Start(codedamn);
        }

        private void btnfreecodecamp_Click(object sender, EventArgs e)
        {
            var freeCodeCamp = new ProcessStartInfo("Chrome.exe");
            freeCodeCamp.Arguments = "https://www.freecodecamp.org";
            Process.Start(freeCodeCamp);
        }

        private void btnnomadcoders_Click(object sender, EventArgs e)
        {
            var nomadcoders = new ProcessStartInfo("Chrome.exe");
            nomadcoders.Arguments = "https://nomadcoders.co";
            Process.Start(nomadcoders);
        }

        private void btnudemy_Click(object sender, EventArgs e)
        {
            var udemy = new ProcessStartInfo("Chrome.exe");
            udemy.Arguments = "https://www.udemy.com";
            Process.Start(udemy);
        }

        private void btnlinkedinlearning_Click(object sender, EventArgs e)
        {
            var linkedinLearning = new ProcessStartInfo("Chrome.exe");
            linkedinLearning.Arguments = "https://www.linkedin.com/learning/";
            Process.Start(linkedinLearning);
        }

        private void btnodinproject_Click(object sender, EventArgs e)
        {
            var theodinproject = new ProcessStartInfo("Chrome.exe");
            theodinproject.Arguments = "https://www.theodinproject.com/";
            Process.Start(theodinproject);
        }
    }
}
