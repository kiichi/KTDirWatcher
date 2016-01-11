//How to implement a simple filewatcher Windows service
//in C# - CodeProject : 
// http://www.codeproject.com/Articles/18521/How-to-implement-a-simple-filewatcher-Windows-serv
//http://www.codeproject.com/Articles/140911/log-net-Tutorial
//http://www.codeproject.com/Articles/18521/How-to-implement-a-simple-filewatcher-Windows-serv
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using log4net.loggly;
using log4net;

namespace KTDirWatcher {
    public partial class MainService : ServiceBase {
        ILog logger;
        public MainService() {
            InitializeComponent();
        }

        protected override void OnStart(string[] args) {
            fileSystemWatcherMain.Path = ConfigurationManager.AppSettings["Path"];            
            log4net.Config.XmlConfigurator.Configure();
            logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            logger.Info("KTDirWatcher Started: " + fileSystemWatcherMain.Path);
        }

        protected override void OnStop() {
            logger.Info("KTDirWatcher Stopped: " + fileSystemWatcherMain.Path);
        }

        private void fileSystemWatcherMain_Changed(object sender, System.IO.FileSystemEventArgs e) {
            logger.Info("Changed: " + e.FullPath);
        }

        private void fileSystemWatcherMain_Created(object sender, System.IO.FileSystemEventArgs e) {
            logger.Info("Created: " + e.FullPath);
        }

        private void fileSystemWatcherMain_Deleted(object sender, System.IO.FileSystemEventArgs e) {
            logger.Info("Deleted: " + e.FullPath);
        }

        private void fileSystemWatcherMain_Renamed(object sender, System.IO.RenamedEventArgs e) {
            logger.Info("Renamed: " + e.FullPath);
        }
    }
}
