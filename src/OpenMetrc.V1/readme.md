# Open:METRC

This is the final product that is published to NuGet. It contains several features that do not come out of the box with an OpenAPI code generator. These features include:

* **Credential Management**: Just make life easier when maintaining what credentials work with which state.
* **Rate Limiting**: While not perfect, it is much better than nothing. Writing your own rate limiter with the rules required is not the most Google-able thing.
* **State/Endpoint Validation**: Not every state has every endpoint. OpenMETRC knows what endpoints work where and will cut down on the errors that you may get from METRC.
