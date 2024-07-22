import java.sql.*;
import java.util.Scanner;
public class StudentSystem {
 // JDBC URL, username, and password of MySQL server
 private static final String JDBC_URL = "jdbc:mysql://localhost:3306/nfsu_dbms";
 private static final String USERNAME = "root";
 private static final String PASSWORD = "0000";
 // Search students by classroom
 public static void searchStudentsByClassroom(String roomNumber) throws Exception{
 Class.forName("com.mysql.cj.jdbc.Driver");
 try (Connection conn = DriverManager.getConnection(JDBC_URL, USERNAME, PASSWORD)) {
 String sql = "SELECT StudentID, Students.FirstName, Students.LastName, Age, Gender FROM
Students INNER JOIN Classroom ON Students.ClassroomID = Classroom.ClassroomID WHERE
RoomNumber = ?";
 PreparedStatement statement = conn.prepareStatement(sql);
 statement.setString(1, roomNumber);
 ResultSet resultSet = statement.executeQuery();

 System.out.println("Students of class number "+roomNumber+" : ");

 System.out.println("---------------------------------------------------------------------------------------------");
 System.out.printf("%10s %15s %15s %10s %10s", "STUDENT_ID", "FIRST_NAME",
"LAST_NAME", "AGE", "GENDER");
 System.out.println();
 System.out.println("---------------------------------------------------------------------------------------------");
while (resultSet.next()) {
 int studentID = resultSet.getInt("StudentID");
 String firstName = resultSet.getString("FirstName");
 String lastName = resultSet.getString("LastName");
 int age = resultSet.getInt("Age");
 String gender = resultSet.getString("Gender");
// System.out.println(studentID+" "+firstName + " " + lastName+" "+age+" "+gender);
 System.out.format("%10s %15s %15s %10s %10s", studentID, firstName, lastName, age,
gender);
 System.out.println();
 }
 System.out.println("----------------------------------------------------------------------------------------------");
 } catch (SQLException e) {
 e.printStackTrace();
 }
 }

 // Search students by teacher name
 public static void searchStudentsByTeacher(String teacherFirstName, String teacherLastName)
throws Exception {
 Class.forName("com.mysql.cj.jdbc.Driver");
 try (Connection conn = DriverManager.getConnection(JDBC_URL, USERNAME, PASSWORD)) {
 String sql = "SELECT StudentID, Students.FirstName, Students.LastName, Age, Gender FROM
Students INNER JOIN Teachers ON Students.ClassroomID = Teachers.ClassroomID WHERE
Teachers.FirstName = ? or Teachers.LastName = ?";
 PreparedStatement statement = conn.prepareStatement(sql);
 statement.setString(1, teacherFirstName);
 statement.setString(2, teacherLastName);
 ResultSet resultSet = statement.executeQuery();
 System.out.println("Students of class with Class Teacher "+teacherFirstName + " " +
teacherLastName+" : ");
System.out.println("---------------------------------------------------------------------------------------------");
 System.out.printf("%10s %15s %15s %10s %10s", "STUDENT_ID", "FIRST_NAME",
"LAST_NAME", "AGE", "GENDER");
 System.out.println();
 System.out.println("---------------------------------------------------------------------------------------------");

 while (resultSet.next()) {
 int studentID = resultSet.getInt("StudentID");
 String firstName = resultSet.getString("FirstName");
 String lastName = resultSet.getString("LastName");
 int age = resultSet.getInt("Age");
 String gender = resultSet.getString("Gender");
// System.out.println(studentID+" "+firstName + " " + lastName+" "+age+" "+gender);
 System.out.format("%10s %15s %15s %10s %10s", studentID, firstName, lastName, age,
gender);
 System.out.println();
 }
 System.out.println("----------------------------------------------------------------------------------------------");
 } catch (SQLException e) {
 e.printStackTrace();
 }
 }

 // Add new student
 public static void addStudent(String firstName, String lastName, int age, String gender, int
classroomID) {
 try (Connection conn = DriverManager.getConnection(JDBC_URL, USERNAME, PASSWORD)) {
 String sql = "INSERT INTO Students (FirstName, LastName, Age, Gender, ClassroomID) VALUES
(?, ?, ?, ?, ?)";
 PreparedStatement statement = conn.prepareStatement(sql);
statement.setString(1, firstName);
 statement.setString(2, lastName);
 statement.setInt(3, age);
 statement.setString(4, gender);
 statement.setInt(5, classroomID);
 int rowsInserted = statement.executeUpdate();
 if (rowsInserted > 0) {
 System.out.println("Student added successfully.");
 }
 } catch (SQLException e) {
 e.printStackTrace();
 }
 }

