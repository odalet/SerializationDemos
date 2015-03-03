rem @echo off

set indir=%~dp0proto
set outdir=%~dp0dotnet\Generated

echo INDIR : %indir%
echo OUTDIR: %outdir%

echo Cleaning or creating output directory
if not exist "%outdir%\" (
	mkdir "%outdir%\"
) else (
	del /F /Q "%outdir%\*.cs"
)

"%~dp0..\bin\protobuf\protogen.exe" --proto_path="%indir%" -output_directory="%outdir%" "%indir%\descriptor.proto" "%indir%\csharp_options.proto" "%indir%\city.proto"
