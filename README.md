# Customer and Order Information Viewer

## Description
This ASP.NET MVC project is designed to display customer and order information. It demonstrates the use of models, view models, controllers, and views to create a simple application that shows details about customers and their orders.

## Technologies Used
- **ASP.NET MVC**: Framework for building web applications following the Model-View-Controller design pattern.
- **C#**: Programming language used to create models, controllers, and other application components.
- **Razor**: Template engine used for dynamic HTML generation in views.

## Project Structure

### Models
- **Customer**: Represents a customer with the following properties:
  - `Id`: Unique identifier (int).
  - `FirstName`: Customer's first name (string).
  - `LastName`: Customer's last name (string).
  - `Email`: Customer's email address (string).

- **Order**: Represents an order with the following properties:
  - `Id`: Unique identifier (int).
  - `ProductName`: Name of the product (string).
  - `Price`: Price of the product (decimal).
  - `Quantity`: Quantity of the product ordered (int).

### ViewModel
- **CustomerOrderViewModel**: Combines `Customer` and `Order` models:
  - `Customer`: A `Customer` object.
  - `Orders`: A list of `Order` objects.

### Controller
- **CustomerOrdersController**: Handles requests and prepares data for the view.
  - **Index Action**: Creates a sample `Customer` and a list of `Order` objects, then passes these to the `CustomerOrderViewModel` and returns the view.

### View
- **Index.cshtml**: Displays customer details and a table of orders.
  - Shows customer information including ID, first name, last name, and email.
  - Displays a table with order details including order ID, product name, price, and quantity.
  - ![image](https://github.com/user-attachments/assets/dfb54ff3-9491-411e-8038-25bfabd09d76)
