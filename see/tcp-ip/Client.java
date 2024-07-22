import java.net.*;
import java.io.*;
public class Client{
public static void main(String[] args) throws IOException {
Socket link = new Socket("localhost", 1234);
PrintWriter out = new PrintWriter(link.getOutputStream(), true);
out.println("hello world");
link.close();
}
}
