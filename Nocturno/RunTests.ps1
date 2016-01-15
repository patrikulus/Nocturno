Set-ExecutionPolicy unrestricted -Scope CurrentUser -Force

dnvm setup

dnvm use default

#dnx $PSScriptRoot\src\ClassLibrary4 test.\nxslt2.exe $PSScriptRoot\testresults.xml .\NunitXslt.xslt -o testresultstransformed.xml

Get-ChildItem -Path $PSScriptRoot\test -Filter project.json -Recurse | ForEach-Object { & dnx test }