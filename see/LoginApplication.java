import java.sql.*;
import java.util.Scanner;
public class LoginApplication{
private static boolean rememberMe = false;
 private static String loggedInUsername = "";
public static boolean login(String uname, String pass) throws Exception {
Class.forName("com.mysql.cj.jdbc.Driver");
// Connection con = DriverManager.getConnection(
// "jdbc:mysql://localhost:3306/nfsu_dbms?useSSL=false","root","0000");

Connection con = DriverManager.getConnection(
    "jdbc:mysql://localhost:3306/nfsu_dbms?useSSL=false", "root", "");
Statement stmt=con.createStatement();
ResultSet rs=stmt.executeQuery("select * from login");
while(rs.next()) {
if (rs.getString(1).equals(uname) & rs.getString(2).endsWith(pass)) {
return true;
}
}
stmt.close();
con.close(); 
return false;
}
public static void main(String[] args) throws Exception {
 Scanner scanner = new Scanner(System.in);
 System.out.println("Welcome to Login Application!");
 while (true) {
 System.out.println("\nOptions:");
 System.out.println("1. Login");
 System.out.println("2. Logout");
 System.out.println("3. Exit");
 System.out.print("Choose an option: ");
 int choice = scanner.nextInt();
 scanner.nextLine(); // Consume newline
 switch (choice) {
 case 1:
 login(scanner);
 break;
 case 2:
 logout();
 break;
 case 3:
 System.out.println("Exiting...");
 scanner.close();
 System.exit(0);
default:
 System.out.println("Invalid option. Please try again.");
 }
 }
 }
 // Method to handle login
 private static void login(Scanner scanner) throws Exception {
 if (!loggedInUsername.isEmpty()) {
 System.out.println("You are already logged in as " + loggedInUsername);
 return;
 }
 System.out.print("Enter your username: ");
 String enteredUsername = scanner.nextLine();
 System.out.print("Enter your password: ");
 String enteredPassword = scanner.nextLine();
 // Validate credentials
 if (login(enteredUsername, enteredPassword)) {
 loggedInUsername = enteredUsername;
 System.out.println("Login successful!");
 // Remember login if requested
 System.out.print("Do you want to remember your login? (yes/no): ");
 String rememberChoice = scanner.nextLine();
 if (rememberChoice.equalsIgnoreCase("yes")) {
 rememberMe = true;
 } else {
 rememberMe = false;
 }
} else {
 System.out.println("Login failed. Incorrect username or password.");
 }
 }
 // Method to handle logout
 private static void logout() {
 if (!loggedInUsername.isEmpty()) {
 System.out.println("Logging out user: " + loggedInUsername);
 if (!rememberMe) {
 loggedInUsername = "";
 }
 } else {
 System.out.println("You are not currently logged in.");
 }
 }
}
