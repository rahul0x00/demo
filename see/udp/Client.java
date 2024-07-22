import java.net.*;
import java.io.*;
public class Client {
public static void main(String[] args) throws IOException{
// creating datagram socket for client;
DatagramSocket clientSocket = new DatagramSocket();
// collecting data to be sent in the datagram packet to send
InetAddress IPAddress = InetAddress.getByName("localhost");
int Port = 1234;
byte[] sendData = new byte[1024];
byte[] receiveData = new byte[1024];
String sentence = "Sample String";
sendData = sentence.getBytes();
// create DatagramPacket and send the data
DatagramPacket sendPacket = new DatagramPacket(sendData, sendData.length,
IPAddress, Port);
// send the packet
clientSocket.send(sendPacket);
// create packet to receive data from server
DatagramPacket receivePacket = new DatagramPacket(receiveData,
receiveData.length);
// receive data from server in receivePacket
clientSocket.receive(receivePacket);
// store the data received in client side in variable
String modifiedSentence = new String(receivePacket.getData());
System.out.println("From server : "+modifiedSentence);
// close client socket
clientSocket.close();
}
}
