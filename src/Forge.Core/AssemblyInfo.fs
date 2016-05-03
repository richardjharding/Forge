﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Forge.Core")>]
[<assembly: AssemblyProductAttribute("Forge")>]
[<assembly: AssemblyDescriptionAttribute("Forge is a build tool that provides tasks for creating, compiling, and testing F# projects")>]
[<assembly: AssemblyVersionAttribute("0.7.0")>]
[<assembly: AssemblyFileVersionAttribute("0.7.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.7.0"
    let [<Literal>] InformationalVersion = "0.7.0"