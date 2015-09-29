# AussieDivers Server

Serves a RESTful api using C# and Entity Framework.

Works with [AussieDiversClient](https://github.com/DigitalPacificSolutions/AussieDiversClient) as the front-end.

Proposed API
============

| Path                       | HTTP Verb | Functionality                            |
| -------------------------- | --------- | ---------------------------------------- |
| /api/customers             | GET       | List all customers                       |
| /api/customers             | POST      | Create new customer                      |
| /api/customers/{id}        | PUT/PATCH | Update customer with given id            |
| /api/customers/{id}        | DELETE    | Mark as inactive / hide customer         |
| /api/bookings              | GET       | List most recent bookings                |
| /api/bookings              | POST      | Create new booking                       |
| /api/bookings/{id}         | PUT/PATCH | Update Booking                           |
| /api/bookings/{id}         | DELETE    | Mark as inactive / hide booking          |
| /api/bookings/{id}/details | GET       | Get details for a booking                |
| /api/packages              | GET       | List all packages                        |
| /api/packages              | POST      | Create new package                       |
| /api/packages/{id}         | PUT/PATCH | Update Package                           |
| /api/packages/{id}         | DELETE    | Delete Package                           |
| /api/divesites             | GET       | List all divesites                       |
| /api/divesites             | POST      | Create new divesites                     |
| /api/divesites/{id}        | PUT/PATCH | Update divesite                          |
| /api/divesites/{id}        | DELETE    | Delete divesite                          |
| /api/boats                 | GET       | List all boats                           |
| /api/boats                 | POST      | Create new boats                         |
| /api/boats/{id}            | PUT/PATCH | Update boat                              |
| /api/boats/{id}            | DELETE    | Delete boat                              |
| /api/employees             | GET       | List all employees                       |
| /api/employees             | POST      | Create new employees                     |
| /api/employees/{id}        | PUT/PATCH | Update employee                          |
| /api/employees/{id}        | DELETE    | Delete employee                          |
| /api/hotels                | GET       | List all hotels                          |
| /api/hotels                | POST      | Create new hotels                        |
| /api/hotels/{id}           | PUT/PATCH | Update hotel                             |
| /api/hotels/{id}           | DELETE    | Delete hotel                             |
