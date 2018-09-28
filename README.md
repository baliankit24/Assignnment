# Assignnment - Web API

This web api exposed below two endpoints that can be consumed by client.

## End point - Manufacturers : 
1. List manufacturers that match a name or all if no name was provided. 
    /api/Manufacturers/GetByName?name=
2. List product count by manufacturers (input should be manufacturer name, response should have a count)
    /api/Manufacturers/GetProductCount?manufacturerName=
3. Show the current stock price
   /api/Manufacturers/GetStock?manufacturerName=

## End point - Products (cereal) :  
1. List products that match name and/or minimum rating and/or minimum fiber content and/or minimum protein content
  /api/Products?name=""&minimumRating=""&minimumFiberContent=""&minimumProteinContent=""


Also, unit test cases project and respective test cases are added.

# Tools & Technologies :
- .net core, web api, mvc 
- VS Code 
- Data is stored as json in static json file
