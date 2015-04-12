using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Sharpsolutions.Edt.System.UnitTests.Azure {

    public class Emulator : IDisposable {
        private const string ProcessName = "WAStorageEmulator.exe";
        private const string BasePath = @"..\..\..\..\lib\Storage Emulator\latest";
        public Emulator() { 
           StartEmulator();
        }

        private void StartEmulator()
        {

            Process[] runningEmulator = Process.GetProcessesByName(ProcessName);

            if (!runningEmulator.Any()) {
                ProcessStartInfo start = new ProcessStartInfo {
                    Arguments = "start",
                    FileName = Path.Combine(BasePath,"WAStorageEmulator.exe")
                };

               
                Process proc = new Process {
                    StartInfo = start
                };

                proc.Start();
                proc.WaitForExit();
            }

            IsRunning = true;
        }


        public void Dispose() {
            //so far nothing just keep it running      
        }

        public bool IsRunning { get; private set; }

        public static Emulator Start()
        {
            return new Emulator();
        }
    }
}

