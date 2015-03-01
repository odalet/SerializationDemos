@echo off

set indir=%~dp0proto
set outdir=%~dp0java-output

echo INDIR : %indir%
echo OUTDIR: %outdir%

echo Cleaning and recreating output directory
if exist "%outdir%\" (
	rmdir /S /Q "%outdir%\"
) 

mkdir "%outdir%\"

"%~dp0..\bin\protobuf\protoc.exe" --proto_path="%indir%" --java_out="%outdir%" %indir%\city.proto

