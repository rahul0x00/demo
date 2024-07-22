import java.net.*;
import java.io.*;
public class Server{
public static void main(String[] args) throws IOException {
// TODO Auto-generated method stub
// 1. Create serversocket object
ServerSocket servSocket = new ServerSocket(1234);
// 2. Put server into waiting state
Socket link = servSocket.accept();
// 3. Set up IO streams
BufferedReader in = new BufferedReader(new
InputStreamReader(link.getInputStream()));
// 4. Receive data
String input = in.readLine();
// 5. Close connection
link.close();
}
}
