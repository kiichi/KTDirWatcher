using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace KTDirWatcher {
    [RunInstaller(true)]
    public partial class InstallerMain : System.Configuration.Install.Installer {
        public InstallerMain() {
            InitializeComponent();
        }
    }
}
