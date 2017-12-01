#! "netcoreapp2.0"
#r "nuget:NetStandard.Library,2.0.0"
#r "nuget:Newtonsoft.Json,10.0.3"

using Newtonsoft.Json;
using System.Linq;
using System;

void testJson()
{
    var rawJson = @"[1,2,3,4]";
    var data = JsonConvert.DeserializeObject<int[]>(rawJson);
    Console.WriteLine(string.Join(",", data));
}

testJson();