# Authentication and Authorization with Microsoft Identity and Web API

## Endpoints

### Register

- **Endpoint:** `/api/register`
- **Method:** `POST`
- **Description:** Register a new user.
- **Request Body:**
  ```json
  {
    "firstName": "string",
    "lastName": "string",
    "email": "user@gmail.com",
    "password": "string"
  }
  ```

  ** Response: 200 OK on success. **

  ### Login

- **Endpoint:** `/api/login`
- **Method:** `POST`
- **Description:** Log in a user.
- **Request Body:**
  ```json
  {
    "email": "user@gmail.com",
    "password": "your-password"
  }
  ```

** Response: 200 OK on success. **

### Weather
- **Endpoint:** `/api/weather`
- **Method:** `GET`
- **Description:** Access a protected endpoint.
- **Authorization:** Include the access token in the Authorization header.

```json
  {
    "date": "2023-10-06T06:42:51.762Z",
    "temperatureC": 0,
    "temperatureF": 0,
    "summary": "string"
  }
  ```

