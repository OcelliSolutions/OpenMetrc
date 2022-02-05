# OpenMETRC: Scraper

Since METRC is deployed separately to each state, and does not share a common code-base, this application is required to check to see which states have METRC installed as well as what sections and endpoints are configured. The results of which are stored in the `state-summaries.json` file at the root of the solution.

## Usage

> This should only be used locally when testing to see if any new states have been added and if any new endpoints are configured.

```bash
dotnet run .
```

This will take a couple of minute to execute. The process is complete when you see the following:

```
Scanning: wy 100.00%   A summary of all METRC states has been written to: state-summaries.json

Please copy this file to the root of the solution.
Summary:
States Found: 16
```

Finally, *move* the generated `state-summaries.json` file to the root of the project. If you ran the app inside Visual Studio, you will find the file in the `bin` directory.
