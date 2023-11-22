# Parallel File Searcher

## Overview
Parallel File Searcher is a C# console application designed to efficiently search for files with a specific extension within a given directory and its subdirectories. It utilizes parallel processing to speed up the search operation, making it ideal for large file systems.

## Features
- Fast file searching using parallel processing.
- Ability to specify the root directory and file extension.
- Handles exceptions and access-denied scenarios gracefully.
- Outputs the list of found files and their count.

## Prerequisites
- .NET Core 3.1 or later.
- Access to directories and files you wish to search.

## Installation
1. Clone the repository or download the source code.
2. Open the solution in Visual Studio or your preferred IDE that supports .NET Core.
3. Restore any NuGet packages if needed.
4. Build the solution to ensure everything compiles correctly.

## Configuration
Update the `appsettings.json` file with the desired settings:

```json
{
  "FileSearchConfig": {
    "DirectoryPath": "C:\\Path\\To\\Your\\Directory",
    "FileExtension": ".ext"
  }
}
