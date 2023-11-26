# Domain

This project contains all the models, requests, and responses for METRC. So far, the core stucture is the same between each version.

When creating new request models please use this inheritance stucture for the classes :

* Create{object}Request
  * Post{object}Request
  * Post{object}CreateRequest (if applicable)
  * Update{object}Request
    * Put{objecT}Request
    * Post{objecT}UpdateRequest (if applicable)

The `POST` and `PUT` names should match the name of the method's operation id. The update method should be the create class plus an `Id` property if possible.
