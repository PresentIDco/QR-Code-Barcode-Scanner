import requests

url = "https://qr-code-and-barcode-scanner.p.rapidapi.com/ScanCode"

payload = "-----011000010111000001101001\r
Content-Disposition: form-data; name=\"image\"\r
\r
\r
-----011000010111000001101001--\r
\r
"
headers = {
    'content-type': "multipart/form-data; boundary=---011000010111000001101001",
    'x-rapidapi-key': "f485496ab8msh2ea068a0bbe333cp179f86jsn2b4afe8962dd",
    'x-rapidapi-host': "qr-code-and-barcode-scanner.p.rapidapi.com"
    }

response = requests.request("POST", url, data=payload, headers=headers)

print(response.text)
