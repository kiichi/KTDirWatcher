namespace KTDirWatcher {
    partial class MainService {
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
            this.fileSystemWatcherMain = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherMain)).BeginInit();
            // 
            // fileSystemWatcherMain
            // 
            this.fileSystemWatcherMain.EnableRaisingEvents = true;
            this.fileSystemWatcherMain.IncludeSubdirectories = true;
            this.fileSystemWatcherMain.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcherMain_Changed);
            this.fileSystemWatcherMain.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcherMain_Created);
            this.fileSystemWatcherMain.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcherMain_Deleted);
            this.fileSystemWatcherMain.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcherMain_Renamed);
            // 
            // MainService
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcherMain)).EndInit();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcherMain;
    }
}
