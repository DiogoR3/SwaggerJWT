### .NET API with Swagger, JWT Authentication and MongoDB

##### Steps to setup MongoDB:
```cmd
mongo
use CarStoreDb
db.createCollection('Cars')
db.Cars.insertMany([{'Key':'audi-6','Name':'Audi','Manufacturer':'AUDI'}, {'Key':'bmw-7','Name':'BMW','Manufacturer':'BMW'}])
db.Cars.insertMany([{'Key':'gm-chevrolet-23','Name':'GM - Chevrolet','Manufacturer':'CHEVROLET'}, {'Key': 'fiat-21','Name':'Fiat','Manufacturer':'FIAT'}])
```