# OpenMETRC Tests

Used to test the OpenMETRC  library. This allows for a developer to test all endpoint for any and all states and companies they may have access too. This also allows testing against sandbox environments.

Right now this only tests GET endpoints.\

**TODO**: test all the other endpoints

## Usage

In order to run integration testing, you will need at least one `softwareApiKey` and `userApiKey` for a given state/sandbox. Create a copy of the `api_keys.template.json` file and name it `api_keys.json`. Use this new file to enter all the credentials you want to use to test against. `api_keys.json` is not checked into source control.

```json
[
  {
    "SubDomain": "sandbox-api-ca",
    "SoftwareApiKey": "value",
    "UserApiKey": "value"
  }
]
```

* **SubDomain**: The subdomain of the state you have access too (eg: https://api-ca.metrc.com and/or https://sandbox-api-ca.metrc.com for the state of California).
* **SoftwareApiKey**: The key provided for a given environment by METRC once you complete the training process.
* **UserApiKey**: The key provided by a companies specific implementation.

_POST, PUT, and DELETE endpoints will only be tested against a sandbox environment._

> Not all endpoints will return data and that is OK. The tests are designed to be `skipped` if no results are returned. It is also possible that every call to an endpoint returns a `401 Unauthorized`, that is OK as well. Tests will only fail if the results are of a different structure or the endpoint does not work (bad path/parameters)
