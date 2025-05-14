# Task Management System

## Overview
The **Task Management System** is a Windows Forms application built with ASP.NET Core and Entity Framework Core. It enables users to efficiently manage personal tasks with robust filtering, sorting, and reporting capabilities.

## Features
### Core Task Management
- Create, read, update, and delete tasks (CRUD operations)
- Track task progress (Pending, In Progress, Completed)
- Set priorities (Low, Medium, High) and due dates

### Task Organization
- Filter tasks by status, priority, or category
- Sort tasks by due date, creation date, or priority
- Group tasks by category or priority level

### Advanced Features
- Search functionality by title or description
- Pagination support for large task lists
- Overdue task detection with visual alerts
- Task completion statistics and reports

## Database Structure
The system uses Entity Framework Core with the following key entities:

### Entities
- **TaskItem**: Core task entity with title, description, due date, priority, and status
- **User**: System users with name and email
- **Category**: Task categorization system

### Relationships
```mermaid
erDiagram
    USER ||--o{ TASK_ITEM : "Has"
    CATEGORY ||--o{ TASK_ITEM : "Contains"
    TASK_ITEM {
        int Id PK
        string Title
        string Description
        datetime DueDate
        string Priority
        Enum Status
        int UserId FK
        int CategoryId FK
    }
