@echo off

set indir=%~dp0proto
set outdir=%~dp0java\pb-server\src

echo INDIR : %indir%
echo OUTDIR: %outdir%

echo Cleaning output directory
if not exist "%outdir%\" (
	mkdir "%outdir%\"
) else (
	del /S /F /Q "%outdir%\io\delta\proto\generated\*.java"
)

"%~dp0..\bin\protobuf\protoc.exe" --proto_path="%indir%" --java_out="%outdir%" %indir%\city.proto %indir%\csharp_options.proto %indir%\descriptor.proto
