module Measures

// Visual Studio & F#
//    Microsoft Visual Studio Community 2022
//    Version 17.10.0 Preview 3.0
//    VisualStudio.17.Preview/17.10.0-pre.3.0+34804.81
//    Microsoft .NET Framework
//    Version 4.8.09032
//
//    Visual F# Tools   17.10.0-beta.24172.5+8d852e43d35fdac96b1ba52e3bd4b35350035914
//    Microsoft Visual F# Tools

// Compiled with
//     <TargetFramework>net8.0</TargetFramework>
//     <LangVersion>Preview</LangVersion>

type [<Measure>] m
let length = 10<m>

let tenth = length / 10

for i in tenth .. 1<m> .. (length-1<m>) do
    ()

// ...\Library.fs(22,7): error FS0073: internal error: Unrecognized numeric type '?12527 (solved)'.
