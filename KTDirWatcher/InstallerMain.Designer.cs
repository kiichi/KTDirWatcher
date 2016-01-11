namespace KTDirWatcher {
    partial class InstallerMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.KTDirWatcherInstaller = new System.ServiceProcess.ServiceInstaller();
            this.serviceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            // 
            // KTDirWatcherInstaller
            // 
            this.KTDirWatcherInstaller.Description = "KTDirWatcher";
            this.KTDirWatcherInstaller.DisplayName = "KTDirWatcher";
            this.KTDirWatcherInstaller.ServiceName = "KTDirWatcher";
            // 
            // serviceProcessInstaller1
            // 
            this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstaller1.Password = null;
            this.serviceProcessInstaller1.Username = null;
            // 
            // InstallerMain
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.KTDirWatcherInstaller,
            this.serviceProcessInstaller1});

        }

        #endregion

        private System.ServiceProcess.ServiceInstaller KTDirWatcherInstaller;
        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller1;
    }
}