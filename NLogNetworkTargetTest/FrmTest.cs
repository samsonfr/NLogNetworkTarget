
using System;
using System.Windows.Forms;

using NLog;

namespace NLogNetworkTargetTest
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
            cmdLog.Click += CmdLog_Click;
        }

        private void CmdLog_Click(object sender, EventArgs e)
        {
            try
            {
                Logger pLogger = LogManager.GetCurrentClassLogger();
                pLogger.Trace(new String('-', 120));
                pLogger.Fatal("Fatal");
                pLogger.Error(new ApplicationException("Exception Text"), "Error");
                pLogger.Warn("Warning");
                pLogger.Info("Info");
                pLogger.Debug("Debug");
                pLogger.Trace("Trace");
            }
            catch (Exception pException)
            {
                MessageBox.Show(pException.Message);
            }
        }
    }
}
