## Technical questions**

Please answer the following questions in a markdown file called `Answers to technical questions.md`.

- How long did you spend on the coding test? What would you add to your solution if you had more time? If you didn't spend much time on the coding test then use this as an opportunity to explain what you would add.
- What was the most useful feature that was added to the latest version of C#? Please include a snippet of code that shows how you've used it.
- How would you track down a performance issue in production? Have you ever had to do this?

Git Repo : https://github.com/VChopra242/AAF-Coding-Exercise.git


- How long did you spend on the coding test? What would you add to your solution if you had more time? If you didn't spend much time on the coding test then use this as an opportunity to explain what you would add.
o	As per the time limit I spend 2 hr on coding test
o	I ran out of time. If I had more time. 
o	I will change my UserServiceHelpers methods not to use UserDTO, instead get the values It need 
o	Wrote more unit tests 
o	Take clientRepository dependency out of UserService
o	Change UserServiceUnitTests to mock out clientRepository

- What was the most useful feature that was added to the latest version of C#? Please include a snippet of code that shows how you've used it.
o	One of the latest C# version feature I used is Language Integrated Query. Language Integrated Query (LINQ) is a powerful feature in C# that allows you to query and manipulate data from various sources, such as databases, XML documents, and in-memory collections, using a consistent syntax. This unified approach simplifies data operations and makes your code more readable and maintainable.
o	snippet of code  : 
o	Assert.DoesNotThrow(() => UserServiceHelpers.CheckUserName(userDTO));
- How would you track down a performance issue in production? Have you ever had to do this?

Pinpointing performance bottlenecks in a production can be a daunting task. Here are some effective strategies I would have used identify and resolve these issues:
1. Establish a Strong Monitoring Baseline:
    •	Application Performance Monitoring (APM) Tools: 
        o	Use tools like dotTrace to find the issue.
        o	Set up alerts for critical thresholds to proactively identify issues.
    •	Custom Logging: 
        o	Implement detailed logging to track specific events, error messages, and performance metrics.
        o	Log information about request/response times, database queries, and external API calls.
•	Server Monitoring: 
    o	Monitor server-side metrics like CPU usage, memory consumption, and disk I/O to identify resource constraints.
2. Identify the Root Cause:
    •	Profiling Tools: 
        o	Use profilers like dotTrace to analyze code execution and identify performance hotspots.
        o	Focus on areas with high CPU or memory usage, long execution times, or frequent garbage collection.
    •	Database Performance Analysis: 
        o	Monitor database queries, indexes, and execution plans to optimize database performance.
        o	Use tools like SQL Server Profiler or Azure Database Performance Advisor to identify slow queries.

3. Implement Performance Optimizations:
    •	Code Optimization: 
        o	Use techniques like caching, lazy loading, and asynchronous programming to reduce processing time.
        o	Optimize algorithms and data structures to improve efficiency.
        o	Minimize object creation and garbage collection.
    •	Database Optimization: 
        o	Create appropriate indexes, optimize queries, and use efficient query patterns.
        o	Consider using caching mechanisms to reduce database load.
    •	Document Your Findings: 
        o	Document the root cause, solutions, and lessons learned to prevent future issues.

