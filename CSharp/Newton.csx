#! "netcoreapp2.0"
#r "nuget:NetStandard.Library,2.0"
#r "nuget:Newtonsoft.Json"

using Newtonsoft.Json;
using System.Collections.Generic;

dynamic a = new
{
    A = 100,
    B = 200,
    C = 300
};

Console.WriteLine(a);