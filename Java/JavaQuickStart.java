HttpRequest request = HttpRequest.newBuilder()
		.uri(URI.create("https://qr-code-and-barcode-scanner.p.rapidapi.com/ScanCode"))
		.header("content-type", "multipart/form-data; boundary=---011000010111000001101001")
		.header("x-rapidapi-key", "f485496ab8msh2ea068a0bbe333cp179f86jsn2b4afe8962dd")
		.header("x-rapidapi-host", "qr-code-and-barcode-scanner.p.rapidapi.com")
		.method("POST", HttpRequest.BodyPublishers.ofString("-----011000010111000001101001\r
Content-Disposition: form-data; name=\"image\"\r
\r
\r
-----011000010111000001101001--\r
\r
"))
		.build();
HttpResponse<String> response = HttpClient.newHttpClient().send(request, HttpResponse.BodyHandlers.ofString());
System.out.println(response.body());
