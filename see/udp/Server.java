import java.net.*;
import java.io.*;
public class Server {
public static void main(String[] args) throws IOException{
// create server side socket
DatagramSocket serverSocket = new DatagramSocket(1234);
System.out.println("Listening on port 1234...");
// set byte array for sending and receiving data
byte[] receiveData = new byte[1024];
byte[] sendData = new byte[1024];
// prepare datagram packet for receiving data from client
DatagramPacket receivePacket = new DatagramPacket(receiveData,
receiveData.length);
// receive data from client side
serverSocket.receive(receivePacket);
String sentence = new String(receivePacket.getData());
System.out.println("Received from client side : "+sentence);
// set data for packet preperation for sending data to client side
InetAddress IPAddress = receivePacket.getAddress();
int Port = receivePacket.getPort();
// reverse the string received
char ch[]=sentence.toCharArray();
 String revSentence="";
 for(int i=ch.length-1;i>=0;i--){
 revSentence+=ch[i];
 }
 revSentence = revSentence.trim();
System.out.println("Reversed String on server side = "+revSentence);
sendData = revSentence.getBytes();
// prepare datagram packet to send
DatagramPacket sendPacket = new DatagramPacket(sendData, sendData.length,
IPAddress, Port);
// send packet to client
serverSocket.send(sendPacket);
// close
serverSocket.close();
}
}
