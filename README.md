# E2E-SkillEvaluationTest

This repository contains my solution for the E2E Skill Evaluation Test.
The purpose of this application is a very simplistic To-do manager.

I have created a solution using a DataTable library and jQuery; I also created another list using ASP.NET Core technology. This alternative list has no pagination.

I personally prefer the solution with the datatable (which has all requirements). It's is more elegant and simpler than the alternative solution. The alternative solution is accessible under the button 'alternative list'.

There are CRUD operations provided for the Todo model.

## To install

1. Clone library
2. Open Package Manager Console and run 'Update-Database'

## Used libraries and packages

**Database:** MSSQLLocalDB

**DataTable:** 
  Website: https://datatables.net/
  jQuery script: https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js
  Bootstrap 4 script:https://cdn.datatables.net/1.10.21/js/dataTables.bootstrap4.min.js
  Bootstrap 4 stylesheet:https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/css/bootstrap.css
  DataTable stylesheet: https://cdn.datatables.net/1.10.21/css/dataTables.bootstrap4.min.css

**EF Core:**
   1. Microsoft.EntityFrameworkCore
   1. Microsoft.EntityFrameworkCore.Design
   1. Microsoft.EntityFrameworkCore.Tools
   1. Microsoft.EntityFrameworkCore.SqlServer
   
**Newtonsoft.Json:** for deserializing the data from the API (https://jsonplaceholder.typicode.com/todos)



