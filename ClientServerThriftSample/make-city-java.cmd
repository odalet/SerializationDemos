@echo off

set indir=%~dp0thrift
set outdir=%~dp0java\th-server\src\main\java

echo INDIR : %indir%
echo OUTDIR: %outdir%

echo Cleaning output directory
if not exist "%outdir%\" (
	mkdir "%outdir%\"
) else (
	del /S /F /Q "%outdir%\io\delta\thrift\generated\*.java"
)

"%~dp0..\bin\thrift\thrift-0.9.2.exe" --gen java -out "%outdir%" "%indir%\city.thrift"
