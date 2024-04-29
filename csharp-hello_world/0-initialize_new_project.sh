#!/usr/bin/bash

# Create a new .NET console application project
# The output directory is specified by the first argument, or defaults to "0-new_project"
dotnet new console -o ${1:-"0-new_project"}