 // Delete student
 public static void deleteStudent(int studentID) {
 try (Connection conn = DriverManager.getConnection(JDBC_URL, USERNAME, PASSWORD)) {
 String sql = "DELETE FROM Students WHERE StudentID=?";
 PreparedStatement statement = conn.prepareStatement(sql);
 statement.setInt(1, studentID);
 int rowsDeleted = statement.executeUpdate();
 if (rowsDeleted > 0) {
 System.out.println("Student deleted successfully.");
 }
 } catch (SQLException e) {
 e.printStackTrace();
 }
 }

 // View student details
 public static void viewStudentDetails(int studentID) {
try (Connection conn = DriverManager.getConnection(JDBC_URL, USERNAME, PASSWORD)) {
 String sql = "SELECT * FROM Students WHERE StudentID=?";
 PreparedStatement statement = conn.prepareStatement(sql);
 statement.setInt(1, studentID);
 ResultSet resultSet = statement.executeQuery();
 if (resultSet.next()) {
 System.out.println("Student ID: " + resultSet.getInt("StudentID"));
 System.out.println("First Name: " + resultSet.getString("FirstName"));
 System.out.println("Last Name: " + resultSet.getString("LastName"));
 System.out.println("Age: " + resultSet.getInt("Age"));
 System.out.println("Gender: " + resultSet.getString("Gender"));
 System.out.println("Classroom ID: " + resultSet.getInt("ClassroomID"));
 } else {
 System.out.println("Student not found.");
 }
 } catch (SQLException e) {
 e.printStackTrace();
 }
 }

 public static void main(String[] args) throws Exception{
// addStudent("Joey", "Ray", 20, "Male", 1);
// deleteStudent(1);
// viewStudentDetails(1);
// searchStudentsByClassroom("101");
// searchStudentsByTeacher("David","Wilson");

 try (Scanner scanner = new Scanner(System.in)) {
while (true) {
 System.out.println("\nStudent System Menu:");
System.out.println("1. Add Student");
 System.out.println("2. Delete Student");
 System.out.println("3. View Student Details");
 System.out.println("4. Search Students by Classroom");
 System.out.println("5. Search Students by Teacher Name");
 System.out.println("6. Exit");
 System.out.print("Enter your choice: ");
 int choice = scanner.nextInt();
 scanner.nextLine();
 switch (choice) {
 case 1:
 // Add Student
 System.out.println("\nAdding a new student:");
 System.out.print("Enter first name: ");
 String firstName = scanner.nextLine();
 System.out.print("Enter last name: ");
 String lastName = scanner.nextLine();
 System.out.print("Enter age: ");
 int age = scanner.nextInt();
 scanner.nextLine(); // Consume newline character
 System.out.print("Enter gender: ");
 String gender = scanner.nextLine();
 System.out.print("Enter classroom ID: ");
 int classroomID = scanner.nextInt();
 scanner.nextLine(); // Consume newline character
 addStudent(firstName, lastName, age, gender, classroomID);
 break;
 case 2:
 // Delete Student
 System.out.println("\nDelete a student:");
 System.out.print("Enter student Id to delete: ");
 int studentID_del = scanner.nextInt();
 scanner.nextLine(); // Consume newline character
 deleteStudent(studentID_del);
 break;
 case 3:
 // View Student Details
 System.out.println("\nViewing Student Details:");
 System.out.print("Enter student Id to view details : ");
 int studentID_view = scanner.nextInt();
 scanner.nextLine(); // Consume newline character
 viewStudentDetails(studentID_view);
 break;
 case 4:
 // Search Students by Classroom
 System.out.println("\nSearch Students by Classroom:");
 System.out.print("Enter Classroom Room Number: ");
 String room = scanner.nextLine();
 searchStudentsByClassroom(room);
 break;
 case 5:
 // Search Students by Teacher Name
 System.out.println("\nSearch Students by Teacher Name:");
 System.out.print("Enter Class Teacher First Name : ");
 String teacherfn = scanner.nextLine();
 System.out.print("Enter Class Teacher Last Name : ");
 String teacherln = scanner.nextLine();
 searchStudentsByTeacher(teacherfn, teacherln);
 break;
 case 6:
// Exit
 System.out.println("Exiting...");
 System.exit(0);
 break;
 default:
 System.out.println("Invalid choice. Please enter a number between 1
and 6.");
 }
}
}
 }
}
