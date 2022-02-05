# OpenMETRC: Builder

This project is an OpenAPI spec builder for the METRC platform. This uses several helpers to ensure that all endpoints scraped and are mapped to controllers and endpoints with the appropriate return types and error structures. The final result of this tool is `open-metrc-swagger.yaml`. This file can use used by any platform for code generation. The application only generates a standard interface for METRC and does not execute any code at runtime.

## Usage

This only needs to be executed if there are changes to models or controllers. Only a `build` is required to generate the OpenAPI spec. If you run the tool, you will be able to use the embedded OpenAPI browser to select a server, authenticate (add credentials), and test an endpoint.

```bash
dotnet build .
```

The `open-metrc-swagger.yaml` file at the solution root directory will be automatically updated on build. No further steps are required.
