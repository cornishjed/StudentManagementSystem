For Sunday’s project, you’ll create a **Student Management System** that applies the concepts of classes, objects, and encapsulation in C#. This project will help you understand how to design simple applications with an object-oriented approach, organizing data and actions logically within classes.

---

### **Project: Student Management System**

**Objective:** 
Design a console-based system to manage students and their information (name, ID, age, grades, etc.) using classes and methods. This project emphasizes creating classes, defining methods, and encapsulating data with properties.

---

### **Project Requirements**

1. **Classes and Structure**:
   - **Student Class**: Create a class named `Student` with the following attributes:
     - **Fields/Properties**:
       - `StudentID` (int): Unique identifier for each student.
       - `Name` (string): Full name of the student.
       - `Age` (int): Age of the student.
       - `Grades` (List<int>): A list to store grades.
     - **Methods**:
       - `AddGrade(int grade)`: Method to add a grade to the student’s record.
       - `GetAverageGrade()`: Method to calculate and return the average grade of the student.
   - **Class Encapsulation**: Make fields private and use public properties to enforce encapsulation.
   
2. **Encapsulation**:
   - Ensure all fields in the `Student` class are private.
   - Provide `get` and `set` accessors for properties like `StudentID`, `Name`, and `Age`.
   - Protect the `Grades` list by only allowing grades to be added through the `AddGrade()` method, not directly.

3. **Main Program (in a separate class)**:
   - Create a **StudentManagementSystem** class that contains the main program logic.
   - Inside the `Main` method, create a list to manage multiple `Student` objects.
   - Implement options to:
     - **Add a New Student**: Allow the user to enter the student’s details (ID, name, age).
     - **Add Grades**: Let the user add grades to a specific student.
     - **View Average Grade**: Calculate and display the average grade for a specific student.
     - **Display Student Information**: Show details of all students, including name, ID, and average grade.
   - **User Interface**: Use a simple text-based menu to prompt the user for inputs and actions.

4. **Error Handling**:
   - Add basic error handling to ensure inputs are valid (e.g., non-negative values for age, grades between 0 and 100).
   - Ensure the program gracefully handles incorrect inputs without crashing.

---

### **Additional Challenge**

If you’d like to extend the project, consider adding:
   - **Grade Classification**: Display if the student's average grade is “Excellent,” “Good,” “Average,” or “Needs Improvement” based on thresholds.
   - **Data Persistence**: Save student data to a file, and load it when the program starts, so that data isn't lost after closing the program. 

---

This project will reinforce foundational OOP concepts and give you hands-on experience organizing code using classes and methods, setting you up for more complex projects down the line.