<h1 align="center" style="font-weight: bold;">WillMax 💻</h1>

<p align="center">
 <a href="#tech">Technologies</a> • 
 <a href="#started">Getting Started</a> • 
  <a href="#routes">API Endpoints</a> •
 <a href="#colab">Collaborators</a> •
 <a href="#contribute">Contribute</a>
</p>

<p align="center">
    <b>This project delivers a seamless and user-friendly real estate experience. The app is designed to help users easily search, buy, sell, or rent properties while providing powerful tools for real estate professionals.</b>
</p>

<h2 id="technologies">💻 Technologies</h2>

- list of all technologies you used
- C#
- .NET
- Angular

<h2 id="started">🚀 Getting started</h2>

Here you describe how to run your project locally

<h3>Prerequisites</h3>

Here you list all prerequisites necessary for running your project. For example:

- Visual studio


<h3>Cloning</h3>

How to clone your project

```bash
git clone your-project-url-in-github
```


<h3>Starting</h3>

How to start your project

```bash
cd project-name
npm some-command-to-run
```

<h2 id="routes">📍 API Endpoints</h2>

Here you can list the main routes of your API, and what are their expected request bodies.
​
| route               | description                                          
|----------------------|-----------------------------------------------------
| <kbd>Login /authenticate</kbd>     | retrieves account info see [response details](#Login-auth-detail)
| <kbd>Register /authenticate</kbd>     | authenticate user into the api see [response details](#Register-auth-detail)
| <kbd>Get /user</kbd>     | getAll user [response details](#get-user-getAll)
| <kbd>GetById /user</kbd>     | getById user [response details](#getById-user-getById)
| <kbd>Put /user</kbd>     | Update user [response details](#put-user-Update)
| <kbd>Delete /user</kbd>     | Delete user [response details](#delete-user-delete)
| <kbd>Get /apartment</kbd>     | getAll apartment [response details](#get-apartment-getAll)
| <kbd>GetById /apartment</kbd>     | getById apartment [response details](#getById-apartment-getById)
| <kbd>Put /apartment</kbd>     | Update apartment [response details](#put-apartment-Update)
| <kbd>Delete /apartment</kbd>     | Delete apartment [response details](#delete-apartment-delete)

<h3 id="Login-auth-detail">Post /authenticate/Login</h3>

**RESPONSE**
```json
{
  "user": {
    "id": "cedc3720-0318-450a-a38d-5df44ffcbad5",
    "name": "will",
    "account": {
      "id": "02e4dc9c-4cc7-4635-6724-08dd1d56cfe2",
      "username": "will",
      "passwordHash": "Bcd2PVncqvcuiQcHFIbSt6wBQQxFtgs1avVY7NL2cgKCy0n52TziWqHxvrX0x4KHmfG8BR5WHcUAbdP7ka9m8g==",
      "saltHash": "KxtmvhqecBuj5YCmtKLsfI5NMi5AgbnH3PEiDRQnrDBq4dOY6Yxphr3JYWZTrdIyWHI7h1sfI0yoGsxUNnUvvIxuikjRcNwkGNgGMrt9CZDWSGMQn2e2ufCL7v2SwVPzETsNXy3S8QXyr85GEDvxzJKj03ONyeEO8Yd87lLfdqc="
    },
    "roles": [
      1
    ]
  },
  "token": "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiJjZWRjMzcyMC0wMzE4LTQ1MGEtYTM4ZC01ZGY0NGZmY2JhZDUiLCJuYW1lIjoid2lsbCIsInJvbGUiOiJST0xFX1VTRVIiLCJuYmYiOjE3MzQzMDE1MjEsImV4cCI6MTczNDMwNTEyMSwiaWF0IjoxNzM0MzAxNTIxLCJpc3MiOiJodHRwczovL3d3dy5hc3NlbWJseS5wdCIsImF1ZCI6Imh0dHBzOi8vd3d3LmFzc2VtYmx5LnB0L2NsYXNzbWFuYWdlbWVudCJ9.fTTOaLqL8tRIMohXikQXbbimFkMRwnABBCF2YN3eSrJG027GlyYagPL9j4jOKgoB-UzE3kv06MI7OeDWZG7q7A",
  "refreshToken": null
}
```

<h3 id="Register-auth-detail">POST /authenticate/Register</h3>

**RESPONSE**
```json
{
  "id": "cedc3720-0318-450a-a38d-5df44ffcbad5",
  "name": "will",
  "account": {
    "id": "02e4dc9c-4cc7-4635-6724-08dd1d56cfe2",
    "username": "will",
    "passwordHash": "Bcd2PVncqvcuiQcHFIbSt6wBQQxFtgs1avVY7NL2cgKCy0n52TziWqHxvrX0x4KHmfG8BR5WHcUAbdP7ka9m8g==",
    "saltHash": "KxtmvhqecBuj5YCmtKLsfI5NMi5AgbnH3PEiDRQnrDBq4dOY6Yxphr3JYWZTrdIyWHI7h1sfI0yoGsxUNnUvvIxuikjRcNwkGNgGMrt9CZDWSGMQn2e2ufCL7v2SwVPzETsNXy3S8QXyr85GEDvxzJKj03ONyeEO8Yd87lLfdqc="
  },
  "roles": [
    1
  ]
}
```
<h3 id="get-user-getAll">GetAll </h3>

**RESPONSE**
```json
[
  {
    "id": "d847ea5b-7567-4dc9-b427-5bd62da8df6b",
    "name": "whizuk",
    "account": null,
    "roles": [
      1
    ]
  },
  {
    "id": "cedc3720-0318-450a-a38d-5df44ffcbad5",
    "name": "will",
    "account": null,
    "roles": [
      1
    ]
  }
]
```

<h2 id="colab">🤝 Collaborators</h2>

Special thank you for all people that contributed for this project.

<table>
  <tr>
    <td align="center">
      <a href="#">
        <img src="https://avatars.githubusercontent.com/u/61896274?v=4" width="100px;" alt="WhizuK Profile Picture"/><br>
        <sub>
          <b>wilker mouta</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="#">
        <img src="https://t.ctcdn.com.br/n7eZ74KAcU3iYwnQ89-ul9txVxc=/400x400/smart/filters:format(webp)/i490769.jpeg" width="100px;" alt="Elon Musk Picture"/><br>
        <sub>
          <b>Elon Musk</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="#">
        <img src="https://miro.medium.com/max/360/0*1SkS3mSorArvY9kS.jpg" width="100px;" alt="Foto do Steve Jobs"/><br>
        <sub>
          <b>Steve Jobs</b>
        </sub>
      </a>
    </td>
  </tr>
</table>

<h2 id="contribute">📫 Contribute</h2>

Here you will explain how other developers can contribute to your project. For example, explaining how can create their branches, which patterns to follow and how to open an pull request

1. `git clone https://github.com/Fernanda-Kipper/text-editor.git`
2. `git checkout -b feature/NAME`
3. Follow commit patterns
4. Open a Pull Request explaining the problem solved or feature made, if exists, append screenshot of visual modifications and wait for the review!

<h3>Documentations that might help</h3>
