package backend;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.*;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
public class MyServlet extends HttpServlet{
/**
* 
*/
private static final long serialVersionUID = 1L;
public void dbInteraction() throws Exception {
}
@Override
protected void doGet(HttpServletRequest request, HttpServletResponse response) throws
IOException {
response.setContentType("text/html");
PrintWriter out = response.getWriter();
try {
Class.forName("com.mysql.cj.jdbc.Driver");
} catch (ClassNotFoundException e) {
// TODO Auto-generated catch block
e.printStackTrace();
}
String firstName = request.getParameter("firstName");
String lastName = request.getParameter("lastName");
String age = request.getParameter("age");
String gender = request.getParameter("gender");
String classroomID = request.getParameter("classroomID");
out.println("<h1>Registration Successful!!</h1>");
out.println("<br>First Name = "+firstName);
out.println("<br>Last Name = "+lastName);
out.println("<br>Age = "+age);
out.println("<br>Gender = "+gender);
out.println("<br>Classroom ID = "+classroomID);
out.println("<br><br><h2>View Records</h2><br>");
// JDBC URL, username, and password of MySQL server
 String JDBC_URL = "jdbc:mysql://localhost:3306/nfsu_dbms";
 final String USERNAME = "root";
 final String PASSWORD = "0000";

 try (Connection conn = DriverManager.getConnection(JDBC_URL, USERNAME, PASSWORD)) {

 // Add record
 String sql = "INSERT INTO Students (FirstName, LastName, Age, Gender, ClassroomID)
VALUES (?, ?, ?, ?, ?)";
 PreparedStatement statement = conn.prepareStatement(sql);
 statement.setString(1, firstName);
 statement.setString(2, lastName);
 statement.setInt(3, Integer.parseInt(age));
 statement.setString(4, gender);
 statement.setInt(5, Integer.parseInt(classroomID));
 int rowsInserted = statement.executeUpdate();
 if (rowsInserted > 0) {
 System.out.println("Student added successfully.");
 }
 // View records
 sql = "SELECT StudentID, FirstName, LastName, Age, Gender FROM Students";
statement = conn.prepareStatement(sql);
 ResultSet resultSet = statement.executeQuery();

 out.println("<table>");
// System.out.printf("%10s %15s %15s %10s %10s", "STUDENT_ID", "FIRST_NAME",
"LAST_NAME", "AGE", "GENDER");
 out.println("<tr>"
 + "<th>STUDENT_ID</th>"
 + "<th>FIRST_NAME</th>"
 + "<th>LAST_NAME</th>"
 + "<th>AGE</th>"
 + "<th>GENDER</th>"
 + "</tr>");

// System.out.println("---------------------------------------------------------------------------------------------
");
 while (resultSet.next()) {
 int studentID = resultSet.getInt("StudentID");
 String fn = resultSet.getString("FirstName");
 String ln = resultSet.getString("LastName");
 int a = resultSet.getInt("Age");
 String g = resultSet.getString("Gender");
// System.out.println(studentID+" "+firstName + " " + lastName+" "+age+" "+gender);
// System.out.format("%10s %15s %15s %10s %10s", studentID, fn, ln, a, g);
 out.println("<tr>"
 + "<td>" + studentID + "</td>"
 + "<td>" + fn + "</td>"
 + "<td>" + ln + "</td>"
 + "<td>" + a + "</td>"
 + "<td>" + g + "</td>"
 + "</tr>");
 }
out.println("</table>");
 } catch (SQLException e) {
 e.printStackTrace();
 }
}
@Override
protected void doPost(HttpServletRequest request, HttpServletResponse response) throws
IOException{
doGet(request, response);
}
}
