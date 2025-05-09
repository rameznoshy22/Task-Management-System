INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES 
    (
        'Complete Project',
        'Finish the task management system project.',
        DATEADD(DAY, 7, GETDATE()), -- DueDate: 7 days from now
        'High',
        0, -- Pending (0)
        (SELECT Id FROM Users WHERE Email = 'Ramez@gmail.com'), -- UserId for John Doe
        (SELECT Id FROM Categories WHERE Name = 'MVC') -- CategoryId for Work
    ),
    (
        'Buy Groceries',
        'Milk, Bread, Eggs, and Vegetables.',
        DATEADD(DAY, 2, GETDATE()), -- DueDate: 2 days from now
        'Medium',
        1, -- Pending (0)
        (SELECT Id FROM Users WHERE Email = 'Ahmed@gmail.com'), -- UserId for Jane Smith
        (SELECT Id FROM Categories WHERE Name = 'EF') -- CategoryId for Shopping
    );



	select*from Tasks

	select*from Users


	-- Insert tasks for each user
INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES
    -- Tasks for User 1 (Ramez)
    ('Learn MVC Basics', 'Study the fundamentals of MVC architecture.', DATEADD(DAY, 7, GETDATE()), 'High', 0, 1, 1),
    ('Practice EF Core', 'Work on Entity Framework Core exercises.', DATEADD(DAY, 14, GETDATE()), 'Medium', 1, 1, 2),

    -- Tasks for User 2 (Ahmed)
    ('Build HTML Forms', 'Create and style HTML forms for a project.', DATEADD(DAY, 5, GETDATE()), 'Medium', 0, 2, 4),
    ('Learn CSS Grid', 'Master CSS Grid layout techniques.', DATEADD(DAY, 10, GETDATE()), 'High', 1, 2, 5),

    -- Tasks for User 3 (hala)
    ('JavaScript Fundamentals', 'Study JavaScript basics and syntax.', DATEADD(DAY, 3, GETDATE()), 'High', 0, 3, 6),
    ('Database Design', 'Design a database schema for a new project.', DATEADD(DAY, 7, GETDATE()), 'Medium', 1, 3, 7),

    -- Tasks for User 4 (Khalid)
    ('Advanced MVC', 'Explore advanced topics in MVC.', DATEADD(DAY, 10, GETDATE()), 'High', 0, 4, 1),
    ('EF Core Migrations', 'Learn how to use EF Core migrations.', DATEADD(DAY, 14, GETDATE()), 'Medium', 1, 4, 2),

    -- Tasks for User 5 (Besho)
    ('CSS Animations', 'Experiment with CSS animations and transitions.', DATEADD(DAY, 2, GETDATE()), 'Medium', 0, 5, 5),
    ('JavaScript DOM Manipulation', 'Practice DOM manipulation with JavaScript.', DATEADD(DAY, 7, GETDATE()), 'High', 1, 5, 6);



	-- Insert completed tasks (Status = 2)
INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES
    -- Completed Task for User 1 (Ramez)
    ('Complete MVC Project', 'Finalize the MVC project and submit it.', DATEADD(DAY, -5, GETDATE()), 'High', 2, 1, 1),

    -- Completed Task for User 2 (Ahmed)
    ('Finish HTML Portfolio', 'Complete and deploy the HTML portfolio website.', DATEADD(DAY, -3, GETDATE()), 'Medium', 2, 2, 4),

    -- Completed Task for User 3 (hala)
    ('JavaScript Course Completion', 'Complete the JavaScript fundamentals course.', DATEADD(DAY, -7, GETDATE()), 'High', 2, 3, 6),

    -- Completed Task for User 4 (Khalid)
    ('EF Core Project Delivery', 'Deliver the EF Core project to the client.', DATEADD(DAY, -2, GETDATE()), 'High', 2, 4, 2),

    -- Completed Task for User 5 (Besho)
    ('CSS Animations Project', 'Complete the CSS animations project.', DATEADD(DAY, -1, GETDATE()), 'Medium', 2, 5, 5);
	
	
	SELECT 
    t.Id, 
    t.Title, 
    t.Description, 
    t.DueDate, 
    t.Priority, 
    t.Status, 
    t.UserId, 
    t.CategoryId
FROM 
    Tasks t
WHERE 
    t.UserId = 1;




	SELECT 
    t.Id, 
    t.Title, 
    t.Description, 
    t.DueDate, 
    t.Priority, 
    t.Status, 
    u.Name AS UserName, 
    c.Name AS CategoryName
FROM 
    Tasks t
INNER JOIN 
    Users u ON t.UserId = u.Id
INNER JOIN 
    Categories c ON t.CategoryId = c.Id
WHERE 
    t.UserId = 3;




	-- Insert low-priority tasks
INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES
    -- Low-priority task for User 1 (Ramez)
    ('Read MVC Documentation', 'Read the official MVC documentation.', DATEADD(DAY, 10, GETDATE()), 'Low', 0, 1, 1),

    -- Low-priority task for User 2 (Ahmed)
    ('Review HTML Basics', 'Go through the basics of HTML.', DATEADD(DAY, 5, GETDATE()), 'Low', 0, 2, 4),

    -- Low-priority task for User 3 (hala)
    ('Practice JavaScript Syntax', 'Practice basic JavaScript syntax.', DATEADD(DAY, 7, GETDATE()), 'Low', 0, 3, 6),

    -- Low-priority task for User 4 (Khalid)
    ('Explore EF Core Features', 'Explore advanced features of EF Core.', DATEADD(DAY, 14, GETDATE()), 'Low', 0, 4, 2),

    -- Low-priority task for User 5 (Besho)
    ('Learn CSS Flexbox', 'Learn and practice CSS Flexbox.', DATEADD(DAY, 3, GETDATE()), 'Low', 0, 5, 5);


	--------------------------------------------------------------------
	-- Task 1
INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES 
(
    'Implement MVC Architecture',
    'Design and implement the MVC architecture for the project.',
    DATEADD(DAY, 5, GETDATE()),
    'High',
    0,
    (SELECT Id FROM Users WHERE Email = 'Ramez@gmail.com'),
    (SELECT Id FROM Categories WHERE Name = 'MVC')
);

-- Task 2
INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES 
(
    'Set Up Entity Framework',
    'Configure Entity Framework for database interactions.',
    DATEADD(DAY, 3, GETDATE()),
    'Medium',
    1,
    (SELECT Id FROM Users WHERE Email = 'Ramez@gmail.com'),
    (SELECT Id FROM Categories WHERE Name = 'EF')
);

-- Task 3
INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES 
(
    'Create PowerShell Scripts',
    'Develop PowerShell scripts for automation tasks.',
    DATEADD(DAY, 10, GETDATE()),
    'Low',
    2,
    (SELECT Id FROM Users WHERE Email = 'Ramez@gmail.com'),
    (SELECT Id FROM Categories WHERE Name = 'PS')
);

-- Task 4
INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES 
(
    'Design HTML Templates',
    'Create HTML templates for the user interface.',
    DATEADD(DAY, 2, GETDATE()),
    'Medium',
    0,
    (SELECT Id FROM Users WHERE Email = 'Ramez@gmail.com'),
    (SELECT Id FROM Categories WHERE Name = 'HTML')
);

-- Task 5
INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES 
(
    'Style with CSS',
    'Apply CSS styles to the HTML templates.',
    DATEADD(DAY, 4, GETDATE()),
    'High',
    1,
    (SELECT Id FROM Users WHERE Email = 'Ramez@gmail.com'),
    (SELECT Id FROM Categories WHERE Name = 'CSS')
);

-- Task 6
INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES 
(
    'Add JavaScript Functionality',
    'Implement JavaScript for dynamic content.',
    DATEADD(DAY, 6, GETDATE()),
    'Medium',
    2,
    (SELECT Id FROM Users WHERE Email = 'Ramez@gmail.com'),
    (SELECT Id FROM Categories WHERE Name = 'JS')
);

-- Task 7
INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES 
(
    'Optimize Database Queries',
    'Optimize SQL queries for better performance.',
    DATEADD(DAY, 8, GETDATE()),
    'High',
    0,
    (SELECT Id FROM Users WHERE Email = 'Ramez@gmail.com'),
    (SELECT Id FROM Categories WHERE Name = 'DB')
);

-- Task 8
INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES 
(
    'Refactor MVC Controllers',
    'Refactor controllers for better code organization.',
    DATEADD(DAY, 7, GETDATE()),
    'Medium',
    1,
    (SELECT Id FROM Users WHERE Email = 'Ramez@gmail.com'),
    (SELECT Id FROM Categories WHERE Name = 'MVC')
);

-- Task 9
INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES 
(
    'Implement EF Migrations',
    'Set up and run Entity Framework migrations.',
    DATEADD(DAY, 9, GETDATE()),
    'Low',
    2,
    (SELECT Id FROM Users WHERE Email = 'Ramez@gmail.com'),
    (SELECT Id FROM Categories WHERE Name = 'EF')
);

-- Task 10
INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES 
(
    'Automate Deployment with PS',
    'Create PowerShell scripts for deployment automation.',
    DATEADD(DAY, 11, GETDATE()),
    'High',
    0,
    (SELECT Id FROM Users WHERE Email = 'Ramez@gmail.com'),
    (SELECT Id FROM Categories WHERE Name = 'PS')
);

-- Continue with similar queries for the remaining tasks...

-- Task 40
INSERT INTO Tasks (Title, Description, DueDate, Priority, Status, UserId, CategoryId)
VALUES 
(
    'Finalize Project Documentation',
    'Complete and review the project documentation.',
    DATEADD(DAY, 15, GETDATE()),
    'High',
    2,
    (SELECT Id FROM Users WHERE Email = 'Ramez@gmail.com'),
    (SELECT Id FROM Categories WHERE Name = 'DB')
);

select*from Tasks
where UserId=1