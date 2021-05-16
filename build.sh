#!/usr/bin/env bash

/usr/bin/csc /out:toy *.cs && chmod 755 toy
# /usr/bin/csc /reference:System.Net.Http.dll /reference:Newtonsoft.Json.dll /out:toy *.cs && chmod 755 toy
