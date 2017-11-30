#! "netcoreapp2.0"
#r "nuget:NetStandard.Library,2.0.0"
#r "nuget:System.ComponentModel.Primitives,4.3.0"

var info = new ProcessStartInfo();
info.Arguments = "./CSharp/Send.sh";
info.FileName = "bash";

var process = new Process();
process.StartInfo = info;
process.Start();