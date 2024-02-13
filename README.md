ZIG MOVIE APP

Project Overview:

Objective: The goal of the Zig Movie App project is to create a web application that fetches and displays information about popular movies using The Movie Database (TMDb) API.

Tech Stack:

    Client-Side:
        Framework: ReactJS
        Build Tool: Webpack
        Language: TypeScript
        Styling: Bootstrap (Bonus Points)

    Server-Side:
        Framework: .NET Core Web API
        Database Access: Entity Framework (implied by the mention of DAL Project)
        Dependency Injection: Inversion of Control (IoC) (Bonus Points)
        API Documentation: Swagger UI (Bonus Points)

Features Implemented:

    Homepage:
        Displays a list of the top 20 most popular movies.
        Utilizes the api/popular endpoint to fetch movie data.

    Search Functionality:
        Implements a search bar to search for movies by title.
        Uses the api/search?query=birdbox endpoint to retrieve matching movies.

    Detail Page:
        Provides an individual detail page for each movie.
        Displays the movie poster, title linked to the official site, and a short description.
        Fetches detailed information using the /api/movie/1145 endpoint.

    Unit Testing:
        Implements unit tests for controllers and repositories to ensure code reliability.

    Bonus Points Achieved:
        Utilizes the Singleton Pattern for the Http Client on the server-side.
        Implements Inversion of Control (Dependency Injection) on the server-side.
        Manages state using React Hooks or Redux on the client-side.
        Implements routing with React Router DOM.
        Applies Bootstrap for styling.
        Integrates Swagger UI for API documentation.

Submission and Code Review:

    The completed project is pushed to a private repository on GitHub.
    Access for code review is granted to specific email addresses provided in the instructions.

Conclusion:

The Zig Movie App demonstrates a full-stack development approach, incorporating ReactJS for the client-side and .NET Core Web API for the server-side. The project not only fulfills the basic requirements but also goes beyond by implementing bonus features, showcasing a comprehensive understanding of various technologies and best practices in web development.
