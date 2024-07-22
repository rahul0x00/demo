
import java.net.*;
import java.io.*;

public class URLConnectionExample {
    public static void main(String[] args) {
        try {
            URL url = new URL("https://www.google.com/");
            HttpURLConnection urlcon = (HttpURLConnection) url.openConnection();

            // Display header attributes
            System.out.println("\nHeader Attributes:");
            urlcon.getHeaderFields().forEach((key, value) -> {
                System.out.println(key + ": " + value);
            });

            // Read and display the website content
            System.out.println("\nWebsite Content:");
            BufferedReader reader = new BufferedReader(new InputStreamReader(urlcon.getInputStream()));
            String line;
            while ((line = reader.readLine()) != null) {
                System.out.println(line);
            }
            reader.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}

