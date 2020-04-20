#!/usr/bin/env bash

/usr/bin/csc /out:csharp *.cs && chmod 755 csharp
# /usr/bin/csc /reference:System.Net.Http.dll /reference:Newtonsoft.Json.dll /out:csharp *.cs && chmod 755 csharp
