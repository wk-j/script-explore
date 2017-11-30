

var info = new ProcessStartInfo();
info.Arguments = "./CSharp/Send.sh";
info.FileName = "bash";

var process = new Process();
process.StartInfo = info;
process.Start();