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

let requestArgs = {
  username: username,
  password: password,
  person: {
    FirstName: "test",
    LastName: "test",
    CrmObjectTypeCode: "person",
    IdentityType: "حقیقی",
    Categories: { CategoryInfo: { Key: "siteclients" } },
    PhoneContacts: {
      IdentityContactPhone: {
        PhoneNumber: "09120000000",
        PhoneType: "موبایل",
        IsDefault: true,
      },
    },
    Emails: { string: ["test@gmail.com"] },
    Subject: "عضویت در سایت",
  },
};

var options = {};

soap.createClient(url, options, function (err, client) {
    
    var method = client['SavePerson'];
    
    method(requestArgs, function (err, result, envelope, soapHeader) {
        res.json(result);
    });
});
