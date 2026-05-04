@echo off
setlocal

title .NET Auto Builder

echo put this batch file in ur project folder
echo and also copy the important part of my .csproj file to ur .csproj file before i can proceed
echo press any key to start compile
pause >nul

cd /d "%~dp0"

echo.
echo deleting old bin + obj...
if exist bin rd /s /q bin
if exist obj rd /s /q obj

echo.
echo restoring project...
dotnet restore -r win-x64
if %errorlevel% neq 0 (
    echo restore failed :c
    pause
    exit /b
)

echo.
echo building release singlefile...
dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true
if %errorlevel% neq 0 (
    echo build failed :c
    pause
    exit /b
)

echo.
echo F I N I S H E D
echo output should be in:
echo bin\Release\net8.0-windows\win-x64\publish\
pause