@echo off

set indir=%~dp0thrift
set outdir=%~dp0dotnet\ThriftClient\Generated

echo INDIR : %indir%
echo OUTDIR: %outdir%

echo Cleaning output directory
if not exist "%outdir%\" (
	mkdir "%outdir%\"
) else (
	del /S /F /Q "%outdir%\*.cs"
)

"%~dp0..\bin\thrift\thrift-0.9.2.exe" --gen csharp -out "%outdir%" "%indir%\city.thrift"
