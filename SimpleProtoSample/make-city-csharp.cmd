@echo off

set indir=%~dp0proto
set outdir=%~dp0csharp-output

echo INDIR : %indir%
echo OUTDIR: %outdir%

echo Cleaning and recreating output directory
if exist "%outdir%\" (
	rmdir /S /Q "%outdir%\"
) 

mkdir "%outdir%\"

"%~dp0..\bin\protobuf\protogen.exe" --proto_path="%indir%" -output_directory="%outdir%" %indir%\city.proto
