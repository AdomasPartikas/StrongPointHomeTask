README>>
This is a simple Windows Forms program that allows users to manage rows in a table. The program provides the following features:

Add new rows to the table
Delete existing rows from the table
Edit existing rows in the table
Store data using JSON format
Filter the table by ID or name
Validate user input before adding or editing rows


Getting Started:
To use this program, download the source code and run the executable file. When the program is launched, you will see a table with four columns: ID, Name, Quantity, and Price.

The program also has four buttons named "Prideti," "Istrinti," "Redaguoti," and "Rusiuoti," which provide the following functionality:

"Prideti" opens a form to add a new row to the table
"Istrinti" deletes the selected row from the table
"Redaguoti" opens a form to edit the selected row in the table
"Rusiuoti" sorts the table by ID or name
The program also has a text box that can be used to filter the table by ID or name. Simply type in the ID or name you want to filter by, and the program will display only the rows that match your input.


Input Validation:
When adding or editing a row in the table, the program validates user input to ensure that the data is in the correct format. Here are the guidelines for input:

ID: generated automatically
Name: can be any string
Quantity: must be a positive integer
Price: must be a positive number with two numbers after a decimal point
If the user enters invalid data, the program will display an error message and prompt the user to correct their input.


Data Storage:
The program uses JSON format to store the data, which means that the data is persisted even if the program is closed. This allows users to add, delete, and edit rows in the table without losing their changes.