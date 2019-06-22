<?php
    /**
     * Target: FindPersonById
     *
     * Authors: Omid Nasri
     * 
     * Description: A simple solution to find person by ID.
     * 
     * Version: 1.0
     */
    try
    {
        // Enter the field with the username and password that has the necessary permission to find the person.
        $username = 'admin';
        $password = 'admin';
        
        // Replace <url> keyword to your CRM host address.
        $url = 'http(s)://<url>/services/api/IPerson.svc?wsdl';
        
        // Create new instance of SoapClient to call FindPersonById method.
        $soapClient = new SoapClient( $url );
        
        $params = array(
            'username' => $username,
            'password' => $password,
            'personId' => '7752d1da-5699-4226-b8a1-1ee6d20b0fbf'
        );
        
        // Calling the FindPersonById method.
        $Result = $soapClient->FindPersonById($params);
        
        // Checked that the operation was successful or not.
        if ($Result->FindPersonByIdResult->Success)
        {
            //Converting Object to JSON type then print output vlaue.
            echo json_encode($Result, JSON_UNESCAPED_UNICODE);
        }
        else 
            echo $Result->FindPersonByIdResult->Message;
    }
    catch ( Exception $e ) 
    {
        // Print exception message
        echo $e->getMessage();
    }
?>