git config credential.helper ""
curl -i --insecure https://localhost:5001/healthcheck
curl -i --insecure https://localhost:5001/currentdatetime/
curl -i --insecure https://localhost:5001/currentdatetime/ -H "Accept: application/json"
curl -i --insecure https://localhost:5001/currentdatetime/ -H "Accept: application/xml"