#!/usr/bin/env bash
# create and build a .NET project in a new directory

dotnet new console --output 1-new_project
cd 1-new_project
dotnet build
