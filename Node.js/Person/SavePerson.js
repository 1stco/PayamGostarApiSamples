/**
 * Author: Reza Poodineh, Omid Nasri
 * 
 * Package: npm i strong-soap
 * 
 * Description:  A simple solution to save person.
 */

var soap = require('strong-soap').soap;

// Enter the field with the username and password that has the necessary permission to find the person.
var username = 'admin';
var password = 'admin';

// Replace <url> keyword to your CRM host address.
var url = 'http(s)://<url>/Services/API/IPerson.svc?wsdl';

var requestArgs = {
    "username": username, 
    "password": password,
    person: {
        FirstName: "node",
        LastName: "node",
        CrmObjectTypeCode: "crmCode",
        CrmObjectTypeIndex: "24",
        'Categories': { 'CategoryInfo': { 'Key': "kpvc" } }
    }
};

var options = {};

soap.createClient(url, options, function (err, client) {
    
    var method = client['SavePerson'];
    
    method(requestArgs, function (err, result, envelope, soapHeader) {
        res.json(result);
    });
});