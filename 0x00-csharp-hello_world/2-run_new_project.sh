#!/usr/bin/env bash
# create, build, and run a new .NET project

dotnet new console --output 2-new_project
cd 2-new_project
dotnet build
dotnet run
